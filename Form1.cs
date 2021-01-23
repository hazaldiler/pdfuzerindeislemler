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
namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdfaç = new OpenFileDialog();
            pdfaç.Title = "pdf aç";
            pdfaç.Filter = "PDF dosyaları(*.Pdf) | *.Pdf";
            if (pdfaç.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = pdfaç.FileName;
                axAcroPDF1.LoadFile(pdfaç.FileName);
            }
        }

        
    }
}
