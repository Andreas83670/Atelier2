namespace GestionPersonnel.Vue
{
    partial class confirmation_modifier_personnel
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
            this.grp_confirmation = new System.Windows.Forms.GroupBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.lbl_confirmation = new System.Windows.Forms.Label();
            this.grp_confirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_confirmation
            // 
            this.grp_confirmation.Controls.Add(this.lbl_confirmation);
            this.grp_confirmation.Controls.Add(this.btn_annuler);
            this.grp_confirmation.Controls.Add(this.btn_modifier);
            this.grp_confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_confirmation.Location = new System.Drawing.Point(12, 12);
            this.grp_confirmation.Name = "grp_confirmation";
            this.grp_confirmation.Size = new System.Drawing.Size(301, 95);
            this.grp_confirmation.TabIndex = 0;
            this.grp_confirmation.TabStop = false;
            this.grp_confirmation.Text = "Modifier un personnel";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(134, 60);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 1;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click_1);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Location = new System.Drawing.Point(53, 60);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 0;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click_1);
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmation.Location = new System.Drawing.Point(21, 35);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(235, 13);
            this.lbl_confirmation.TabIndex = 4;
            this.lbl_confirmation.Text = "Souhaitez-vous vraiment modifier ce personnel ?";
            // 
            // confirmation_modifier_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 113);
            this.Controls.Add(this.grp_confirmation);
            this.Name = "confirmation_modifier_personnel";
            this.Text = "confirmation_modifier_personnel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.confirmation_modifier_personnel_FormClosed);
            this.Load += new System.EventHandler(this.confirmation_modifier_personnel_Load);
            this.grp_confirmation.ResumeLayout(false);
            this.grp_confirmation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_confirmation;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Label lbl_confirmation;
    }
}