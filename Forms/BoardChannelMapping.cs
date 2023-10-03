using BC.Dal.Business;
using BC.Dal.Entity;
using BC.Resources;
using System;
using System.Windows.Forms;

namespace BC.Forms
{
    public partial class FrmBoardChannelMapping : Form
    {
        private BConfig bConfig = new BConfig();
        protected Config eConfig = new Config();
        private Translator obTranslator;
        public FrmBoardChannelMapping()
        {
            InitializeComponent();
            this.Width = 930;
            this.Height = 650;
            eConfig = bConfig.GetConfig();
            obTranslator = new Translator(this.Controls, eConfig.Language);
            this.Text = obTranslator.GetTranslation("FrmBoardChannelMapping");

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
