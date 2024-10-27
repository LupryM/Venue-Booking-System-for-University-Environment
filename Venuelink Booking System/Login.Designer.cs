namespace Venuelink_Booking_System
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            fileSystemWatcher1 = new FileSystemWatcher();
            fileSystemWatcher2 = new FileSystemWatcher();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBoxClose = new PictureBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblRegister = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            txtUserID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBoxSHOWpassword = new PictureBox();
            PictureBoxPasswordHide = new PictureBox();
            toolTip3 = new ToolTip(components);
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            openFileDialog1 = new OpenFileDialog();
            toolTipHidePassword = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSHOWpassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPasswordHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            fileSystemWatcher2.EnableRaisingEvents = true;
            fileSystemWatcher2.SynchronizingObject = this;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1204, -4);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(31, 50);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 665);
            panel1.Name = "panel1";
            panel1.Size = new Size(1247, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(339, 20);
            label1.TabIndex = 0;
            label1.Text = "Copyright@2024. All Right Reserved,C# VenueLink";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(lblRegister);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtUserID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBoxSHOWpassword);
            groupBox1.Controls.Add(PictureBoxPasswordHide);
            groupBox1.Location = new Point(115, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 417);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.Red;
            lblRegister.Location = new Point(328, 327);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(45, 23);
            lblRegister.TabIndex = 6;
            lblRegister.Text = "here";
            lblRegister.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(89, 329);
            label4.Name = "label4";
            label4.Size = new Size(251, 20);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account?, Create one";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 211);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(313, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(37, 198, 218);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(89, 285);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(313, 41);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(89, 131);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(313, 27);
            txtUserID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(89, 188);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(89, 108);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // pictureBoxSHOWpassword
            // 
            pictureBoxSHOWpassword.Image = (Image)resources.GetObject("pictureBoxSHOWpassword.Image");
            pictureBoxSHOWpassword.Location = new Point(408, 211);
            pictureBoxSHOWpassword.Name = "pictureBoxSHOWpassword";
            pictureBoxSHOWpassword.Size = new Size(28, 27);
            pictureBoxSHOWpassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSHOWpassword.TabIndex = 7;
            pictureBoxSHOWpassword.TabStop = false;
            pictureBoxSHOWpassword.Click += pictureBox1_Click;
            // 
            // PictureBoxPasswordHide
            // 
            PictureBoxPasswordHide.Image = (Image)resources.GetObject("PictureBoxPasswordHide.Image");
            PictureBoxPasswordHide.Location = new Point(408, 211);
            PictureBoxPasswordHide.Name = "PictureBoxPasswordHide";
            PictureBoxPasswordHide.Size = new Size(28, 27);
            PictureBoxPasswordHide.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxPasswordHide.TabIndex = 8;
            PictureBoxPasswordHide.TabStop = false;
            PictureBoxPasswordHide.Click += PictureBoxPasswordHide_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(710, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 573);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(790, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(355, 302);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(37, 198, 218);
            label6.Location = new Point(805, 421);
            label6.Name = "label6";
            label6.Size = new Size(328, 40);
            label6.TabIndex = 3;
            label6.Text = "VenueLink Booking";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(37, 198, 218);
            label7.Location = new Point(900, 461);
            label7.Name = "label7";
            label7.Size = new Size(128, 39);
            label7.TabIndex = 4;
            label7.Text = "System";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTipHidePassword
            // 
            toolTipHidePassword.Tag = "Hide/Show Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1247, 724);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBoxClose);
            ForeColor = Color.DeepSkyBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSHOWpassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPasswordHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private FileSystemWatcher fileSystemWatcher2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBoxClose;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnLogin;
        private TextBox txtUserID;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private Label lblRegister;
        private Label label4;
        private PictureBox pictureBoxSHOWpassword;
        private ToolTip toolTip3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private OpenFileDialog openFileDialog1;
        private PictureBox PictureBoxPasswordHide;
        private ToolTip toolTipHidePassword;
    }
}