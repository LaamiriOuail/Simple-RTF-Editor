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
    public partial class DlgCustom : Form
    {
        public DlgCustom()
        {
            InitializeComponent();
        }
        public string CustText
        {
            get => this.txtCustomText.Text;
            set => this.txtCustomText.Text = value;
        }
        private void DlgCustom_Load(object sender, EventArgs e)
        {

        }
    }
}
