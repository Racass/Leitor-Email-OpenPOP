namespace Leitor_E_mail
{
    partial class Principal
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
            this.email = new System.Windows.Forms.TextBox();
            this.NEmail = new System.Windows.Forms.Button();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.senha = new System.Windows.Forms.TextBox();
            this.Arquivo = new System.Windows.Forms.OpenFileDialog();
            this.sair = new System.Windows.Forms.Button();
            this.emailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Qtd = new System.Windows.Forms.TextBox();
            this.Remind = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Ler
            // 
            this.Ler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ler.Enabled = false;
            this.Ler.FlatAppearance.BorderSize = 2;
            this.Ler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ler.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ler.Location = new System.Drawing.Point(12, 12);
            this.Ler.Name = "Ler";
            this.Ler.Size = new System.Drawing.Size(114, 23);
            this.Ler.TabIndex = 0;
            this.Ler.Text = "Att";
            this.Ler.UseVisualStyleBackColor = false;
            this.Ler.Click += new System.EventHandler(this.Ler_Click);
            // 
            // emailsListBox
            // 
            this.emailsListBox.FormattingEnabled = true;
            this.emailsListBox.Location = new System.Drawing.Point(12, 46);
            this.emailsListBox.Name = "emailsListBox";
            this.emailsListBox.Size = new System.Drawing.Size(114, 303);
            this.emailsListBox.TabIndex = 1;
            this.emailsListBox.DoubleClick += new System.EventHandler(this.emailsListBox_DoubleClick);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(132, 47);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(158, 20);
            this.email.TabIndex = 3;
            // 
            // NEmail
            // 
            this.NEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NEmail.Enabled = false;
            this.NEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEmail.Location = new System.Drawing.Point(132, 128);
            this.NEmail.Name = "NEmail";
            this.NEmail.Size = new System.Drawing.Size(211, 23);
            this.NEmail.TabIndex = 7;
            this.NEmail.Text = "Novo Email";
            this.NEmail.UseVisualStyleBackColor = true;
            this.NEmail.Click += new System.EventHandler(this.NEmail_Click);
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(170, 15);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(180, 20);
            this.progresso.TabIndex = 11;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(132, 73);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(158, 20);
            this.senha.TabIndex = 12;
            // 
            // Arquivo
            // 
            this.Arquivo.FileName = "openFileDialog1";
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
            this.sair.Location = new System.Drawing.Point(12, 352);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(28, 23);
            this.sair.TabIndex = 18;
            this.sair.Text = "X";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect.FlatAppearance.BorderSize = 2;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Location = new System.Drawing.Point(132, 99);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(114, 23);
            this.Connect.TabIndex = 19;
            this.Connect.Text = "Conectar";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email";
            // 
            // Qtd
            // 
            this.Qtd.Location = new System.Drawing.Point(132, 15);
            this.Qtd.Name = "Qtd";
            this.Qtd.Size = new System.Drawing.Size(31, 20);
            this.Qtd.TabIndex = 22;
            this.Qtd.Text = "10";
            // 
            // Remind
            // 
            this.Remind.AutoSize = true;
            this.Remind.Location = new System.Drawing.Point(252, 103);
            this.Remind.Name = "Remind";
            this.Remind.Size = new System.Drawing.Size(64, 17);
            this.Remind.TabIndex = 23;
            this.Remind.Text = "Lembrar";
            this.Remind.UseVisualStyleBackColor = true;
            this.Remind.CheckedChanged += new System.EventHandler(this.Remind_CheckedChanged);
            // 
            // Principal
            // 
            this.AcceptButton = this.NEmail;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(359, 387);
            this.Controls.Add(this.Remind);
            this.Controls.Add(this.Qtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.NEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.emailsListBox);
            this.Controls.Add(this.Ler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox emailsListBox;
        private System.Windows.Forms.BindingSource emailsBindingSource;
        private System.Windows.Forms.Button NEmail;
        private System.Windows.Forms.OpenFileDialog Arquivo;
        private System.Windows.Forms.Button sair;
        public System.Windows.Forms.ProgressBar progresso;
        public System.Windows.Forms.Button Ler;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox senha;
        public System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Qtd;
        private System.Windows.Forms.CheckBox Remind;
    }
}

