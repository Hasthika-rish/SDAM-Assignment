namespace Gym_Management_System
{
    partial class AdminReservationManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReservationManagement));
            this.dgvReservedEquipment = new System.Windows.Forms.DataGridView();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReservationDate = new System.Windows.Forms.DateTimePicker();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnUpdateReservation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservedEquipment
            // 
            this.dgvReservedEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservedEquipment.Location = new System.Drawing.Point(58, 102);
            this.dgvReservedEquipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReservedEquipment.Name = "dgvReservedEquipment";
            this.dgvReservedEquipment.RowHeadersWidth = 51;
            this.dgvReservedEquipment.RowTemplate.Height = 24;
            this.dgvReservedEquipment.Size = new System.Drawing.Size(813, 208);
            this.dgvReservedEquipment.TabIndex = 0;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Location = new System.Drawing.Point(690, 337);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(203, 20);
            this.dtpReturnDate.TabIndex = 12;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReservationDate.Location = new System.Drawing.Point(231, 394);
            this.dtpReservationDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.Size = new System.Drawing.Size(232, 29);
            this.dtpReservationDate.TabIndex = 11;
            this.dtpReservationDate.ValueChanged += new System.EventHandler(this.dtpReservationDate_ValueChanged);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(231, 335);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(232, 29);
            this.txtMemberName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(489, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Edit Return Date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Edit Reservation Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edit Member Name:";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Reserved",
            "Returned"});
            this.cmbStatus.Location = new System.Drawing.Point(690, 376);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(203, 32);
            this.cmbStatus.TabIndex = 13;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(489, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Edit Status:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReservation.Location = new System.Drawing.Point(753, 449);
            this.btnDeleteReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(169, 65);
            this.btnDeleteReservation.TabIndex = 15;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click_1);
            // 
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateReservation.Location = new System.Drawing.Point(551, 449);
            this.btnUpdateReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(172, 65);
            this.btnUpdateReservation.TabIndex = 16;
            this.btnUpdateReservation.Text = "Update Reservation";
            this.btnUpdateReservation.UseVisualStyleBackColor = true;
            this.btnUpdateReservation.Click += new System.EventHandler(this.btnUpdateReservation_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 65);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(307, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reservation Manager";
            // 
            // AdminReservationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateReservation);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.dtpReservationDate);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservedEquipment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminReservationManagement";
            this.Text = "Admin Reservation Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservedEquipment;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReservationDate;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnUpdateReservation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}