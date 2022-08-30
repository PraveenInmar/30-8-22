
namespace BusPass
{
    partial class BusPassForm
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
            this.Registration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BPFN = new System.Windows.Forms.TextBox();
            this.BPADD = new System.Windows.Forms.TextBox();
            this.BPM = new System.Windows.Forms.TextBox();
            this.BPA = new System.Windows.Forms.TextBox();
            this.BPLN = new System.Windows.Forms.TextBox();
            this.BPG = new System.Windows.Forms.GroupBox();
            this.FemaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleradioButton1 = new System.Windows.Forms.RadioButton();
            this.BPS = new System.Windows.Forms.GroupBox();
            this.UnMarriedradioButton = new System.Windows.Forms.RadioButton();
            this.MarriedradioButton = new System.Windows.Forms.RadioButton();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.BPG.SuspendLayout();
            this.BPS.SuspendLayout();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.Location = new System.Drawing.Point(230, 19);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(352, 37);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Bus Pass Registration";
            this.Registration.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Address :";
            // 
            // BPFN
            // 
            this.BPFN.Location = new System.Drawing.Point(254, 80);
            this.BPFN.Name = "BPFN";
            this.BPFN.Size = new System.Drawing.Size(196, 26);
            this.BPFN.TabIndex = 6;
            // 
            // BPADD
            // 
            this.BPADD.Location = new System.Drawing.Point(254, 285);
            this.BPADD.Name = "BPADD";
            this.BPADD.Size = new System.Drawing.Size(196, 26);
            this.BPADD.TabIndex = 7;
            this.BPADD.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BPM
            // 
            this.BPM.Location = new System.Drawing.Point(254, 224);
            this.BPM.Name = "BPM";
            this.BPM.Size = new System.Drawing.Size(196, 26);
            this.BPM.TabIndex = 8;
            // 
            // BPA
            // 
            this.BPA.Location = new System.Drawing.Point(254, 178);
            this.BPA.Name = "BPA";
            this.BPA.Size = new System.Drawing.Size(196, 26);
            this.BPA.TabIndex = 9;
            // 
            // BPLN
            // 
            this.BPLN.Location = new System.Drawing.Point(254, 132);
            this.BPLN.Name = "BPLN";
            this.BPLN.Size = new System.Drawing.Size(196, 26);
            this.BPLN.TabIndex = 10;
            // 
            // BPG
            // 
            this.BPG.Controls.Add(this.FemaleradioButton);
            this.BPG.Controls.Add(this.MaleradioButton1);
            this.BPG.Location = new System.Drawing.Point(508, 80);
            this.BPG.Name = "BPG";
            this.BPG.Size = new System.Drawing.Size(280, 100);
            this.BPG.TabIndex = 11;
            this.BPG.TabStop = false;
            this.BPG.Text = "Gender";
            // 
            // FemaleradioButton
            // 
            this.FemaleradioButton.AutoSize = true;
            this.FemaleradioButton.Location = new System.Drawing.Point(96, 70);
            this.FemaleradioButton.Name = "FemaleradioButton";
            this.FemaleradioButton.Size = new System.Drawing.Size(87, 24);
            this.FemaleradioButton.TabIndex = 1;
            this.FemaleradioButton.Text = "Female";
            this.FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton1
            // 
            this.MaleradioButton1.AutoSize = true;
            this.MaleradioButton1.Location = new System.Drawing.Point(96, 25);
            this.MaleradioButton1.Name = "MaleradioButton1";
            this.MaleradioButton1.Size = new System.Drawing.Size(68, 24);
            this.MaleradioButton1.TabIndex = 0;
            this.MaleradioButton1.Text = "Male";
            this.MaleradioButton1.UseVisualStyleBackColor = true;
            this.MaleradioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BPS
            // 
            this.BPS.Controls.Add(this.UnMarriedradioButton);
            this.BPS.Controls.Add(this.MarriedradioButton);
            this.BPS.Location = new System.Drawing.Point(508, 208);
            this.BPS.Name = "BPS";
            this.BPS.Size = new System.Drawing.Size(280, 100);
            this.BPS.TabIndex = 12;
            this.BPS.TabStop = false;
            this.BPS.Text = "Status";
            // 
            // UnMarriedradioButton
            // 
            this.UnMarriedradioButton.AutoSize = true;
            this.UnMarriedradioButton.Location = new System.Drawing.Point(96, 70);
            this.UnMarriedradioButton.Name = "UnMarriedradioButton";
            this.UnMarriedradioButton.Size = new System.Drawing.Size(108, 24);
            this.UnMarriedradioButton.TabIndex = 1;
            this.UnMarriedradioButton.Text = "UnMarried";
            this.UnMarriedradioButton.UseVisualStyleBackColor = true;
            // 
            // MarriedradioButton
            // 
            this.MarriedradioButton.AutoSize = true;
            this.MarriedradioButton.Location = new System.Drawing.Point(97, 25);
            this.MarriedradioButton.Name = "MarriedradioButton";
            this.MarriedradioButton.Size = new System.Drawing.Size(87, 24);
            this.MarriedradioButton.TabIndex = 0;
            this.MarriedradioButton.Text = "Married";
            this.MarriedradioButton.UseVisualStyleBackColor = true;
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Loginbutton.Location = new System.Drawing.Point(268, 357);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(182, 57);
            this.Loginbutton.TabIndex = 13;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // BusPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.BPS);
            this.Controls.Add(this.BPG);
            this.Controls.Add(this.BPLN);
            this.Controls.Add(this.BPA);
            this.Controls.Add(this.BPM);
            this.Controls.Add(this.BPADD);
            this.Controls.Add(this.BPFN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registration);
            this.Name = "BusPassForm";
            this.Text = "Buspass Form";
            this.Load += new System.EventHandler(this.BusPassForm_Load);
            this.BPG.ResumeLayout(false);
            this.BPG.PerformLayout();
            this.BPS.ResumeLayout(false);
            this.BPS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BPFN;
        private System.Windows.Forms.TextBox BPADD;
        private System.Windows.Forms.TextBox BPM;
        private System.Windows.Forms.TextBox BPA;
        private System.Windows.Forms.TextBox BPLN;
        private System.Windows.Forms.GroupBox BPG;
        private System.Windows.Forms.RadioButton MaleradioButton1;
        private System.Windows.Forms.RadioButton FemaleradioButton;
        private System.Windows.Forms.GroupBox BPS;
        private System.Windows.Forms.RadioButton UnMarriedradioButton;
        private System.Windows.Forms.RadioButton MarriedradioButton;
        private System.Windows.Forms.Button Loginbutton;
    }
}

