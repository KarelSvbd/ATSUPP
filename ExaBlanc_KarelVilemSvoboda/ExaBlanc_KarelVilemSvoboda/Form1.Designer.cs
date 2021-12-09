namespace ExaBlanc_KarelVilemSvoboda
{
    partial class Frm1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTypeVehicule = new System.Windows.Forms.Label();
            this.lblImmatriculation = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.tbxImmatriculation = new System.Windows.Forms.TextBox();
            this.tbxTicket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbxDuree = new System.Windows.Forms.ComboBox();
            this.cbxVehicule = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTypeVehicule
            // 
            this.lblTypeVehicule.AutoSize = true;
            this.lblTypeVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeVehicule.Location = new System.Drawing.Point(12, 21);
            this.lblTypeVehicule.Name = "lblTypeVehicule";
            this.lblTypeVehicule.Size = new System.Drawing.Size(125, 18);
            this.lblTypeVehicule.TabIndex = 0;
            this.lblTypeVehicule.Text = "Type de véhicule :";
            // 
            // lblImmatriculation
            // 
            this.lblImmatriculation.AutoSize = true;
            this.lblImmatriculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImmatriculation.Location = new System.Drawing.Point(21, 67);
            this.lblImmatriculation.Name = "lblImmatriculation";
            this.lblImmatriculation.Size = new System.Drawing.Size(116, 18);
            this.lblImmatriculation.TabIndex = 1;
            this.lblImmatriculation.Text = "Immatriculation :";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.Location = new System.Drawing.Point(45, 107);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(92, 18);
            this.lblDuree.TabIndex = 2;
            this.lblDuree.Text = "Durée [min] :";
            // 
            // tbxImmatriculation
            // 
            this.tbxImmatriculation.Location = new System.Drawing.Point(155, 64);
            this.tbxImmatriculation.Name = "tbxImmatriculation";
            this.tbxImmatriculation.Size = new System.Drawing.Size(119, 20);
            this.tbxImmatriculation.TabIndex = 3;
            // 
            // tbxTicket
            // 
            this.tbxTicket.Location = new System.Drawing.Point(376, 198);
            this.tbxTicket.Multiline = true;
            this.tbxTicket.Name = "tbxTicket";
            this.tbxTicket.Size = new System.Drawing.Size(224, 171);
            this.tbxTicket.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ticket";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(155, 164);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbxDuree
            // 
            this.cbxDuree.FormattingEnabled = true;
            this.cbxDuree.Location = new System.Drawing.Point(155, 108);
            this.cbxDuree.Name = "cbxDuree";
            this.cbxDuree.Size = new System.Drawing.Size(119, 21);
            this.cbxDuree.TabIndex = 7;
            // 
            // cbxVehicule
            // 
            this.cbxVehicule.FormattingEnabled = true;
            this.cbxVehicule.Location = new System.Drawing.Point(155, 21);
            this.cbxVehicule.Name = "cbxVehicule";
            this.cbxVehicule.Size = new System.Drawing.Size(119, 21);
            this.cbxVehicule.TabIndex = 8;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxVehicule);
            this.Controls.Add(this.cbxDuree);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTicket);
            this.Controls.Add(this.tbxImmatriculation);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblImmatriculation);
            this.Controls.Add(this.lblTypeVehicule);
            this.Name = "Frm1";
            this.Text = "Parcmètre V1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeVehicule;
        private System.Windows.Forms.Label lblImmatriculation;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.TextBox tbxImmatriculation;
        private System.Windows.Forms.TextBox tbxTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbxDuree;
        private System.Windows.Forms.ComboBox cbxVehicule;
    }
}

