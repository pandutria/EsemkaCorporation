namespace EsemkaCorporation
{
    partial class FormProfile
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
            this.btnMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHireDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJobLevel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDepartement = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDirectSupervisorName = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDataJobHistory = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdDataSubordinate = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDataWorks = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataJobHistory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdDataSubordinate)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(33, 29);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(99, 38);
            this.btnMain.TabIndex = 10;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(208, 90);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(286, 34);
            this.tbName.TabIndex = 13;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Location = new System.Drawing.Point(208, 141);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(286, 34);
            this.tbEmail.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhoneNumber.Location = new System.Drawing.Point(208, 191);
            this.tbPhoneNumber.Multiline = true;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(286, 34);
            this.tbPhoneNumber.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone Number";
            // 
            // tbHireDate
            // 
            this.tbHireDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHireDate.Location = new System.Drawing.Point(208, 242);
            this.tbHireDate.Multiline = true;
            this.tbHireDate.Name = "tbHireDate";
            this.tbHireDate.Size = new System.Drawing.Size(286, 34);
            this.tbHireDate.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hire Date";
            // 
            // tbPosition
            // 
            this.tbPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPosition.Location = new System.Drawing.Point(208, 293);
            this.tbPosition.Multiline = true;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(286, 34);
            this.tbPosition.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Position";
            // 
            // tbJobLevel
            // 
            this.tbJobLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbJobLevel.Location = new System.Drawing.Point(208, 344);
            this.tbJobLevel.Multiline = true;
            this.tbJobLevel.Name = "tbJobLevel";
            this.tbJobLevel.Size = new System.Drawing.Size(286, 34);
            this.tbJobLevel.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Job Level";
            // 
            // tbDepartement
            // 
            this.tbDepartement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDepartement.Location = new System.Drawing.Point(208, 394);
            this.tbDepartement.Multiline = true;
            this.tbDepartement.Name = "tbDepartement";
            this.tbDepartement.Size = new System.Drawing.Size(286, 34);
            this.tbDepartement.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Departement";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Direct Supervisor";
            // 
            // lblDirectSupervisorName
            // 
            this.lblDirectSupervisorName.AutoSize = true;
            this.lblDirectSupervisorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectSupervisorName.Location = new System.Drawing.Point(230, 447);
            this.lblDirectSupervisorName.Name = "lblDirectSupervisorName";
            this.lblDirectSupervisorName.Size = new System.Drawing.Size(218, 25);
            this.lblDirectSupervisorName.TabIndex = 27;
            this.lblDirectSupervisorName.TabStop = true;
            this.lblDirectSupervisorName.Text = "Direct Supervisor Name";
            this.lblDirectSupervisorName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDirectSupervisorName_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDataJobHistory);
            this.groupBox1.Location = new System.Drawing.Point(33, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 169);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job History";
            // 
            // dgvDataJobHistory
            // 
            this.dgvDataJobHistory.AllowUserToAddRows = false;
            this.dgvDataJobHistory.AllowUserToDeleteRows = false;
            this.dgvDataJobHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataJobHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataJobHistory.Location = new System.Drawing.Point(18, 24);
            this.dgvDataJobHistory.Name = "dgvDataJobHistory";
            this.dgvDataJobHistory.ReadOnly = true;
            this.dgvDataJobHistory.RowHeadersWidth = 51;
            this.dgvDataJobHistory.RowTemplate.Height = 24;
            this.dgvDataJobHistory.Size = new System.Drawing.Size(421, 108);
            this.dgvDataJobHistory.TabIndex = 29;
            this.dgvDataJobHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataJobHistory_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvdDataSubordinate);
            this.groupBox2.Location = new System.Drawing.Point(540, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 181);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subordinate";
            // 
            // dgvdDataSubordinate
            // 
            this.dgvdDataSubordinate.AllowUserToAddRows = false;
            this.dgvdDataSubordinate.AllowUserToDeleteRows = false;
            this.dgvdDataSubordinate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdDataSubordinate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdDataSubordinate.Location = new System.Drawing.Point(18, 24);
            this.dgvdDataSubordinate.Name = "dgvdDataSubordinate";
            this.dgvdDataSubordinate.ReadOnly = true;
            this.dgvdDataSubordinate.RowHeadersWidth = 51;
            this.dgvdDataSubordinate.RowTemplate.Height = 24;
            this.dgvdDataSubordinate.Size = new System.Drawing.Size(421, 108);
            this.dgvdDataSubordinate.TabIndex = 29;
            this.dgvdDataSubordinate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdDataSubordinate_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDataWorks);
            this.groupBox3.Location = new System.Drawing.Point(531, 493);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 169);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Works With";
            // 
            // dgvDataWorks
            // 
            this.dgvDataWorks.AllowUserToAddRows = false;
            this.dgvDataWorks.AllowUserToDeleteRows = false;
            this.dgvDataWorks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataWorks.Location = new System.Drawing.Point(18, 24);
            this.dgvDataWorks.Name = "dgvDataWorks";
            this.dgvDataWorks.ReadOnly = true;
            this.dgvDataWorks.RowHeadersWidth = 51;
            this.dgvDataWorks.RowTemplate.Height = 24;
            this.dgvDataWorks.Size = new System.Drawing.Size(421, 108);
            this.dgvDataWorks.TabIndex = 29;
            this.dgvDataWorks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataWorks_CellClick);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1023, 701);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDirectSupervisorName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDepartement);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbJobLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHireDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMain);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataJobHistory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdDataSubordinate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataWorks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHireDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJobLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDepartement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lblDirectSupervisorName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDataJobHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdDataSubordinate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDataWorks;
    }
}