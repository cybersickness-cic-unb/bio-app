using BC.Data;
using System;
using System.IO;
using System.Windows.Forms;
using BC.Resources;
using BC.Dal.Business;
using BC.Dal.Entity;

namespace BC.Forms
{
    public partial class FrmConvertGameDataWeka : Form
    {
        private Translator obTranslator;
        private BConfig bConfig = new BConfig();
        protected Config eConfig = new Config();
        public FrmConvertGameDataWeka()
        {
            InitializeComponent();

            this.Width =584;
            this.Height = 244;

            eConfig = bConfig.GetConfig();
            obTranslator = new Translator(this.Controls, eConfig.Language);
            this.Text = obTranslator.GetTranslation("FrmConvertGameDataWeka");
            
        }


        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            // Select the root directory
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the root directory";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                txtSelectDirectory.Text = folderBrowserDialog.SelectedPath;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       
        private async void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string rootDirectory = txtSelectDirectory.Text;
                if (!String.IsNullOrEmpty(txtSelectDirectory.Text))
                {
                    // Instancia a classe ARFFConverter
                    ARFFConverter converter = new ARFFConverter();

                    // Configura a barra de progresso
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;

                    // Chama o método de conversão assíncrono
                    string strArffContent = await converter.ConvertXMLToARFF(rootDirectory, UpdateProgressBar);

                    // Conclui o processamento e atualiza a barra de progresso
                    progressBar.Value = progressBar.Maximum;

                    // Salva o arquivo ARFF
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "ARFF Files|*.arff";
                    saveFileDialog.Title = obTranslator.GetTranslation("saveFileDialog.Title");
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, strArffContent);
                        MessageBox.Show(obTranslator.GetTranslation("saveFileDialogSuccess"), obTranslator.GetTranslation("titleMsgSuccess"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show(obTranslator.GetTranslation("ConversionCompletedSuccess"), obTranslator.GetTranslation("titleMsgSuccess"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(obTranslator.GetTranslation("msgErrorConvertData")+": " + ex.Message, obTranslator.GetTranslation("titleMsgError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar()
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.BeginInvoke(new Action(UpdateProgressBar));
            }
            else
            {
                progressBar.Value++;
            }
        }

    }
}
