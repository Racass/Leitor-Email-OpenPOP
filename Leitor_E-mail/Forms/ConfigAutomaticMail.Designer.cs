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
            this.init = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carregados = new System.Windows.Forms.RichTextBox();
            this.carg = new System.Windows.Forms.Button();
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
            this.sair.Location = new System.Drawing.Point(367, 4);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(28, 23);
            this.sair.TabIndex = 19;
            this.sair.Text = "X";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // init
            // 
            this.init.Cursor = System.Windows.Forms.Cursors.Hand;
            this.init.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.init.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init.Location = new System.Drawing.Point(3, 380);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(384, 23);
            this.init.TabIndex = 40;
            this.init.Text = "Iniciar";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "O programa precisa estar rodando para";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "enviar os e-mails.";
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(57, 60);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(221, 21);
            this.combo.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Email:";
            // 
            // carregados
            // 
            this.carregados.Location = new System.Drawing.Point(12, 87);
            this.carregados.Name = "carregados";
            this.carregados.Size = new System.Drawing.Size(375, 276);
            this.carregados.TabIndex = 49;
            this.carregados.Text = "";
            // 
            // carg
            // 
            this.carg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.carg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carg.Location = new System.Drawing.Point(284, 60);
            this.carg.Name = "carg";
            this.carg.Size = new System.Drawing.Size(103, 21);
            this.carg.TabIndex = 50;
            this.carg.Text = "Carregar";
            this.carg.UseVisualStyleBackColor = true;
            this.carg.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfigAutomaticMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(397, 415);
            this.Controls.Add(this.carg);
            this.Controls.Add(this.carregados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.init);
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
        private System.Windows.Forms.Button init;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox carregados;
        private System.Windows.Forms.Button carg;
    }
}