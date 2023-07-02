using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(500,500);
            this.dlgOpen.Filter = "Rich Text Files |*.rtf|Text Files|*.txt";
            this.btnExit.Click += (Sender, E) => this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (this.dlgOpen.ShowDialog() == DialogResult.OK)
            {
                //switch (this.dlgOpen.FilterIndex)
                //{
                //    case 1:
                //        txtInput.LoadFile(this.dlgOpen.FileName,RichTextBoxStreamType.RichText);
                //        break;
                //    case 2:
                //        txtInput.LoadFile(this.dlgOpen.FileName, RichTextBoxStreamType.PlainText);
                //        break;
                //}
                txtInput.LoadFile(this.dlgOpen.FileName, (this.dlgOpen.FilterIndex==1)? RichTextBoxStreamType.RichText: RichTextBoxStreamType.PlainText);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dlgSave.ShowDialog() == DialogResult.OK)
            {
                //txtInput.SaveFile(this.dlgSave.FileName,(RichTextBoxStreamType)(dlgSave.FilterIndex-1));
                txtInput.SaveFile(this.dlgSave.FileName, (this.dlgOpen.FilterIndex == 1) ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText);
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText.Length > 0)
            {
                this.dlgFont.Font = txtInput.SelectionFont;
            }
            if (this.dlgFont.ShowDialog() == DialogResult.OK)
            {
                txtInput.SelectionFont = this.dlgFont.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText.Length > 0)
            {
                this.dlgColor.Color = txtInput.SelectionColor;
            }
            if (this.dlgColor.ShowDialog() == DialogResult.OK)
            {
                txtInput.SelectionColor = this.dlgColor.Color;
            }
        }

        DlgCustom DlgCustom = new DlgCustom();
        private void btnDlg_Click(object sender, EventArgs e)
        {
            DlgCustom.CustText = "Type here";
            if (DlgCustom.ShowDialog() == DialogResult.OK)
            {
                txtInput.AppendText(DlgCustom.CustText);
            } else if(DlgCustom.ShowDialog() == DialogResult.Cancel)
            {

            }
        }
    }
}
