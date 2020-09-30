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
            this.tabControlViewData = new System.Windows.Forms.TabControl();
            this.tabPageImageTypes = new System.Windows.Forms.TabPage();
            this.tabPageImages = new System.Windows.Forms.TabPage();
            this.tabPageProjects = new System.Windows.Forms.TabPage();
            this.tabPageSessions = new System.Windows.Forms.TabPage();
            this.dataGridViewImageTypes = new System.Windows.Forms.DataGridView();
            this.dataGridViewImages = new System.Windows.Forms.DataGridView();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxNewProjectName = new System.Windows.Forms.TextBox();
            this.comboBoxImageTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectProject = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectSession = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tabControlViewData.SuspendLayout();
            this.tabPageImageTypes.SuspendLayout();
            this.tabPageImages.SuspendLayout();
            this.tabPageProjects.SuspendLayout();
            this.tabPageSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImageTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
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
            this.groupBox1.Controls.Add(this.comboBoxSelectSession);
            this.groupBox1.Controls.Add(this.comboBoxSelectProject);
            this.groupBox1.Controls.Add(this.comboBoxImageTypes);
            this.groupBox1.Controls.Add(this.textBoxNewProjectName);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonConnectToDb);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 573);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select an action or command";
            // 
            // tabControlViewData
            // 
            this.tabControlViewData.Controls.Add(this.tabPageImageTypes);
            this.tabControlViewData.Controls.Add(this.tabPageImages);
            this.tabControlViewData.Controls.Add(this.tabPageProjects);
            this.tabControlViewData.Controls.Add(this.tabPageSessions);
            this.tabControlViewData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlViewData.Location = new System.Drawing.Point(0, 234);
            this.tabControlViewData.Name = "tabControlViewData";
            this.tabControlViewData.SelectedIndex = 0;
            this.tabControlViewData.Size = new System.Drawing.Size(630, 339);
            this.tabControlViewData.TabIndex = 2;
            // 
            // tabPageImageTypes
            // 
            this.tabPageImageTypes.Controls.Add(this.dataGridViewImageTypes);
            this.tabPageImageTypes.Location = new System.Drawing.Point(4, 22);
            this.tabPageImageTypes.Name = "tabPageImageTypes";
            this.tabPageImageTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImageTypes.Size = new System.Drawing.Size(622, 313);
            this.tabPageImageTypes.TabIndex = 0;
            this.tabPageImageTypes.Text = "Image Types";
            this.tabPageImageTypes.UseVisualStyleBackColor = true;
            // 
            // tabPageImages
            // 
            this.tabPageImages.Controls.Add(this.dataGridViewImages);
            this.tabPageImages.Location = new System.Drawing.Point(4, 22);
            this.tabPageImages.Name = "tabPageImages";
            this.tabPageImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImages.Size = new System.Drawing.Size(622, 313);
            this.tabPageImages.TabIndex = 1;
            this.tabPageImages.Text = "Images";
            this.tabPageImages.UseVisualStyleBackColor = true;
            // 
            // tabPageProjects
            // 
            this.tabPageProjects.Controls.Add(this.dataGridViewProjects);
            this.tabPageProjects.Location = new System.Drawing.Point(4, 22);
            this.tabPageProjects.Name = "tabPageProjects";
            this.tabPageProjects.Size = new System.Drawing.Size(622, 313);
            this.tabPageProjects.TabIndex = 2;
            this.tabPageProjects.Text = "Projects";
            this.tabPageProjects.UseVisualStyleBackColor = true;
            // 
            // tabPageSessions
            // 
            this.tabPageSessions.Controls.Add(this.dataGridViewSessions);
            this.tabPageSessions.Location = new System.Drawing.Point(4, 22);
            this.tabPageSessions.Name = "tabPageSessions";
            this.tabPageSessions.Size = new System.Drawing.Size(622, 313);
            this.tabPageSessions.TabIndex = 3;
            this.tabPageSessions.Text = "Sessions";
            this.tabPageSessions.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageTypes
            // 
            this.dataGridViewImageTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImageTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImageTypes.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewImageTypes.Name = "dataGridViewImageTypes";
            this.dataGridViewImageTypes.Size = new System.Drawing.Size(616, 307);
            this.dataGridViewImageTypes.TabIndex = 0;
            // 
            // dataGridViewImages
            // 
            this.dataGridViewImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImages.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewImages.Name = "dataGridViewImages";
            this.dataGridViewImages.Size = new System.Drawing.Size(616, 307);
            this.dataGridViewImages.TabIndex = 1;
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProjects.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.Size = new System.Drawing.Size(622, 313);
            this.dataGridViewProjects.TabIndex = 1;
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSessions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.Size = new System.Drawing.Size(622, 313);
            this.dataGridViewSessions.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(219, 99);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Session";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(233, 169);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Files";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(228, 134);
            this.button4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add Types";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBoxNewProjectName
            // 
            this.textBoxNewProjectName.Location = new System.Drawing.Point(302, 64);
            this.textBoxNewProjectName.Name = "textBoxNewProjectName";
            this.textBoxNewProjectName.Size = new System.Drawing.Size(194, 23);
            this.textBoxNewProjectName.TabIndex = 5;
            // 
            // comboBoxImageTypes
            // 
            this.comboBoxImageTypes.FormattingEnabled = true;
            this.comboBoxImageTypes.Location = new System.Drawing.Point(33, 134);
            this.comboBoxImageTypes.Name = "comboBoxImageTypes";
            this.comboBoxImageTypes.Size = new System.Drawing.Size(175, 24);
            this.comboBoxImageTypes.TabIndex = 6;
            // 
            // comboBoxSelectProject
            // 
            this.comboBoxSelectProject.FormattingEnabled = true;
            this.comboBoxSelectProject.Location = new System.Drawing.Point(33, 65);
            this.comboBoxSelectProject.Name = "comboBoxSelectProject";
            this.comboBoxSelectProject.Size = new System.Drawing.Size(175, 24);
            this.comboBoxSelectProject.TabIndex = 7;
            // 
            // comboBoxSelectSession
            // 
            this.comboBoxSelectSession.FormattingEnabled = true;
            this.comboBoxSelectSession.Location = new System.Drawing.Point(33, 97);
            this.comboBoxSelectSession.Name = "comboBoxSelectSession";
            this.comboBoxSelectSession.Size = new System.Drawing.Size(175, 24);
            this.comboBoxSelectSession.TabIndex = 8;
            // 
            // FormCatalogFunctionsDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(630, 573);
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
            this.tabPageImages.ResumeLayout(false);
            this.tabPageProjects.ResumeLayout(false);
            this.tabPageSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImageTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxImageTypes;
        private System.Windows.Forms.TextBox textBoxNewProjectName;
        private System.Windows.Forms.ComboBox comboBoxSelectSession;
        private System.Windows.Forms.ComboBox comboBoxSelectProject;
    }
}

