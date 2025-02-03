namespace Gym_Management_System
{
    partial class AdminAttendanceManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAttendanceManagement));
            this.dgvAttendanceRecords = new System.Windows.Forms.DataGridView();
            this.btnDeleteAttendance = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAttendanceRecords
            // 
            this.dgvAttendanceRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceRecords.Location = new System.Drawing.Point(39, 80);
            this.dgvAttendanceRecords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAttendanceRecords.Name = "dgvAttendanceRecords";
            this.dgvAttendanceRecords.RowHeadersWidth = 51;
            this.dgvAttendanceRecords.RowTemplate.Height = 24;
            this.dgvAttendanceRecords.Size = new System.Drawing.Size(795, 272);
            this.dgvAttendanceRecords.TabIndex = 0;
            // 
            // btnDeleteAttendance
            // 
            this.btnDeleteAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAttendance.Location = new System.Drawing.Point(639, 367);
            this.btnDeleteAttendance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteAttendance.Name = "btnDeleteAttendance";
            this.btnDeleteAttendance.Size = new System.Drawing.Size(195, 90);
            this.btnDeleteAttendance.TabIndex = 1;
            this.btnDeleteAttendance.Text = "Delete Selected Attendance";
            this.btnDeleteAttendance.UseVisualStyleBackColor = true;
            this.btnDeleteAttendance.Click += new System.EventHandler(this.btnDeleteAttendance_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attendace Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminAttendanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteAttendance);
            this.Controls.Add(this.dgvAttendanceRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminAttendanceManagement";
            this.Text = "Admin Attendance Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendanceRecords;
        private System.Windows.Forms.Button btnDeleteAttendance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}