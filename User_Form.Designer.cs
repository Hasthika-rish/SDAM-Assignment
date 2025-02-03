namespace Gym_Management_System
{
    partial class User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Form));
            this.register_btn = new System.Windows.Forms.Button();
            this.attendence_btn = new System.Windows.Forms.Button();
            this.TrianerR_btn = new System.Windows.Forms.Button();
            this.Equ_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(69, 71);
            this.register_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(266, 130);
            this.register_btn.TabIndex = 0;
            this.register_btn.Text = "Register for the Gym";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // attendence_btn
            // 
            this.attendence_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendence_btn.Location = new System.Drawing.Point(69, 244);
            this.attendence_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.attendence_btn.Name = "attendence_btn";
            this.attendence_btn.Size = new System.Drawing.Size(266, 135);
            this.attendence_btn.TabIndex = 1;
            this.attendence_btn.Text = "Mark Your Attendence";
            this.attendence_btn.UseVisualStyleBackColor = true;
            this.attendence_btn.Click += new System.EventHandler(this.attendence_btn_Click);
            // 
            // TrianerR_btn
            // 
            this.TrianerR_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrianerR_btn.Location = new System.Drawing.Point(521, 244);
            this.TrianerR_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrianerR_btn.Name = "TrianerR_btn";
            this.TrianerR_btn.Size = new System.Drawing.Size(273, 135);
            this.TrianerR_btn.TabIndex = 3;
            this.TrianerR_btn.Text = "Trainers Reservation";
            this.TrianerR_btn.UseVisualStyleBackColor = true;
            this.TrianerR_btn.Click += new System.EventHandler(this.TrianerR_btn_Click);
            // 
            // Equ_btn
            // 
            this.Equ_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equ_btn.Location = new System.Drawing.Point(521, 71);
            this.Equ_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Equ_btn.Name = "Equ_btn";
            this.Equ_btn.Size = new System.Drawing.Size(273, 130);
            this.Equ_btn.TabIndex = 2;
            this.Equ_btn.Text = "Equipments Reservation";
            this.Equ_btn.UseVisualStyleBackColor = true;
            this.Equ_btn.Click += new System.EventHandler(this.Equ_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(728, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "welcome to titan fitness centre";
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TrianerR_btn);
            this.Controls.Add(this.Equ_btn);
            this.Controls.Add(this.attendence_btn);
            this.Controls.Add(this.register_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "User_Form";
            this.Text = "User Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button attendence_btn;
        private System.Windows.Forms.Button TrianerR_btn;
        private System.Windows.Forms.Button Equ_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}