namespace ProjetAtelierSupport
{
    partial class FrmEmprunts
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.lstEmprunts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(478, 406);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(138, 23);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lstEmprunts
            // 
            this.lstEmprunts.FormattingEnabled = true;
            this.lstEmprunts.Location = new System.Drawing.Point(13, 13);
            this.lstEmprunts.Name = "lstEmprunts";
            this.lstEmprunts.Size = new System.Drawing.Size(603, 381);
            this.lstEmprunts.TabIndex = 1;
            this.lstEmprunts.SelectedIndexChanged += new System.EventHandler(this.lstEmprunts_SelectedIndexChanged);
            // 
            // frmEmprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 441);
            this.Controls.Add(this.lstEmprunts);
            this.Controls.Add(this.btnRetour);
            this.Name = "frmEmprunts";
            this.Text = "Gestion des emprunts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListBox lstEmprunts;
    }
}