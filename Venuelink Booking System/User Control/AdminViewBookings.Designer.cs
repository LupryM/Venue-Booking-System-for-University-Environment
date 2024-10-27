namespace Venuelink_Booking_System.User_Control
{
    partial class AdminViewBookings
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label12 = new Label();
            DGVviewBookings = new DataGridView();
            USERID = new Label();
            tabPage2 = new TabPage();
            dgvViewUser = new DataGridView();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVviewBookings).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewUser).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1077, 485);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(DGVviewBookings);
            tabPage1.Controls.Add(USERID);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1069, 452);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bookings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(-4, -4);
            label12.Name = "label12";
            label12.Size = new Size(211, 38);
            label12.TabIndex = 38;
            label12.Text = "View Bookings";
            // 
            // DGVviewBookings
            // 
            DGVviewBookings.AllowUserToAddRows = false;
            DGVviewBookings.AllowUserToDeleteRows = false;
            DGVviewBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DGVviewBookings.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVviewBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVviewBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVviewBookings.GridColor = Color.White;
            DGVviewBookings.Location = new Point(-9, 46);
            DGVviewBookings.Name = "DGVviewBookings";
            DGVviewBookings.ReadOnly = true;
            DGVviewBookings.RowHeadersWidth = 51;
            DGVviewBookings.Size = new Size(1082, 406);
            DGVviewBookings.TabIndex = 37;
            // 
            // USERID
            // 
            USERID.AutoSize = true;
            USERID.Location = new Point(504, 174);
            USERID.Name = "USERID";
            USERID.Size = new Size(59, 20);
            USERID.TabIndex = 39;
            USERID.Text = "USERID";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvViewUser);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1069, 452);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Users";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // dgvViewUser
            // 
            dgvViewUser.AllowUserToAddRows = false;
            dgvViewUser.AllowUserToDeleteRows = false;
            dgvViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvViewUser.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewUser.GridColor = Color.White;
            dgvViewUser.Location = new Point(-4, 46);
            dgvViewUser.Name = "dgvViewUser";
            dgvViewUser.ReadOnly = true;
            dgvViewUser.RowHeadersWidth = 51;
            dgvViewUser.Size = new Size(1082, 406);
            dgvViewUser.TabIndex = 40;
            dgvViewUser.CellContentClick += dgvViewUser_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-4, -4);
            label1.Name = "label1";
            label1.Size = new Size(147, 38);
            label1.TabIndex = 39;
            label1.Text = "View User";
            // 
            // AdminViewBookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "AdminViewBookings";
            RightToLeft = RightToLeft.No;
            Size = new Size(1077, 485);
            Load += AdminViewBookings_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVviewBookings).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label12;
        private DataGridView DGVviewBookings;
        private Label USERID;
        private Label label1;
        private DataGridView dgvViewUser;
    }
}
