namespace Leitor_E_mail.Forms
{
    partial class Email
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
            this.label1 = new System.Windows.Forms.Label();
            this.deText = new System.Windows.Forms.TextBox();
            this.assunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conteudo
            // 
            this.conteudo.Location = new System.Drawing.Point(12, 88);
            this.conteudo.Name = "conteudo";
            this.conteudo.Size = new System.Drawing.Size(414, 364);
            this.conteudo.TabIndex = 0;
            this.conteudo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De:";
            // 
            // deText
            // 
            this.deText.Enabled = false;
            this.deText.Location = new System.Drawing.Point(58, 7);
            this.deText.Name = "deText";
            this.deText.Size = new System.Drawing.Size(100, 20);
            this.deText.TabIndex = 3;
            // 
            // assunto
            // 
            this.assunto.Enabled = false;
            this.assunto.Location = new System.Drawing.Point(58, 33);
            this.assunto.Name = "assunto";
            this.assunto.Size = new System.Drawing.Size(100, 20);
            this.assunto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assunto:";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(406, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 23);
            this.close.TabIndex = 21;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(438, 464);
            this.Controls.Add(this.close);
            this.Controls.Add(this.assunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox conteudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deText;
        private System.Windows.Forms.TextBox assunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
    }
}