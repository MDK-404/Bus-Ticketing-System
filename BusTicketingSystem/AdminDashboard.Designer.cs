namespace BusTicketingSystem
{
    partial class AdminDashboard
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
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnViewBus = new System.Windows.Forms.Button();
            this.dgvViewBusses = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBusses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(39, 68);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(191, 47);
            this.btnAddBus.TabIndex = 0;
            this.btnAddBus.Text = "Add Bus";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnViewBus
            // 
            this.btnViewBus.Location = new System.Drawing.Point(39, 135);
            this.btnViewBus.Name = "btnViewBus";
            this.btnViewBus.Size = new System.Drawing.Size(191, 50);
            this.btnViewBus.TabIndex = 2;
            this.btnViewBus.Text = "View Buses";
            this.btnViewBus.UseVisualStyleBackColor = true;
            this.btnViewBus.Click += new System.EventHandler(this.btnViewBus_Click);
            // 
            // dgvViewBusses
            // 
            this.dgvViewBusses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBusses.Location = new System.Drawing.Point(348, 355);
            this.dgvViewBusses.Name = "dgvViewBusses";
            this.dgvViewBusses.RowHeadersWidth = 51;
            this.dgvViewBusses.RowTemplate.Height = 24;
            this.dgvViewBusses.Size = new System.Drawing.Size(864, 275);
            this.dgvViewBusses.TabIndex = 4;
            this.dgvViewBusses.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BusTicketingSystem.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(495, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 318);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvViewBusses);
            this.Controls.Add(this.btnViewBus);
            this.Controls.Add(this.btnAddBus);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBusses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnViewBus;
        private System.Windows.Forms.DataGridView dgvViewBusses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}