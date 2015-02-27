using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSupergoo.ABCpdf10;

namespace PDFtoTIFF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
        }

        OpenFileDialog file = new OpenFileDialog();
        string dosya = "";
        int kalan = 0;
        private void btnChoose_Click(object sender, EventArgs e)
        {
            
            file.Filter = "PDF Files (*.pdf)|*.pdf";
            file.Multiselect = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtDosya.Text = file.FileName;
                dosya = file.SafeFileName;
            }
            kalan = file.FileNames.Length;
            lblKalanText.Text = Convert.ToString(kalan);
        }


        private void pbSend_Click(object sender, EventArgs e)
        {
            if (txtDosya.Text == "Seçiniz..")
            {
                MessageBox.Show("En az bir PDF dosyası seçmelisiniz.", "Uyarı", MessageBoxButtons.OK);
            }
            else {

                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\PDFtoTIF");
                progressBar1.Maximum = file.SafeFileNames.Length;


                //C:\Users\serbayacar\Desktop\tarama\DEST2000000000008214.pdf
                // DEST2000000000008214.pdf  24
                for (int j = 0; j < file.FileNames.Length; j++)
                {
                    dosya = file.SafeFileNames[j];
                    string yol = file.FileNames[j];
                    yol = string.Concat(yol.Substring(0, yol.Length - file.SafeFileNames[j].Length), file.SafeFileNames[j]);
                    Doc theDoc = new Doc();
                    theDoc.Read(yol);
                    int n = theDoc.PageCount;
                    theDoc.Rendering.ColorSpace = XRendering.ColorSpaceType.Gray;
                    theDoc.Rendering.BitsPerChannel = 1;
                    theDoc.Rendering.DotsPerInchX = 200;
                    theDoc.Rendering.DotsPerInchY = 400;

                    for (int i = 1; i <= n; i++)
                    {
                        theDoc.PageNumber = i;

                        theDoc.Rect.String = theDoc.CropBox.String;

                        theDoc.Rendering.SaveAppend = (i != 1);

                        //theDoc.Rendering.SaveCompression = XRendering.Compression.G4;

                        theDoc.SetInfo(0, "ImageCompression", "4");
                        theDoc.Rendering.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\PDFtoTIF\\" + dosya + ".tiff");

                    }
                    progressBar1.Value++;
                    kalan--;
                    lblKalanText.Text = Convert.ToString(kalan);
                    theDoc.Clear();
                }



                MessageBox.Show("Tüm veriler dönüştürüldü. İsterseniz tekrar kullanabilirsiniz", "Son", MessageBoxButtons.OK);
                txtDosya.Text = "Seçiniz..";
                progressBar1.Value = 0;
            }
        }

        

        
    }
}
