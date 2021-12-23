namespace ProjetAtelierSupport
{
    partial class FrmModifEmprunt
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
            this.cbxPersonne = new System.Windows.Forms.ComboBox();
            this.cbxObjet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.tbxPeronneInitiale = new System.Windows.Forms.TextBox();
            this.tbxObjetInitial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxPersonne
            // 
            this.cbxPersonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonne.FormattingEnabled = true;
            this.cbxPersonne.Location = new System.Drawing.Point(34, 151);
            this.cbxPersonne.Name = "cbxPersonne";
            this.cbxPersonne.Size = new System.Drawing.Size(184, 21);
            this.cbxPersonne.TabIndex = 0;
            // 
            // cbxObjet
            // 
            this.cbxObjet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxObjet.FormattingEnabled = true;
            this.cbxObjet.Location = new System.Drawing.Point(34, 203);
            this.cbxObjet.Name = "cbxObjet";
            this.cbxObjet.Size = new System.Drawing.Size(184, 21);
            this.cbxObjet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Objet";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(37, 254);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(181, 23);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // tbxPeronneInitiale
            // 
            this.tbxPeronneInitiale.Location = new System.Drawing.Point(34, 27);
            this.tbxPeronneInitiale.Name = "tbxPeronneInitiale";
            this.tbxPeronneInitiale.ReadOnly = true;
            this.tbxPeronneInitiale.Size = new System.Drawing.Size(184, 20);
            this.tbxPeronneInitiale.TabIndex = 5;
            // 
            // tbxObjetInitial
            // 
            this.tbxObjetInitial.Location = new System.Drawing.Point(34, 78);
            this.tbxObjetInitial.Name = "tbxObjetInitial";
            this.tbxObjetInitial.ReadOnly = true;
            this.tbxObjetInitial.Size = new System.Drawing.Size(184, 20);
            this.tbxObjetInitial.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Objet";
            // 
            // FrmModifEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxObjetInitial);
            this.Controls.Add(this.tbxPeronneInitiale);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxObjet);
            this.Controls.Add(this.cbxPersonne);
            this.Name = "FrmModifEmprunt";
            this.Text = "Modifier un emprunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPersonne;
        private System.Windows.Forms.ComboBox cbxObjet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbxPeronneInitiale;
        private System.Windows.Forms.TextBox tbxObjetInitial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}