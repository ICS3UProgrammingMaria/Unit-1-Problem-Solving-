namespace SchoolMascotsMaria
{
    partial class SchoolMascotForm
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
            this.mnuSchool = new System.Windows.Forms.MenuStrip();
            this.mniSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMotherTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStMarks = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStJoes = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblSchoolMascot = new System.Windows.Forms.Label();
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.mnuSchool.SuspendLayout();
            this.grbSchool.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSchool
            // 
            this.mnuSchool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchool});
            this.mnuSchool.Location = new System.Drawing.Point(0, 0);
            this.mnuSchool.Name = "mnuSchool";
            this.mnuSchool.Size = new System.Drawing.Size(415, 24);
            this.mnuSchool.TabIndex = 0;
            this.mnuSchool.Text = "menuStrip1";
            // 
            // mniSchool
            // 
            this.mniSchool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniMotherTeresa,
            this.mniStMarks,
            this.mniStJoes});
            this.mniSchool.Name = "mniSchool";
            this.mniSchool.Size = new System.Drawing.Size(60, 20);
            this.mniSchool.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(149, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniMotherTeresa
            // 
            this.mniMotherTeresa.Name = "mniMotherTeresa";
            this.mniMotherTeresa.Size = new System.Drawing.Size(149, 22);
            this.mniMotherTeresa.Text = "Mother Teresa";
            this.mniMotherTeresa.Click += new System.EventHandler(this.mniMotherTeresa_Click);
            // 
            // mniStMarks
            // 
            this.mniStMarks.Name = "mniStMarks";
            this.mniStMarks.Size = new System.Drawing.Size(149, 22);
            this.mniStMarks.Text = "St.Marks";
            this.mniStMarks.Click += new System.EventHandler(this.mniStMarks_Click);
            // 
            // mniStJoes
            // 
            this.mniStJoes.Name = "mniStJoes";
            this.mniStJoes.Size = new System.Drawing.Size(149, 22);
            this.mniStJoes.Text = "St.Joes";
            this.mniStJoes.Click += new System.EventHandler(this.mniStJoes_Click);
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(63, 56);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(209, 47);
            this.lblSchoolName.TabIndex = 1;
            this.lblSchoolName.Text = ".....................";
            // 
            // lblSchoolMascot
            // 
            this.lblSchoolMascot.AutoSize = true;
            this.lblSchoolMascot.Font = new System.Drawing.Font("Monotxt_IV50", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolMascot.Location = new System.Drawing.Point(84, 125);
            this.lblSchoolMascot.Name = "lblSchoolMascot";
            this.lblSchoolMascot.Size = new System.Drawing.Size(169, 43);
            this.lblSchoolMascot.TabIndex = 2;
            this.lblSchoolMascot.Text = "Mascot";
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblSchoolName);
            this.grbSchool.Controls.Add(this.lblSchoolMascot);
            this.grbSchool.ForeColor = System.Drawing.Color.LightBlue;
            this.grbSchool.Location = new System.Drawing.Point(39, 121);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(350, 193);
            this.grbSchool.TabIndex = 3;
            this.grbSchool.TabStop = false;
            // 
            // SchoolMascotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(415, 350);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuSchool);
            this.MainMenuStrip = this.mnuSchool;
            this.Name = "SchoolMascotForm";
            this.Text = "Schools & Mascots";
            this.mnuSchool.ResumeLayout(false);
            this.mnuSchool.PerformLayout();
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSchool;
        private System.Windows.Forms.ToolStripMenuItem mniSchool;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniMotherTeresa;
        private System.Windows.Forms.ToolStripMenuItem mniStMarks;
        private System.Windows.Forms.ToolStripMenuItem mniStJoes;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblSchoolMascot;
        private System.Windows.Forms.GroupBox grbSchool;
    }
}

