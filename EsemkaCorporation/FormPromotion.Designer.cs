namespace EsemkaCorporation
{
    partial class FormPromotion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApply = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCurrentJobLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCurrentPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCurrentDepartement = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Location = new System.Drawing.Point(46, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 169);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avalilable Job Mutation";
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.btnApply,
            this.Column3});
            this.dgvData.Location = new System.Drawing.Point(18, 24);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(449, 108);
            this.dgvData.TabIndex = 29;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Departement";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Position";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // btnApply
            // 
            this.btnApply.HeaderText = "Action";
            this.btnApply.MinimumWidth = 6;
            this.btnApply.Name = "btnApply";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // tbCurrentJobLevel
            // 
            this.tbCurrentJobLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentJobLevel.Location = new System.Drawing.Point(250, 250);
            this.tbCurrentJobLevel.Multiline = true;
            this.tbCurrentJobLevel.Name = "tbCurrentJobLevel";
            this.tbCurrentJobLevel.Size = new System.Drawing.Size(286, 34);
            this.tbCurrentJobLevel.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Current Job Level";
            // 
            // tbCurrentPosition
            // 
            this.tbCurrentPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentPosition.Location = new System.Drawing.Point(250, 199);
            this.tbCurrentPosition.Multiline = true;
            this.tbCurrentPosition.Name = "tbCurrentPosition";
            this.tbCurrentPosition.Size = new System.Drawing.Size(286, 34);
            this.tbCurrentPosition.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Current Position";
            // 
            // tbCurrentDepartement
            // 
            this.tbCurrentDepartement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentDepartement.Location = new System.Drawing.Point(250, 149);
            this.tbCurrentDepartement.Multiline = true;
            this.tbCurrentDepartement.Name = "tbCurrentDepartement";
            this.tbCurrentDepartement.Size = new System.Drawing.Size(286, 34);
            this.tbCurrentDepartement.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Current Departement";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(250, 98);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(286, 34);
            this.tbName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Promotion";
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(35, 21);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(99, 38);
            this.btnMain.TabIndex = 30;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // FormPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(600, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbCurrentJobLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCurrentPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCurrentDepartement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMain);
            this.Name = "FormPromotion";
            this.Text = "FormPromotion";
            this.Load += new System.EventHandler(this.FormPromotion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn btnApply;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox tbCurrentJobLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCurrentPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCurrentDepartement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMain;
    }
}