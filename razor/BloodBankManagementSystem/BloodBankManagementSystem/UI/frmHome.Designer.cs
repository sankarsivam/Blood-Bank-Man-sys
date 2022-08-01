namespace BloodBankManagementSystem
{
    partial class Frmhome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhome));
            this.menuStriptop = new System.Windows.Forms.MenuStrip();
            this.uSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dONORSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lblname = new System.Windows.Forms.Label();
            this.LblDevtitle = new System.Windows.Forms.Label();
            this.Lblappname = new System.Windows.Forms.Label();
            this.panelOpositive = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.lblOpositivecount = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.panelOnegative = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnegativecount = new System.Windows.Forms.Label();
            this.lblOnegative = new System.Windows.Forms.Label();
            this.panelAnegative = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnegativecount = new System.Windows.Forms.Label();
            this.lblAnegative = new System.Windows.Forms.Label();
            this.panelApositive = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApositivecount = new System.Windows.Forms.Label();
            this.lblApositive = new System.Windows.Forms.Label();
            this.panelABnegative = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABnegativecount = new System.Windows.Forms.Label();
            this.lblABnegative = new System.Windows.Forms.Label();
            this.panelABpositive = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblABpositivecount = new System.Windows.Forms.Label();
            this.lblABpositive = new System.Windows.Forms.Label();
            this.panelBnegative = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBnegativecount = new System.Windows.Forms.Label();
            this.lblBnegative = new System.Windows.Forms.Label();
            this.panelBpositive = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBpositivecount = new System.Windows.Forms.Label();
            this.lblBpositive = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStriptop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOpositive.SuspendLayout();
            this.panelOnegative.SuspendLayout();
            this.panelAnegative.SuspendLayout();
            this.panelApositive.SuspendLayout();
            this.panelABnegative.SuspendLayout();
            this.panelABpositive.SuspendLayout();
            this.panelBnegative.SuspendLayout();
            this.panelBpositive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStriptop
            // 
            this.menuStriptop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStriptop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERToolStripMenuItem,
            this.dONORSToolStripMenuItem});
            this.menuStriptop.Location = new System.Drawing.Point(0, 0);
            this.menuStriptop.Name = "menuStriptop";
            this.menuStriptop.Padding = new System.Windows.Forms.Padding(8, 10, 0, 10);
            this.menuStriptop.Size = new System.Drawing.Size(1135, 45);
            this.menuStriptop.TabIndex = 0;
            this.menuStriptop.Text = "menuStrip1";
            // 
            // uSERToolStripMenuItem
            // 
            this.uSERToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSERToolStripMenuItem.ForeColor = System.Drawing.Color.IndianRed;
            this.uSERToolStripMenuItem.Name = "uSERToolStripMenuItem";
            this.uSERToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.uSERToolStripMenuItem.Text = "USERS";
            this.uSERToolStripMenuItem.Click += new System.EventHandler(this.uSERToolStripMenuItem_Click);
            // 
            // dONORSToolStripMenuItem
            // 
            this.dONORSToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dONORSToolStripMenuItem.ForeColor = System.Drawing.Color.IndianRed;
            this.dONORSToolStripMenuItem.Name = "dONORSToolStripMenuItem";
            this.dONORSToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.dONORSToolStripMenuItem.Text = "DONORS";
            this.dONORSToolStripMenuItem.Click += new System.EventHandler(this.dONORSToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Lblname);
            this.panel1.Controls.Add(this.LblDevtitle);
            this.panel1.Controls.Add(this.Lblappname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 47);
            this.panel1.TabIndex = 1;
            // 
            // Lblname
            // 
            this.Lblname.AutoSize = true;
            this.Lblname.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblname.ForeColor = System.Drawing.Color.Aqua;
            this.Lblname.Location = new System.Drawing.Point(799, 15);
            this.Lblname.Name = "Lblname";
            this.Lblname.Size = new System.Drawing.Size(80, 21);
            this.Lblname.TabIndex = 2;
            this.Lblname.Text = "SANKAR";
            // 
            // LblDevtitle
            // 
            this.LblDevtitle.AutoSize = true;
            this.LblDevtitle.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDevtitle.Location = new System.Drawing.Point(636, 13);
            this.LblDevtitle.Name = "LblDevtitle";
            this.LblDevtitle.Size = new System.Drawing.Size(152, 21);
            this.LblDevtitle.TabIndex = 1;
            this.LblDevtitle.Text = "Developed By-";
            // 
            // Lblappname
            // 
            this.Lblappname.AutoSize = true;
            this.Lblappname.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblappname.ForeColor = System.Drawing.Color.IndianRed;
            this.Lblappname.Location = new System.Drawing.Point(277, 15);
            this.Lblappname.Name = "Lblappname";
            this.Lblappname.Size = new System.Drawing.Size(320, 21);
            this.Lblappname.TabIndex = 0;
            this.Lblappname.Text = "BloodBank Management System";
            // 
            // panelOpositive
            // 
            this.panelOpositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelOpositive.Controls.Add(this.labelName);
            this.panelOpositive.Controls.Add(this.lblOpositivecount);
            this.panelOpositive.Controls.Add(this.lblBloodGroup);
            this.panelOpositive.Location = new System.Drawing.Point(25, 86);
            this.panelOpositive.Name = "panelOpositive";
            this.panelOpositive.Size = new System.Drawing.Size(200, 100);
            this.panelOpositive.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(101, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 21);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "DONORS";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // lblOpositivecount
            // 
            this.lblOpositivecount.AutoSize = true;
            this.lblOpositivecount.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpositivecount.ForeColor = System.Drawing.Color.IndianRed;
            this.lblOpositivecount.Location = new System.Drawing.Point(117, 15);
            this.lblOpositivecount.Name = "lblOpositivecount";
            this.lblOpositivecount.Size = new System.Drawing.Size(59, 46);
            this.lblOpositivecount.TabIndex = 1;
            this.lblOpositivecount.Text = "10";
            this.lblOpositivecount.Click += new System.EventHandler(this.lblOpositivecount_Click);
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBloodGroup.Location = new System.Drawing.Point(10, 22);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(85, 59);
            this.lblBloodGroup.TabIndex = 0;
            this.lblBloodGroup.Text = "O+";
            // 
            // panelOnegative
            // 
            this.panelOnegative.BackColor = System.Drawing.SystemColors.Control;
            this.panelOnegative.Controls.Add(this.label1);
            this.panelOnegative.Controls.Add(this.lblOnegativecount);
            this.panelOnegative.Controls.Add(this.lblOnegative);
            this.panelOnegative.Location = new System.Drawing.Point(258, 86);
            this.panelOnegative.Name = "panelOnegative";
            this.panelOnegative.Size = new System.Drawing.Size(200, 100);
            this.panelOnegative.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "DONORS";
            // 
            // lblOnegativecount
            // 
            this.lblOnegativecount.AutoSize = true;
            this.lblOnegativecount.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegativecount.ForeColor = System.Drawing.Color.IndianRed;
            this.lblOnegativecount.Location = new System.Drawing.Point(126, 15);
            this.lblOnegativecount.Name = "lblOnegativecount";
            this.lblOnegativecount.Size = new System.Drawing.Size(59, 46);
            this.lblOnegativecount.TabIndex = 1;
            this.lblOnegativecount.Text = "10";
            // 
            // lblOnegative
            // 
            this.lblOnegative.AutoSize = true;
            this.lblOnegative.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegative.ForeColor = System.Drawing.Color.IndianRed;
            this.lblOnegative.Location = new System.Drawing.Point(14, 22);
            this.lblOnegative.Name = "lblOnegative";
            this.lblOnegative.Size = new System.Drawing.Size(80, 59);
            this.lblOnegative.TabIndex = 0;
            this.lblOnegative.Text = "O-";
            // 
            // panelAnegative
            // 
            this.panelAnegative.BackColor = System.Drawing.SystemColors.Control;
            this.panelAnegative.Controls.Add(this.label4);
            this.panelAnegative.Controls.Add(this.lblAnegativecount);
            this.panelAnegative.Controls.Add(this.lblAnegative);
            this.panelAnegative.Location = new System.Drawing.Point(258, 224);
            this.panelAnegative.Name = "panelAnegative";
            this.panelAnegative.Size = new System.Drawing.Size(200, 100);
            this.panelAnegative.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(100, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "DONORS";
            // 
            // lblAnegativecount
            // 
            this.lblAnegativecount.AutoSize = true;
            this.lblAnegativecount.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegativecount.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAnegativecount.Location = new System.Drawing.Point(126, 15);
            this.lblAnegativecount.Name = "lblAnegativecount";
            this.lblAnegativecount.Size = new System.Drawing.Size(59, 46);
            this.lblAnegativecount.TabIndex = 1;
            this.lblAnegativecount.Text = "10";
            // 
            // lblAnegative
            // 
            this.lblAnegative.AutoSize = true;
            this.lblAnegative.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegative.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAnegative.Location = new System.Drawing.Point(14, 22);
            this.lblAnegative.Name = "lblAnegative";
            this.lblAnegative.Size = new System.Drawing.Size(76, 59);
            this.lblAnegative.TabIndex = 0;
            this.lblAnegative.Text = "A-";
            // 
            // panelApositive
            // 
            this.panelApositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelApositive.Controls.Add(this.label7);
            this.panelApositive.Controls.Add(this.lblApositivecount);
            this.panelApositive.Controls.Add(this.lblApositive);
            this.panelApositive.Location = new System.Drawing.Point(25, 224);
            this.panelApositive.Name = "panelApositive";
            this.panelApositive.Size = new System.Drawing.Size(200, 100);
            this.panelApositive.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(101, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "DONORS";
            // 
            // lblApositivecount
            // 
            this.lblApositivecount.AutoSize = true;
            this.lblApositivecount.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositivecount.ForeColor = System.Drawing.Color.IndianRed;
            this.lblApositivecount.Location = new System.Drawing.Point(116, 15);
            this.lblApositivecount.Name = "lblApositivecount";
            this.lblApositivecount.Size = new System.Drawing.Size(59, 46);
            this.lblApositivecount.TabIndex = 1;
            this.lblApositivecount.Text = "10";
            // 
            // lblApositive
            // 
            this.lblApositive.AutoSize = true;
            this.lblApositive.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositive.ForeColor = System.Drawing.Color.IndianRed;
            this.lblApositive.Location = new System.Drawing.Point(10, 22);
            this.lblApositive.Name = "lblApositive";
            this.lblApositive.Size = new System.Drawing.Size(81, 59);
            this.lblApositive.TabIndex = 0;
            this.lblApositive.Text = "A+";
            // 
            // panelABnegative
            // 
            this.panelABnegative.BackColor = System.Drawing.SystemColors.Control;
            this.panelABnegative.Controls.Add(this.label10);
            this.panelABnegative.Controls.Add(this.lblABnegativecount);
            this.panelABnegative.Controls.Add(this.lblABnegative);
            this.panelABnegative.Location = new System.Drawing.Point(258, 486);
            this.panelABnegative.Name = "panelABnegative";
            this.panelABnegative.Size = new System.Drawing.Size(200, 100);
            this.panelABnegative.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(100, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "DONORS";
            // 
            // lblABnegativecount
            // 
            this.lblABnegativecount.AutoSize = true;
            this.lblABnegativecount.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegativecount.ForeColor = System.Drawing.Color.IndianRed;
            this.lblABnegativecount.Location = new System.Drawing.Point(126, 9);
            this.lblABnegativecount.Name = "lblABnegativecount";
            this.lblABnegativecount.Size = new System.Drawing.Size(59, 46);
            this.lblABnegativecount.TabIndex = 1;
            this.lblABnegativecount.Text = "10";
            // 
            // lblABnegative
            // 
            this.lblABnegative.AutoSize = true;
            this.lblABnegative.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegative.ForeColor = System.Drawing.Color.IndianRed;
            this.lblABnegative.Location = new System.Drawing.Point(14, 23);
            this.lblABnegative.Name = "lblABnegative";
            this.lblABnegative.Size = new System.Drawing.Size(108, 59);
            this.lblABnegative.TabIndex = 0;
            this.lblABnegative.Text = "AB-";
            // 
            // panelABpositive
            // 
            this.panelABpositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelABpositive.Controls.Add(this.label13);
            this.panelABpositive.Controls.Add(this.lblABpositivecount);
            this.panelABpositive.Controls.Add(this.lblABpositive);
            this.panelABpositive.Location = new System.Drawing.Point(25, 486);
            this.panelABpositive.Name = "panelABpositive";
            this.panelABpositive.Size = new System.Drawing.Size(200, 100);
            this.panelABpositive.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(101, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "DONORS";
            // 
            // lblABpositivecount
            // 
            this.lblABpositivecount.AutoSize = true;
            this.lblABpositivecount.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositivecount.ForeColor = System.Drawing.Color.IndianRed;
            this.lblABpositivecount.Location = new System.Drawing.Point(117, 9);
            this.lblABpositivecount.Name = "lblABpositivecount";
            this.lblABpositivecount.Size = new System.Drawing.Size(59, 46);
            this.lblABpositivecount.TabIndex = 1;
            this.lblABpositivecount.Text = "10";
            // 
            // lblABpositive
            // 
            this.lblABpositive.AutoSize = true;
            this.lblABpositive.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositive.ForeColor = System.Drawing.Color.IndianRed;
            this.lblABpositive.Location = new System.Drawing.Point(10, 23);
            this.lblABpositive.Name = "lblABpositive";
            this.lblABpositive.Size = new System.Drawing.Size(113, 59);
            this.lblABpositive.TabIndex = 0;
            this.lblABpositive.Text = "AB+";
            this.lblABpositive.Click += new System.EventHandler(this.lblABpositive_Click);
            // 
            // panelBnegative
            // 
            this.panelBnegative.BackColor = System.Drawing.SystemColors.Control;
            this.panelBnegative.Controls.Add(this.label16);
            this.panelBnegative.Controls.Add(this.lblBnegativecount);
            this.panelBnegative.Controls.Add(this.lblBnegative);
            this.panelBnegative.Location = new System.Drawing.Point(258, 348);
            this.panelBnegative.Name = "panelBnegative";
            this.panelBnegative.Size = new System.Drawing.Size(200, 100);
            this.panelBnegative.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(100, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "DONORS";
            // 
            // lblBnegativecount
            // 
            this.lblBnegativecount.AutoSize = true;
            this.lblBnegativecount.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegativecount.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBnegativecount.Location = new System.Drawing.Point(126, 9);
            this.lblBnegativecount.Name = "lblBnegativecount";
            this.lblBnegativecount.Size = new System.Drawing.Size(59, 46);
            this.lblBnegativecount.TabIndex = 1;
            this.lblBnegativecount.Text = "10";
            // 
            // lblBnegative
            // 
            this.lblBnegative.AutoSize = true;
            this.lblBnegative.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegative.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBnegative.Location = new System.Drawing.Point(14, 23);
            this.lblBnegative.Name = "lblBnegative";
            this.lblBnegative.Size = new System.Drawing.Size(78, 59);
            this.lblBnegative.TabIndex = 0;
            this.lblBnegative.Text = "B-";
            // 
            // panelBpositive
            // 
            this.panelBpositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelBpositive.Controls.Add(this.label19);
            this.panelBpositive.Controls.Add(this.lblBpositivecount);
            this.panelBpositive.Controls.Add(this.lblBpositive);
            this.panelBpositive.Location = new System.Drawing.Point(25, 348);
            this.panelBpositive.Name = "panelBpositive";
            this.panelBpositive.Size = new System.Drawing.Size(200, 100);
            this.panelBpositive.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(101, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "DONORS";
            // 
            // lblBpositivecount
            // 
            this.lblBpositivecount.AutoSize = true;
            this.lblBpositivecount.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositivecount.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBpositivecount.Location = new System.Drawing.Point(116, 9);
            this.lblBpositivecount.Name = "lblBpositivecount";
            this.lblBpositivecount.Size = new System.Drawing.Size(59, 46);
            this.lblBpositivecount.TabIndex = 1;
            this.lblBpositivecount.Text = "10";
            // 
            // lblBpositive
            // 
            this.lblBpositive.AutoSize = true;
            this.lblBpositive.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositive.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBpositive.Location = new System.Drawing.Point(10, 23);
            this.lblBpositive.Name = "lblBpositive";
            this.lblBpositive.Size = new System.Drawing.Size(83, 59);
            this.lblBpositive.TabIndex = 0;
            this.lblBpositive.Text = "B+";
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(490, 126);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.RowHeadersWidth = 51;
            this.dgvDonors.RowTemplate.Height = 24;
            this.dgvDonors.Size = new System.Drawing.Size(618, 460);
            this.dgvDonors.TabIndex = 10;
            this.dgvDonors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonors_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(532, 75);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(131, 28);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search Donor";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(669, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(410, 34);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1083, 6);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(44, 33);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 13;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Location = new System.Drawing.Point(12, 54);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(89, 16);
            this.lblUserTitle.TabIndex = 14;
            this.lblUserTitle.Text = "Logged In As:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.Aqua;
            this.lblUser.Location = new System.Drawing.Point(107, 54);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(10, 16);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = ".";
            // 
            // Frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1135, 670);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserTitle);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.panelABnegative);
            this.Controls.Add(this.panelABpositive);
            this.Controls.Add(this.panelBnegative);
            this.Controls.Add(this.panelBpositive);
            this.Controls.Add(this.panelAnegative);
            this.Controls.Add(this.panelApositive);
            this.Controls.Add(this.panelOnegative);
            this.Controls.Add(this.panelOpositive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStriptop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStriptop;
            this.Name = "Frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Activated += new System.EventHandler(this.Frmhome_Activated);
            this.Load += new System.EventHandler(this.Frmhome_Load);
            this.menuStriptop.ResumeLayout(false);
            this.menuStriptop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOpositive.ResumeLayout(false);
            this.panelOpositive.PerformLayout();
            this.panelOnegative.ResumeLayout(false);
            this.panelOnegative.PerformLayout();
            this.panelAnegative.ResumeLayout(false);
            this.panelAnegative.PerformLayout();
            this.panelApositive.ResumeLayout(false);
            this.panelApositive.PerformLayout();
            this.panelABnegative.ResumeLayout(false);
            this.panelABnegative.PerformLayout();
            this.panelABpositive.ResumeLayout(false);
            this.panelABpositive.PerformLayout();
            this.panelBnegative.ResumeLayout(false);
            this.panelBnegative.PerformLayout();
            this.panelBpositive.ResumeLayout(false);
            this.panelBpositive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStriptop;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dONORSToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lblname;
        private System.Windows.Forms.Label LblDevtitle;
        private System.Windows.Forms.Label Lblappname;
        private System.Windows.Forms.Panel panelOpositive;
        private System.Windows.Forms.Label lblOpositivecount;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelOnegative;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnegativecount;
        private System.Windows.Forms.Label lblOnegative;
        private System.Windows.Forms.Panel panelAnegative;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAnegativecount;
        private System.Windows.Forms.Label lblAnegative;
        private System.Windows.Forms.Panel panelApositive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApositivecount;
        private System.Windows.Forms.Label lblApositive;
        private System.Windows.Forms.Panel panelABnegative;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABnegativecount;
        private System.Windows.Forms.Label lblABnegative;
        private System.Windows.Forms.Panel panelABpositive;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblABpositivecount;
        private System.Windows.Forms.Label lblABpositive;
        private System.Windows.Forms.Panel panelBnegative;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBnegativecount;
        private System.Windows.Forms.Label lblBnegative;
        private System.Windows.Forms.Panel panelBpositive;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBpositivecount;
        private System.Windows.Forms.Label lblBpositive;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUser;
    }
}

