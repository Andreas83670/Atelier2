namespace GestionPersonnel.Vue
{
    /// <summary>
    /// classe de se connecter
    /// </summary>
    partial class se_connecter
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
            this.grp_seConnecter = new System.Windows.Forms.GroupBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_motdepasse = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_motdepasse = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.grp_seConnecter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_seConnecter
            // 
            this.grp_seConnecter.Controls.Add(this.lbl_info);
            this.grp_seConnecter.Controls.Add(this.button1);
            this.grp_seConnecter.Controls.Add(this.txt_motdepasse);
            this.grp_seConnecter.Controls.Add(this.txt_login);
            this.grp_seConnecter.Controls.Add(this.lbl_motdepasse);
            this.grp_seConnecter.Controls.Add(this.lbl_login);
            this.grp_seConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_seConnecter.Location = new System.Drawing.Point(12, 12);
            this.grp_seConnecter.Name = "grp_seConnecter";
            this.grp_seConnecter.Size = new System.Drawing.Size(445, 103);
            this.grp_seConnecter.TabIndex = 1;
            this.grp_seConnecter.TabStop = false;
            this.grp_seConnecter.Text = "Se connecter";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(175, 15);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(249, 13);
            this.lbl_info.TabIndex = 5;
            this.lbl_info.Text = "le nom d\'utilisateur ou le mot de passe est incorrect.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_motdepasse
            // 
            this.txt_motdepasse.Location = new System.Drawing.Point(178, 58);
            this.txt_motdepasse.Name = "txt_motdepasse";
            this.txt_motdepasse.Size = new System.Drawing.Size(134, 29);
            this.txt_motdepasse.TabIndex = 3;
            this.txt_motdepasse.TextChanged += new System.EventHandler(this.txt_motdepasse_TextChanged);
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(16, 58);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(142, 29);
            this.txt_login.TabIndex = 2;
            // 
            // lbl_motdepasse
            // 
            this.lbl_motdepasse.AutoSize = true;
            this.lbl_motdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motdepasse.Location = new System.Drawing.Point(175, 39);
            this.lbl_motdepasse.Name = "lbl_motdepasse";
            this.lbl_motdepasse.Size = new System.Drawing.Size(70, 13);
            this.lbl_motdepasse.TabIndex = 1;
            this.lbl_motdepasse.Text = "mot de passe";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(13, 39);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(82, 13);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "nom d\'utilisateur";
            this.lbl_login.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // se_connecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 117);
            this.Controls.Add(this.grp_seConnecter);
            this.Name = "se_connecter";
            this.Text = "se_connecter";
            this.Load += new System.EventHandler(this.se_connecter_Load);
            this.grp_seConnecter.ResumeLayout(false);
            this.grp_seConnecter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_seConnecter;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_motdepasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_motdepasse;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lbl_info;
    }
}