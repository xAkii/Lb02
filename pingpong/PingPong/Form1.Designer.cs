namespace Pong
{
    partial class frmPong
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.Schläger = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Schläger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.Schläger);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(33, 12);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(754, 359);
            this.pnlSpiel.TabIndex = 0;
            // 
            // Schläger
            // 
            this.Schläger.BackColor = System.Drawing.Color.Black;
            this.Schläger.Location = new System.Drawing.Point(3, 128);
            this.Schläger.Name = "Schläger";
            this.Schläger.Size = new System.Drawing.Size(15, 97);
            this.Schläger.TabIndex = 2;
            this.Schläger.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picBall.Location = new System.Drawing.Point(394, 142);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(25, 25);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 399);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Punkte";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Location = new System.Drawing.Point(172, 406);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(100, 20);
            this.txtPunkte.TabIndex = 3;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(13, 13);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 350);
            this.vScrollBar1.TabIndex = 13;
            // 
            // frmPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.Name = "frmPong";
            this.Text = "Ping Pong";
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Schläger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.PictureBox Schläger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

