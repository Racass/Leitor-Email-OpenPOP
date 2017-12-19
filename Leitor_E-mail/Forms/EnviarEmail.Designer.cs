namespace Leitor_E_mail.Forms
{
    partial class EnviarEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.De = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.para = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Assunto = new System.Windows.Forms.TextBox();
            this.Anexo = new System.Windows.Forms.Button();
            this.Arquivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(12, 12);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(236, 324);
            this.texto.TabIndex = 0;
            this.texto.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(254, 313);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 1;
            this.send.Text = "Enviar";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(335, 313);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // De
            // 
            this.De.Location = new System.Drawing.Point(310, 12);
            this.De.Name = "De";
            this.De.ReadOnly = true;
            this.De.Size = new System.Drawing.Size(100, 20);
            this.De.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Para:";
            // 
            // para
            // 
            this.para.Location = new System.Drawing.Point(310, 38);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(100, 20);
            this.para.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Assunto";
            // 
            // Assunto
            // 
            this.Assunto.Location = new System.Drawing.Point(310, 64);
            this.Assunto.Name = "Assunto";
            this.Assunto.Size = new System.Drawing.Size(100, 20);
            this.Assunto.TabIndex = 7;
            // 
            // Anexo
            // 
            this.Anexo.Location = new System.Drawing.Point(272, 90);
            this.Anexo.Name = "Anexo";
            this.Anexo.Size = new System.Drawing.Size(138, 23);
            this.Anexo.TabIndex = 9;
            this.Anexo.Text = "Anexo";
            this.Anexo.UseVisualStyleBackColor = true;
            this.Anexo.Click += new System.EventHandler(this.Anexo_Click);
            // 
            // Arquivo
            // 
            this.Arquivo.FileName = "openFileDialog1";
            // 
            // EnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 348);
            this.Controls.Add(this.Anexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Assunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.para);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.De);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.send);
            this.Controls.Add(this.texto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnviarEmail";
            this.Text = "EnviarEmail";
            this.Load += new System.EventHandler(this.EnviarEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox De;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox para;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Assunto;
        private System.Windows.Forms.Button Anexo;
        private System.Windows.Forms.OpenFileDialog Arquivo;
    }
}