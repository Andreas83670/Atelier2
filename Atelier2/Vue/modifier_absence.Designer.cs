namespace Atelier2.Vue
{
    partial class modifier_absence
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
            this.grp_modifierUneAbsence = new System.Windows.Forms.GroupBox();
            this.date_fin = new System.Windows.Forms.DateTimePicker();
            this.date_debut = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateDeFin = new System.Windows.Forms.Label();
            this.cb_motif = new System.Windows.Forms.ComboBox();
            this.lbl_motif = new System.Windows.Forms.Label();
            this.lbl_dateDeDebut = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.grp_modifierUneAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_modifierUneAbsence
            // 
            this.grp_modifierUneAbsence.Controls.Add(this.date_fin);
            this.grp_modifierUneAbsence.Controls.Add(this.date_debut);
            this.grp_modifierUneAbsence.Controls.Add(this.lbl_dateDeFin);
            this.grp_modifierUneAbsence.Controls.Add(this.cb_motif);
            this.grp_modifierUneAbsence.Controls.Add(this.lbl_motif);
            this.grp_modifierUneAbsence.Controls.Add(this.lbl_dateDeDebut);
            this.grp_modifierUneAbsence.Controls.Add(this.btn_annuler);
            this.grp_modifierUneAbsence.Controls.Add(this.btn_valider);
            this.grp_modifierUneAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_modifierUneAbsence.Location = new System.Drawing.Point(12, 12);
            this.grp_modifierUneAbsence.Name = "grp_modifierUneAbsence";
            this.grp_modifierUneAbsence.Size = new System.Drawing.Size(280, 143);
            this.grp_modifierUneAbsence.TabIndex = 6;
            this.grp_modifierUneAbsence.TabStop = false;
            this.grp_modifierUneAbsence.Text = "Modifier une absence";
            // 
            // date_fin
            // 
            this.date_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fin.Location = new System.Drawing.Point(106, 57);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(167, 20);
            this.date_fin.TabIndex = 15;
            // 
            // date_debut
            // 
            this.date_debut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_debut.Location = new System.Drawing.Point(107, 31);
            this.date_debut.Name = "date_debut";
            this.date_debut.Size = new System.Drawing.Size(167, 20);
            this.date_debut.TabIndex = 14;
            // 
            // lbl_dateDeFin
            // 
            this.lbl_dateDeFin.AutoSize = true;
            this.lbl_dateDeFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateDeFin.Location = new System.Drawing.Point(25, 60);
            this.lbl_dateDeFin.Name = "lbl_dateDeFin";
            this.lbl_dateDeFin.Size = new System.Drawing.Size(59, 13);
            this.lbl_dateDeFin.TabIndex = 13;
            this.lbl_dateDeFin.Text = "Date de fin";
            // 
            // cb_motif
            // 
            this.cb_motif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_motif.FormattingEnabled = true;
            this.cb_motif.Location = new System.Drawing.Point(106, 83);
            this.cb_motif.Name = "cb_motif";
            this.cb_motif.Size = new System.Drawing.Size(167, 21);
            this.cb_motif.TabIndex = 12;
            // 
            // lbl_motif
            // 
            this.lbl_motif.AutoSize = true;
            this.lbl_motif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motif.Location = new System.Drawing.Point(25, 86);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(30, 13);
            this.lbl_motif.TabIndex = 7;
            this.lbl_motif.Text = "Motif";
            // 
            // lbl_dateDeDebut
            // 
            this.lbl_dateDeDebut.AutoSize = true;
            this.lbl_dateDeDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateDeDebut.Location = new System.Drawing.Point(26, 37);
            this.lbl_dateDeDebut.Name = "lbl_dateDeDebut";
            this.lbl_dateDeDebut.Size = new System.Drawing.Size(75, 13);
            this.lbl_dateDeDebut.TabIndex = 3;
            this.lbl_dateDeDebut.Text = "Date de début";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(174, 110);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(53, 23);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.Location = new System.Drawing.Point(106, 110);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(62, 23);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // modifier_absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 168);
            this.Controls.Add(this.grp_modifierUneAbsence);
            this.Name = "modifier_absence";
            this.Text = "modifier_absence";
            this.grp_modifierUneAbsence.ResumeLayout(false);
            this.grp_modifierUneAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_modifierUneAbsence;
        private System.Windows.Forms.DateTimePicker date_fin;
        private System.Windows.Forms.DateTimePicker date_debut;
        private System.Windows.Forms.Label lbl_dateDeFin;
        private System.Windows.Forms.ComboBox cb_motif;
        private System.Windows.Forms.Label lbl_motif;
        private System.Windows.Forms.Label lbl_dateDeDebut;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
    }
}