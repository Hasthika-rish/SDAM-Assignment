namespace Gym_Management_System
{
    partial class TrainerReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerReservationForm));
            this.dgvAvailableTrainers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.dtpReservationDate = new System.Windows.Forms.DateTimePicker();
            this.btnReserveTrainer = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableTrainers
            // 
            this.dgvAvailableTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableTrainers.Location = new System.Drawing.Point(52, 85);
            this.dgvAvailableTrainers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAvailableTrainers.Name = "dgvAvailableTrainers";
            this.dgvAvailableTrainers.RowHeadersWidth = 51;
            this.dgvAvailableTrainers.RowTemplate.Height = 24;
            this.dgvAvailableTrainers.Size = new System.Drawing.Size(910, 193);
            this.dgvAvailableTrainers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Member Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Member Name:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(296, 312);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(296, 31);
            this.txtMemberName.TabIndex = 3;
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReservationDate.Location = new System.Drawing.Point(296, 361);
            this.dtpReservationDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.Size = new System.Drawing.Size(296, 31);
            this.dtpReservationDate.TabIndex = 4;
            // 
            // btnReserveTrainer
            // 
            this.btnReserveTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveTrainer.Location = new System.Drawing.Point(810, 452);
            this.btnReserveTrainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReserveTrainer.Name = "btnReserveTrainer";
            this.btnReserveTrainer.Size = new System.Drawing.Size(194, 61);
            this.btnReserveTrainer.TabIndex = 5;
            this.btnReserveTrainer.Text = "Reserve Trainer";
            this.btnReserveTrainer.UseVisualStyleBackColor = true;
            this.btnReserveTrainer.Click += new System.EventHandler(this.btnReserveTrainer_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(11, 452);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(193, 61);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reserve a Trainer";
            // 
            // TrainerReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.btnReserveTrainer);
            this.Controls.Add(this.dtpReservationDate);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAvailableTrainers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TrainerReservationForm";
            this.Text = "Trainer Reservation Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTrainers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvailableTrainers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.DateTimePicker dtpReservationDate;
        private System.Windows.Forms.Button btnReserveTrainer;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label label3;
    }
}