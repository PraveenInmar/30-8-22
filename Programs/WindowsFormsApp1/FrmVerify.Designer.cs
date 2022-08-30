
namespace WindowsFormsApp1
{
    partial class FrmVerify
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VerifyStatus = new System.Windows.Forms.Label();
            this.VerifyGender = new System.Windows.Forms.Label();
            this.VerifyAge = new System.Windows.Forms.Label();
            this.VerifyLastName = new System.Windows.Forms.Label();
            this.VerifyFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // VerifyStatus
            // 
            this.VerifyStatus.AutoSize = true;
            this.VerifyStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VerifyStatus.Location = new System.Drawing.Point(164, 224);
            this.VerifyStatus.Name = "VerifyStatus";
            this.VerifyStatus.Size = new System.Drawing.Size(0, 20);
            this.VerifyStatus.TabIndex = 5;
            // 
            // VerifyGender
            // 
            this.VerifyGender.AutoSize = true;
            this.VerifyGender.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VerifyGender.Location = new System.Drawing.Point(164, 168);
            this.VerifyGender.Name = "VerifyGender";
            this.VerifyGender.Size = new System.Drawing.Size(0, 20);
            this.VerifyGender.TabIndex = 6;
            // 
            // VerifyAge
            // 
            this.VerifyAge.AutoSize = true;
            this.VerifyAge.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VerifyAge.Location = new System.Drawing.Point(164, 117);
            this.VerifyAge.Name = "VerifyAge";
            this.VerifyAge.Size = new System.Drawing.Size(0, 20);
            this.VerifyAge.TabIndex = 7;
            // 
            // VerifyLastName
            // 
            this.VerifyLastName.AutoSize = true;
            this.VerifyLastName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VerifyLastName.Location = new System.Drawing.Point(164, 71);
            this.VerifyLastName.Name = "VerifyLastName";
            this.VerifyLastName.Size = new System.Drawing.Size(0, 20);
            this.VerifyLastName.TabIndex = 8;
            // 
            // VerifyFirstName
            // 
            this.VerifyFirstName.AutoSize = true;
            this.VerifyFirstName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.VerifyFirstName.Location = new System.Drawing.Point(164, 21);
            this.VerifyFirstName.Name = "VerifyFirstName";
            this.VerifyFirstName.Size = new System.Drawing.Size(0, 20);
            this.VerifyFirstName.TabIndex = 9;
            // 
            // FrmVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.VerifyFirstName);
            this.Controls.Add(this.VerifyLastName);
            this.Controls.Add(this.VerifyAge);
            this.Controls.Add(this.VerifyGender);
            this.Controls.Add(this.VerifyStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVerify";
            this.Text = "Verify Form";
            this.Load += new System.EventHandler(this.FrmVerify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label VerifyStatus;
        private System.Windows.Forms.Label VerifyGender;
        private System.Windows.Forms.Label VerifyAge;
        private System.Windows.Forms.Label VerifyLastName;
        private System.Windows.Forms.Label VerifyFirstName;
    }
}