namespace Venuelink_Booking_System.User_Control
{
    partial class UserControlCreateBooking
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
            tabpageCreateaBooking = new TabControl();
            tabpageFindAvenue = new TabPage();
            label4 = new Label();
            dtpStartDate = new DateTimePicker();
            TimeSlot = new CheckedListBox();
            label2 = new Label();
            label7 = new Label();
            label9 = new Label();
            cboVenueCategory = new ComboBox();
            txtEventType = new TextBox();
            label10 = new Label();
            cboCapacityRequired = new ComboBox();
            label1 = new Label();
            btnClear = new Button();
            btnFindVenue = new Button();
            label6 = new Label();
            tabpageCreateaBookin = new TabPage();
            label3 = new Label();
            PickaVenue = new Label();
            button1 = new Button();
            button2 = new Button();
            label16 = new Label();
            label15 = new Label();
            btnCreate_Booking = new Button();
            cboVenue = new ComboBox();
            label8 = new Label();
            tabpageCreateaBooking.SuspendLayout();
            tabpageFindAvenue.SuspendLayout();
            tabpageCreateaBookin.SuspendLayout();
            SuspendLayout();
            // 
            // tabpageCreateaBooking
            // 
            tabpageCreateaBooking.Alignment = TabAlignment.Bottom;
            tabpageCreateaBooking.Controls.Add(tabpageFindAvenue);
            tabpageCreateaBooking.Controls.Add(tabpageCreateaBookin);
            tabpageCreateaBooking.Dock = DockStyle.Fill;
            tabpageCreateaBooking.Location = new Point(0, 0);
            tabpageCreateaBooking.Name = "tabpageCreateaBooking";
            tabpageCreateaBooking.SelectedIndex = 0;
            tabpageCreateaBooking.Size = new Size(1128, 521);
            tabpageCreateaBooking.TabIndex = 0;
            tabpageCreateaBooking.Selecting += tabpageCreateaBooking_Selecting_1;
            // 
            // tabpageFindAvenue
            // 
            tabpageFindAvenue.BackColor = Color.White;
            tabpageFindAvenue.Controls.Add(label4);
            tabpageFindAvenue.Controls.Add(dtpStartDate);
            tabpageFindAvenue.Controls.Add(TimeSlot);
            tabpageFindAvenue.Controls.Add(label2);
            tabpageFindAvenue.Controls.Add(label7);
            tabpageFindAvenue.Controls.Add(label9);
            tabpageFindAvenue.Controls.Add(cboVenueCategory);
            tabpageFindAvenue.Controls.Add(txtEventType);
            tabpageFindAvenue.Controls.Add(label10);
            tabpageFindAvenue.Controls.Add(cboCapacityRequired);
            tabpageFindAvenue.Controls.Add(label1);
            tabpageFindAvenue.Controls.Add(btnClear);
            tabpageFindAvenue.Controls.Add(btnFindVenue);
            tabpageFindAvenue.Controls.Add(label6);
            tabpageFindAvenue.Location = new Point(4, 4);
            tabpageFindAvenue.Name = "tabpageFindAvenue";
            tabpageFindAvenue.Padding = new Padding(3);
            tabpageFindAvenue.Size = new Size(1120, 487);
            tabpageFindAvenue.TabIndex = 0;
            tabpageFindAvenue.Text = "Find a Venue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(866, 6);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 75;
            label4.Text = "Event Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.None;
            dtpStartDate.Location = new Point(866, 40);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(249, 28);
            dtpStartDate.TabIndex = 3;
            // 
            // TimeSlot
            // 
            TimeSlot.BorderStyle = BorderStyle.None;
            TimeSlot.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimeSlot.FormattingEnabled = true;
            TimeSlot.Location = new Point(866, 89);
            TimeSlot.Name = "TimeSlot";
            TimeSlot.Size = new Size(157, 276);
            TimeSlot.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 20);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 51;
            label2.Text = "label2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(37, 198, 218);
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(186, 38);
            label7.TabIndex = 50;
            label7.Text = "Find a Venue";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(26, 178);
            label9.Name = "label9";
            label9.Size = new Size(153, 25);
            label9.TabIndex = 49;
            label9.Text = "Venue Category:";
            // 
            // cboVenueCategory
            // 
            cboVenueCategory.Anchor = AnchorStyles.None;
            cboVenueCategory.BackColor = SystemColors.Menu;
            cboVenueCategory.FlatStyle = FlatStyle.Flat;
            cboVenueCategory.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboVenueCategory.FormattingEnabled = true;
            cboVenueCategory.Location = new Point(26, 213);
            cboVenueCategory.Margin = new Padding(3, 2, 3, 2);
            cboVenueCategory.Name = "cboVenueCategory";
            cboVenueCategory.Size = new Size(274, 30);
            cboVenueCategory.TabIndex = 1;
            cboVenueCategory.Text = "Please select...";
            // 
            // txtEventType
            // 
            txtEventType.BackColor = SystemColors.ControlLight;
            txtEventType.Location = new Point(26, 119);
            txtEventType.Margin = new Padding(3, 2, 3, 2);
            txtEventType.Name = "txtEventType";
            txtEventType.Size = new Size(274, 28);
            txtEventType.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(26, 268);
            label10.Name = "label10";
            label10.Size = new Size(230, 25);
            label10.TabIndex = 46;
            label10.Text = "Venue Capacity Required:";
            // 
            // cboCapacityRequired
            // 
            cboCapacityRequired.Anchor = AnchorStyles.None;
            cboCapacityRequired.BackColor = SystemColors.Menu;
            cboCapacityRequired.FlatStyle = FlatStyle.Flat;
            cboCapacityRequired.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCapacityRequired.FormattingEnabled = true;
            cboCapacityRequired.Location = new Point(26, 295);
            cboCapacityRequired.Margin = new Padding(3, 2, 3, 2);
            cboCapacityRequired.Name = "cboCapacityRequired";
            cboCapacityRequired.Size = new Size(274, 30);
            cboCapacityRequired.TabIndex = 2;
            cboCapacityRequired.Text = "Please select...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(26, 89);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 44;
            label1.Text = "Event Type:";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.FromArgb(234, 73, 73);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(613, 382);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(158, 41);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnFindVenue
            // 
            btnFindVenue.Anchor = AnchorStyles.None;
            btnFindVenue.BackColor = Color.FromArgb(37, 198, 218);
            btnFindVenue.FlatAppearance.BorderSize = 0;
            btnFindVenue.FlatStyle = FlatStyle.Flat;
            btnFindVenue.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFindVenue.ForeColor = Color.White;
            btnFindVenue.Location = new Point(347, 382);
            btnFindVenue.Margin = new Padding(3, 2, 3, 2);
            btnFindVenue.Name = "btnFindVenue";
            btnFindVenue.Size = new Size(158, 41);
            btnFindVenue.TabIndex = 5;
            btnFindVenue.Text = "Find Venue";
            btnFindVenue.UseVisualStyleBackColor = false;
            btnFindVenue.Click += btnFindVenue_Click_1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(656, 223);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 40;
            // 
            // tabpageCreateaBookin
            // 
            tabpageCreateaBookin.BackColor = Color.White;
            tabpageCreateaBookin.Controls.Add(label3);
            tabpageCreateaBookin.Controls.Add(PickaVenue);
            tabpageCreateaBookin.Controls.Add(button1);
            tabpageCreateaBookin.Controls.Add(button2);
            tabpageCreateaBookin.Controls.Add(label16);
            tabpageCreateaBookin.Controls.Add(label15);
            tabpageCreateaBookin.Controls.Add(btnCreate_Booking);
            tabpageCreateaBookin.Controls.Add(cboVenue);
            tabpageCreateaBookin.Controls.Add(label8);
            tabpageCreateaBookin.Location = new Point(4, 4);
            tabpageCreateaBookin.Name = "tabpageCreateaBookin";
            tabpageCreateaBookin.Padding = new Padding(3);
            tabpageCreateaBookin.Size = new Size(1120, 488);
            tabpageCreateaBookin.TabIndex = 1;
            tabpageCreateaBookin.Text = "Create a Booking";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(37, 198, 218);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(242, 38);
            label3.TabIndex = 72;
            label3.Text = "Create a Booking";
            // 
            // PickaVenue
            // 
            PickaVenue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PickaVenue.AutoSize = true;
            PickaVenue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PickaVenue.ForeColor = Color.Black;
            PickaVenue.Location = new Point(398, 157);
            PickaVenue.Name = "PickaVenue";
            PickaVenue.Size = new Size(149, 23);
            PickaVenue.TabIndex = 71;
            PickaVenue.Text = "Available Venues:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(234, 73, 73);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(665, 308);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(148, 34);
            button1.TabIndex = 70;
            button1.Text = "Quit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.DarkGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(438, 308);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(156, 34);
            button2.TabIndex = 69;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(544, 192);
            label16.Name = "label16";
            label16.Size = new Size(0, 20);
            label16.TabIndex = 64;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(73, 174);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 62;
            // 
            // btnCreate_Booking
            // 
            btnCreate_Booking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreate_Booking.BackColor = Color.FromArgb(37, 198, 218);
            btnCreate_Booking.FlatAppearance.BorderSize = 0;
            btnCreate_Booking.FlatStyle = FlatStyle.Flat;
            btnCreate_Booking.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate_Booking.ForeColor = Color.White;
            btnCreate_Booking.Location = new Point(216, 308);
            btnCreate_Booking.Margin = new Padding(3, 2, 3, 2);
            btnCreate_Booking.Name = "btnCreate_Booking";
            btnCreate_Booking.Size = new Size(159, 34);
            btnCreate_Booking.TabIndex = 60;
            btnCreate_Booking.Text = "Create Booking";
            btnCreate_Booking.UseVisualStyleBackColor = false;
            btnCreate_Booking.Click += btnCreate_Booking_Click;
            // 
            // cboVenue
            // 
            cboVenue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboVenue.BackColor = SystemColors.Menu;
            cboVenue.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVenue.FlatStyle = FlatStyle.Flat;
            cboVenue.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboVenue.FormattingEnabled = true;
            cboVenue.Location = new Point(398, 182);
            cboVenue.Margin = new Padding(3, 2, 3, 2);
            cboVenue.Name = "cboVenue";
            cboVenue.Size = new Size(249, 30);
            cboVenue.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(37, 198, 218);
            label8.Location = new Point(43, 62);
            label8.Name = "label8";
            label8.Size = new Size(0, 38);
            label8.TabIndex = 58;
            // 
            // UserControlCreateBooking
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tabpageCreateaBooking);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(37, 198, 250);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1128, 48);
            Name = "UserControlCreateBooking";
            Size = new Size(1128, 521);
            Load += UserControlCreateBooking_Load;
            tabpageCreateaBooking.ResumeLayout(false);
            tabpageFindAvenue.ResumeLayout(false);
            tabpageFindAvenue.PerformLayout();
            tabpageCreateaBookin.ResumeLayout(false);
            tabpageCreateaBookin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private TabControl tabpageCreateaBooking;
        private TabPage tabpageFindAvenue;
        private TextBox txtEventType;
        private Label label10;
        private ComboBox cboCapacityRequired;
        private Label label1;
        private Button btnClear;
        private Button btnFindVenue;
        private Label label6;
        private Label label9;
        private ComboBox cboVenueCategory;
        private Label label7;
        private Label label2;
        private CheckedListBox TimeSlot;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private TabPage tabpageCreateaBookin;
        private Label label15;
        private Label label8;
        private Label label3;
        private Label PickaVenue;
        private Button button1;
        private Button button2;
        private Label label16;
        private Button btnCreate_Booking;
        private ComboBox cboVenue;
    }
}
