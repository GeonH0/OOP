using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename = "";
        bool modifyFlag = false;

        FIND FindForm;

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            openFileDialog1.ShowDialog();

            filename = openFileDialog1.FileName;

            string Data = System.IO.File.ReadAllText(filename);

            //3. 화면에 표시 한다.
            richTextBox1.Text = Data;
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                //1. 사용자 에게 저장할 파일을 선택 하게 함
                this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                this.saveFileDialog1.ShowDialog();


                //2. 파일을 저장 한다.            
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);

                //3. 파일명을 기억
                filename = saveFileDialog1.FileName;
            }
            else
            {
                //해당 파일명으로 현재 내용을 저장

                //2. 파일을 저장 한다.            
                System.IO.File.WriteAllText(filename, richTextBox1.Text);
            }
        }

        private void 끝내ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox contents = (RichTextBox)ActiveControl;
            if (contents != null)
            {
                Clipboard.SetDataObject(contents.SelectedText);
                MessageBox.Show(contents.SelectedText);
            }

        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox contents = (RichTextBox)ActiveControl;
            if (contents != null)
            {
                IDataObject data = Clipboard.GetDataObject();
                contents.SelectedText = data.GetData(DataFormats.Text).ToString();
                modifyFlag = true;
            }

        }

        private void 모두선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(richTextBox1.SelectedText);
            richTextBox1.SelectedText = String.Empty;
        }
    }
}
