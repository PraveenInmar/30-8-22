
namespace WindowsFormsApp1
{
    partial class FrmUser
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.StatusGroupBox = new System.Windows.Forms.GroupBox();
            this.SingleRadioButton = new System.Windows.Forms.RadioButton();
            this.MarriedRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstNameInputBox = new System.Windows.Forms.TextBox();
            this.AgeInputBox = new System.Windows.Forms.TextBox();
            this.LastNameInputBox = new System.Windows.Forms.TextBox();
            this.Verifybutton = new System.Windows.Forms.Button();
            this.GenderGroupBox.SuspendLayout();
            this.StatusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(54, 47);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(54, 87);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(54, 128);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(38, 20);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Age";
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.FemaleRadioButton);
            this.GenderGroupBox.Controls.Add(this.MaleRadioButton);
            this.GenderGroupBox.Location = new System.Drawing.Point(58, 166);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(340, 66);
            this.GenderGroupBox.TabIndex = 3;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(178, 25);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(87, 24);
            this.FemaleRadioButton.TabIndex = 1;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(85, 25);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(68, 24);
            this.MaleRadioButton.TabIndex = 0;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // StatusGroupBox
            // 
            this.StatusGroupBox.Controls.Add(this.SingleRadioButton);
            this.StatusGroupBox.Controls.Add(this.MarriedRadioButton);
            this.StatusGroupBox.Location = new System.Drawing.Point(58, 238);
            this.StatusGroupBox.Name = "StatusGroupBox";
            this.StatusGroupBox.Size = new System.Drawing.Size(315, 78);
            this.StatusGroupBox.TabIndex = 4;
            this.StatusGroupBox.TabStop = false;
            this.StatusGroupBox.Text = "Status";
            // 
            // SingleRadioButton
            // 
            this.SingleRadioButton.AutoSize = true;
            this.SingleRadioButton.Location = new System.Drawing.Point(178, 30);
            this.SingleRadioButton.Name = "SingleRadioButton";
            this.SingleRadioButton.Size = new System.Drawing.Size(78, 24);
            this.SingleRadioButton.TabIndex = 2;
            this.SingleRadioButton.TabStop = true;
            this.SingleRadioButton.Text = "Single";
            this.SingleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MarriedRadioButton
            // 
            this.MarriedRadioButton.AutoSize = true;
            this.MarriedRadioButton.Location = new System.Drawing.Point(85, 30);
            this.MarriedRadioButton.Name = "MarriedRadioButton";
            this.MarriedRadioButton.Size = new System.Drawing.Size(87, 24);
            this.MarriedRadioButton.TabIndex = 1;
            this.MarriedRadioButton.TabStop = true;
            this.MarriedRadioButton.Text = "Married";
            this.MarriedRadioButton.UseVisualStyleBackColor = true;
            // 
            // FirstNameInputBox
            // 
            this.FirstNameInputBox.Location = new System.Drawing.Point(233, 45);
            this.FirstNameInputBox.Name = "FirstNameInputBox";
            this.FirstNameInputBox.Size = new System.Drawing.Size(140, 26);
            this.FirstNameInputBox.TabIndex = 5;
            // 
            // AgeInputBox
            // 
            this.AgeInputBox.Location = new System.Drawing.Point(233, 134);
            this.AgeInputBox.Name = "AgeInputBox";
            this.AgeInputBox.Size = new System.Drawing.Size(140, 26);
            this.AgeInputBox.TabIndex = 6;
            // 
            // LastNameInputBox
            // 
            this.LastNameInputBox.Location = new System.Drawing.Point(233, 84);
            this.LastNameInputBox.Name = "LastNameInputBox";
            this.LastNameInputBox.Size = new System.Drawing.Size(140, 26);
            this.LastNameInputBox.TabIndex = 7;
            // 
            // Verifybutton
            // 
            this.Verifybutton.Location = new System.Drawing.Point(113, 352);
            this.Verifybutton.Name = "Verifybutton";
            this.Verifybutton.Size = new System.Drawing.Size(260, 46);
            this.Verifybutton.TabIndex = 8;
            this.Verifybutton.Text = "Verify";
            this.Verifybutton.UseVisualStyleBackColor = true;
            this.Verifybutton.Click += new System.EventHandler(this.Verifybutton_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.Verifybutton);
            this.Controls.Add(this.LastNameInputBox);
            this.Controls.Add(this.AgeInputBox);
            this.Controls.Add(this.FirstNameInputBox);
            this.Controls.Add(this.StatusGroupBox);
            this.Controls.Add(this.GenderGroupBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "FrmUser";
            this.Text = "User Form";
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.StatusGroupBox.ResumeLayout(false);
            this.StatusGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.GroupBox StatusGroupBox;
        private System.Windows.Forms.RadioButton SingleRadioButton;
        private System.Windows.Forms.RadioButton MarriedRadioButton;
        private System.Windows.Forms.TextBox FirstNameInputBox;
        private System.Windows.Forms.TextBox AgeInputBox;
        private System.Windows.Forms.TextBox LastNameInputBox;
        private System.Windows.Forms.Button Verifybutton;
    }
}

