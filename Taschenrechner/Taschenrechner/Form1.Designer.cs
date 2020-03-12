namespace Taschenrechner
{
    partial class frmTaschenrechner
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.btnMultiplikation = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMittelwert = new System.Windows.Forms.Button();
            this.btnPotenz = new System.Windows.Forms.Button();
            this.btnMaxium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtOperand1
            // 
            this.txtOperand1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOperand1.Location = new System.Drawing.Point(17, 12);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 2;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(144, 12);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 3;
            // 
            // lblOperator
            // 
            this.lblOperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(123, 15);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(0, 13);
            this.lblOperator.TabIndex = 4;
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ergebnis:";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.BackColor = System.Drawing.Color.White;
            this.lblErgebnis.Location = new System.Drawing.Point(141, 48);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(100, 23);
            this.lblErgebnis.TabIndex = 6;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(26, 93);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(82, 23);
            this.btnAddition.TabIndex = 7;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.Location = new System.Drawing.Point(135, 93);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(81, 23);
            this.btnSubtraktion.TabIndex = 8;
            this.btnSubtraktion.Text = "Subtraktion";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            // 
            // btnMultiplikation
            // 
            this.btnMultiplikation.Location = new System.Drawing.Point(26, 123);
            this.btnMultiplikation.Name = "btnMultiplikation";
            this.btnMultiplikation.Size = new System.Drawing.Size(81, 23);
            this.btnMultiplikation.TabIndex = 9;
            this.btnMultiplikation.Text = "Multiplikation";
            this.btnMultiplikation.UseVisualStyleBackColor = true;
            this.btnMultiplikation.Click += new System.EventHandler(this.btnMultiplikation_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(135, 123);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(81, 23);
            this.btnDivision.TabIndex = 10;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMittelwert
            // 
            this.btnMittelwert.Location = new System.Drawing.Point(26, 153);
            this.btnMittelwert.Name = "btnMittelwert";
            this.btnMittelwert.Size = new System.Drawing.Size(81, 23);
            this.btnMittelwert.TabIndex = 11;
            this.btnMittelwert.Text = "Mittelwert";
            this.btnMittelwert.UseVisualStyleBackColor = true;
            this.btnMittelwert.Click += new System.EventHandler(this.btnMittelwert_Click);
            // 
            // btnPotenz
            // 
            this.btnPotenz.Location = new System.Drawing.Point(135, 153);
            this.btnPotenz.Name = "btnPotenz";
            this.btnPotenz.Size = new System.Drawing.Size(81, 23);
            this.btnPotenz.TabIndex = 12;
            this.btnPotenz.Text = "Potenz";
            this.btnPotenz.UseVisualStyleBackColor = true;
            this.btnPotenz.Click += new System.EventHandler(this.btnPotenz_Click);
            // 
            // btnMaxium
            // 
            this.btnMaxium.Location = new System.Drawing.Point(26, 182);
            this.btnMaxium.Name = "btnMaxium";
            this.btnMaxium.Size = new System.Drawing.Size(82, 23);
            this.btnMaxium.TabIndex = 13;
            this.btnMaxium.Text = "Maximum";
            this.btnMaxium.UseVisualStyleBackColor = true;
            this.btnMaxium.Click += new System.EventHandler(this.btnMaxium_Click);
            // 
            // frmTaschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 252);
            this.Controls.Add(this.btnMaxium);
            this.Controls.Add(this.btnPotenz);
            this.Controls.Add(this.btnMittelwert);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplikation);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Name = "frmTaschenrechner";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.Button btnMultiplikation;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMittelwert;
        private System.Windows.Forms.Button btnPotenz;
        private System.Windows.Forms.Button btnMaxium;
    }
}

