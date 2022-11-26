using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save an Text File";
            //saveFileDialog1.InitialDirectory = "C:\"; 
            openFileDialog1.InitialDirectory = Application.ExecutablePath;
           //openFileDialog1.FileName = "";

                // saveFileDialog1.ShowDialog();
           
                // Saves the Image via a FileStream created by the OpenFile method.
        
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //StreamWriter writer = new StreamWriter(save.OpenFile());
                    String nomFichier = openFileDialog1.FileName;
                    StreamReader fichier = null;
                    try
                    {
                        fichier = new StreamReader(nomFichier);
                        textBox2.Text = fichier.ReadToEnd();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Probléme à l'ecriture du fichier ("
                            + ex.Message + ")", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        if(fichier != null)
                        {
                            fichier.Dispose();
                        }
                    }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //  StreamWriter fichier = new StreamWriter(nomFichier);
           // SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save an Text File";
           // saveFileDialog1.ShowDialog();
           
                // Saves the Image via a FileStream created by the OpenFile method.
        
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //StreamWriter writer = new StreamWriter(save.OpenFile());
                    String nomFichier = saveFileDialog1.FileName;
                    StreamWriter fichier = null;
                    try
                    {
                        fichier = new StreamWriter(nomFichier);
                        fichier.Write(textBox2.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Probléme à l'ecriture du fichier ("
                            + ex.Message + ")", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        if(fichier != null)
                        {
                            fichier.Dispose();
                        }
                    }
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Font = fontDialog1.Font;
            }
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.ForeColor = colorDialog1.Color;
            }
        }
    }
}
