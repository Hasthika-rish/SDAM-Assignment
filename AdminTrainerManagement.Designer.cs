namespace Gym_Management_System
{
    partial class AdminTrainerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTrainerManagement));
            this.dgvTrainers = new System.Windows.Forms.DataGridView();
            this.btnDeleteTrainer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainers
            // 
            this.dgvTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainers.Location = new System.Drawing.Point(45, 106);
            this.dgvTrainers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTrainers.Name = "dgvTrainers";
            this.dgvTrainers.RowHeadersWidth = 51;
            this.dgvTrainers.RowTemplate.Height = 24;
            this.dgvTrainers.Size = new System.Drawing.Size(957, 279);
            this.dgvTrainers.TabIndex = 0;
            // 
            // btnDeleteTrainer
            // 
            this.btnDeleteTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTrainer.Location = new System.Drawing.Point(817, 483);
            this.btnDeleteTrainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteTrainer.Name = "btnDeleteTrainer";
            this.btnDeleteTrainer.Size = new System.Drawing.Size(223, 73);
            this.btnDeleteTrainer.TabIndex = 1;
            this.btnDeleteTrainer.Text = "Delete Selected Trainer";
            this.btnDeleteTrainer.UseVisualStyleBackColor = true;
            this.btnDeleteTrainer.Click += new System.EventHandler(this.btnDeleteTrainer_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 70);
            this.button1.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(393, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trainer Manager";
            // 
            // AdminTrainerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteTrainer);
            this.Controls.Add(this.dgvTrainers);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminTrainerManagement";
            this.Text = "Admin Trainer Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainers;
        private System.Windows.Forms.Button btnDeleteTrainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}