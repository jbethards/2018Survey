namespace Survey
{
    partial class Workout
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lblWork = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.lblCal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(12, 186);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(12, 42);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(79, 13);
            this.lblWork.TabIndex = 1;
            this.lblWork.Text = "Workout Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(98, 68);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(30, 20);
            this.txtTime.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(31, 68);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time Spent";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(98, 94);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(30, 20);
            this.txtCal.TabIndex = 6;
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Location = new System.Drawing.Point(12, 97);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(81, 13);
            this.lblCal.TabIndex = 5;
            this.lblCal.Text = "Calories Burned";
            // 
            // Workout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.btn_Submit);
            this.Name = "Workout";
            this.Text = "WorkoutName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.Label lblCal;
    }
}