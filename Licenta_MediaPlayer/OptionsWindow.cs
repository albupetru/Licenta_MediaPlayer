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
using System.Xml;

namespace Licenta_MediaPlayer
{
    public partial class OptionsWindow : Form
    {
        string settingsPath = string.Empty;
        string recordFolder = string.Empty;

        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            settingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Options.xml");
            Load_Settings_From_XML();
            Directory.CreateDirectory(Application.StartupPath + @"\Recorded Videos");
        }

        void Load_Settings_From_XML()
        {
            try
            {
                if (File.Exists(settingsPath))
                { // If XML file exists do...

                    XmlDocument doc = new XmlDocument();
                    doc.Load(settingsPath);

                    // READ Settings:
                    XmlNodeList nodesl = doc.SelectNodes("//settings");
                    if (nodesl != null)
                    {
                        foreach (XmlElement no in nodesl)
                        {
                            if (no.GetAttribute("recordFolder") != null) { recordFolder = (no.GetAttribute("recordFolder")); };
                        }
                    }
                }
            }
            catch { }

            try
            {
                if (String.IsNullOrEmpty(recordFolder)) { recordFolder = Application.StartupPath + @"\Recorded Videos"; };
                textBoxSaveFolder.Text = recordFolder;

            }
            catch { }
        }

        void Save_Settings_To_XML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlNode headerNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(headerNode);

                XmlNode rootNode = doc.CreateElement("root");
                doc.AppendChild(rootNode);

                XmlNode settNode = doc.CreateElement("settings");
                rootNode.AppendChild(settNode);

                XmlAttribute Attr1 = doc.CreateAttribute("recordFolder");
                if (String.IsNullOrEmpty(recordFolder)) {recordFolder = Application.StartupPath + @"\Recorded Videos"; textBoxSaveFolder.Text = recordFolder; };
                Attr1.Value = recordFolder;
                settNode.Attributes.Append(Attr1);

                doc.Save(settingsPath);
            }
            catch { }
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBrowseSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                recordFolder = fbd.SelectedPath;
                textBoxSaveFolder.Text = fbd.SelectedPath;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save_Settings_To_XML();
            this.Close();
        }
    }

}
