namespace Manage_Chef_Dishes
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnNo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnChef = new System.Windows.Forms.Panel();
            this.btnChef = new System.Windows.Forms.Button();
            this.pnDish = new System.Windows.Forms.Panel();
            this.btnDish = new System.Windows.Forms.Button();
            this.pnStatistic = new System.Windows.Forms.Panel();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.pnSetting = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.pnChef.SuspendLayout();
            this.pnDish.SuspendLayout();
            this.pnStatistic.SuspendLayout();
            this.pnSetting.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(2)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 45);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMinimize);
            this.flowLayoutPanel1.Controls.Add(this.btnNo);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(997, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(104, 45);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(2)))), ((int)(((byte)(111)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(3, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            // 
            // btnNo
            // 
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(33, 8);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(24, 24);
            this.btnNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnNo.TabIndex = 2;
            this.btnNo.TabStop = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(63, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(21, 7);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(41, 32);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.pnChef);
            this.sidebar.Controls.Add(this.pnDish);
            this.sidebar.Controls.Add(this.pnStatistic);
            this.sidebar.Controls.Add(this.pnSetting);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 45);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(261, 513);
            this.sidebar.TabIndex = 1;
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.btnDashboard);
            this.pnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDashboard.Location = new System.Drawing.Point(3, 3);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(257, 70);
            this.pnDashboard.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-13, -15);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(285, 108);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "             Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnChef
            // 
            this.pnChef.Controls.Add(this.btnChef);
            this.pnChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnChef.Location = new System.Drawing.Point(3, 79);
            this.pnChef.Name = "pnChef";
            this.pnChef.Size = new System.Drawing.Size(257, 70);
            this.pnChef.TabIndex = 4;
            // 
            // btnChef
            // 
            this.btnChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnChef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChef.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChef.ForeColor = System.Drawing.Color.White;
            this.btnChef.Image = ((System.Drawing.Image)(resources.GetObject("btnChef.Image")));
            this.btnChef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChef.Location = new System.Drawing.Point(-13, -21);
            this.btnChef.Name = "btnChef";
            this.btnChef.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnChef.Size = new System.Drawing.Size(285, 108);
            this.btnChef.TabIndex = 3;
            this.btnChef.Text = "             Chefs";
            this.btnChef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChef.UseVisualStyleBackColor = false;
            // 
            // pnDish
            // 
            this.pnDish.Controls.Add(this.btnDish);
            this.pnDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDish.Location = new System.Drawing.Point(3, 155);
            this.pnDish.Name = "pnDish";
            this.pnDish.Size = new System.Drawing.Size(257, 70);
            this.pnDish.TabIndex = 4;
            // 
            // btnDish
            // 
            this.btnDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDish.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDish.ForeColor = System.Drawing.Color.White;
            this.btnDish.Image = ((System.Drawing.Image)(resources.GetObject("btnDish.Image")));
            this.btnDish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDish.Location = new System.Drawing.Point(-13, -21);
            this.btnDish.Name = "btnDish";
            this.btnDish.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDish.Size = new System.Drawing.Size(285, 108);
            this.btnDish.TabIndex = 3;
            this.btnDish.Text = "             Dishes";
            this.btnDish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDish.UseVisualStyleBackColor = false;
            // 
            // pnStatistic
            // 
            this.pnStatistic.Controls.Add(this.btnStatistic);
            this.pnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnStatistic.Location = new System.Drawing.Point(3, 231);
            this.pnStatistic.Name = "pnStatistic";
            this.pnStatistic.Size = new System.Drawing.Size(257, 70);
            this.pnStatistic.TabIndex = 5;
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistic.Image")));
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(-13, -21);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStatistic.Size = new System.Drawing.Size(285, 108);
            this.btnStatistic.TabIndex = 3;
            this.btnStatistic.Text = "             Statistic";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.UseVisualStyleBackColor = false;
            // 
            // pnSetting
            // 
            this.pnSetting.Controls.Add(this.btnSettings);
            this.pnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSetting.Location = new System.Drawing.Point(3, 307);
            this.pnSetting.Name = "pnSetting";
            this.pnSetting.Size = new System.Drawing.Size(257, 70);
            this.pnSetting.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(-13, -21);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(285, 108);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "             Setting";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLogout.Location = new System.Drawing.Point(3, 383);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(257, 70);
            this.pnLogout.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-13, -21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(285, 108);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "             Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // pnBody
            // 
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(261, 45);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(840, 513);
            this.pnBody.TabIndex = 2;
            this.pnBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBody_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1101, 558);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.pnChef.ResumeLayout(false);
            this.pnDish.ResumeLayout(false);
            this.pnStatistic.ResumeLayout(false);
            this.pnSetting.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnDish;
        private System.Windows.Forms.Button btnDish;
        private System.Windows.Forms.Panel pnChef;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.Panel pnSetting;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnStatistic;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox btnNo;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnBody;
    }
}

