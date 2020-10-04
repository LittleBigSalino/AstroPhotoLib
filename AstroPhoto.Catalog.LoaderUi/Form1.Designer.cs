namespace AstroPhoto.Catalog.LoaderUi
{
    partial class FormCatalogFunctionsDriver
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
            this.buttonConnectToDb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonShowAddDataDlg = new System.Windows.Forms.Button();
            this.tabControlViewData = new System.Windows.Forms.TabControl();
            this.tabPageImageTypes = new System.Windows.Forms.TabPage();
            this.dataGridViewImageTypes = new System.Windows.Forms.DataGridView();
            this.tabPageImages = new System.Windows.Forms.TabPage();
            this.dataGridViewImages = new System.Windows.Forms.DataGridView();
            this.tabPageProjects = new System.Windows.Forms.TabPage();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.tabPageSessions = new System.Windows.Forms.TabPage();
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.openFileDialogAddNewFiles = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.tabControlViewData.SuspendLayout();
            this.tabPageImageTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImageTypes)).BeginInit();
            this.tabPageImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).BeginInit();
            this.tabPageProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.tabPageSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnectToDb
            // 
            this.buttonConnectToDb.AutoSize = true;
            this.buttonConnectToDb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonConnectToDb.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonConnectToDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectToDb.Font = new System.Drawing.Font("Nirmala UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectToDb.Location = new System.Drawing.Point(33, 27);
            this.buttonConnectToDb.Margin = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.buttonConnectToDb.Name = "buttonConnectToDb";
            this.buttonConnectToDb.Size = new System.Drawing.Size(113, 24);
            this.buttonConnectToDb.TabIndex = 0;
            this.buttonConnectToDb.Text = "Connect To Database";
            this.buttonConnectToDb.UseVisualStyleBackColor = true;
            this.buttonConnectToDb.Click += new System.EventHandler(this.buttonConnectToDb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonShowAddDataDlg);
            this.groupBox1.Controls.Add(this.buttonConnectToDb);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 819);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select an action or command";
            // 
            // buttonShowAddDataDlg
            // 
            this.buttonShowAddDataDlg.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAddDataDlg.Location = new System.Drawing.Point(486, 28);
            this.buttonShowAddDataDlg.Name = "buttonShowAddDataDlg";
            this.buttonShowAddDataDlg.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAddDataDlg.TabIndex = 1;
            this.buttonShowAddDataDlg.Text = "Add Data";
            this.buttonShowAddDataDlg.UseVisualStyleBackColor = true;
            this.buttonShowAddDataDlg.Click += new System.EventHandler(this.buttonShowAddDataDlg_Click);
            // 
            // tabControlViewData
            // 
            this.tabControlViewData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlViewData.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlViewData.Controls.Add(this.tabPageImageTypes);
            this.tabControlViewData.Controls.Add(this.tabPageImages);
            this.tabControlViewData.Controls.Add(this.tabPageProjects);
            this.tabControlViewData.Controls.Add(this.tabPageSessions);
            this.tabControlViewData.Location = new System.Drawing.Point(0, 93);
            this.tabControlViewData.Multiline = true;
            this.tabControlViewData.Name = "tabControlViewData";
            this.tabControlViewData.SelectedIndex = 0;
            this.tabControlViewData.Size = new System.Drawing.Size(1185, 726);
            this.tabControlViewData.TabIndex = 2;
            // 
            // tabPageImageTypes
            // 
            this.tabPageImageTypes.Controls.Add(this.dataGridViewImageTypes);
            this.tabPageImageTypes.Location = new System.Drawing.Point(4, 25);
            this.tabPageImageTypes.Name = "tabPageImageTypes";
            this.tabPageImageTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImageTypes.Size = new System.Drawing.Size(1177, 697);
            this.tabPageImageTypes.TabIndex = 0;
            this.tabPageImageTypes.Text = "Image Types";
            this.tabPageImageTypes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageTypes
            // 
            this.dataGridViewImageTypes.AllowUserToAddRows = false;
            this.dataGridViewImageTypes.AllowUserToDeleteRows = false;
            this.dataGridViewImageTypes.AllowUserToOrderColumns = true;
            this.dataGridViewImageTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewImageTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewImageTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewImageTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewImageTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImageTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImageTypes.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewImageTypes.Name = "dataGridViewImageTypes";
            this.dataGridViewImageTypes.Size = new System.Drawing.Size(1171, 691);
            this.dataGridViewImageTypes.TabIndex = 0;
            // 
            // tabPageImages
            // 
            this.tabPageImages.Controls.Add(this.dataGridViewImages);
            this.tabPageImages.Location = new System.Drawing.Point(4, 25);
            this.tabPageImages.Name = "tabPageImages";
            this.tabPageImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImages.Size = new System.Drawing.Size(1176, 310);
            this.tabPageImages.TabIndex = 1;
            this.tabPageImages.Text = "Images";
            this.tabPageImages.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImages
            // 
            this.dataGridViewImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImages.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewImages.Name = "dataGridViewImages";
            this.dataGridViewImages.Size = new System.Drawing.Size(1170, 304);
            this.dataGridViewImages.TabIndex = 1;
            // 
            // tabPageProjects
            // 
            this.tabPageProjects.Controls.Add(this.dataGridViewProjects);
            this.tabPageProjects.Location = new System.Drawing.Point(4, 25);
            this.tabPageProjects.Name = "tabPageProjects";
            this.tabPageProjects.Size = new System.Drawing.Size(1176, 310);
            this.tabPageProjects.TabIndex = 2;
            this.tabPageProjects.Text = "Projects";
            this.tabPageProjects.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProjects.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.Size = new System.Drawing.Size(1176, 310);
            this.dataGridViewProjects.TabIndex = 1;
            // 
            // tabPageSessions
            // 
            this.tabPageSessions.Controls.Add(this.dataGridViewSessions);
            this.tabPageSessions.Location = new System.Drawing.Point(4, 25);
            this.tabPageSessions.Name = "tabPageSessions";
            this.tabPageSessions.Size = new System.Drawing.Size(1176, 310);
            this.tabPageSessions.TabIndex = 3;
            this.tabPageSessions.Text = "Sessions";
            this.tabPageSessions.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSessions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.Size = new System.Drawing.Size(1176, 310);
            this.dataGridViewSessions.TabIndex = 1;
            // 
            // openFileDialogAddNewFiles
            // 
            this.openFileDialogAddNewFiles.FileName = "openFileDialog1";
            // 
            // FormCatalogFunctionsDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 819);
            this.Controls.Add(this.tabControlViewData);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "FormCatalogFunctionsDriver";
            this.Text = "AstroPhoto Catalog Loader/Reader Function tester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlViewData.ResumeLayout(false);
            this.tabPageImageTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImageTypes)).EndInit();
            this.tabPageImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).EndInit();
            this.tabPageProjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.tabPageSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnectToDb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControlViewData;
        private System.Windows.Forms.TabPage tabPageImageTypes;
        private System.Windows.Forms.DataGridView dataGridViewImageTypes;
        private System.Windows.Forms.TabPage tabPageImages;
        private System.Windows.Forms.TabPage tabPageProjects;
        private System.Windows.Forms.TabPage tabPageSessions;
        private System.Windows.Forms.DataGridView dataGridViewImages;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.OpenFileDialog openFileDialogAddNewFiles;
        private System.Windows.Forms.Button buttonShowAddDataDlg;
    }
}

