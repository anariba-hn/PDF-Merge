using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Spire.Pdf;

namespace ImpresionFacturas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        public void btnBuscarDir_Click(object sender, EventArgs e)
        {
            using (var dialogo = new FolderBrowserDialog())
            {
                DialogResult resultado = dialogo.ShowDialog();

                if(resultado == DialogResult.OK && !string.IsNullOrEmpty(dialogo.SelectedPath))
                {
                    string ruta = dialogo.SelectedPath;
                    txtRutaDir.Text = ruta;
                }
            }
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            if(txtRutaDir.Text != "")
            {
                string rutaDir = txtRutaDir.Text;
                
                if (Directory.Exists(rutaDir))
                {
                    string[] subDir = Directory.GetDirectories(rutaDir);
                    progressBar1.Maximum = subDir.Length;

                    foreach (string dir in subDir)
                    {
                        string[] pdfs = Directory.GetFiles(dir);
                        string finalPDF = dir + @"PDFinal.pdf";

                        if (pdfs.Length != 0)
                        {
                            PdfDocumentBase doc = PdfDocument.MergeFiles(pdfs);
                            doc.Save(finalPDF, FileFormat.PDF);
                        }

                        Console.WriteLine("Apilando en el Directorio: " + dir);
                        progressBar1.Value += 1;
                    }

                    MessageBox.Show("Proceso Completado", "", MessageBoxButtons.OK);
                    progressBar1.Value = 0;
                }
                else
                {
                    MessageBox.Show("Esta ruta no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione un directorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
