namespace Survey
{
    partial class Health
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
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalCon = new System.Windows.Forms.TextBox();
            this.lblCal = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(115, 7);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(30, 20);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight:";
            // 
            // txtCalCon
            // 
            this.txtCalCon.Location = new System.Drawing.Point(115, 33);
            this.txtCalCon.Name = "txtCalCon";
            this.txtCalCon.Size = new System.Drawing.Size(30, 20);
            this.txtCalCon.TabIndex = 5;
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Location = new System.Drawing.Point(12, 36);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(97, 13);
            this.lblCal.TabIndex = 4;
            this.lblCal.Text = "Calories Consumed";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 70);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Health
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 108);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCalCon);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label1);
            this.Name = "Health";
            this.Text = "Health";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalCon;
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Button btnSubmit;
    }
}