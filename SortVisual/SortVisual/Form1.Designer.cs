namespace SortVisual
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.reset_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(46, 22);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reset_btn.Size = new System.Drawing.Size(172, 23);
            this.reset_btn.TabIndex = 0;
            this.reset_btn.Text = "Wygeneruj elementy";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 281);
            this.panel1.TabIndex = 1;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(224, 22);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(172, 23);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Zacznij sortowanie";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 366);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Wizualizacja sortowania - 22657";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start_btn;
    }
}

