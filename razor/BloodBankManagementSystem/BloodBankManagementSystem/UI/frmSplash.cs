using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        int move = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {

            timerSplash.Interval = 20;
            panelMovable.Width += 5;

            move += 5;

            if (move == 640)
            {
                timerSplash.Stop();
                this.Hide();

                frmLogin login = new frmLogin();
                login.Show();

            }
                   
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }
    }
}
