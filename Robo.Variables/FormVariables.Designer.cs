namespace Robo.Variables
{
    partial class FormVariables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVariables));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpVariablesLocales = new System.Windows.Forms.TabPage();
            this.dgvLocales = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpVariablesSysteme = new System.Windows.Forms.TabPage();
            this.scVariablesSysteme = new System.Windows.Forms.SplitContainer();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.dgvSysteme = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpVariablesUtilisateur = new System.Windows.Forms.TabPage();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.lbVariable = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpVariablesLocales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).BeginInit();
            this.tpVariablesSysteme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scVariablesSysteme)).BeginInit();
            this.scVariablesSysteme.Panel1.SuspendLayout();
            this.scVariablesSysteme.Panel2.SuspendLayout();
            this.scVariablesSysteme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysteme)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpVariablesLocales);
            this.tabControl1.Controls.Add(this.tpVariablesSysteme);
            this.tabControl1.Controls.Add(this.tpVariablesUtilisateur);
            this.tabControl1.Location = new System.Drawing.Point(23, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tpVariablesLocales
            // 
            this.tpVariablesLocales.Controls.Add(this.dgvLocales);
            this.tpVariablesLocales.Location = new System.Drawing.Point(4, 22);
            this.tpVariablesLocales.Name = "tpVariablesLocales";
            this.tpVariablesLocales.Padding = new System.Windows.Forms.Padding(3);
            this.tpVariablesLocales.Size = new System.Drawing.Size(878, 442);
            this.tpVariablesLocales.TabIndex = 0;
            this.tpVariablesLocales.Text = "Variables locales";
            this.tpVariablesLocales.UseVisualStyleBackColor = true;
            // 
            // dgvLocales
            // 
            this.dgvLocales.AllowUserToAddRows = false;
            this.dgvLocales.AllowUserToDeleteRows = false;
            this.dgvLocales.AllowUserToResizeRows = false;
            this.dgvLocales.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLocales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLocales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Description});
            this.dgvLocales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLocales.Location = new System.Drawing.Point(3, 3);
            this.dgvLocales.MultiSelect = false;
            this.dgvLocales.Name = "dgvLocales";
            this.dgvLocales.ReadOnly = true;
            this.dgvLocales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLocales.RowHeadersVisible = false;
            this.dgvLocales.RowTemplate.Height = 18;
            this.dgvLocales.RowTemplate.ReadOnly = true;
            this.dgvLocales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLocales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocales.Size = new System.Drawing.Size(872, 436);
            this.dgvLocales.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 130;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // tpVariablesSysteme
            // 
            this.tpVariablesSysteme.Controls.Add(this.scVariablesSysteme);
            this.tpVariablesSysteme.Location = new System.Drawing.Point(4, 22);
            this.tpVariablesSysteme.Name = "tpVariablesSysteme";
            this.tpVariablesSysteme.Padding = new System.Windows.Forms.Padding(3);
            this.tpVariablesSysteme.Size = new System.Drawing.Size(878, 442);
            this.tpVariablesSysteme.TabIndex = 1;
            this.tpVariablesSysteme.Text = "Variables système";
            this.tpVariablesSysteme.UseVisualStyleBackColor = true;
            // 
            // scVariablesSysteme
            // 
            this.scVariablesSysteme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scVariablesSysteme.Location = new System.Drawing.Point(3, 3);
            this.scVariablesSysteme.Name = "scVariablesSysteme";
            // 
            // scVariablesSysteme.Panel1
            // 
            this.scVariablesSysteme.Panel1.Controls.Add(this.lbCategories);
            // 
            // scVariablesSysteme.Panel2
            // 
            this.scVariablesSysteme.Panel2.Controls.Add(this.dgvSysteme);
            this.scVariablesSysteme.Size = new System.Drawing.Size(872, 436);
            this.scVariablesSysteme.SplitterDistance = 209;
            this.scVariablesSysteme.TabIndex = 0;
            // 
            // lbCategories
            // 
            this.lbCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.Location = new System.Drawing.Point(0, 0);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(209, 436);
            this.lbCategories.TabIndex = 0;
            this.lbCategories.SelectedIndexChanged += new System.EventHandler(this.lbCategories_SelectedIndexChanged);
            // 
            // dgvSysteme
            // 
            this.dgvSysteme.AllowUserToAddRows = false;
            this.dgvSysteme.AllowUserToDeleteRows = false;
            this.dgvSysteme.AllowUserToResizeRows = false;
            this.dgvSysteme.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSysteme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSysteme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSysteme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSysteme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSysteme.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSysteme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSysteme.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSysteme.Location = new System.Drawing.Point(0, 0);
            this.dgvSysteme.MultiSelect = false;
            this.dgvSysteme.Name = "dgvSysteme";
            this.dgvSysteme.ReadOnly = true;
            this.dgvSysteme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSysteme.RowHeadersVisible = false;
            this.dgvSysteme.RowTemplate.Height = 18;
            this.dgvSysteme.RowTemplate.ReadOnly = true;
            this.dgvSysteme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSysteme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSysteme.Size = new System.Drawing.Size(659, 436);
            this.dgvSysteme.TabIndex = 1;
            this.dgvSysteme.SelectionChanged += new System.EventHandler(this.dgvSysteme_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tpVariablesUtilisateur
            // 
            this.tpVariablesUtilisateur.Location = new System.Drawing.Point(4, 22);
            this.tpVariablesUtilisateur.Name = "tpVariablesUtilisateur";
            this.tpVariablesUtilisateur.Padding = new System.Windows.Forms.Padding(3);
            this.tpVariablesUtilisateur.Size = new System.Drawing.Size(878, 442);
            this.tpVariablesUtilisateur.TabIndex = 2;
            this.tpVariablesUtilisateur.Text = "Variables utilisateur";
            this.tpVariablesUtilisateur.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Image = global::Robo.Variables.Properties.Resources.cancel;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btCancel.Location = new System.Drawing.Point(827, 537);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Annuler";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Image = ((System.Drawing.Image)(resources.GetObject("btOK.Image")));
            this.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btOK.Location = new System.Drawing.Point(746, 537);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 11;
            this.btOK.Text = "OK";
            this.btOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // lbVariable
            // 
            this.lbVariable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVariable.AutoEllipsis = true;
            this.lbVariable.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVariable.Location = new System.Drawing.Point(27, 542);
            this.lbVariable.Name = "lbVariable";
            this.lbVariable.Size = new System.Drawing.Size(713, 18);
            this.lbVariable.TabIndex = 13;
            this.lbVariable.Text = "Variable !";
            // 
            // FormVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(932, 573);
            this.Controls.Add(this.lbVariable);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(364, 300);
            this.Name = "FormVariables";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "variables";
            this.Load += new System.EventHandler(this.FormVariables_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpVariablesLocales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).EndInit();
            this.tpVariablesSysteme.ResumeLayout(false);
            this.scVariablesSysteme.Panel1.ResumeLayout(false);
            this.scVariablesSysteme.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scVariablesSysteme)).EndInit();
            this.scVariablesSysteme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSysteme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpVariablesLocales;
        private System.Windows.Forms.TabPage tpVariablesSysteme;
        private System.Windows.Forms.TabPage tpVariablesUtilisateur;
        private System.Windows.Forms.DataGridView dgvLocales;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.SplitContainer scVariablesSysteme;
        private System.Windows.Forms.DataGridView dgvSysteme;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lbVariable;
    }
}