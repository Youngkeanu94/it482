namespace IT482_Unit2
{
    partial class Form1
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
            this.txtMessageText = new System.Windows.Forms.RichTextBox();
            this.btnView_Click = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate_Click = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.btnCount_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessageText
            // 
            this.txtMessageText.Location = new System.Drawing.Point(541, 12);
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.Size = new System.Drawing.Size(447, 247);
            this.txtMessageText.TabIndex = 0;
            this.txtMessageText.Text = "";
            // 
            // btnView_Click
            // 
            this.btnView_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView_Click.Location = new System.Drawing.Point(376, 544);
            this.btnView_Click.Name = "btnView_Click";
            this.btnView_Click.Size = new System.Drawing.Size(191, 51);
            this.btnView_Click.TabIndex = 1;
            this.btnView_Click.Text = "View Database";
            this.btnView_Click.UseVisualStyleBackColor = true;
            this.btnView_Click.Click += new System.EventHandler(this.btnView_Click_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 186);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnUpdate_Click
            // 
            this.btnUpdate_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Click.Location = new System.Drawing.Point(165, 107);
            this.btnUpdate_Click.Name = "btnUpdate_Click";
            this.btnUpdate_Click.Size = new System.Drawing.Size(181, 45);
            this.btnUpdate_Click.TabIndex = 3;
            this.btnUpdate_Click.Text = "Update Database";
            this.btnUpdate_Click.UseVisualStyleBackColor = true;
            this.btnUpdate_Click.Click += new System.EventHandler(this.btnUpdate_Click_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(165, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(181, 29);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(165, 55);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(181, 29);
            this.txtCompanyName.TabIndex = 5;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(122, 12);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 24);
            this.IdLabel.TabIndex = 6;
            this.IdLabel.Text = "ID";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(2, 55);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(147, 24);
            this.CompanyNameLabel.TabIndex = 7;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // btnCount_Click
            // 
            this.btnCount_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount_Click.Location = new System.Drawing.Point(698, 287);
            this.btnCount_Click.Name = "btnCount_Click";
            this.btnCount_Click.Size = new System.Drawing.Size(159, 41);
            this.btnCount_Click.TabIndex = 8;
            this.btnCount_Click.Text = "Count Records";
            this.btnCount_Click.UseVisualStyleBackColor = true;
            this.btnCount_Click.Click += new System.EventHandler(this.btnCount_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 641);
            this.Controls.Add(this.btnCount_Click);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUpdate_Click);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView_Click);
            this.Controls.Add(this.txtMessageText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMessageText;
        private System.Windows.Forms.Button btnView_Click;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate_Click;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Button btnCount_Click;
    }
}

