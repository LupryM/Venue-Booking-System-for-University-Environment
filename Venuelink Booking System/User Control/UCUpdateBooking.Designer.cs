namespace Venuelink_Booking_System.User_Control
{
    partial class UCUpdateBooking
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            TimeSlot = new CheckedListBox();
            label15 = new Label();
            dtpStartDate = new DateTimePicker();
            txtBookingID = new TextBox();
            label2 = new Label();
            txtEventType = new TextBox();
            label10 = new Label();
            cboCapacityRequired = new ComboBox();
            label9 = new Label();
            cboVenueCategory = new ComboBox();
            label1 = new Label();
            btnClear = new Button();
            btnUpdateBooking = new Button();
            label6 = new Label();
            label7 = new Label();
            tabUpdateVenue = new TabPage();
            label50 = new Label();
            btnQuit = new Button();
            btnConfirmUpdate = new Button();
            label14 = new Label();
            cboVenue = new ComboBox();
            label8 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabUpdateVenue.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabUpdateVenue);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Century Gothic", 10.2F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1128, 521);
            tabControl1.TabIndex = 0;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(TimeSlot);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(dtpStartDate);
            tabPage2.Controls.Add(txtBookingID);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtEventType);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(cboCapacityRequired);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(cboVenueCategory);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnClear);
            tabPage2.Controls.Add(btnUpdateBooking);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            tabPage2.ForeColor = Color.White;
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1120, 487);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update Booking";
            tabPage2.Click += tabPage2_Click;
            // 
            // TimeSlot
            // 
            TimeSlot.BorderStyle = BorderStyle.None;
            TimeSlot.FormattingEnabled = true;
            TimeSlot.Location = new Point(795, 118);
            TimeSlot.Name = "TimeSlot";
            TimeSlot.Size = new Size(209, 276);
            TimeSlot.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(795, 54);
            label15.Name = "label15";
            label15.Size = new Size(89, 20);
            label15.TabIndex = 53;
            label15.Text = "Event Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.None;
            dtpStartDate.Location = new Point(795, 77);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(296, 28);
            dtpStartDate.TabIndex = 4;
            // 
            // txtBookingID
            // 
            txtBookingID.BackColor = SystemColors.Menu;
            txtBookingID.Location = new Point(6, 93);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new Size(313, 28);
            txtBookingID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 40;
            label2.Text = "Booking ID:";
            // 
            // txtEventType
            // 
            txtEventType.BackColor = SystemColors.Menu;
            txtEventType.Location = new Point(6, 169);
            txtEventType.Name = "txtEventType";
            txtEventType.Size = new Size(313, 28);
            txtEventType.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(3, 312);
            label10.Name = "label10";
            label10.Size = new Size(210, 23);
            label10.TabIndex = 36;
            label10.Text = "Venue Capacity Required";
            // 
            // cboCapacityRequired
            // 
            cboCapacityRequired.Anchor = AnchorStyles.None;
            cboCapacityRequired.BackColor = SystemColors.Menu;
            cboCapacityRequired.FlatStyle = FlatStyle.Flat;
            cboCapacityRequired.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCapacityRequired.FormattingEnabled = true;
            cboCapacityRequired.Location = new Point(3, 338);
            cboCapacityRequired.Name = "cboCapacityRequired";
            cboCapacityRequired.Size = new Size(313, 30);
            cboCapacityRequired.TabIndex = 3;
            cboCapacityRequired.SelectedIndexChanged += cboCapacityRequired_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(3, 224);
            label9.Name = "label9";
            label9.Size = new Size(137, 23);
            label9.TabIndex = 34;
            label9.Text = "Venue Category";
            // 
            // cboVenueCategory
            // 
            cboVenueCategory.Anchor = AnchorStyles.None;
            cboVenueCategory.BackColor = SystemColors.Menu;
            cboVenueCategory.FlatStyle = FlatStyle.Flat;
            cboVenueCategory.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboVenueCategory.FormattingEnabled = true;
            cboVenueCategory.Location = new Point(3, 250);
            cboVenueCategory.Name = "cboVenueCategory";
            cboVenueCategory.Size = new Size(313, 30);
            cboVenueCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 141);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 32;
            label1.Text = "Event Type:";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.FromArgb(234, 73, 73);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(639, 413);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(169, 41);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdateBooking
            // 
            btnUpdateBooking.Anchor = AnchorStyles.None;
            btnUpdateBooking.BackColor = Color.LimeGreen;
            btnUpdateBooking.FlatAppearance.BorderSize = 0;
            btnUpdateBooking.FlatStyle = FlatStyle.Flat;
            btnUpdateBooking.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateBooking.ForeColor = Color.White;
            btnUpdateBooking.Location = new Point(312, 413);
            btnUpdateBooking.Name = "btnUpdateBooking";
            btnUpdateBooking.Size = new Size(169, 41);
            btnUpdateBooking.TabIndex = 6;
            btnUpdateBooking.Text = "Update Booking";
            btnUpdateBooking.UseVisualStyleBackColor = false;
            btnUpdateBooking.Click += btnUpdateBooking_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(755, 270);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(230, 38);
            label7.TabIndex = 20;
            label7.Text = "Update Booking";
            // 
            // tabUpdateVenue
            // 
            tabUpdateVenue.Controls.Add(label50);
            tabUpdateVenue.Controls.Add(btnQuit);
            tabUpdateVenue.Controls.Add(btnConfirmUpdate);
            tabUpdateVenue.Controls.Add(label14);
            tabUpdateVenue.Controls.Add(cboVenue);
            tabUpdateVenue.Controls.Add(label8);
            tabUpdateVenue.Location = new Point(4, 4);
            tabUpdateVenue.Name = "tabUpdateVenue";
            tabUpdateVenue.Padding = new Padding(3);
            tabUpdateVenue.Size = new Size(1120, 487);
            tabUpdateVenue.TabIndex = 2;
            tabUpdateVenue.Text = "Update Venue";
            tabUpdateVenue.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.ForeColor = Color.White;
            label50.Location = new Point(562, 84);
            label50.Name = "label50";
            label50.Size = new Size(60, 21);
            label50.TabIndex = 58;
            label50.Text = "label3";
            // 
            // btnQuit
            // 
            btnQuit.Anchor = AnchorStyles.None;
            btnQuit.BackColor = Color.FromArgb(234, 73, 73);
            btnQuit.FlatAppearance.BorderSize = 0;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.White;
            btnQuit.Location = new Point(622, 364);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(169, 41);
            btnQuit.TabIndex = 57;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnConfirmUpdate
            // 
            btnConfirmUpdate.Anchor = AnchorStyles.None;
            btnConfirmUpdate.BackColor = Color.LimeGreen;
            btnConfirmUpdate.FlatAppearance.BorderSize = 0;
            btnConfirmUpdate.FlatStyle = FlatStyle.Flat;
            btnConfirmUpdate.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmUpdate.ForeColor = Color.White;
            btnConfirmUpdate.Location = new Point(301, 364);
            btnConfirmUpdate.Name = "btnConfirmUpdate";
            btnConfirmUpdate.Size = new Size(169, 41);
            btnConfirmUpdate.TabIndex = 47;
            btnConfirmUpdate.Text = "Confirm Update";
            btnConfirmUpdate.UseVisualStyleBackColor = false;
            btnConfirmUpdate.Click += btnUpdateVenue_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(407, 169);
            label14.Name = "label14";
            label14.Size = new Size(63, 23);
            label14.TabIndex = 46;
            label14.Text = "Venue:";
            // 
            // cboVenue
            // 
            cboVenue.Anchor = AnchorStyles.None;
            cboVenue.BackColor = SystemColors.Menu;
            cboVenue.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVenue.FlatStyle = FlatStyle.Flat;
            cboVenue.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboVenue.FormattingEnabled = true;
            cboVenue.Location = new Point(407, 195);
            cboVenue.Name = "cboVenue";
            cboVenue.Size = new Size(284, 30);
            cboVenue.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(201, 38);
            label8.TabIndex = 39;
            label8.Text = "Update Venue";
            // 
            // UCUpdateBooking
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tabControl1);
            MinimumSize = new Size(1128, 521);
            Name = "UCUpdateBooking";
            Size = new Size(1128, 521);
            Load += UCUpdateBooking_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabUpdateVenue.ResumeLayout(false);
            tabUpdateVenue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TextBox txtBookingID;
        private Label label2;
        private GroupBox Duration;
        private Label label11;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private Label label9;
        private ComboBox cboVenueCategory;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private TabPage tabUpdateVenue;
        private Button btnQuit;
        private Button btnConfirmUpdate;
        private Label label14;
        private ComboBox cboVenue;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtEventType;
        private Label label10;
        private ComboBox cboCapacityRequired;
        private Label label1;
        private Button btnClear;
        private Button btnUpdateBooking;
        private Label label6;
        private Label label15;
        private DateTimePicker dtpStartDate;
        private CheckedListBox TimeSlot;
        private Label label50;
    }
}
