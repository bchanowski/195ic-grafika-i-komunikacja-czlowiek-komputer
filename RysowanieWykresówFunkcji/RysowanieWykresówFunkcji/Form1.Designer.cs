
namespace RysowanieWykresówFunkcji
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Xmin = new System.Windows.Forms.TextBox();
            this.Xmax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ymax = new System.Windows.Forms.TextBox();
            this.Ymin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bText = new System.Windows.Forms.TextBox();
            this.aText = new System.Windows.Forms.TextBox();
            this.cText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 260);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Xmin
            // 
            this.Xmin.Location = new System.Drawing.Point(49, 308);
            this.Xmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Xmin.Name = "Xmin";
            this.Xmin.Size = new System.Drawing.Size(52, 20);
            this.Xmin.TabIndex = 3;
            // 
            // Xmax
            // 
            this.Xmax.Location = new System.Drawing.Point(49, 331);
            this.Xmax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Xmax.Name = "Xmax";
            this.Xmax.Size = new System.Drawing.Size(52, 20);
            this.Xmax.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 310);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X max:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y min:";
            // 
            // Ymax
            // 
            this.Ymax.Location = new System.Drawing.Point(153, 329);
            this.Ymax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ymax.Name = "Ymax";
            this.Ymax.Size = new System.Drawing.Size(52, 20);
            this.Ymax.TabIndex = 8;
            // 
            // Ymin
            // 
            this.Ymin.Location = new System.Drawing.Point(153, 306);
            this.Ymin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ymin.Name = "Ymin";
            this.Ymin.Size = new System.Drawing.Size(52, 20);
            this.Ymin.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(221, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "RYSUJ FUNKCJE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bText
            // 
            this.bText.Location = new System.Drawing.Point(117, 265);
            this.bText.Name = "bText";
            this.bText.Size = new System.Drawing.Size(24, 20);
            this.bText.TabIndex = 13;
            // 
            // aText
            // 
            this.aText.Location = new System.Drawing.Point(49, 265);
            this.aText.Name = "aText";
            this.aText.Size = new System.Drawing.Size(24, 20);
            this.aText.TabIndex = 14;
            // 
            // cText
            // 
            this.cText.Location = new System.Drawing.Point(181, 265);
            this.cText.Name = "cText";
            this.cText.Size = new System.Drawing.Size(24, 20);
            this.cText.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "b";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cText);
            this.Controls.Add(this.aText);
            this.Controls.Add(this.bText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ymax);
            this.Controls.Add(this.Ymin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Xmax);
            this.Controls.Add(this.Xmin);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Xmin;
        private System.Windows.Forms.TextBox Xmax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ymax;
        private System.Windows.Forms.TextBox Ymin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bText;
        private System.Windows.Forms.TextBox aText;
        private System.Windows.Forms.TextBox cText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

