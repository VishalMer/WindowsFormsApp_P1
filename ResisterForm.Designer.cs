namespace WindowsFormsApp_P1
{
    partial class Form3
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
            this.MaleTXT = new System.Windows.Forms.RadioButton();
            this.FemaleTXT = new System.Windows.Forms.RadioButton();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.passTXT = new System.Windows.Forms.TextBox();
            this.branchTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cityList = new System.Windows.Forms.ListBox();
            this.resisterBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.idTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.ShowDataBtn = new System.Windows.Forms.Button();
            this.DisplayData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MaleTXT
            // 
            this.MaleTXT.AutoSize = true;
            this.MaleTXT.Location = new System.Drawing.Point(212, 263);
            this.MaleTXT.Name = "MaleTXT";
            this.MaleTXT.Size = new System.Drawing.Size(68, 24);
            this.MaleTXT.TabIndex = 4;
            this.MaleTXT.TabStop = true;
            this.MaleTXT.Text = "Male";
            this.MaleTXT.UseVisualStyleBackColor = true;
            this.MaleTXT.CheckedChanged += new System.EventHandler(this.MaleTXT_CheckedChanged);
            // 
            // FemaleTXT
            // 
            this.FemaleTXT.AutoSize = true;
            this.FemaleTXT.Location = new System.Drawing.Point(323, 263);
            this.FemaleTXT.Name = "FemaleTXT";
            this.FemaleTXT.Size = new System.Drawing.Size(87, 24);
            this.FemaleTXT.TabIndex = 5;
            this.FemaleTXT.TabStop = true;
            this.FemaleTXT.Text = "Female";
            this.FemaleTXT.UseVisualStyleBackColor = true;
            this.FemaleTXT.CheckedChanged += new System.EventHandler(this.FemaleTXT_CheckedChanged);
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(212, 110);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(231, 26);
            this.nameTXT.TabIndex = 6;
            // 
            // passTXT
            // 
            this.passTXT.Location = new System.Drawing.Point(212, 159);
            this.passTXT.Name = "passTXT";
            this.passTXT.Size = new System.Drawing.Size(231, 26);
            this.passTXT.TabIndex = 7;
            // 
            // branchTXT
            // 
            this.branchTXT.Location = new System.Drawing.Point(212, 207);
            this.branchTXT.Name = "branchTXT";
            this.branchTXT.Size = new System.Drawing.Size(231, 26);
            this.branchTXT.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "City";
            // 
            // cityList
            // 
            this.cityList.FormattingEnabled = true;
            this.cityList.ItemHeight = 20;
            this.cityList.Items.AddRange(new object[] {
            "Surat",
            "Botad",
            "Amreli"});
            this.cityList.Location = new System.Drawing.Point(212, 315);
            this.cityList.Name = "cityList";
            this.cityList.Size = new System.Drawing.Size(231, 64);
            this.cityList.TabIndex = 10;
            // 
            // resisterBtn
            // 
            this.resisterBtn.Location = new System.Drawing.Point(96, 403);
            this.resisterBtn.Name = "resisterBtn";
            this.resisterBtn.Size = new System.Drawing.Size(157, 45);
            this.resisterBtn.TabIndex = 11;
            this.resisterBtn.Text = "Resister";
            this.resisterBtn.UseVisualStyleBackColor = true;
            this.resisterBtn.Click += new System.EventHandler(this.resisterBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(286, 403);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(157, 45);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTXT
            // 
            this.idTXT.Location = new System.Drawing.Point(212, 58);
            this.idTXT.Name = "idTXT";
            this.idTXT.Size = new System.Drawing.Size(231, 26);
            this.idTXT.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(286, 474);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(157, 45);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ShowDataBtn
            // 
            this.ShowDataBtn.Location = new System.Drawing.Point(96, 474);
            this.ShowDataBtn.Name = "ShowDataBtn";
            this.ShowDataBtn.Size = new System.Drawing.Size(157, 45);
            this.ShowDataBtn.TabIndex = 16;
            this.ShowDataBtn.Text = "Show Data";
            this.ShowDataBtn.UseVisualStyleBackColor = true;
            this.ShowDataBtn.Click += new System.EventHandler(this.ShowDataBtn_Click);
            // 
            // DisplayData
            // 
            this.DisplayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayData.Location = new System.Drawing.Point(472, 58);
            this.DisplayData.Name = "DisplayData";
            this.DisplayData.RowHeadersWidth = 62;
            this.DisplayData.RowTemplate.Height = 28;
            this.DisplayData.Size = new System.Drawing.Size(964, 461);
            this.DisplayData.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 554);
            this.Controls.Add(this.DisplayData);
            this.Controls.Add(this.ShowDataBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.idTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.resisterBtn);
            this.Controls.Add(this.cityList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.branchTXT);
            this.Controls.Add(this.passTXT);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.FemaleTXT);
            this.Controls.Add(this.MaleTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton MaleTXT;
        private System.Windows.Forms.RadioButton FemaleTXT;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.TextBox passTXT;
        private System.Windows.Forms.TextBox branchTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox cityList;
        private System.Windows.Forms.Button resisterBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox idTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button ShowDataBtn;
        private System.Windows.Forms.DataGridView DisplayData;
    }
}