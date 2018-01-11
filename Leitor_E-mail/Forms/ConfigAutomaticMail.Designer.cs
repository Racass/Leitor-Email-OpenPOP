namespace Leitor_E_mail.Forms
{
    partial class ConfigAutomaticMail
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
            this.sair = new System.Windows.Forms.Button();
            this.conteudo = new System.Windows.Forms.RichTextBox();
            this.Anexo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Assunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.para = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.sair.FlatAppearance.BorderSize = 0;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.ForeColor = System.Drawing.Color.Red;
            this.sair.Location = new System.Drawing.Point(383, 5);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(28, 23);
            this.sair.TabIndex = 19;
            this.sair.Text = "X";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // conteudo
            // 
            this.conteudo.Location = new System.Drawing.Point(12, 36);
            this.conteudo.Name = "conteudo";
            this.conteudo.Size = new System.Drawing.Size(240, 367);
            this.conteudo.TabIndex = 20;
            this.conteudo.Text = "";
            // 
            // Anexo
            // 
            this.Anexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Anexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anexo.Location = new System.Drawing.Point(258, 137);
            this.Anexo.Name = "Anexo";
            this.Anexo.Size = new System.Drawing.Size(153, 23);
            this.Anexo.TabIndex = 35;
            this.Anexo.Text = "Anexar";
            this.Anexo.UseVisualStyleBackColor = true;
            this.Anexo.Click += new System.EventHandler(this.Anexo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Assunto";
            // 
            // Assunto
            // 
            this.Assunto.Location = new System.Drawing.Point(311, 105);
            this.Assunto.Name = "Assunto";
            this.Assunto.Size = new System.Drawing.Size(100, 20);
            this.Assunto.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Para:";
            // 
            // para
            // 
            this.para.Location = new System.Drawing.Point(311, 79);
            this.para.Name = "para";
            this.para.Size = new System.Drawing.Size(100, 20);
            this.para.TabIndex = 36;
            // 
            // send
            // 
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.send.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(258, 380);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(153, 23);
            this.send.TabIndex = 40;
            this.send.Text = "Salvar";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Conteúdo";
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(332, 168);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(79, 20);
            this.TimePicker.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Horario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(254, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "O programa precisa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(258, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "estar rodando para";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(271, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "enviar o e-mail.";
            // 
            // ConfigAutomaticMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(417, 415);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Assunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.para);
            this.Controls.Add(this.Anexo);
            this.Controls.Add(this.conteudo);
            this.Controls.Add(this.sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigAutomaticMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfigAutomaticMail";
            this.Load += new System.EventHandler(this.ConfigAutomaticMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.RichTextBox conteudo;
        private System.Windows.Forms.Button Anexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Assunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox para;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}