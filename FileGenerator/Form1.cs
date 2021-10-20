using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace FileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        static int nb = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAnnuler.Enabled = false;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy != true)
            {
                btnGenerer.Enabled = false;
                numTailleFichier.Enabled = false;
                btnAnnuler.Enabled = true;

                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Status: ";

                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void numTailleFichier_ValueChanged(object sender, EventArgs e)
        {
            lblProgession.Text = "0 / " + numTailleFichier.Value.ToString();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            string tmp = "";
            if (Convert.ToUInt64(numTailleFichier.Value) >= 100 && Convert.ToUInt64(numTailleFichier.Value) <= 1000)            
                for (UInt64 i = 0; i < 100; i++) tmp += 'a';            
            else if (Convert.ToUInt64(numTailleFichier.Value) >= 1001 && Convert.ToUInt64(numTailleFichier.Value) <= 10000)            
                for (UInt64 i = 0; i < 1000; i++) tmp += 'a';            
            else if (Convert.ToUInt64(numTailleFichier.Value) >= 10001 && Convert.ToUInt64(numTailleFichier.Value) <= 100000)            
                for (UInt64 i = 0; i < 10000; i++) tmp += 'a';
            else if (Convert.ToUInt64(numTailleFichier.Value) >= 100001 && Convert.ToUInt64(numTailleFichier.Value) <= 1000000)            
                for (UInt64 i = 0; i < 100000; i++) tmp += 'a';
            else if (Convert.ToUInt64(numTailleFichier.Value) > 100000)            
                for (UInt64 i = 0; i < 1000000; i++) tmp += 'a';
            else            
                tmp = "a";

            using (StreamWriter sw = new StreamWriter("generated-" + nb + ".txt"))
            {
                for (UInt64 i = 1; i <= Convert.ToUInt64(numTailleFichier.Value) / Convert.ToUInt64(tmp.Length); i++)
                {
                    sw.Write(tmp);
                    sw.Flush();
                    Application.DoEvents();

                    if(worker.CancellationPending)
                    {
                        worker.CancelAsync();
                    }

                    //lblProgession.Text = Convert.ToString(i * 10) + " / " + numTailleFichier.Value.ToString();
                }
            }
            nb++;
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            btnGenerer.Enabled = true;
            numTailleFichier.Enabled = true;
            btnAnnuler.Enabled = false;

            if(e.Cancelled)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Status: Annulé";
            }
            else if(e.Error != null)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Status: Erreur: " + e.Error.Message;
            }
            else
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Status: Terminé";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            
        }
    }
}
