namespace Venuelink_Booking_System.User_Control
{
    partial class UCViewBooking
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
            DGVviewBookings = new DataGridView();
            label12 = new Label();
            USERID = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVviewBookings).BeginInit();
            SuspendLayout();
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
            DGVviewBookings.Location = new Point(3, 69);
            DGVviewBookings.Name = "DGVviewBookings";
            DGVviewBookings.ReadOnly = true;
            DGVviewBookings.RowHeadersWidth = 51;
            DGVviewBookings.Size = new Size(1087, 392);
            DGVviewBookings.TabIndex = 0;
            DGVviewBookings.CellContentClick += DGVviewBookings_CellContentClick_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(261, 38);
            label12.TabIndex = 29;
            label12.Text = "View My Bookings";
            // 
            // USERID
            // 
            USERID.AutoSize = true;
            USERID.Location = new Point(510, 124);
            USERID.Name = "USERID";
            USERID.Size = new Size(59, 20);
            USERID.TabIndex = 30;
            USERID.Text = "USERID";
            // 
            // UCViewBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(label12);
            Controls.Add(DGVviewBookings);
            Controls.Add(USERID);
            Name = "UCViewBooking";
            Size = new Size(1092, 464);
            Load += UCViewBooking_Load;
            ((System.ComponentModel.ISupportInitialize)DGVviewBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVviewBookings;
        private Label label12;
        private Label USERID;
    }
}
