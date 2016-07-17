using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// test remxxxxxx


namespace KmlBrowser
{
    public partial class Form1 : Form
    {
        kml myKml = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // einlesen der Datei
            KmlIO kmlIO = new KmlIO(showTxt);
            myKml = kmlIO.read(tBKmlDateiName.Text);
            //KmlIO.write(@"..\..\..\Daten\Ideen_neu.kml",myKml);

            // Anzeigen der Datei
            //tbOut.Clear();
            Show(myKml);
        }


        private void Show(kml myKml)
        {
            kmlDocument Document = myKml.Document;

            foreach (var item in Document.Items)
            {
                if (item.GetType() == typeof(kmlFolder))
                {
                    showFolder((kmlFolder)item,0);
                }
            }

        }

        private void showFolder(kmlFolder mainFolder, int ident)
        {
            showFolderInfo(mainFolder, ident);

            if (mainFolder.Placemark != null)
            {
                foreach (var item in mainFolder.Placemark)
                {
                    showPlacemarkInfo(item,ident);
                }
            }


            if (mainFolder.Folder != null)
            {
                foreach (kmlFolder item in mainFolder.Folder)
                {
                    showFolder(item, ident + 2);
                } 
            }
        }

        private void showPlacemarkInfo(kmlPlacemark item, int ident)
        {
            tbOut.AppendText(Einzug(ident+2)+"Placemark: " + item.name + Environment.NewLine);
        }

        private string Einzug(int ident)
        {
            return "".PadLeft(ident * 2, ' ');
        }

        private void showFolderInfo(kmlFolder mainFolder, int ident)
        {
            tbOut.AppendText(Einzug(ident) + "Folder: " + mainFolder.name + Environment.NewLine);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnLoad_Click(null, null);
        }

        private void btnFileAuswahl_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory ;
            openFileDialog1.FileName = "Ideen.kml";
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                tBKmlDateiName.Text = openFileDialog1.FileName;
            }
        }

        private void showTxt(String txt)
        {
            tbOut.AppendText(txt + Environment.NewLine);
        }

    }
}
