using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            String[] files = new String[] { @"D:\Comparar\1.pdf", @"D:\Comparar\2.pdf", @"D:\Comparar\3.pdf" };
            string outputFile = @"D:\Comparar\result.pdf";
            PdfDocumentBase doc = PdfDocument.MergeFiles(files);
            doc.Save(outputFile, FileFormat.PDF);
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            string ruta = "";

            folderBrowserDialog1.ShowDialog();
            ruta = folderBrowserDialog1.SelectedPath;
            textBox1.Text = ruta;
        }
    }
}
