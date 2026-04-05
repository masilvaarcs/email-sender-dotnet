//using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace EnviarEmail
{
    public partial class FrmEnviarEmail : Form
    {
        private DialogResult confirma;

        public FrmEnviarEmail()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }

        private void EnviarEmail()
        {
            this.Cursor = Cursors.WaitCursor;

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("seu_email@gmail.com", "sua_senha_de_app"); // Configure suas credenciais SMTP

            MailMessage mail = new MailMessage
            {
                Sender = new System.Net.Mail.MailAddress("masilva.arcs@gmail.com", "ENCODE-Enviador de E-mails"),
                From = new MailAddress(txtRemetente.Text.Trim(),  "Encode Soluções")
            };
            //Quebra o Destinatário para enviar para múltiplos
            var destinatarios = txtDestinatario.Text.Trim().Split(';');
            for (int i = 0; i < destinatarios.Count(); i++)
            {
                mail.To.Add(new MailAddress(destinatarios[i], "Destinatário"));

            }
            //mail.To.Add(new MailAddress(txtDestinatario.Text.Trim(), "Destinatário"));

            mail.Subject = txtAssunto.Text.Trim();

            mail.Body = txtMensagem.Text.Trim();

            if (LstAnexos.Items.Count > 0)
            {
                try
                {
                    for (int i = 0; i < LstAnexos.Items.Count; i++)
                    {
                        mail.Attachments.Add(new Attachment(LstAnexos.Items[i].ToString()));
                    }
                    //mail.Attachments.Add(new Attachment(LstAnexos.Text));
                }
                catch (System.Exception erro)
                {

                    MessageBox.Show("Erro ao anexar o arquivo ( " + erro.Source + " - " + erro.Message + ")",
                                    "Erro para enviar o e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnEnviar.Enabled = true;
                    return;
                }
            }

            mail.IsBodyHtml = false;
            mail.Priority = MailPriority.High;

            DialogResult confirmarEnvio = MessageBox.Show("O e-mail será enviado... Confirma?", "Envio de E-mail", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (confirmarEnvio == DialogResult.No)
            {
                return;
            }
            
            try
            {
                this.Cursor = Cursors.WaitCursor;
                client.Send(mail);
            }
            catch (System.Exception erro)
            {
                //trata erro
                MessageBox.Show("Erro ao conectar e enviar o e-mail ( " + erro.Source + " - " + erro.Message + ")",
                                "Erro enviando e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnEnviar.Enabled = true;
                return;
            }
            finally
            {
                MessageBox.Show("E-mail enviado com Sucesso!", "Envio de E-mails", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnEnviar.Enabled=false;
                this.Cursor = Cursors.Default;
                LimparCampos();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {

            DialogResult limparCampos;
            if (BtnEnviar.Enabled)
            {
                limparCampos = MessageBox.Show("Todos os campos serão reiniciados, confirma?", "Limpeza de Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                limparCampos = DialogResult.Yes;
            }

            if (limparCampos == DialogResult.Yes)
            {
                txtRemetente.Text = string.Empty;
                txtDestinatario.Text = string.Empty;
                txtAssunto.Text = string.Empty;
                txtMensagem.Text = string.Empty;
                LstAnexos.Items.Clear();
                //
                if (PicboxPreview.Image != null)
                {
                    PicboxPreview.Image.Dispose();
                    PicboxPreview.Image = null;
                }
                PicboxPreview.Image = Properties.Resources.img_indisponivel;
                //
                BtnEnviar.Enabled = true;
                txtRemetente.Focus();
            }
        }

        private void lblCaminhoNomeArquivo_Click(object sender, EventArgs e)
        {
            SelecionaAnexos();

        }

        private void SelecionaAnexos()
        {
            OpenFileDialog dgAnexos = new OpenFileDialog()
            {
                InitialDirectory = "C:\\",
                Multiselect = true,
                Title = "Anexar arquivos"
            };

            if (dgAnexos.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dgAnexos.FileNames.Count(); i++)
                {
                    LstAnexos.Items.Add(dgAnexos.FileNames[i]);
                }
                LstAnexos.Refresh();
            }
        }

        private void FrmEnviarEmail_Load(object sender, EventArgs e)
        {
            /* - Inicialmente foi criado para facilitar o envio de e-mails com o meu currículo para as agências de emprego. 
             * Daí seria era uma vantagem guardar o caminho e nome do arquivo para não precisar ficar sempre selecionando. -
             * 
            lblCaminhoNomeArquivo.Text = Properties.Settings.Default.caminhoArq;
            */
        }

        private void LstAnexos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (true) {
            //    MessageBox.Show("KeyPress");
            //}
        }

        private void LstAnexos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (LstAnexos.SelectedIndex >= 0)
                {
                    string pathReduzido = "..." + LstAnexos.SelectedItem.ToString().Trim();
                    if (LstAnexos.SelectedItem.ToString().Trim().Length - 30 > 0) {
                        pathReduzido = "..." + LstAnexos.SelectedItem.ToString().Trim().Substring(LstAnexos.SelectedItem.ToString().Trim().Length - 30);
                    }else if (LstAnexos.SelectedItem.ToString().Length - 25 > 0) {
                        pathReduzido = "..." + LstAnexos.SelectedItem.ToString().Trim().Substring(LstAnexos.SelectedItem.ToString().Trim().Length - 25); 
                    }else if (LstAnexos.SelectedItem.ToString().Length - 20 > 0) {
                        pathReduzido = "..." + LstAnexos.SelectedItem.ToString().Trim().Substring(LstAnexos.SelectedItem.ToString().Trim().Length - 20);
                    }              
                    confirma = MessageBox.Show("Esse anexo: \n\n[ " + pathReduzido + " ]\n\n Será excluído, Confirma ?", "Exclusão de anexo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (confirma == DialogResult.Yes)
                    {
                        LstAnexos.Items.RemoveAt(LstAnexos.SelectedIndex);
                        LstAnexos.Refresh();
                    }
                }
            }
        }

        private void BtnAnexos_Click(object sender, EventArgs e)
        {
            SelecionaAnexos();
        }

        private void LstAnexos_Click(object sender, EventArgs e)
        {
            AtualizaPreviewAnexo();
        }

        private void AtualizaPreviewAnexo()
        {
            try
            {
                if (LstAnexos.SelectedIndex >= 0) { 
                    PicboxPreview.Load(LstAnexos.SelectedItem.ToString().Trim());
                }
            }
            catch (Exception)
            {

                if (PicboxPreview.Image != null)
                {
                    PicboxPreview.Image.Dispose();
                    PicboxPreview.Image = null;
                }
                PicboxPreview.Image= Properties.Resources.img_indisponivel;
            }
        }

        private void LstAnexos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaPreviewAnexo();
        }

        private void LstAnexos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AtualizaPreviewAnexo();
        }
    }
}
