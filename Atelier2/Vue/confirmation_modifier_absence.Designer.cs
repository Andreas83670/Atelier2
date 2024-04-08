namespace Atelier2.Vue
{
    partial class confirmation_modifier_absence
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
            this.grp_ModifierUneAbsence = new System.Windows.Forms.GroupBox();
            this.lbl_confirmation = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.grp_ModifierUneAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_ModifierUneAbsence
            // 
            this.grp_ModifierUneAbsence.Controls.Add(this.lbl_confirmation);
            this.grp_ModifierUneAbsence.Controls.Add(this.btn_annuler);
            this.grp_ModifierUneAbsence.Controls.Add(this.btn_modifier);
            this.grp_ModifierUneAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ModifierUneAbsence.Location = new System.Drawing.Point(12, 12);
            this.grp_ModifierUneAbsence.Name = "grp_ModifierUneAbsence";
            this.grp_ModifierUneAbsence.Size = new System.Drawing.Size(293, 107);
            this.grp_ModifierUneAbsence.TabIndex = 7;
            this.grp_ModifierUneAbsence.TabStop = false;
            this.grp_ModifierUneAbsence.Text = "Modifier une absence";
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmation.Location = new System.Drawing.Point(6, 39);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(275, 13);
            this.lbl_confirmation.TabIndex = 3;
            this.lbl_confirmation.Text = "Souhaitez-vous vraiment modifier cette/ces absence(s) ?";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(139, 66);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(53, 23);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Location = new System.Drawing.Point(71, 66);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(62, 23);
            this.btn_modifier.TabIndex = 1;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // confirmation_modifier_absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 122);
            this.Controls.Add(this.grp_ModifierUneAbsence);
            this.Name = "confirmation_modifier_absence";
            this.Text = "confirmation_modifier_absence";
            this.grp_ModifierUneAbsence.ResumeLayout(false);
            this.grp_ModifierUneAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_ModifierUneAbsence;
        private System.Windows.Forms.Label lbl_confirmation;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_modifier;
    }
}