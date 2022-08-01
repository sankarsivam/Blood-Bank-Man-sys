using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BloodBankManagementSystem.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        string imageName = "default.jpg";
        string sourcePath = "";
        string destinationPath = "";
        string rowHeaderImage;

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            if(imageName != "default.jpg")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool success = dal.Insert(u);

            if (success==true)
            {
                MessageBox.Show("New User added Successfully.");
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add New User.");
            }
        }

        public void Clear()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtUserID.Text = "";
            imageName ="default.jpg";

            //string paths = Application.StartupPath.Substring(0,(Application.StartupPath.Length - 10));
            //string imagePath = paths + "\\images\\default.jpg";

            pictureBoxProfilePicture.Image = null;
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[RowIndex].Cells[3].Value.ToString();
            txtFullName.Text = dgvUsers.Rows[RowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[RowIndex].Cells[6].Value.ToString();
            imageName = dgvUsers.Rows[RowIndex].Cells[8].Value.ToString();

            rowHeaderImage = imageName;



            string paths = Application.StartupPath.Substring(0,(Application.StartupPath.Length - 10));

            if (imageName != "default.jpg")
            {


                string imagePath = paths + "\\images\\" + imageName;
                Debug.WriteLine(imagePath);
                pictureBoxProfilePicture.Image = new Bitmap(imagePath);
            }
            else
            {
                string imagePath = paths + "\\images\\default.jpg";
                Debug.WriteLine(imagePath);
                pictureBoxProfilePicture.Image = new Bitmap(imagePath);
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtUserID.Text);
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            if (imageName != "default.jpg")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool success = dal.Update(u);

            if (rowHeaderImage != "default.jpg")
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                string imagePath = paths + "\\images\\" + rowHeaderImage;

                Clear();

                GC.Collect();
                GC.WaitForPendingFinalizers();

                File.Delete(imagePath);
            }

            if (success == true)
            {
                MessageBox.Show("User Updated Successfully.");

                DataTable dt = dal.Select();
                dgvUsers.DataSource= dt;

                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.user_id =int.Parse(txtUserID.Text);

            if(rowHeaderImage != "default.jpg")
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                string imagePath = paths + "\\images\\" + rowHeaderImage;

                Clear();

                GC.Collect();
                GC.WaitForPendingFinalizers();

                File.Delete(imagePath);
            }
            bool success = dal.Delete(u);

            if(success == true)
            {
                MessageBox.Show("User Deleted Successfully");

                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;)|*.jpg;*.jpeg;*.png;*.gif;";

            if(open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    pictureBoxProfilePicture.Image = new Bitmap(open.FileName);

                    string ext = Path.GetExtension(open.FileName);
                    
                    Random random = new Random();
                    int RandInt = random.Next(0, 1000);

                    imageName = "Blood Bank MS " + RandInt + ext;


                     sourcePath = open.FileName;

                  

                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                     destinationPath = paths + "\\images\\" + imageName;

                   // File.Copy(sourcePath, destinationPath);

                    MessageBox.Show("Image Successfully Updated");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if(keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;
                
            }
            else
            {
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;   
            }
        }
    }
}
