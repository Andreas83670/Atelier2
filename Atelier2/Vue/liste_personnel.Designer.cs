﻿namespace Atelier2
{
    partial class liste_personnel
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
            this.grp_ListeDuPersonnel = new System.Windows.Forms.GroupBox();
            this.btn_toutSélectionner = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_gestionDesAbsences = new System.Windows.Forms.Button();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grp_ListeDuPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_ListeDuPersonnel
            // 
            this.grp_ListeDuPersonnel.Controls.Add(this.checkBox1);
            this.grp_ListeDuPersonnel.Controls.Add(this.btn_nouveau);
            this.grp_ListeDuPersonnel.Controls.Add(this.btn_gestionDesAbsences);
            this.grp_ListeDuPersonnel.Controls.Add(this.btn_modifier);
            this.grp_ListeDuPersonnel.Controls.Add(this.btn_supprimer);
            this.grp_ListeDuPersonnel.Controls.Add(this.btn_toutSélectionner);
            this.grp_ListeDuPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ListeDuPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grp_ListeDuPersonnel.Name = "grp_ListeDuPersonnel";
            this.grp_ListeDuPersonnel.Size = new System.Drawing.Size(371, 336);
            this.grp_ListeDuPersonnel.TabIndex = 2;
            this.grp_ListeDuPersonnel.TabStop = false;
            this.grp_ListeDuPersonnel.Text = "Liste du personnel";
            this.grp_ListeDuPersonnel.Enter += new System.EventHandler(this.grp_seConnecter_Enter);
            // 
            // btn_toutSélectionner
            // 
            this.btn_toutSélectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toutSélectionner.Location = new System.Drawing.Point(6, 275);
            this.btn_toutSélectionner.Name = "btn_toutSélectionner";
            this.btn_toutSélectionner.Size = new System.Drawing.Size(99, 23);
            this.btn_toutSélectionner.TabIndex = 0;
            this.btn_toutSélectionner.Text = "Tout sélectionner";
            this.btn_toutSélectionner.UseVisualStyleBackColor = true;
            this.btn_toutSélectionner.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Location = new System.Drawing.Point(111, 275);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(62, 23);
            this.btn_supprimer.TabIndex = 1;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Location = new System.Drawing.Point(179, 275);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(62, 23);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_gestionDesAbsences
            // 
            this.btn_gestionDesAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestionDesAbsences.Location = new System.Drawing.Point(247, 275);
            this.btn_gestionDesAbsences.Name = "btn_gestionDesAbsences";
            this.btn_gestionDesAbsences.Size = new System.Drawing.Size(124, 23);
            this.btn_gestionDesAbsences.TabIndex = 3;
            this.btn_gestionDesAbsences.Text = "Gestion des absences";
            this.btn_gestionDesAbsences.UseVisualStyleBackColor = true;
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nouveau.Location = new System.Drawing.Point(6, 304);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(62, 23);
            this.btn_nouveau.TabIndex = 4;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(36, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // liste_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 361);
            this.Controls.Add(this.grp_ListeDuPersonnel);
            this.Name = "liste_personnel";
            this.Text = "liste_personnel";
            this.grp_ListeDuPersonnel.ResumeLayout(false);
            this.grp_ListeDuPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_ListeDuPersonnel;
        private System.Windows.Forms.Button btn_toutSélectionner;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_gestionDesAbsences;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
    }
}