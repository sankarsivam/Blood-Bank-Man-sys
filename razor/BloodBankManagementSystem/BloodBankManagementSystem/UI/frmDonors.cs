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

namespace BloodBankManagementSystem.UI
{
    public partial class frmDonors : Form
    {
        public frmDonors()
        {
            InitializeComponent();
        }

        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();
        userDAL udal = new userDAL();
        
        string imageName = "default.jpg";
        string sourcePath = "";
        string destinationPath = "";
        string rowHeaderImage;
        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            d.first_name = txtFirstName.Text;
            d.last_name = txtLastname.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;

            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            d.added_by = usr.user_id;
           
            d.image_name = imageName;

            if(imageName != "default.jpg")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool isSuccess = dal.Insert(d);

            if (isSuccess == true)
            {
                MessageBox.Show("New Donor Added Successfully.");

                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed To Add New Donor");
            }
        }
         
        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtDonorID.Text = "";
            cmbGender.Text = "";
            cmbBloodGroup.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            imageName = "default.jpg";

            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

            string imagepath = path + "\\images\\default.jpg";

            pictureBoxProfilePicture.Image = new Bitmap(imagepath);
        }

        private void frmDonors_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvDonors.DataSource=dt;

            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

            string imagepath = path + "\\images\\default.jpg";

            pictureBoxProfilePicture.Image = new Bitmap(imagepath);
        }

        private void dgvDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int RowIndex = e.RowIndex;

            txtDonorID.Text = dgvDonors.Rows[RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvDonors.Rows[RowIndex].Cells[1].Value.ToString();
            txtLastname.Text = dgvDonors.Rows[RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDonors.Rows[RowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDonors.Rows[RowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvDonors.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvDonors.Rows[RowIndex].Cells[6].Value.ToString();
            cmbBloodGroup.Text = dgvDonors.Rows[RowIndex].Cells[7].Value.ToString();

            imageName = dgvDonors.Rows[RowIndex].Cells[9].Value.ToString();

            rowHeaderImage = imageName;

            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
            string imagePath = paths + "\\images\\" + imageName;

            pictureBoxProfilePicture.Image = new Bitmap(imagePath);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            d.donor_id = int.Parse(txtDonorID.Text);
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastname.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            
            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            d.added_by = usr.user_id;
            d.image_name = imageName;

            if (imageName != "default.jpg")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool isSuccess = dal.Update(d);
            
            if (rowHeaderImage != "default.jpg")
            {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

                string imagePath = path + "\\images\\" + rowHeaderImage;

                Clear();

                GC.Collect();

                GC.WaitForPendingFinalizers();

                File.Delete(imagePath);
            }

            if (isSuccess == true)
            {
                MessageBox.Show("Donor Updated Successfully");
                Clear();

                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Donors");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            d.donor_id = int.Parse(txtDonorID.Text);

            if(rowHeaderImage != "default.jpg")
            {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

                string imagePath = path + "\\images\\" + rowHeaderImage;

                Clear();

                GC.Collect();

                GC.WaitForPendingFinalizers();

                File.Delete(imagePath);
            }
            bool isSuccess = dal.Delete(d);

            if (isSuccess == true)
            {
                MessageBox.Show("Donor Deleted Successfully");

                Clear();

                DataTable dt = dal.Select();
                dgvDonors.DataSource= dt;
            }
            else
            {
                MessageBox.Show("Failed to Delet Donor");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files Only (*.jpg;*.jpeg;*.png;*.gif| *.jpg;*.jpeg;*.png;*.gif)";

            if(open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    pictureBoxProfilePicture.Image = new Bitmap(open.FileName);

                    string ext = Path.GetExtension(open.FileName);

                    string name = Path.GetFileNameWithoutExtension(open.FileName);

                    Guid g = new Guid();
                    g = Guid.NewGuid();

                    imageName = "Blood_Bank_MS_" + name + g + ext;

                     sourcePath = open.FileName;

                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

                     destinationPath = paths + "\\images\\" + imageName;

                   // File.Copy(sourcePath, destinationPath);

                    MessageBox.Show("Image Successfully Uploaded");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if(keywords!= null)
            {
                DataTable dt = dal.Search(keywords);

                dgvDonors.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
        }
    }

}
