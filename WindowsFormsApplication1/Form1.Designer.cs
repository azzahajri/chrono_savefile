namespace WindowsFormsApplication1
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
            this.btnsave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnload = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(93, 339);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(441, 186);
            this.textBox2.TabIndex = 2;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(241, 351);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(78, 33);
            this.btnload.TabIndex = 3;
            this.btnload.Text = "load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(399, 339);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 33);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(93, 399);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(75, 31);
            this.btncolor.TabIndex = 5;
            this.btncolor.Text = "color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(399, 399);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(75, 29);
            this.btnfont.TabIndex = 6;
            this.btnfont.Text = "font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 452);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnsave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

