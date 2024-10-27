namespace Venuelink_Booking_System.User_Control
{
    partial class Delete_User
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
            btnDelete = new Button();
            txtUserID = new TextBox();
            label10 = new Label();
            label7 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(462, 328);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 41);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete User";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.KeyPress += btnDelete_KeyPress;
            // 
            // txtUserID
            // 
            txtUserID.BackColor = SystemColors.Menu;
            txtUserID.Location = new Point(19, 107);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(313, 27);
            txtUserID.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(19, 81);
            label10.Name = "label10";
            label10.Size = new Size(73, 23);
            label10.TabIndex = 45;
            label10.Text = "User ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(177, 38);
            label7.TabIndex = 44;
            label7.Text = "Delete User:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(388, 184);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 48;
            label1.Text = "label1";
            // 
            // Delete_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(txtUserID);
            Controls.Add(label10);
            Controls.Add(label7);
            Name = "Delete_User";
            Size = new Size(1120, 487);
            Load += Delete_User_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private TextBox txtUserID;
        private Label label10;
        private Label label7;
        private Label label1;
    }
}
