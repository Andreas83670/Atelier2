namespace Atelier2.Vue
{
    partial class absences
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
            this.grp_Absences = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_toutSélectionner = new System.Windows.Forms.Button();
            this.grp_Absences.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Absences
            // 
            this.grp_Absences.Controls.Add(this.checkBox1);
            this.grp_Absences.Controls.Add(this.btn_ajouter);
            this.grp_Absences.Controls.Add(this.btn_modifier);
            this.grp_Absences.Controls.Add(this.btn_supprimer);
            this.grp_Absences.Controls.Add(this.btn_toutSélectionner);
            this.grp_Absences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Absences.Location = new System.Drawing.Point(12, 12);
            this.grp_Absences.Name = "grp_Absences";
            this.grp_Absences.Size = new System.Drawing.Size(371, 304);
            this.grp_Absences.TabIndex = 3;
            this.grp_Absences.TabStop = false;
            this.grp_Absences.Text = "Absences";
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
            // btn_ajouter
            // 
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.Location = new System.Drawing.Point(252, 275);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(62, 23);
            this.btn_ajouter.TabIndex = 4;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Location = new System.Drawing.Point(184, 275);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(62, 23);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Location = new System.Drawing.Point(116, 275);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(62, 23);
            this.btn_supprimer.TabIndex = 1;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_toutSélectionner
            // 
            this.btn_toutSélectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toutSélectionner.Location = new System.Drawing.Point(6, 275);
            this.btn_toutSélectionner.Name = "btn_toutSélectionner";
            this.btn_toutSélectionner.Size = new System.Drawing.Size(104, 23);
            this.btn_toutSélectionner.TabIndex = 0;
            this.btn_toutSélectionner.Text = "Tout sélectionner";
            this.btn_toutSélectionner.UseVisualStyleBackColor = true;
            // 
            // absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 316);
            this.Controls.Add(this.grp_Absences);
            this.Name = "absences";
            this.Text = "absences";
            this.grp_Absences.ResumeLayout(false);
            this.grp_Absences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Absences;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_toutSélectionner;
    }
}