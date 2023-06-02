namespace BusTicketingSystem
{
    partial class AddBuses
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tx = new System.Windows.Forms.Label();
            this.txtBusNo = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartureCity = new System.Windows.Forms.TextBox();
            this.txtArrivalCity = new System.Windows.Forms.TextBox();
            this.busdate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(171, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Bus";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bus Number";
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(12, 136);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(135, 16);
            this.tx.TabIndex = 2;
            this.tx.Text = "Bus Seating Capacity";
            this.tx.Click += new System.EventHandler(this.tx_Click);
            // 
            // txtBusNo
            // 
            this.txtBusNo.Location = new System.Drawing.Point(171, 86);
            this.txtBusNo.Name = "txtBusNo";
            this.txtBusNo.Size = new System.Drawing.Size(114, 22);
            this.txtBusNo.TabIndex = 3;
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(171, 133);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(114, 22);
            this.txtSeats.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Departure City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arrival City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // txtDepartureCity
            // 
            this.txtDepartureCity.Location = new System.Drawing.Point(171, 181);
            this.txtDepartureCity.Name = "txtDepartureCity";
            this.txtDepartureCity.Size = new System.Drawing.Size(145, 22);
            this.txtDepartureCity.TabIndex = 8;
            // 
            // txtArrivalCity
            // 
            this.txtArrivalCity.Location = new System.Drawing.Point(171, 220);
            this.txtArrivalCity.Name = "txtArrivalCity";
            this.txtArrivalCity.Size = new System.Drawing.Size(145, 22);
            this.txtArrivalCity.TabIndex = 9;
            // 
            // busdate
            // 
            this.busdate.Location = new System.Drawing.Point(171, 261);
            this.busdate.Name = "busdate";
            this.busdate.Size = new System.Drawing.Size(200, 22);
            this.busdate.TabIndex = 10;
            this.busdate.ValueChanged += new System.EventHandler(this.busdate_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BusTicketingSystem.Properties.Resources.bus;
            this.pictureBox1.Location = new System.Drawing.Point(499, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 128);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(171, 383);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 39);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddBuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.busdate);
            this.Controls.Add(this.txtArrivalCity);
            this.Controls.Add(this.txtDepartureCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.txtBusNo);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddBuses";
            this.Text = "AddBuses";
            this.Load += new System.EventHandler(this.AddBuses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.TextBox txtBusNo;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartureCity;
        private System.Windows.Forms.TextBox txtArrivalCity;
        private System.Windows.Forms.DateTimePicker busdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
    }
}