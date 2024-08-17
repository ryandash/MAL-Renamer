using System;
using System.Windows.Forms;

namespace MALRenamer
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class Form_Loading : Form
    {
        public Form_Loading()
        {
            InitializeComponent();
        }

        private void Form_Loading_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.CenterToParent();
        }
    }
}
