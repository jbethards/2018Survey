namespace Survey
{
    partial class School
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassLength = new System.Windows.Forms.TextBox();
            this.txtStudy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(12, 116);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Length:";
            // 
            // txtClassLength
            // 
            this.txtClassLength.Location = new System.Drawing.Point(87, 32);
            this.txtClassLength.Name = "txtClassLength";
            this.txtClassLength.Size = new System.Drawing.Size(47, 20);
            this.txtClassLength.TabIndex = 2;
            // 
            // txtStudy
            // 
            this.txtStudy.Location = new System.Drawing.Point(86, 62);
            this.txtStudy.Name = "txtStudy";
            this.txtStudy.Size = new System.Drawing.Size(30, 20);
            this.txtStudy.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Study Length:";
            // 
            // School
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtStudy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClassLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Submit);
            this.Name = "School";
            this.Text = "School";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassLength;
        private System.Windows.Forms.TextBox txtStudy;
        private System.Windows.Forms.Label label2;
    }
}