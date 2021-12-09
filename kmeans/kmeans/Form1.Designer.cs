namespace kmeans
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lblListe = new System.Windows.Forms.Label();
            this.btnCommencer = new System.Windows.Forms.Button();
            this.lblNumeroTrouves = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(28, 12);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(120, 23);
            this.nudNumero.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Location = new System.Drawing.Point(31, 101);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(38, 15);
            this.lblListe.TabIndex = 2;
            this.lblListe.Text = "label1";
            // 
            // btnCommencer
            // 
            this.btnCommencer.Location = new System.Drawing.Point(298, 40);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(145, 23);
            this.btnCommencer.TabIndex = 3;
            this.btnCommencer.Text = "Commencer";
            this.btnCommencer.UseVisualStyleBackColor = true;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // lblNumeroTrouves
            // 
            this.lblNumeroTrouves.AutoSize = true;
            this.lblNumeroTrouves.Location = new System.Drawing.Point(475, 48);
            this.lblNumeroTrouves.Name = "lblNumeroTrouves";
            this.lblNumeroTrouves.Size = new System.Drawing.Size(38, 15);
            this.lblNumeroTrouves.TabIndex = 4;
            this.lblNumeroTrouves.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumeroTrouves);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudNumero;
        private Button button1;
        private Label lblListe;
        private Button btnCommencer;
        private Label lblNumeroTrouves;
    }
}