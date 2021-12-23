namespace ProjetAtelierSupport
{
    partial class FrmMain
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
            this.btnUser = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnEmprunts = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnModeles = new System.Windows.Forms.Button();
            this.btnTypeObjet = new System.Windows.Forms.Button();
            this.btnConnexions = new System.Windows.Forms.Button();
            this.btnPersonnes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(12, 12);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(135, 23);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Information Utilisateur";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(153, 17);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Email :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(188, 17);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(13, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "0";
            // 
            // btnEmprunts
            // 
            this.btnEmprunts.Location = new System.Drawing.Point(12, 50);
            this.btnEmprunts.Name = "btnEmprunts";
            this.btnEmprunts.Size = new System.Drawing.Size(299, 23);
            this.btnEmprunts.TabIndex = 6;
            this.btnEmprunts.Text = "Gérer les emprunts";
            this.btnEmprunts.UseVisualStyleBackColor = true;
            this.btnEmprunts.Click += new System.EventHandler(this.btnEmprunts_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(12, 210);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(299, 23);
            this.btnGrade.TabIndex = 7;
            this.btnGrade.Text = "Voir les grades";
            this.btnGrade.UseVisualStyleBackColor = true;
            // 
            // btnModeles
            // 
            this.btnModeles.Location = new System.Drawing.Point(12, 79);
            this.btnModeles.Name = "btnModeles";
            this.btnModeles.Size = new System.Drawing.Size(299, 23);
            this.btnModeles.TabIndex = 8;
            this.btnModeles.Text = "Gérer les modeles";
            this.btnModeles.UseVisualStyleBackColor = true;
            // 
            // btnTypeObjet
            // 
            this.btnTypeObjet.Location = new System.Drawing.Point(12, 108);
            this.btnTypeObjet.Name = "btnTypeObjet";
            this.btnTypeObjet.Size = new System.Drawing.Size(299, 23);
            this.btnTypeObjet.TabIndex = 9;
            this.btnTypeObjet.Text = "Gérer les types d\'objets";
            this.btnTypeObjet.UseVisualStyleBackColor = true;
            // 
            // btnConnexions
            // 
            this.btnConnexions.Location = new System.Drawing.Point(12, 181);
            this.btnConnexions.Name = "btnConnexions";
            this.btnConnexions.Size = new System.Drawing.Size(299, 23);
            this.btnConnexions.TabIndex = 10;
            this.btnConnexions.Text = "Voir les connexions";
            this.btnConnexions.UseVisualStyleBackColor = true;
            // 
            // btnPersonnes
            // 
            this.btnPersonnes.Location = new System.Drawing.Point(12, 152);
            this.btnPersonnes.Name = "btnPersonnes";
            this.btnPersonnes.Size = new System.Drawing.Size(299, 23);
            this.btnPersonnes.TabIndex = 11;
            this.btnPersonnes.Text = "Gérer les personnes";
            this.btnPersonnes.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 245);
            this.Controls.Add(this.btnPersonnes);
            this.Controls.Add(this.btnConnexions);
            this.Controls.Add(this.btnTypeObjet);
            this.Controls.Add(this.btnModeles);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnEmprunts);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lbl2);
            this.Name = "FrmMain";
            this.Text = "Console d\'administration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEmprunts;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnModeles;
        private System.Windows.Forms.Button btnTypeObjet;
        private System.Windows.Forms.Button btnConnexions;
        private System.Windows.Forms.Button btnPersonnes;
    }
}