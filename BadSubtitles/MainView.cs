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

namespace BadSubtitles
{
    public partial class MainView : Form
    {
        public List<string> fileContent = new List<string>();
        public string filePath = string.Empty;
        public MainView()
        {
            InitializeComponent();
        }

        private void uploadBTN_Click(object sender, EventArgs e)
        {
            
            

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Desktop";
                openFileDialog.Filter = "srt files (*.srt)|*.srt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        while(!reader.EndOfStream)
                        {
                            string text = reader.ReadLine();
                            fileContent.Add(text);
                        }
                        
                        
                    }
                }
                textBoxSubs.Clear();
                foreach (string s in fileContent)
                {

                    textBoxSubs.Text += s + "\n";
                    
                }
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
              List<string> converted = new List<string>();
            string v;
            foreach(string s in fileContent)
            {
                
                if(s.Contains("0:"))
                {
                    i++;
                    var a=  s.Split(',');
                    v =  a[0] + " --> " + a[1];
                    converted.Add(i.ToString());
                }
                else
                {
                    v = s;
                }
                converted.Add(v);
            }
            textBoxSubs.Clear();
            foreach (string s in converted)
            {
                textBoxSubs.Text += s + "\n";
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            SaveFileDialog newFile = new SaveFileDialog();
            newFile.FileName = "[FIXED]"+ Path.GetFileName(filePath);
            newFile.Filter = "srt files (*.srt)|*.srt";
            newFile.FilterIndex = 2;
            newFile.RestoreDirectory = true;

            if (newFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(newFile.OpenFile()))
                {
                    sw.Write(textBoxSubs.Text);
                }
            }
        }
    }
}
