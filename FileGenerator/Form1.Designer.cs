namespace FileGenerator
{
    partial class Form1
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
            this.btnGenerer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numTailleFichier = new System.Windows.Forms.NumericUpDown();
            this.progressionGener = new System.Windows.Forms.ProgressBar();
            this.lblProgession = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTailleFichier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(168, 87);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(75, 23);
            this.btnGenerer.TabIndex = 0;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taille du fichier";
            // 
            // numTailleFichier
            // 
            this.numTailleFichier.Location = new System.Drawing.Point(143, 36);
            this.numTailleFichier.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numTailleFichier.Name = "numTailleFichier";
            this.numTailleFichier.Size = new System.Drawing.Size(329, 20);
            this.numTailleFichier.TabIndex = 3;
            this.numTailleFichier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTailleFichier.ValueChanged += new System.EventHandler(this.numTailleFichier_ValueChanged);
            // 
            // progressionGener
            // 
            this.progressionGener.Location = new System.Drawing.Point(12, 177);
            this.progressionGener.Name = "progressionGener";
            this.progressionGener.Size = new System.Drawing.Size(528, 23);
            this.progressionGener.Step = 1;
            this.progressionGener.TabIndex = 4;
            // 
            // lblProgession
            // 
            this.lblProgession.AutoSize = true;
            this.lblProgession.Location = new System.Drawing.Point(260, 158);
            this.lblProgession.Name = "lblProgession";
            this.lblProgession.Size = new System.Drawing.Size(30, 13);
            this.lblProgession.TabIndex = 5;
            this.lblProgession.Text = "0 / 1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(307, 87);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 212);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblProgession);
            this.Controls.Add(this.progressionGener);
            this.Controls.Add(this.numTailleFichier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FileGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTailleFichier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTailleFichier;
        private System.Windows.Forms.ProgressBar progressionGener;
        private System.Windows.Forms.Label lblProgession;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblStatus;
    }
}

