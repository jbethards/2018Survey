namespace Survey
{
    partial class Programming
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.GH = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjID = new System.Windows.Forms.TextBox();
            this.lblProj = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 120);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // GH
            // 
            this.GH.AutoSize = true;
            this.GH.Location = new System.Drawing.Point(12, 13);
            this.GH.Name = "GH";
            this.GH.Size = new System.Drawing.Size(94, 17);
            this.GH.TabIndex = 1;
            this.GH.Text = "Github Upload";
            this.GH.UseVisualStyleBackColor = true;
            this.GH.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project List";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(76, 30);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(30, 20);
            this.txtTime.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time Spent:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProjID
            // 
            this.txtProjID.Location = new System.Drawing.Point(76, 54);
            this.txtProjID.Name = "txtProjID";
            this.txtProjID.Size = new System.Drawing.Size(30, 20);
            this.txtProjID.TabIndex = 7;
            // 
            // lblProj
            // 
            this.lblProj.AutoSize = true;
            this.lblProj.Location = new System.Drawing.Point(12, 57);
            this.lblProj.Name = "lblProj";
            this.lblProj.Size = new System.Drawing.Size(51, 13);
            this.lblProj.TabIndex = 6;
            this.lblProj.Text = "ProjectID";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(12, 217);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(118, 23);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish Project";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // Programming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtProjID);
            this.Controls.Add(this.lblProj);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GH);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Programming";
            this.Text = "Programming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox GH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjID;
        private System.Windows.Forms.Label lblProj;
        private System.Windows.Forms.Button btnFinish;
    }
}