﻿namespace Leitor_E_mail
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
            this.components = new System.ComponentModel.Container();
            this.Ler = new System.Windows.Forms.Button();
            this.emailsListBox = new System.Windows.Forms.ListBox();
            this.deTextBox = new System.Windows.Forms.TextBox();
            this.paraTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conteudoTextBox = new System.Windows.Forms.RichTextBox();
            this.NEmail = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.assunto = new System.Windows.Forms.TextBox();
            this.Qtd = new System.Windows.Forms.TextBox();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.senha = new System.Windows.Forms.TextBox();
            this.pop = new System.Windows.Forms.TextBox();
            this.portaPP = new System.Windows.Forms.TextBox();
            this.portaSMTP = new System.Windows.Forms.TextBox();
            this.smtp = new System.Windows.Forms.TextBox();
            this.Arquivo = new System.Windows.Forms.OpenFileDialog();
            this.anexo = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Min = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.enviarEmail = new System.Windows.Forms.RichTextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.conte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Ler
            // 
            this.Ler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ler.FlatAppearance.BorderSize = 2;
            this.Ler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ler.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ler.Location = new System.Drawing.Point(8, 30);
            this.Ler.Name = "Ler";
            this.Ler.Size = new System.Drawing.Size(67, 23);
            this.Ler.TabIndex = 0;
            this.Ler.Text = "Att";
            this.Ler.UseVisualStyleBackColor = false;
            this.Ler.Click += new System.EventHandler(this.Ler_Click);
            // 
            // emailsListBox
            // 
            this.emailsListBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.emailsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailsListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.emailsListBox.FormattingEnabled = true;
            this.emailsListBox.Location = new System.Drawing.Point(12, 59);
            this.emailsListBox.Name = "emailsListBox";
            this.emailsListBox.Size = new System.Drawing.Size(114, 288);
            this.emailsListBox.TabIndex = 1;
            // 
            // deTextBox
            // 
            this.deTextBox.Location = new System.Drawing.Point(132, 7);
            this.deTextBox.Name = "deTextBox";
            this.deTextBox.Size = new System.Drawing.Size(107, 20);
            this.deTextBox.TabIndex = 2;
            // 
            // paraTextBox
            // 
            this.paraTextBox.Location = new System.Drawing.Point(245, 7);
            this.paraTextBox.Name = "paraTextBox";
            this.paraTextBox.Size = new System.Drawing.Size(158, 20);
            this.paraTextBox.TabIndex = 3;
            this.paraTextBox.Text = "rcassiolato@outlook.com";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataDateTimePicker.Enabled = false;
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(694, 7);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.dataDateTimePicker.TabIndex = 5;
            // 
            // conteudoTextBox
            // 
            this.conteudoTextBox.Location = new System.Drawing.Point(132, 59);
            this.conteudoTextBox.Name = "conteudoTextBox";
            this.conteudoTextBox.Size = new System.Drawing.Size(516, 290);
            this.conteudoTextBox.TabIndex = 6;
            this.conteudoTextBox.Text = "";
            // 
            // NEmail
            // 
            this.NEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEmail.Location = new System.Drawing.Point(8, 1);
            this.NEmail.Name = "NEmail";
            this.NEmail.Size = new System.Drawing.Size(69, 23);
            this.NEmail.TabIndex = 7;
            this.NEmail.Text = "Novo Email";
            this.NEmail.UseVisualStyleBackColor = true;
            this.NEmail.Click += new System.EventHandler(this.NEmail_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Location = new System.Drawing.Point(81, 30);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(45, 23);
            this.enter.TabIndex = 8;
            this.enter.Text = "Enviar";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // assunto
            // 
            this.assunto.Location = new System.Drawing.Point(133, 33);
            this.assunto.Name = "assunto";
            this.assunto.Size = new System.Drawing.Size(106, 20);
            this.assunto.TabIndex = 9;
            // 
            // Qtd
            // 
            this.Qtd.Location = new System.Drawing.Point(749, 33);
            this.Qtd.Name = "Qtd";
            this.Qtd.Size = new System.Drawing.Size(30, 20);
            this.Qtd.TabIndex = 10;
            this.Qtd.Text = "4";
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(245, 33);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(284, 20);
            this.progresso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progresso.TabIndex = 11;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(409, 7);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(120, 20);
            this.senha.TabIndex = 12;
            this.senha.Text = "rafael558471";
            // 
            // pop
            // 
            this.pop.Location = new System.Drawing.Point(535, 7);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(113, 20);
            this.pop.TabIndex = 13;
            this.pop.Text = "pop-mail.outlook.com";
            // 
            // portaPP
            // 
            this.portaPP.Location = new System.Drawing.Point(654, 7);
            this.portaPP.Name = "portaPP";
            this.portaPP.Size = new System.Drawing.Size(31, 20);
            this.portaPP.TabIndex = 14;
            this.portaPP.Text = "995";
            // 
            // portaSMTP
            // 
            this.portaSMTP.Location = new System.Drawing.Point(654, 32);
            this.portaSMTP.Name = "portaSMTP";
            this.portaSMTP.Size = new System.Drawing.Size(30, 20);
            this.portaSMTP.TabIndex = 15;
            this.portaSMTP.Text = "587";
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(535, 32);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(113, 20);
            this.smtp.TabIndex = 16;
            this.smtp.Text = "smtp-mail.outlook.com";
            // 
            // Arquivo
            // 
            this.Arquivo.FileName = "openFileDialog1";
            // 
            // anexo
            // 
            this.anexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anexo.Location = new System.Drawing.Point(81, 1);
            this.anexo.Name = "anexo";
            this.anexo.Size = new System.Drawing.Size(45, 23);
            this.anexo.TabIndex = 17;
            this.anexo.Text = "Anexo";
            this.anexo.UseVisualStyleBackColor = true;
            this.anexo.Click += new System.EventHandler(this.anexo_Click);
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
            this.sair.Location = new System.Drawing.Point(741, 355);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(28, 23);
            this.sair.TabIndex = 18;
            this.sair.Text = "X";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Min.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Min.FlatAppearance.BorderSize = 0;
            this.Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.ForeColor = System.Drawing.Color.Red;
            this.Min.Location = new System.Drawing.Point(707, 355);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(28, 23);
            this.Min.TabIndex = 19;
            this.Min.Text = "-";
            this.Min.UseVisualStyleBackColor = false;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(13, 362);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(0, 13);
            this.timer.TabIndex = 20;
            // 
            // enviarEmail
            // 
            this.enviarEmail.Location = new System.Drawing.Point(654, 59);
            this.enviarEmail.Name = "enviarEmail";
            this.enviarEmail.Size = new System.Drawing.Size(125, 290);
            this.enviarEmail.TabIndex = 21;
            this.enviarEmail.Text = "";
            this.enviarEmail.Visible = false;
            // 
            // Cancelar
            // 
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(690, 33);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(53, 23);
            this.Cancelar.TabIndex = 22;
            this.Cancelar.Text = "Cancel";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // conte
            // 
            this.conte.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.conte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conte.Location = new System.Drawing.Point(653, 365);
            this.conte.Name = "conte";
            this.conte.Size = new System.Drawing.Size(31, 13);
            this.conte.TabIndex = 23;
            this.conte.Text = "120";
            // 
            // Email
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(783, 387);
            this.Controls.Add(this.conte);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.enviarEmail);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.anexo);
            this.Controls.Add(this.smtp);
            this.Controls.Add(this.portaSMTP);
            this.Controls.Add(this.portaPP);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.Qtd);
            this.Controls.Add(this.assunto);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.NEmail);
            this.Controls.Add(this.conteudoTextBox);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.paraTextBox);
            this.Controls.Add(this.deTextBox);
            this.Controls.Add(this.emailsListBox);
            this.Controls.Add(this.Ler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.Text = "Email";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ler;
        private System.Windows.Forms.ListBox emailsListBox;
        private System.Windows.Forms.TextBox deTextBox;
        private System.Windows.Forms.TextBox paraTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.BindingSource emailsBindingSource;
        private System.Windows.Forms.RichTextBox conteudoTextBox;
        private System.Windows.Forms.Button NEmail;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox assunto;
        private System.Windows.Forms.TextBox Qtd;
        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox pop;
        private System.Windows.Forms.TextBox portaPP;
        private System.Windows.Forms.TextBox portaSMTP;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.OpenFileDialog Arquivo;
        private System.Windows.Forms.Button anexo;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.RichTextBox enviarEmail;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox conte;
    }
}

