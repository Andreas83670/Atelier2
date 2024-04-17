namespace GestionPersonnel.Vue
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
            this.dgv_absences = new System.Windows.Forms.DataGridView();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_toutSélectionner = new System.Windows.Forms.Button();
            this.grp_Absences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_absences)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Absences
            // 
            this.grp_Absences.Controls.Add(this.dgv_absences);
            this.grp_Absences.Controls.Add(this.btn_ajouter);
            this.grp_Absences.Controls.Add(this.btn_modifier);
            this.grp_Absences.Controls.Add(this.btn_supprimer);
            this.grp_Absences.Controls.Add(this.btn_toutSélectionner);
            this.grp_Absences.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Absences.Location = new System.Drawing.Point(12, 12);
            this.grp_Absences.Name = "grp_Absences";
            this.grp_Absences.Size = new System.Drawing.Size(589, 304);
            this.grp_Absences.TabIndex = 3;
            this.grp_Absences.TabStop = false;
            this.grp_Absences.Text = "Absences";
            // 
            // dgv_absences
            // 
            this.dgv_absences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_absences.Location = new System.Drawing.Point(6, 28);
            this.dgv_absences.Name = "dgv_absences";
            this.dgv_absences.Size = new System.Drawing.Size(576, 241);
            this.dgv_absences.TabIndex = 5;
            this.dgv_absences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_absences_CellContentClick);
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
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
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
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
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
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
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
            this.btn_toutSélectionner.Click += new System.EventHandler(this.btn_toutSélectionner_Click);
            // 
            // absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 316);
            this.Controls.Add(this.grp_Absences);
            this.Name = "absences";
            this.Text = "absences";
            this.Load += new System.EventHandler(this.absences_Load);
            this.grp_Absences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_absences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Absences;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_toutSélectionner;
        private System.Windows.Forms.DataGridView dgv_absences;
    }
}