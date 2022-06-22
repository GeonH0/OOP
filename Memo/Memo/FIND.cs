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
    public partial class FIND : Form
    {

        public FIND(Form1 objDotnetNote)
        {
            dnn = objDotnetNote;
            InitializeComponent();
        }
        private Form1 dnn = null;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!FindText())
            {
                MessageBox.Show(
                    this.textBox1.Text + "을(를) 찾을 수 없습니다."
                    , "메모장"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool FindText()
        {
            int nFind;
            int nLen;
            string strTempText;
            string strTempFind;

            strTempText = dnn.richTextBox1.Text; //찾을 대상
            strTempFind = textBox1.Text; //찾을 단어

            nLen = textBox1.Text.Length; //텍스트 길이

            if ((dnn.richTextBox1.SelectionStart - dnn.richTextBox1.SelectionLength) < 0)
                nFind = -1;
            else
                nFind = strTempText.IndexOf(strTempFind, dnn.richTextBox1.SelectionStart + dnn.richTextBox1.SelectionLength);

            if (nFind == -1)
            {
                return false;
            }
            else
            {
                dnn.richTextBox1.SelectionStart = nFind;
                dnn.richTextBox1.SelectionLength = nLen;
                dnn.richTextBox1.Focus();
                return true;
            }
        }
    }
}
