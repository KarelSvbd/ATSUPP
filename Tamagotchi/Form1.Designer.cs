
namespace Tamagotchi
{
    partial class lblFatigue
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
            this.components = new System.ComponentModel.Container();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.pgbCalorie = new System.Windows.Forms.ProgressBar();
            this.pgbLiquide = new System.Windows.Forms.ProgressBar();
            this.lblLiquide = new System.Windows.Forms.Label();
            this.pgbFatigue = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pgbVirus = new System.Windows.Forms.ProgressBar();
            this.lblVirus = new System.Windows.Forms.Label();
            this.btnManger = new System.Windows.Forms.Button();
            this.btnBoire = new System.Windows.Forms.Button();
            this.btnDormir = new System.Windows.Forms.Button();
            this.btnSoigner = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbxEtat = new System.Windows.Forms.TextBox();
            this.tbxTama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Location = new System.Drawing.Point(385, 87);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(38, 13);
            this.lblCalorie.TabIndex = 0;
            this.lblCalorie.Text = "calorie";
            // 
            // pgbCalorie
            // 
            this.pgbCalorie.Location = new System.Drawing.Point(388, 103);
            this.pgbCalorie.Name = "pgbCalorie";
            this.pgbCalorie.Size = new System.Drawing.Size(400, 23);
            this.pgbCalorie.TabIndex = 2;
            // 
            // pgbLiquide
            // 
            this.pgbLiquide.Location = new System.Drawing.Point(388, 160);
            this.pgbLiquide.Name = "pgbLiquide";
            this.pgbLiquide.Size = new System.Drawing.Size(400, 23);
            this.pgbLiquide.TabIndex = 4;
            // 
            // lblLiquide
            // 
            this.lblLiquide.AutoSize = true;
            this.lblLiquide.Location = new System.Drawing.Point(385, 144);
            this.lblLiquide.Name = "lblLiquide";
            this.lblLiquide.Size = new System.Drawing.Size(37, 13);
            this.lblLiquide.TabIndex = 3;
            this.lblLiquide.Text = "liquide";
            // 
            // pgbFatigue
            // 
            this.pgbFatigue.Location = new System.Drawing.Point(388, 215);
            this.pgbFatigue.Name = "pgbFatigue";
            this.pgbFatigue.Size = new System.Drawing.Size(400, 23);
            this.pgbFatigue.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "fatigue";
            // 
            // pgbVirus
            // 
            this.pgbVirus.Location = new System.Drawing.Point(388, 275);
            this.pgbVirus.Name = "pgbVirus";
            this.pgbVirus.Size = new System.Drawing.Size(400, 23);
            this.pgbVirus.TabIndex = 8;
            // 
            // lblVirus
            // 
            this.lblVirus.AutoSize = true;
            this.lblVirus.Location = new System.Drawing.Point(385, 259);
            this.lblVirus.Name = "lblVirus";
            this.lblVirus.Size = new System.Drawing.Size(29, 13);
            this.lblVirus.TabIndex = 7;
            this.lblVirus.Text = "virus";
            // 
            // btnManger
            // 
            this.btnManger.Location = new System.Drawing.Point(48, 377);
            this.btnManger.Name = "btnManger";
            this.btnManger.Size = new System.Drawing.Size(75, 23);
            this.btnManger.TabIndex = 9;
            this.btnManger.Text = "Manger";
            this.btnManger.UseVisualStyleBackColor = true;
            this.btnManger.Click += new System.EventHandler(this.btnManger_Click);
            // 
            // btnBoire
            // 
            this.btnBoire.Location = new System.Drawing.Point(176, 377);
            this.btnBoire.Name = "btnBoire";
            this.btnBoire.Size = new System.Drawing.Size(75, 23);
            this.btnBoire.TabIndex = 10;
            this.btnBoire.Text = "Boire";
            this.btnBoire.UseVisualStyleBackColor = true;
            this.btnBoire.Click += new System.EventHandler(this.btnBoire_Click);
            // 
            // btnDormir
            // 
            this.btnDormir.Location = new System.Drawing.Point(319, 377);
            this.btnDormir.Name = "btnDormir";
            this.btnDormir.Size = new System.Drawing.Size(75, 23);
            this.btnDormir.TabIndex = 11;
            this.btnDormir.Text = "Dormir";
            this.btnDormir.UseVisualStyleBackColor = true;
            this.btnDormir.Click += new System.EventHandler(this.btnDormir_Click);
            // 
            // btnSoigner
            // 
            this.btnSoigner.Location = new System.Drawing.Point(470, 377);
            this.btnSoigner.Name = "btnSoigner";
            this.btnSoigner.Size = new System.Drawing.Size(75, 23);
            this.btnSoigner.TabIndex = 12;
            this.btnSoigner.Text = "Soigner";
            this.btnSoigner.UseVisualStyleBackColor = true;
            this.btnSoigner.Click += new System.EventHandler(this.btnSoigner_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(679, 377);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // tbxEtat
            // 
            this.tbxEtat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEtat.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEtat.ForeColor = System.Drawing.Color.Teal;
            this.tbxEtat.Location = new System.Drawing.Point(103, 12);
            this.tbxEtat.Name = "tbxEtat";
            this.tbxEtat.ReadOnly = true;
            this.tbxEtat.Size = new System.Drawing.Size(586, 39);
            this.tbxEtat.TabIndex = 14;
            // 
            // tbxTama
            // 
            this.tbxTama.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTama.Location = new System.Drawing.Point(107, 87);
            this.tbxTama.Multiline = true;
            this.tbxTama.Name = "tbxTama";
            this.tbxTama.Size = new System.Drawing.Size(190, 211);
            this.tbxTama.TabIndex = 15;
            // 
            // lblFatigue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxTama);
            this.Controls.Add(this.tbxEtat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSoigner);
            this.Controls.Add(this.btnDormir);
            this.Controls.Add(this.btnBoire);
            this.Controls.Add(this.btnManger);
            this.Controls.Add(this.pgbVirus);
            this.Controls.Add(this.lblVirus);
            this.Controls.Add(this.pgbFatigue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbLiquide);
            this.Controls.Add(this.lblLiquide);
            this.Controls.Add(this.pgbCalorie);
            this.Controls.Add(this.lblCalorie);
            this.Name = "lblFatigue";
            this.Text = "Tamagotchi - V 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalorie;
        private System.Windows.Forms.ProgressBar pgbCalorie;
        private System.Windows.Forms.ProgressBar pgbLiquide;
        private System.Windows.Forms.Label lblLiquide;
        private System.Windows.Forms.ProgressBar pgbFatigue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgbVirus;
        private System.Windows.Forms.Label lblVirus;
        private System.Windows.Forms.Button btnManger;
        private System.Windows.Forms.Button btnBoire;
        private System.Windows.Forms.Button btnDormir;
        private System.Windows.Forms.Button btnSoigner;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.TextBox tbxEtat;
        private System.Windows.Forms.TextBox tbxTama;
    }
}

