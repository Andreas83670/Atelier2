namespace GestionPersonnel.Vue
{
    partial class supprimer_absence
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
            this.grp_SupprimerUneAbsence = new System.Windows.Forms.GroupBox();
            this.lbl_confirmation = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.grp_SupprimerUneAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_SupprimerUneAbsence
            // 
            this.grp_SupprimerUneAbsence.Controls.Add(this.lbl_confirmation);
            this.grp_SupprimerUneAbsence.Controls.Add(this.btn_annuler);
            this.grp_SupprimerUneAbsence.Controls.Add(this.btn_valider);
            this.grp_SupprimerUneAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_SupprimerUneAbsence.Location = new System.Drawing.Point(12, 12);
            this.grp_SupprimerUneAbsence.Name = "grp_SupprimerUneAbsence";
            this.grp_SupprimerUneAbsence.Size = new System.Drawing.Size(293, 107);
            this.grp_SupprimerUneAbsence.TabIndex = 6;
            this.grp_SupprimerUneAbsence.TabStop = false;
            this.grp_SupprimerUneAbsence.Text = "Supprimer une absence";
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmation.Location = new System.Drawing.Point(6, 39);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(284, 13);
            this.lbl_confirmation.TabIndex = 3;
            this.lbl_confirmation.Text = "Souhaitez-vous vraiment supprimer cette/ces absence(s) ?";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(149, 66);
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
            this.btn_valider.Location = new System.Drawing.Point(81, 66);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(62, 23);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // supprimer_absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 124);
            this.Controls.Add(this.grp_SupprimerUneAbsence);
            this.Name = "supprimer_absence";
            this.Text = "supprimer_absence";
            this.Load += new System.EventHandler(this.supprimer_absence_Load);
            this.grp_SupprimerUneAbsence.ResumeLayout(false);
            this.grp_SupprimerUneAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_SupprimerUneAbsence;
        private System.Windows.Forms.Label lbl_confirmation;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
    }
}