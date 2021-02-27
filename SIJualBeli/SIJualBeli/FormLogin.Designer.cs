namespace SIJualBeli
{
    partial class FormLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkLabelPengaturan = new System.Windows.Forms.LinkLabel();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPengaturan = new System.Windows.Forms.Panel();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelPengaturan.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Navy;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(277, 168);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(161, 63);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Lavender;
            this.panelLogin.Controls.Add(this.linkLabelPengaturan);
            this.panelLogin.Controls.Add(this.buttonKeluar);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(6);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(677, 266);
            this.panelLogin.TabIndex = 12;
            // 
            // linkLabelPengaturan
            // 
            this.linkLabelPengaturan.AutoSize = true;
            this.linkLabelPengaturan.Location = new System.Drawing.Point(22, 223);
            this.linkLabelPengaturan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabelPengaturan.Name = "linkLabelPengaturan";
            this.linkLabelPengaturan.Size = new System.Drawing.Size(171, 25);
            this.linkLabelPengaturan.TabIndex = 17;
            this.linkLabelPengaturan.TabStop = true;
            this.linkLabelPengaturan.Text = "Pengaturan Lanjut";
            this.linkLabelPengaturan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPengaturan_LinkClicked);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(455, 168);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(161, 63);
            this.buttonKeluar.TabIndex = 16;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(277, 98);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(336, 29);
            this.textBoxPassword.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(277, 42);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(336, 29);
            this.textBoxUsername.TabIndex = 13;
            this.textBoxUsername.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Database :";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(277, 42);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(336, 29);
            this.textBoxServer.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Server :";
            // 
            // panelPengaturan
            // 
            this.panelPengaturan.BackColor = System.Drawing.Color.Lavender;
            this.panelPengaturan.Controls.Add(this.textBoxDatabase);
            this.panelPengaturan.Controls.Add(this.label3);
            this.panelPengaturan.Controls.Add(this.textBoxServer);
            this.panelPengaturan.Controls.Add(this.label4);
            this.panelPengaturan.Controls.Add(this.buttonSimpan);
            this.panelPengaturan.Location = new System.Drawing.Point(0, 277);
            this.panelPengaturan.Margin = new System.Windows.Forms.Padding(6);
            this.panelPengaturan.Name = "panelPengaturan";
            this.panelPengaturan.Size = new System.Drawing.Size(677, 266);
            this.panelPengaturan.TabIndex = 18;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(277, 98);
            this.textBoxDatabase.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(336, 29);
            this.textBoxDatabase.TabIndex = 15;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Navy;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(277, 168);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(161, 63);
            this.buttonSimpan.TabIndex = 11;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 545);
            this.Controls.Add(this.panelPengaturan);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelPengaturan.ResumeLayout(false);
            this.panelPengaturan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelPengaturan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelPengaturan;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Button buttonSimpan;
    }
}