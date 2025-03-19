namespace WindowsFormsApp_P1
{
    partial class Form5
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
            this.idTXT = new System.Windows.Forms.TextBox();
            this.stateTXT = new System.Windows.Forms.TextBox();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cityTXT = new System.Windows.Forms.TextBox();
            this.maleTXT = new System.Windows.Forms.RadioButton();
            this.femaleTXT = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.salaryTXT = new System.Windows.Forms.TextBox();
            this.insertBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.ShowBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.displayData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // idTXT
            // 
            this.idTXT.Location = new System.Drawing.Point(165, 77);
            this.idTXT.Name = "idTXT";
            this.idTXT.Size = new System.Drawing.Size(186, 26);
            this.idTXT.TabIndex = 2;
            // 
            // stateTXT
            // 
            this.stateTXT.Location = new System.Drawing.Point(165, 261);
            this.stateTXT.Name = "stateTXT";
            this.stateTXT.Size = new System.Drawing.Size(186, 26);
            this.stateTXT.TabIndex = 3;
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(165, 219);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(186, 26);
            this.emailTXT.TabIndex = 4;
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(165, 124);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(186, 26);
            this.nameTXT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "City";
            // 
            // cityTXT
            // 
            this.cityTXT.Location = new System.Drawing.Point(165, 310);
            this.cityTXT.Name = "cityTXT";
            this.cityTXT.Size = new System.Drawing.Size(186, 26);
            this.cityTXT.TabIndex = 10;
            // 
            // maleTXT
            // 
            this.maleTXT.AutoSize = true;
            this.maleTXT.Location = new System.Drawing.Point(165, 174);
            this.maleTXT.Name = "maleTXT";
            this.maleTXT.Size = new System.Drawing.Size(68, 24);
            this.maleTXT.TabIndex = 13;
            this.maleTXT.TabStop = true;
            this.maleTXT.Text = "Male";
            this.maleTXT.UseVisualStyleBackColor = true;
            this.maleTXT.CheckedChanged += new System.EventHandler(this.maleTXT_CheckedChanged);
            // 
            // femaleTXT
            // 
            this.femaleTXT.AutoSize = true;
            this.femaleTXT.Location = new System.Drawing.Point(264, 174);
            this.femaleTXT.Name = "femaleTXT";
            this.femaleTXT.Size = new System.Drawing.Size(87, 24);
            this.femaleTXT.TabIndex = 14;
            this.femaleTXT.TabStop = true;
            this.femaleTXT.Text = "Female";
            this.femaleTXT.UseVisualStyleBackColor = true;
            this.femaleTXT.CheckedChanged += new System.EventHandler(this.femaleTXT_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salary";
            // 
            // salaryTXT
            // 
            this.salaryTXT.Location = new System.Drawing.Point(165, 359);
            this.salaryTXT.Name = "salaryTXT";
            this.salaryTXT.Size = new System.Drawing.Size(186, 26);
            this.salaryTXT.TabIndex = 15;
            // 
            // insertBTN
            // 
            this.insertBTN.Location = new System.Drawing.Point(84, 416);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(141, 38);
            this.insertBTN.TabIndex = 17;
            this.insertBTN.Text = "INSERT";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(84, 481);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(120, 38);
            this.deleteBTN.TabIndex = 18;
            this.deleteBTN.Text = "DELETE";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // ShowBTN
            // 
            this.ShowBTN.Location = new System.Drawing.Point(210, 481);
            this.ShowBTN.Name = "ShowBTN";
            this.ShowBTN.Size = new System.Drawing.Size(141, 38);
            this.ShowBTN.TabIndex = 20;
            this.ShowBTN.Text = "SHOW DATA";
            this.ShowBTN.UseVisualStyleBackColor = true;
            this.ShowBTN.Click += new System.EventHandler(this.ShowBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(231, 416);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(120, 38);
            this.updateBTN.TabIndex = 19;
            this.updateBTN.Text = "UPDATE";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // displayData
            // 
            this.displayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayData.Location = new System.Drawing.Point(385, 77);
            this.displayData.Name = "displayData";
            this.displayData.RowHeadersWidth = 62;
            this.displayData.RowTemplate.Height = 28;
            this.displayData.Size = new System.Drawing.Size(762, 442);
            this.displayData.TabIndex = 21;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 600);
            this.Controls.Add(this.displayData);
            this.Controls.Add(this.ShowBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salaryTXT);
            this.Controls.Add(this.femaleTXT);
            this.Controls.Add(this.maleTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.emailTXT);
            this.Controls.Add(this.stateTXT);
            this.Controls.Add(this.idTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.displayData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTXT;
        private System.Windows.Forms.TextBox stateTXT;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cityTXT;
        private System.Windows.Forms.RadioButton maleTXT;
        private System.Windows.Forms.RadioButton femaleTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox salaryTXT;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button ShowBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.DataGridView displayData;
    }
}