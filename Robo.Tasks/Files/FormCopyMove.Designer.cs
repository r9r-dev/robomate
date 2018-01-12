namespace Robo.Tasks.Files
{
    partial class FormCopyMove
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCopyMove));
            this.tbFichiers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btVariables = new System.Windows.Forms.Button();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btClearList = new System.Windows.Forms.Button();
            this.btAddFolder = new System.Windows.Forms.Button();
            this.btAddFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEffacerSource = new System.Windows.Forms.RadioButton();
            this.rbNeRienFaire = new System.Windows.Forms.RadioButton();
            this.rbRenommerSource = new System.Windows.Forms.RadioButton();
            this.rbRenommerCible = new System.Windows.Forms.RadioButton();
            this.rbRemplacer = new System.Windows.Forms.RadioButton();
            this.cbIncludeSubFolders = new System.Windows.Forms.CheckBox();
            this.cbMove = new System.Windows.Forms.CheckBox();
            this.cbIgnoreHiddenFiles = new System.Windows.Forms.CheckBox();
            this.cbIgnoreSystemFiles = new System.Windows.Forms.CheckBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFichiers
            // 
            this.tbFichiers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFichiers.Location = new System.Drawing.Point(23, 83);
            this.tbFichiers.Multiline = true;
            this.tbFichiers.Name = "tbFichiers";
            this.tbFichiers.Size = new System.Drawing.Size(328, 122);
            this.tbFichiers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fichiers (vous pouvez utiliser des caractères génériques) :";
            // 
            // btVariables
            // 
            this.btVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btVariables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btVariables.Image = global::Robo.Tasks.Properties.Resources.database_property;
            this.btVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btVariables.Location = new System.Drawing.Point(23, 495);
            this.btVariables.Name = "btVariables";
            this.btVariables.Size = new System.Drawing.Size(24, 24);
            this.btVariables.TabIndex = 8;
            this.toolTip.SetToolTip(this.btVariables, "Insérer une variable");
            this.btVariables.UseVisualStyleBackColor = true;
            this.btVariables.Click += new System.EventHandler(this.btVariables_Click);
            // 
            // btBrowse
            // 
            this.btBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btBrowse.Image = global::Robo.Tasks.Properties.Resources.folder_search;
            this.btBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btBrowse.Location = new System.Drawing.Point(357, 232);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(24, 24);
            this.btBrowse.TabIndex = 7;
            this.toolTip.SetToolTip(this.btBrowse, "Parcourir");
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btClearList
            // 
            this.btClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btClearList.Image = global::Robo.Tasks.Properties.Resources.delete;
            this.btClearList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btClearList.Location = new System.Drawing.Point(357, 143);
            this.btClearList.Name = "btClearList";
            this.btClearList.Size = new System.Drawing.Size(24, 24);
            this.btClearList.TabIndex = 4;
            this.toolTip.SetToolTip(this.btClearList, "Effacer la liste");
            this.btClearList.UseVisualStyleBackColor = true;
            this.btClearList.Click += new System.EventHandler(this.btClearList_Click);
            // 
            // btAddFolder
            // 
            this.btAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAddFolder.Image = global::Robo.Tasks.Properties.Resources.folder__plus;
            this.btAddFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAddFolder.Location = new System.Drawing.Point(357, 113);
            this.btAddFolder.Name = "btAddFolder";
            this.btAddFolder.Size = new System.Drawing.Size(24, 24);
            this.btAddFolder.TabIndex = 3;
            this.toolTip.SetToolTip(this.btAddFolder, "Sélectionner un dossier");
            this.btAddFolder.UseVisualStyleBackColor = true;
            this.btAddFolder.Click += new System.EventHandler(this.btAddFolder_Click);
            // 
            // btAddFile
            // 
            this.btAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAddFile.Image = global::Robo.Tasks.Properties.Resources.blue_document__plus;
            this.btAddFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAddFile.Location = new System.Drawing.Point(357, 83);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(24, 24);
            this.btAddFile.TabIndex = 1;
            this.toolTip.SetToolTip(this.btAddFile, "Sélectionner un fichier");
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(23, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination :";
            // 
            // tbDestination
            // 
            this.tbDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDestination.Location = new System.Drawing.Point(23, 235);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(328, 20);
            this.tbDestination.TabIndex = 6;
            this.tbDestination.Text = "C:\\{NomFichier}";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbEffacerSource);
            this.groupBox1.Controls.Add(this.rbNeRienFaire);
            this.groupBox1.Controls.Add(this.rbRenommerSource);
            this.groupBox1.Controls.Add(this.rbRenommerCible);
            this.groupBox1.Controls.Add(this.rbRemplacer);
            this.groupBox1.Location = new System.Drawing.Point(23, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 97);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Si le fichier existe déjà :";
            // 
            // rbEffacerSource
            // 
            this.rbEffacerSource.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbEffacerSource.AutoSize = true;
            this.rbEffacerSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbEffacerSource.Location = new System.Drawing.Point(128, 65);
            this.rbEffacerSource.Name = "rbEffacerSource";
            this.rbEffacerSource.Size = new System.Drawing.Size(136, 17);
            this.rbEffacerSource.TabIndex = 4;
            this.rbEffacerSource.Text = "Effacer le fichier source";
            this.rbEffacerSource.UseVisualStyleBackColor = true;
            // 
            // rbNeRienFaire
            // 
            this.rbNeRienFaire.AutoSize = true;
            this.rbNeRienFaire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbNeRienFaire.Location = new System.Drawing.Point(6, 65);
            this.rbNeRienFaire.Name = "rbNeRienFaire";
            this.rbNeRienFaire.Size = new System.Drawing.Size(82, 17);
            this.rbNeRienFaire.TabIndex = 3;
            this.rbNeRienFaire.Text = "Ne rien faire";
            this.rbNeRienFaire.UseVisualStyleBackColor = true;
            // 
            // rbRenommerSource
            // 
            this.rbRenommerSource.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbRenommerSource.AutoSize = true;
            this.rbRenommerSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbRenommerSource.Location = new System.Drawing.Point(128, 19);
            this.rbRenommerSource.Name = "rbRenommerSource";
            this.rbRenommerSource.Size = new System.Drawing.Size(153, 17);
            this.rbRenommerSource.TabIndex = 2;
            this.rbRenommerSource.Text = "Renommer le fichier source";
            this.rbRenommerSource.UseVisualStyleBackColor = true;
            // 
            // rbRenommerCible
            // 
            this.rbRenommerCible.AutoSize = true;
            this.rbRenommerCible.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbRenommerCible.Location = new System.Drawing.Point(6, 42);
            this.rbRenommerCible.Name = "rbRenommerCible";
            this.rbRenommerCible.Size = new System.Drawing.Size(143, 17);
            this.rbRenommerCible.TabIndex = 1;
            this.rbRenommerCible.Text = "Renommer le fichier cible";
            this.rbRenommerCible.UseVisualStyleBackColor = true;
            // 
            // rbRemplacer
            // 
            this.rbRemplacer.AutoSize = true;
            this.rbRemplacer.Checked = true;
            this.rbRemplacer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbRemplacer.Location = new System.Drawing.Point(6, 19);
            this.rbRemplacer.Name = "rbRemplacer";
            this.rbRemplacer.Size = new System.Drawing.Size(86, 17);
            this.rbRemplacer.TabIndex = 0;
            this.rbRemplacer.TabStop = true;
            this.rbRemplacer.Text = "Le remplacer";
            this.rbRemplacer.UseVisualStyleBackColor = true;
            // 
            // cbIncludeSubFolders
            // 
            this.cbIncludeSubFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIncludeSubFolders.AutoSize = true;
            this.cbIncludeSubFolders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbIncludeSubFolders.Location = new System.Drawing.Point(23, 387);
            this.cbIncludeSubFolders.Name = "cbIncludeSubFolders";
            this.cbIncludeSubFolders.Size = new System.Drawing.Size(219, 17);
            this.cbIncludeSubFolders.TabIndex = 12;
            this.cbIncludeSubFolders.Text = "Inclure les sous-dossiers (le cas échéant)";
            this.cbIncludeSubFolders.UseVisualStyleBackColor = true;
            // 
            // cbMove
            // 
            this.cbMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMove.AutoSize = true;
            this.cbMove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbMove.Location = new System.Drawing.Point(23, 410);
            this.cbMove.Name = "cbMove";
            this.cbMove.Size = new System.Drawing.Size(268, 17);
            this.cbMove.TabIndex = 13;
            this.cbMove.Text = "Déplacer (effacer le fichier après une copie réussie)";
            this.cbMove.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreHiddenFiles
            // 
            this.cbIgnoreHiddenFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIgnoreHiddenFiles.AutoSize = true;
            this.cbIgnoreHiddenFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbIgnoreHiddenFiles.Location = new System.Drawing.Point(23, 433);
            this.cbIgnoreHiddenFiles.Name = "cbIgnoreHiddenFiles";
            this.cbIgnoreHiddenFiles.Size = new System.Drawing.Size(149, 17);
            this.cbIgnoreHiddenFiles.TabIndex = 14;
            this.cbIgnoreHiddenFiles.Text = "Ignorer les fichiers cachés";
            this.cbIgnoreHiddenFiles.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreSystemFiles
            // 
            this.cbIgnoreSystemFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIgnoreSystemFiles.AutoSize = true;
            this.cbIgnoreSystemFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbIgnoreSystemFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbIgnoreSystemFiles.Location = new System.Drawing.Point(23, 456);
            this.cbIgnoreSystemFiles.Name = "cbIgnoreSystemFiles";
            this.cbIgnoreSystemFiles.Size = new System.Drawing.Size(152, 17);
            this.cbIgnoreSystemFiles.TabIndex = 15;
            this.cbIgnoreSystemFiles.Text = "Ignorer les fichiers système";
            this.cbIgnoreSystemFiles.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Image = global::Robo.Tasks.Properties.Resources.cancel1;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btCancel.Location = new System.Drawing.Point(306, 496);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Annuler";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.Image = global::Robo.Tasks.Properties.Resources.accept;
            this.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btOK.Location = new System.Drawing.Point(225, 496);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 9;
            this.btOK.Text = "OK";
            this.btOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // FormCopyMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(404, 536);
            this.Controls.Add(this.cbIgnoreSystemFiles);
            this.Controls.Add(this.cbIgnoreHiddenFiles);
            this.Controls.Add(this.cbMove);
            this.Controls.Add(this.cbIncludeSubFolders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btVariables);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btClearList);
            this.Controls.Add(this.btAddFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddFile);
            this.Controls.Add(this.tbFichiers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(344, 497);
            this.Name = "FormCopyMove";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Text = "copier/déplacer un fichier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFichiers;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddFolder;
        private System.Windows.Forms.Button btClearList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btVariables;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEffacerSource;
        private System.Windows.Forms.RadioButton rbNeRienFaire;
        private System.Windows.Forms.RadioButton rbRenommerSource;
        private System.Windows.Forms.RadioButton rbRenommerCible;
        private System.Windows.Forms.RadioButton rbRemplacer;
        private System.Windows.Forms.CheckBox cbIncludeSubFolders;
        private System.Windows.Forms.CheckBox cbMove;
        private System.Windows.Forms.CheckBox cbIgnoreHiddenFiles;
        private System.Windows.Forms.CheckBox cbIgnoreSystemFiles;
       

    }
}