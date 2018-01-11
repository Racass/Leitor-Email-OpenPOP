namespace Leitor_E_mail.Forms
{
    partial class StdMail
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
            this.conteudo = new System.Windows.Forms.RichTextBox();
            this.Anexo = new System.Windows.Forms.Button();
            this.assunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Arquivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // conteudo
            // 
            this.conteudo.Location = new System.Drawing.Point(12, 81);
            this.conteudo.Name = "conteudo";
            this.conteudo.Size = new System.Drawing.Size(429, 284);
            this.conteudo.TabIndex = 0;
            this.conteudo.Text = "";
            // 
            // Anexo
            // 
            this.Anexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Anexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anexo.Location = new System.Drawing.Point(12, 52);
            this.Anexo.Name = "Anexo";
            this.Anexo.Size = new System.Drawing.Size(156, 23);
            this.Anexo.TabIndex = 35;
            this.Anexo.Text = "Anexar";
            this.Anexo.UseVisualStyleBackColor = true;
            this.Anexo.Click += new System.EventHandler(this.Anexo_Click);
            // 
            // assunto
            // 
            this.assunto.Location = new System.Drawing.Point(12, 26);
            this.assunto.Name = "assunto";
            this.assunto.Size = new System.Drawing.Size(156, 20);
            this.assunto.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Assunto";
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
            this.Cancel.Location = new System.Drawing.Point(413, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(28, 23);
            this.Cancel.TabIndex = 38;
            this.Cancel.Text = "X";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(285, 52);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(156, 23);
            this.save.TabIndex = 39;
            this.save.Text = "Salvar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Arquivo
            // 
            this.Arquivo.FileName = "openFileDialog1";
            // 
            // StdMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(453, 377);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assunto);
            this.Controls.Add(this.Anexo);
            this.Controls.Add(this.conteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StdMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StdMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox conteudo;
        private System.Windows.Forms.Button Anexo;
        private System.Windows.Forms.TextBox assunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.OpenFileDialog Arquivo;
    }
}