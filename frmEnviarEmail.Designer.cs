
namespace EnviarEmail
{
    partial class FrmEnviarEmail
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlFundo = new System.Windows.Forms.Panel();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblRemetente = new System.Windows.Forms.Label();
            this.PicboxPreview = new System.Windows.Forms.PictureBox();
            this.BtnAnexos = new System.Windows.Forms.Button();
            this.LstAnexos = new System.Windows.Forms.ListBox();
            this.PnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlFundo
            // 
            this.PnlFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PnlFundo.Controls.Add(this.BtnAnexos);
            this.PnlFundo.Controls.Add(this.LstAnexos);
            this.PnlFundo.Controls.Add(this.PicboxPreview);
            this.PnlFundo.Controls.Add(this.BtnLimpar);
            this.PnlFundo.Controls.Add(this.BtnEnviar);
            this.PnlFundo.Controls.Add(this.txtMensagem);
            this.PnlFundo.Controls.Add(this.txtAssunto);
            this.PnlFundo.Controls.Add(this.txtDestinatario);
            this.PnlFundo.Controls.Add(this.txtRemetente);
            this.PnlFundo.Controls.Add(this.lblMensagem);
            this.PnlFundo.Controls.Add(this.lblAssunto);
            this.PnlFundo.Controls.Add(this.lblDestinatario);
            this.PnlFundo.Controls.Add(this.lblRemetente);
            this.PnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFundo.Location = new System.Drawing.Point(0, 0);
            this.PnlFundo.Name = "PnlFundo";
            this.PnlFundo.Size = new System.Drawing.Size(512, 512);
            this.PnlFundo.TabIndex = 0;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(67, 484);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(58, 25);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.Location = new System.Drawing.Point(3, 484);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(58, 25);
            this.BtnEnviar.TabIndex = 4;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.SystemColors.Info;
            this.txtMensagem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtMensagem.Location = new System.Drawing.Point(9, 197);
            this.txtMensagem.MaxLength = 5000;
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagem.Size = new System.Drawing.Size(495, 120);
            this.txtMensagem.TabIndex = 3;
            // 
            // txtAssunto
            // 
            this.txtAssunto.BackColor = System.Drawing.SystemColors.Info;
            this.txtAssunto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtAssunto.Location = new System.Drawing.Point(9, 141);
            this.txtAssunto.MaxLength = 250;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(495, 26);
            this.txtAssunto.TabIndex = 2;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.BackColor = System.Drawing.SystemColors.Info;
            this.txtDestinatario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtDestinatario.Location = new System.Drawing.Point(9, 83);
            this.txtDestinatario.MaxLength = 250;
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(293, 26);
            this.txtDestinatario.TabIndex = 1;
            // 
            // txtRemetente
            // 
            this.txtRemetente.BackColor = System.Drawing.SystemColors.Info;
            this.txtRemetente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtRemetente.Location = new System.Drawing.Point(9, 31);
            this.txtRemetente.MaxLength = 250;
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(293, 26);
            this.txtRemetente.TabIndex = 0;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(9, 175);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(71, 19);
            this.lblMensagem.TabIndex = 8;
            this.lblMensagem.Text = "Mensagem";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAssunto.Location = new System.Drawing.Point(9, 119);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(58, 19);
            this.lblAssunto.TabIndex = 7;
            this.lblAssunto.Text = "Assunto";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDestinatario.Location = new System.Drawing.Point(9, 61);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(85, 19);
            this.lblDestinatario.TabIndex = 6;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemetente.Location = new System.Drawing.Point(9, 9);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(74, 19);
            this.lblRemetente.TabIndex = 5;
            this.lblRemetente.Text = "Remetente";
            // 
            // PicboxPreview
            // 
            this.PicboxPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicboxPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicboxPreview.ErrorImage = global::EnviarEmail.Properties.Resources.img_indisponivel;
            this.PicboxPreview.Image = global::EnviarEmail.Properties.Resources.img_indisponivel;
            this.PicboxPreview.Location = new System.Drawing.Point(308, 9);
            this.PicboxPreview.Name = "PicboxPreview";
            this.PicboxPreview.Size = new System.Drawing.Size(196, 129);
            this.PicboxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicboxPreview.TabIndex = 12;
            this.PicboxPreview.TabStop = false;
            // 
            // BtnAnexos
            // 
            this.BtnAnexos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnexos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAnexos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnexos.Location = new System.Drawing.Point(9, 323);
            this.BtnAnexos.Name = "BtnAnexos";
            this.BtnAnexos.Size = new System.Drawing.Size(26, 154);
            this.BtnAnexos.TabIndex = 13;
            this.BtnAnexos.Text = "A\r\nN\r\nE\r\nX\r\nO\r\nS";
            this.BtnAnexos.UseVisualStyleBackColor = true;
            this.BtnAnexos.Click += new System.EventHandler(this.BtnAnexos_Click);
            // 
            // LstAnexos
            // 
            this.LstAnexos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LstAnexos.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstAnexos.FormattingEnabled = true;
            this.LstAnexos.ItemHeight = 15;
            this.LstAnexos.Location = new System.Drawing.Point(35, 323);
            this.LstAnexos.Name = "LstAnexos";
            this.LstAnexos.Size = new System.Drawing.Size(469, 154);
            this.LstAnexos.TabIndex = 14;
            this.LstAnexos.Click += new System.EventHandler(this.LstAnexos_Click);
            this.LstAnexos.SelectedIndexChanged += new System.EventHandler(this.LstAnexos_SelectedIndexChanged_1);
            // 
            // FrmEnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.PnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnviarEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar E-mail";
            this.Load += new System.EventHandler(this.FrmEnviarEmail_Load);
            this.PnlFundo.ResumeLayout(false);
            this.PnlFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFundo;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.PictureBox PicboxPreview;
        private System.Windows.Forms.Button BtnAnexos;
        private System.Windows.Forms.ListBox LstAnexos;
    }
}

