
namespace WindowsFormsApp1
{
    partial class SearchForm
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
            this.EnterUserNamelabel = new System.Windows.Forms.Label();
            this.SearchCustomerButton = new System.Windows.Forms.Button();
            this.EnterUserNameInputBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterUserNamelabel
            // 
            this.EnterUserNamelabel.AutoSize = true;
            this.EnterUserNamelabel.Location = new System.Drawing.Point(65, 35);
            this.EnterUserNamelabel.Name = "EnterUserNamelabel";
            this.EnterUserNamelabel.Size = new System.Drawing.Size(132, 20);
            this.EnterUserNamelabel.TabIndex = 0;
            this.EnterUserNamelabel.Text = "Enter User Name";
            // 
            // SearchCustomerButton
            // 
            this.SearchCustomerButton.Location = new System.Drawing.Point(255, 35);
            this.SearchCustomerButton.Name = "SearchCustomerButton";
            this.SearchCustomerButton.Size = new System.Drawing.Size(138, 55);
            this.SearchCustomerButton.TabIndex = 1;
            this.SearchCustomerButton.Text = "Search Customer";
            this.SearchCustomerButton.UseVisualStyleBackColor = true;
            // 
            // EnterUserNameInputBox
            // 
            this.EnterUserNameInputBox.Location = new System.Drawing.Point(69, 86);
            this.EnterUserNameInputBox.Name = "EnterUserNameInputBox";
            this.EnterUserNameInputBox.Size = new System.Drawing.Size(128, 26);
            this.EnterUserNameInputBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(331, 320);
            this.dataGridView1.TabIndex = 3;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 464);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EnterUserNameInputBox);
            this.Controls.Add(this.SearchCustomerButton);
            this.Controls.Add(this.EnterUserNamelabel);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterUserNamelabel;
        private System.Windows.Forms.Button SearchCustomerButton;
        private System.Windows.Forms.TextBox EnterUserNameInputBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}