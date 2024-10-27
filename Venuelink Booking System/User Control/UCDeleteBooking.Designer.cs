namespace Venuelink_Booking_System.User_Control
{
    partial class UCDeleteBooking
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
            label7 = new Label();
            label10 = new Label();
            txtBookingID = new TextBox();
            btnDelete = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(220, 38);
            label7.TabIndex = 21;
            label7.Text = "Delete Booking";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(19, 81);
            label10.Name = "label10";
            label10.Size = new Size(105, 23);
            label10.TabIndex = 24;
            label10.Text = "Booking ID:";
            // 
            // txtBookingID
            // 
            txtBookingID.BackColor = SystemColors.Menu;
            txtBookingID.Location = new Point(19, 107);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new Size(313, 30);
            txtBookingID.TabIndex = 42;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(474, 328);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 41);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete Booking";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(570, 167);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 44;
            label1.Text = "label1";
            // 
            // UCDeleteBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtBookingID);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UCDeleteBooking";
            Size = new Size(1120, 464);
            Load += UCDeleteBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label10;
        private TextBox txtBookingID;
        private Button btnDelete;
        private Label label1;
    }
}
