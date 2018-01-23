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
            this.De = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.para = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Assunto = new System.Windows.Forms.TextBox();
            this.Arquivo = new System.Windows.Forms.OpenFileDialog();
            this.Cancel = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.Anexo = new System.Windows.Forms.Button();
            this.carregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.qtdanexos = new System.Windows.Forms.TextBox();
            this.StdsChar = new System.Windows.Forms.ComboBox();
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
            // De
            // 
            this.De.Location = new System.Drawing.Point(310, 32);
            this.De.Name = "De";
            this.De.ReadOnly = true;
            this.De.Size = new System.Drawing.Size(100, 20);
            this.De.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Para:";
            // 
            // para
            // 
            this.para.Location = new System.Drawing.Point(310, 58);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(100, 20);
            this.para.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Assunto";
            // 
            // Assunto
            // 
            this.Assunto.Location = new System.Drawing.Point(310, 84);
            this.Assunto.Name = "Assunto";
            this.Assunto.Size = new System.Drawing.Size(100, 20);
            this.Assunto.TabIndex = 7;
            // 
            // Arquivo
            // 
            this.Arquivo.FileName = "openFileDialog1";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Red;
            this.Cancel.Location = new System.Drawing.Point(382, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(28, 23);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "X";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // send
            // 
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(254, 313);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(156, 23);
            this.send.TabIndex = 33;
            this.send.Text = "Enviar";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Anexo
            // 
            this.Anexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Anexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anexo.Location = new System.Drawing.Point(254, 136);
            this.Anexo.Name = "Anexo";
            this.Anexo.Size = new System.Drawing.Size(156, 23);
            this.Anexo.TabIndex = 34;
            this.Anexo.Text = "Anexar";
            this.Anexo.UseVisualStyleBackColor = true;
            this.Anexo.Click += new System.EventHandler(this.Anexo_Click);
            // 
            // carregar
            // 
            this.carregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.carregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carregar.Location = new System.Drawing.Point(254, 195);
            this.carregar.Name = "carregar";
            this.carregar.Size = new System.Drawing.Size(156, 23);
            this.carregar.TabIndex = 35;
            this.carregar.Text = "CarregarEmail";
            this.carregar.UseVisualStyleBackColor = true;
            this.carregar.Click += new System.EventHandler(this.carregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Anexos:";
            // 
            // qtdanexos
            // 
            this.qtdanexos.Enabled = false;
            this.qtdanexos.Location = new System.Drawing.Point(310, 110);
            this.qtdanexos.Name = "qtdanexos";
            this.qtdanexos.Size = new System.Drawing.Size(100, 20);
            this.qtdanexos.TabIndex = 36;
            // 
            // StdsChar
            // 
            this.StdsChar.FormattingEnabled = true;
            this.StdsChar.Location = new System.Drawing.Point(254, 165);
            this.StdsChar.Name = "StdsChar";
            this.StdsChar.Size = new System.Drawing.Size(156, 21);
            this.StdsChar.TabIndex = 38;
            // 
            // EnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(422, 348);
            this.Controls.Add(this.StdsChar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qtdanexos);
            this.Controls.Add(this.carregar);
            this.Controls.Add(this.Anexo);
            this.Controls.Add(this.send);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Assunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.para);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.De);
            this.Controls.Add(this.texto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnviarEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EnviarEmail";
            this.Load += new System.EventHandler(this.EnviarEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.TextBox De;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox para;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Assunto;
        private System.Windows.Forms.OpenFileDialog Arquivo;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button Anexo;
        private System.Windows.Forms.Button carregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qtdanexos;
        private System.Windows.Forms.ComboBox StdsChar;
    }
}