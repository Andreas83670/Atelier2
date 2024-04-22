namespace GestionPersonnel.Vue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifier_absence));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.grp_ModifierAbsence = new System.Windows.Forms.GroupBox();
            this.lbl_motif = new System.Windows.Forms.Label();
            this.lbl_dateFin = new System.Windows.Forms.Label();
            this.cb_motif = new System.Windows.Forms.ComboBox();
            this.lbl_dateDebut = new System.Windows.Forms.Label();
            this.grp_ModifierAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy à HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(109, 79);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy à HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(109, 138);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(190, 138);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 3;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // grp_ModifierAbsence
            // 
            this.grp_ModifierAbsence.Controls.Add(this.lbl_motif);
            this.grp_ModifierAbsence.Controls.Add(this.lbl_dateFin);
            this.grp_ModifierAbsence.Controls.Add(this.cb_motif);
            this.grp_ModifierAbsence.Controls.Add(this.lbl_dateDebut);
            this.grp_ModifierAbsence.Controls.Add(this.btn_modifier);
            this.grp_ModifierAbsence.Controls.Add(this.btn_annuler);
            this.grp_ModifierAbsence.Controls.Add(this.dateTimePicker1);
            this.grp_ModifierAbsence.Controls.Add(this.dateTimePicker2);
            this.grp_ModifierAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ModifierAbsence.Location = new System.Drawing.Point(12, 12);
            this.grp_ModifierAbsence.Name = "grp_ModifierAbsence";
            this.grp_ModifierAbsence.Size = new System.Drawing.Size(318, 173);
            this.grp_ModifierAbsence.TabIndex = 4;
            this.grp_ModifierAbsence.TabStop = false;
            this.grp_ModifierAbsence.Text = "Modifier une absence";
            // 
            // lbl_motif
            // 
            this.lbl_motif.AutoSize = true;
            this.lbl_motif.Location = new System.Drawing.Point(16, 108);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(30, 13);
            this.lbl_motif.TabIndex = 7;
            this.lbl_motif.Text = "Motif";
            // 
            // lbl_dateFin
            // 
            this.lbl_dateFin.AutoSize = true;
            this.lbl_dateFin.Location = new System.Drawing.Point(16, 85);
            this.lbl_dateFin.Name = "lbl_dateFin";
            this.lbl_dateFin.Size = new System.Drawing.Size(59, 13);
            this.lbl_dateFin.TabIndex = 6;
            this.lbl_dateFin.Text = "Date de fin";
            // 
            // cb_motif
            // 
            this.cb_motif.FormattingEnabled = true;
            this.cb_motif.Location = new System.Drawing.Point(109, 105);
            this.cb_motif.Name = "cb_motif";
            this.cb_motif.Size = new System.Drawing.Size(121, 21);
            this.cb_motif.TabIndex = 5;
            this.cb_motif.SelectedIndexChanged += new System.EventHandler(this.cb_motif_SelectedIndexChanged);
            // 
            // lbl_dateDebut
            // 
            this.lbl_dateDebut.AutoSize = true;
            this.lbl_dateDebut.Location = new System.Drawing.Point(16, 59);
            this.lbl_dateDebut.Name = "lbl_dateDebut";
            this.lbl_dateDebut.Size = new System.Drawing.Size(75, 13);
            this.lbl_dateDebut.TabIndex = 4;
            this.lbl_dateDebut.Text = "Date de début";
            this.lbl_dateDebut.Click += new System.EventHandler(this.label1_Click);
            // 
            // modifier_absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 185);
            this.Controls.Add(this.grp_ModifierAbsence);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modifier_absence";
            this.Text = "Modifier une absence";
            this.Load += new System.EventHandler(this.modifier_absence_Load);
            this.grp_ModifierAbsence.ResumeLayout(false);
            this.grp_ModifierAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.GroupBox grp_ModifierAbsence;
        private System.Windows.Forms.ComboBox cb_motif;
        private System.Windows.Forms.Label lbl_dateDebut;
        private System.Windows.Forms.Label lbl_dateFin;
        private System.Windows.Forms.Label lbl_motif;
    }
}