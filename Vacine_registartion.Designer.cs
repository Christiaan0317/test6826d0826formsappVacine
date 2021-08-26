
namespace test6826d0826formsappVacine
{
    partial class Vacine_registartion
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
            this.TxtIdNum = new System.Windows.Forms.TextBox();
            this.LblIdNum = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblProvince = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtProvince = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.CBGender = new System.Windows.Forms.ComboBox();
            this.BtnSubmitExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtIdNum
            // 
            this.TxtIdNum.Location = new System.Drawing.Point(130, 31);
            this.TxtIdNum.Name = "TxtIdNum";
            this.TxtIdNum.Size = new System.Drawing.Size(125, 23);
            this.TxtIdNum.TabIndex = 0;
            // 
            // LblIdNum
            // 
            this.LblIdNum.AutoSize = true;
            this.LblIdNum.Location = new System.Drawing.Point(31, 34);
            this.LblIdNum.Name = "LblIdNum";
            this.LblIdNum.Size = new System.Drawing.Size(63, 15);
            this.LblIdNum.TabIndex = 1;
            this.LblIdNum.Text = "ID number";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(31, 63);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(39, 15);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(31, 92);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(54, 15);
            this.LblSurname.TabIndex = 3;
            this.LblSurname.Text = "Surname";
            // 
            // LblProvince
            // 
            this.LblProvince.AutoSize = true;
            this.LblProvince.Location = new System.Drawing.Point(33, 121);
            this.LblProvince.Name = "LblProvince";
            this.LblProvince.Size = new System.Drawing.Size(53, 15);
            this.LblProvince.TabIndex = 4;
            this.LblProvince.Text = "Province";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(31, 150);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(45, 15);
            this.LblGender.TabIndex = 5;
            this.LblGender.Text = "Gender";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(130, 60);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(125, 23);
            this.TxtName.TabIndex = 6;
            // 
            // TxtProvince
            // 
            this.TxtProvince.Location = new System.Drawing.Point(130, 118);
            this.TxtProvince.Name = "TxtProvince";
            this.TxtProvince.Size = new System.Drawing.Size(125, 23);
            this.TxtProvince.TabIndex = 9;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(130, 89);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(125, 23);
            this.TxtSurname.TabIndex = 10;
            // 
            // CBGender
            // 
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.CBGender.Location = new System.Drawing.Point(130, 147);
            this.CBGender.Name = "CBGender";
            this.CBGender.Size = new System.Drawing.Size(125, 23);
            this.CBGender.TabIndex = 11;
            // 
            // BtnSubmitExit
            // 
            this.BtnSubmitExit.Location = new System.Drawing.Point(130, 196);
            this.BtnSubmitExit.Name = "BtnSubmitExit";
            this.BtnSubmitExit.Size = new System.Drawing.Size(124, 23);
            this.BtnSubmitExit.TabIndex = 12;
            this.BtnSubmitExit.Text = "Submit and Exit";
            this.BtnSubmitExit.UseVisualStyleBackColor = true;
            this.BtnSubmitExit.Click += new System.EventHandler(this.BtnSubmitExit_Click);
            // 
            // Vacine_registartion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 241);
            this.Controls.Add(this.BtnSubmitExit);
            this.Controls.Add(this.CBGender);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtProvince);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblProvince);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblIdNum);
            this.Controls.Add(this.TxtIdNum);
            this.Name = "Vacine_registartion";
            this.Text = "Vacine_registartion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdNum;
        private System.Windows.Forms.Label LblIdNum;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblProvince;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtProvince;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.ComboBox CBGender;
        private System.Windows.Forms.Button BtnSubmitExit;
    }
}