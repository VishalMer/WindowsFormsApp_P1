namespace WindowsFormsApp_P1
{
    partial class Form4
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
            this.idTXT = new System.Windows.Forms.TextBox();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.rollTXT = new System.Windows.Forms.TextBox();
            this.branchTXT = new System.Windows.Forms.TextBox();
            this.updateBTN = new System.Windows.Forms.Button();
            this.showBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.insertBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.displayData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayData)).BeginInit();
            this.SuspendLayout();
            // 
            // idTXT
            // 
            this.idTXT.Location = new System.Drawing.Point(136, 52);
            this.idTXT.Name = "idTXT";
            this.idTXT.Size = new System.Drawing.Size(146, 26);
            this.idTXT.TabIndex = 3;
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(137, 84);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(145, 26);
            this.nameTXT.TabIndex = 4;
            // 
            // rollTXT
            // 
            this.rollTXT.Location = new System.Drawing.Point(136, 116);
            this.rollTXT.Name = "rollTXT";
            this.rollTXT.Size = new System.Drawing.Size(146, 26);
            this.rollTXT.TabIndex = 5;
            // 
            // branchTXT
            // 
            this.branchTXT.Location = new System.Drawing.Point(137, 148);
            this.branchTXT.Name = "branchTXT";
            this.branchTXT.Size = new System.Drawing.Size(146, 26);
            this.branchTXT.TabIndex = 6;
            this.branchTXT.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // updateBTN
            // 
            this.updateBTN.Font = new System.Drawing.Font("Mistral", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBTN.Location = new System.Drawing.Point(178, 215);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(104, 37);
            this.updateBTN.TabIndex = 7;
            this.updateBTN.Text = "UPDATE";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // showBTN
            // 
            this.showBTN.Font = new System.Drawing.Font("Mistral", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBTN.Location = new System.Drawing.Point(178, 282);
            this.showBTN.Name = "showBTN";
            this.showBTN.Size = new System.Drawing.Size(104, 37);
            this.showBTN.TabIndex = 8;
            this.showBTN.Text = "Show Data";
            this.showBTN.UseVisualStyleBackColor = true;
            this.showBTN.Click += new System.EventHandler(this.showBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Font = new System.Drawing.Font("Mistral", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.Location = new System.Drawing.Point(43, 282);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(104, 37);
            this.deleteBTN.TabIndex = 9;
            this.deleteBTN.Text = "DELETE";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // insertBTN
            // 
            this.insertBTN.Font = new System.Drawing.Font("Mistral", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBTN.Location = new System.Drawing.Point(43, 215);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(104, 37);
            this.insertBTN.TabIndex = 10;
            this.insertBTN.Text = "INSERT";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "BRANCH : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Roll No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "NAME : ";
            // 
            // displayData
            // 
            this.displayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayData.Location = new System.Drawing.Point(316, 52);
            this.displayData.Name = "displayData";
            this.displayData.RowHeadersWidth = 62;
            this.displayData.RowTemplate.Height = 28;
            this.displayData.Size = new System.Drawing.Size(457, 267);
            this.displayData.TabIndex = 15;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.showBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.branchTXT);
            this.Controls.Add(this.rollTXT);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.idTXT);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTXT;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.TextBox rollTXT;
        private System.Windows.Forms.TextBox branchTXT;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button showBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView displayData;
    }
}