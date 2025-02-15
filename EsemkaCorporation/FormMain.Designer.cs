namespace EsemkaCorporation
{
    partial class FormMain
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMutation = new System.Windows.Forms.Button();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME";
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(43, 96);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(392, 38);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMutation
            // 
            this.btnMutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMutation.Location = new System.Drawing.Point(43, 151);
            this.btnMutation.Name = "btnMutation";
            this.btnMutation.Size = new System.Drawing.Size(392, 38);
            this.btnMutation.TabIndex = 7;
            this.btnMutation.Text = "Apply for Job Mutation ";
            this.btnMutation.UseVisualStyleBackColor = true;
            this.btnMutation.Click += new System.EventHandler(this.btnMutation_Click);
            // 
            // btnPromotion
            // 
            this.btnPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromotion.Location = new System.Drawing.Point(41, 206);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Size = new System.Drawing.Size(392, 38);
            this.btnPromotion.TabIndex = 8;
            this.btnPromotion.Text = "Apply for Job Promotion";
            this.btnPromotion.UseVisualStyleBackColor = true;
            this.btnPromotion.Click += new System.EventHandler(this.btnPromotion_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(43, 342);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(392, 38);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(474, 417);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPromotion);
            this.Controls.Add(this.btnMutation);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMutation;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnLogout;
    }
}