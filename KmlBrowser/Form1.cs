using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            myKml = KmlIO.read(@"D:\Users\Petzoldt\Eigene Programme\rp\KmlBrowser\Daten\Ideen.kml");
            // Anzeigen der Datei
            Show(myKml);
        }


        private void Show(kml myKml)
        {
            kmlDocument Document = myKml.Document;

            foreach (var item in Document.Items)
            {
                if (item.GetType() == typeof(kmlDocumentFolder))
                {
                    showFolder((kmlDocumentFolder)item,0);
                }
            }

        }

        private void showFolder(kmlDocumentFolder mainFolder, int ident)
        {
            String fill = "                                   ".Substring(0, ident);
            tbOut.AppendText("Folder: " + mainFolder.name + Environment.NewLine);

            foreach (kmlDocumentFolderFolder item in mainFolder.Folder)
            {
                showFolder(item, ident + 1);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnLoad_Click(null, null);
        }
    }
}
