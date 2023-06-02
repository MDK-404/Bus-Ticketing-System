namespace BusTicketingSystem
{
    partial class UserDashBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDeparture = new System.Windows.Forms.ComboBox();
            this.cmbArrival = new System.Windows.Forms.ComboBox();
            this.btnFindBus = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAvailablebus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Departure City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Arrival City";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Date";
            // 
            // cmbDeparture
            // 
            this.cmbDeparture.FormattingEnabled = true;
            this.cmbDeparture.Location = new System.Drawing.Point(202, 47);
            this.cmbDeparture.Name = "cmbDeparture";
            this.cmbDeparture.Size = new System.Drawing.Size(121, 24);
            this.cmbDeparture.TabIndex = 4;
            this.cmbDeparture.SelectedIndexChanged += new System.EventHandler(this.cmbDeparture_SelectedIndexChanged);
            // 
            // cmbArrival
            // 
            this.cmbArrival.FormattingEnabled = true;
            this.cmbArrival.Location = new System.Drawing.Point(202, 103);
            this.cmbArrival.Name = "cmbArrival";
            this.cmbArrival.Size = new System.Drawing.Size(121, 24);
            this.cmbArrival.TabIndex = 5;
            // 
            // btnFindBus
            // 
            this.btnFindBus.Location = new System.Drawing.Point(179, 208);
            this.btnFindBus.Name = "btnFindBus";
            this.btnFindBus.Size = new System.Drawing.Size(75, 23);
            this.btnFindBus.TabIndex = 6;
            this.btnFindBus.Text = "Find Bus";
            this.btnFindBus.UseVisualStyleBackColor = true;
            this.btnFindBus.Click += new System.EventHandler(this.btnFindBus_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(648, 208);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(133, 23);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Book Seat";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(89, 511);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(165, 53);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Available Buses";
            // 
            // cmbAvailablebus
            // 
            this.cmbAvailablebus.FormattingEnabled = true;
            this.cmbAvailablebus.Location = new System.Drawing.Point(675, 56);
            this.cmbAvailablebus.Name = "cmbAvailablebus";
            this.cmbAvailablebus.Size = new System.Drawing.Size(121, 24);
            this.cmbAvailablebus.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "How many Seats Do you want to book";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(770, 136);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(199, 22);
            this.txtSeats.TabIndex = 15;
            // 
            // UserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 602);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAvailablebus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnFindBus);
            this.Controls.Add(this.cmbArrival);
            this.Controls.Add(this.cmbDeparture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserDashBoard";
            this.Text = "UserDashBoard";
            this.Load += new System.EventHandler(this.UserDashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDeparture;
        private System.Windows.Forms.ComboBox cmbArrival;
        private System.Windows.Forms.Button btnFindBus;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAvailablebus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeats;
    }
}