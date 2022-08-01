using BloodBankManagementSystem.DAL;
using BloodBankManagementSystem.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class Frmhome : Form
    {
        public Frmhome()
        {
            InitializeComponent();
        }

        donorDAL dal = new donorDAL();
        private void lblOpositivecount_Click(object sender, EventArgs e)
        {

        }

        private void lblABpositive_Click(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
        }

        private void dONORSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonors donors = new frmDonors();
            donors.Show();
        }

        private void Frmhome_Load(object sender, EventArgs e)
        {

            allDonorCount();

            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;

            lblUser.Text = frmLogin.loggedInUser;
        }
        public void allDonorCount()
        {
            lblOpositivecount.Text = dal.countDonors("O+");
            lblOnegativecount.Text = dal.countDonors("O-");
            lblApositivecount.Text = dal.countDonors("A+");
            lblAnegativecount.Text = dal.countDonors("A-");
            lblBpositivecount.Text = dal.countDonors("B+");
            lblBnegativecount.Text = dal.countDonors("B-");
            lblABpositivecount.Text = dal.countDonors("AB+");
            lblABnegativecount.Text = dal.countDonors("AB-");
        }

        private void Frmhome_Activated(object sender, EventArgs e)
        {
            allDonorCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvDonors.DataSource= dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
        }

        private void dgvDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
