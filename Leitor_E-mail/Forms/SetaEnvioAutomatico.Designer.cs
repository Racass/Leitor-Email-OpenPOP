namespace Leitor_E_mail.Forms
{
    partial class SetaEnvioAutomatico
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
            this.TxtTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StdsChar = new System.Windows.Forms.ComboBox();
            this.carregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTempo
            // 
            this.TxtTempo.Location = new System.Drawing.Point(72, 12);
            this.TxtTempo.Name = "TxtTempo";
            this.TxtTempo.Size = new System.Drawing.Size(209, 20);
            this.TxtTempo.TabIndex = 0;
            this.TxtTempo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo (s)";
            // 
            // StdsChar
            // 
            this.StdsChar.FormattingEnabled = true;
            this.StdsChar.Location = new System.Drawing.Point(12, 64);
            this.StdsChar.Name = "StdsChar";
            this.StdsChar.Size = new System.Drawing.Size(269, 21);
            this.StdsChar.TabIndex = 39;
            // 
            // carregar
            // 
            this.carregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.carregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carregar.Location = new System.Drawing.Point(12, 91);
            this.carregar.Name = "carregar";
            this.carregar.Size = new System.Drawing.Size(269, 23);
            this.carregar.TabIndex = 40;
            this.carregar.Text = "CarregarEmail";
            this.carregar.UseVisualStyleBackColor = true;
            this.carregar.Click += new System.EventHandler(this.carregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nome";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(72, 38);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(209, 20);
            this.nome.TabIndex = 41;
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
            this.close.Location = new System.Drawing.Point(12, 120);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 23);
            this.close.TabIndex = 43;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // SetaEnvioAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.carregar);
            this.Controls.Add(this.StdsChar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetaEnvioAutomatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SetaEnvioAutomatico";
            this.Load += new System.EventHandler(this.SetaEnvioAutomatico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StdsChar;
        private System.Windows.Forms.Button carregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Button close;
    }
}