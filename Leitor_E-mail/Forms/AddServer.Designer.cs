namespace Leitor_E_mail.Forms
{
    partial class AddServer
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
            this.Server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ssl = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lSMTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pSMTP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lPOP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pPOP = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
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
            this.sair.Location = new System.Drawing.Point(278, 4);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(28, 23);
            this.sair.TabIndex = 19;
            this.sair.Text = "X";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(76, 46);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(144, 20);
            this.Server.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Server";
            // 
            // ssl
            // 
            this.ssl.AutoSize = true;
            this.ssl.Location = new System.Drawing.Point(238, 49);
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(68, 17);
            this.ssl.TabIndex = 22;
            this.ssl.Text = "Usa SSL";
            this.ssl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Configurar Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Link SMTP";
            // 
            // lSMTP
            // 
            this.lSMTP.Location = new System.Drawing.Point(76, 72);
            this.lSMTP.Name = "lSMTP";
            this.lSMTP.Size = new System.Drawing.Size(144, 20);
            this.lSMTP.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Porta SMTP";
            // 
            // pSMTP
            // 
            this.pSMTP.Location = new System.Drawing.Point(76, 97);
            this.pSMTP.Name = "pSMTP";
            this.pSMTP.Size = new System.Drawing.Size(144, 20);
            this.pSMTP.TabIndex = 26;
            this.pSMTP.TextChanged += new System.EventHandler(this.pSMTP_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Link POP";
            // 
            // lPOP
            // 
            this.lPOP.Location = new System.Drawing.Point(76, 123);
            this.lPOP.Name = "lPOP";
            this.lPOP.Size = new System.Drawing.Size(144, 20);
            this.lPOP.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Porta POP";
            // 
            // pPOP
            // 
            this.pPOP.Location = new System.Drawing.Point(76, 149);
            this.pPOP.Name = "pPOP";
            this.pPOP.Size = new System.Drawing.Size(144, 20);
            this.pPOP.TabIndex = 30;
            this.pPOP.TextChanged += new System.EventHandler(this.pPOP_TextChanged);
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Enabled = false;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(8, 175);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(291, 23);
            this.Save.TabIndex = 32;
            this.Save.Text = "Salvar";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(311, 209);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pPOP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lPOP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pSMTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lSMTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ssl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ssl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lSMTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pSMTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lPOP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pPOP;
        private System.Windows.Forms.Button Save;
    }
}