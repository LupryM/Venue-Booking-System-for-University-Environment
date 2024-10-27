namespace Venuelink_Booking_System.User_Control
{
    partial class UpdateUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLname = new TextBox();
            label3 = new Label();
            txtFname = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            btnUpdateUser = new Button();
            label7 = new Label();
            txtUserID = new TextBox();
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // txtLname
            // 
            txtLname.Location = new Point(290, 283);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(313, 27);
            txtLname.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(292, 255);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 22;
            label3.Text = "Last Name:";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(290, 214);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(313, 27);
            txtFname.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(292, 186);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 20;
            label2.Text = "First Name:";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.FromArgb(234, 73, 73);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(527, 372);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(169, 41);
            btnClear.TabIndex = 33;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Anchor = AnchorStyles.None;
            btnUpdateUser.BackColor = Color.LimeGreen;
            btnUpdateUser.FlatAppearance.BorderSize = 0;
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateUser.ForeColor = Color.White;
            btnUpdateUser.Location = new Point(200, 372);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(169, 41);
            btnUpdateUser.TabIndex = 32;
            btnUpdateUser.Text = "Update Profile";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(178, 38);
            label7.TabIndex = 34;
            label7.Text = "Update User";
            // 
            // txtUserID
            // 
            txtUserID.BackColor = SystemColors.Menu;
            txtUserID.Location = new Point(3, 87);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(313, 27);
            txtUserID.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(3, 61);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 42;
            label1.Text = "User Number:";
            // 
            // UpdateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtUserID);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(btnUpdateUser);
            Controls.Add(txtLname);
            Controls.Add(label3);
            Controls.Add(txtFname);
            Controls.Add(label2);
            Name = "UpdateUser";
            Size = new Size(962, 464);
            Load += UpdateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLname;
        private Label label3;
        private TextBox txtFname;
        private Label label2;
        private Button btnClear;
        private Button btnUpdateUser;
        private Label label7;
        private TextBox txtUserID;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
