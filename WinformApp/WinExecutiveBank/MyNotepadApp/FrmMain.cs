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

namespace MyNotepadApp
{
    public partial class FrmMain : Form
    {
        public bool isModify { get; set; }
        private const string firstFileName = "noname.txt";
        private string currfileName = firstFileName;
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MnuGGyy_Click(object sender, EventArgs e)
        {
            // TODO:만약 작업중인 파일이 있으면 저장처리
            ProcessSaveBeforeClose();
            TxtMain.Text = "";
            isModify = false;
            currfileName = "noname.txt";
            this.Text = this.Text = $"{currfileName}-내 메모장";
        }

        private void MnuOpenFile_Click(object sender, EventArgs e)
        {
            ProcessSaveBeforeClose();

            DlgOpenText.ShowDialog();
            currfileName = DlgOpenText.FileName;
            this.Text = this.Text = $"{currfileName}-내 메모장";

            try
            {
                StreamReader sr = File.OpenText(currfileName);
                TxtMain.Text = sr.ReadToEnd();

                isModify = false;
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessSaveBeforeClose()
        {
            if (isModify)
            {
                DialogResult answer = MessageBox.Show("변경사항이 있습니다. 저장하시겠습니까?", "저장",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (currfileName == firstFileName)
                    {
                        if(DlgSaveText.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(DlgSaveText.FileName);
                            sw.WriteLine(TxtMain.Text);
                            sw.Close();
                        }
                        else
                        {
                            StreamWriter sw = File.CreateText(currfileName);
                            sw.WriteLine(TxtMain.Text);
                            sw.Close();
                        }
                    }
                }
            }
        }
        private void MnusaveFile_Click(object sender, EventArgs e)
        {
            if (currfileName == firstFileName)
            {
                DlgSaveText.Filter = "Text file(*.txt)|*.txt|Log file(*.log)|*.log";
                if (DlgSaveText.ShowDialog() == DialogResult.OK)
                    currfileName = DlgSaveText.FileName;
            }

            StreamWriter sw = File.CreateText(currfileName);
            sw.WriteLine(TxtMain.Text);

            isModify = false;
            sw.Close();

            this.Text= this.Text = $"{currfileName}-내 메모장";

        }

        private void MnuEsc_Click(object sender, EventArgs e)
        {
            ProcessSaveBeforeClose();
            Environment.Exit(0);
        }

        private void MnuCopy_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                Clipboard.SetDataObject(contents.SelectedText);
                MessageBox.Show(contents.SelectedText);
            }
        }

        private void MnuPath_Click(object sender, EventArgs e)
        {
            var conteets = ActiveControl as RichTextBox;
            if (conteets != null)
            {
                IDataObject data = Clipboard.GetDataObject();
                conteets.SelectedText = data.GetData(DataFormats.Text).ToString();
                isModify = true;
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("메모장 v1.0입니다.");
            var form = new AboutThis();
            form.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DlgSaveText.Filter= DlgOpenText.Filter = "Text file(*.txt)|*.txt|Log file(*.log)|*.log";
            this.Text = $"{currfileName}-내 메모장";
            isModify = false;
        }

        private void TxtMain_TextChanged(object sender, EventArgs e)
        {
            isModify = true;
            this.Text = $"{currfileName}*-내 메모장";
        }
    }
}
