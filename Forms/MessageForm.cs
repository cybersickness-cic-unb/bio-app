using System.Windows.Forms;

namespace BC.Forms
{
    class MessageForm : Form
    {

        /// <summary>
        /// Mostra mensagem no Sistema 
        /// </summary>
        /// <param name="str_msg"></param>
        /// <param name="tipo"></param>
        /// <param name="str_titulo"></param>
        /// <returns></returns>
        public DialogResult ShowMessage(string Msg, string Type, string Title= "")
        {
            DialogResult response;
            

            if (Type == "EXCLAMATION")
                response = MessageBox.Show(Msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (Type == "INFORMATION")
                response = MessageBox.Show(Msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else if (Type == "ERROR")
                response = MessageBox.Show(Msg, Title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else if (Type == "SIMPLE")
                response = MessageBox.Show(Msg);
            else if (Type == "QUESTION")
                response = MessageBox.Show(Msg, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                response = DialogResult.None;

            return response;
        }
    }

}
