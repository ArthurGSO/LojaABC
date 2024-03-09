
namespace LojaABC
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pctSplash = new System.Windows.Forms.PictureBox();
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.lblPorc = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSplash
            // 
            this.pctSplash.Image = ((System.Drawing.Image)(resources.GetObject("pctSplash.Image")));
            this.pctSplash.Location = new System.Drawing.Point(250, 150);
            this.pctSplash.Name = "pctSplash";
            this.pctSplash.Size = new System.Drawing.Size(300, 225);
            this.pctSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSplash.TabIndex = 0;
            this.pctSplash.TabStop = false;
            this.pctSplash.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(250, 425);
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(300, 32);
            this.pgbSplash.TabIndex = 1;
            this.pgbSplash.UseWaitCursor = true;
            this.pgbSplash.Value = 50;
            this.pgbSplash.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblPorc
            // 
            this.lblPorc.AutoSize = true;
            this.lblPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorc.Location = new System.Drawing.Point(383, 402);
            this.lblPorc.Name = "lblPorc";
            this.lblPorc.Size = new System.Drawing.Size(18, 20);
            this.lblPorc.TabIndex = 2;
            this.lblPorc.Text = "0";
            this.lblPorc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(402, 402);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(23, 20);
            this.lblPorcentagem.TabIndex = 3;
            this.lblPorcentagem.Text = "%";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblPorc);
            this.Controls.Add(this.pgbSplash);
            this.Controls.Add(this.pctSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSplash;
        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Label lblPorc;
        private System.Windows.Forms.Label lblPorcentagem;
    }
}