using AstroPhoto.Catalog.LoaderUi.AstrophotoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroPhoto.Catalog.LoaderUi
{
    public partial class FormCatalogFunctionsDriver : Form
    {
        public List<ImageType> APImageTypes { get; set; }
        public List<Image> APImages { get; set; }
        public List<Project> APProjects { get; set; }
        public List<Session> APSessions { get; set; }

        public AstroPhotoDataDataContext apdc { get; set; }
        public FormCatalogFunctionsDriver()
        {
            InitializeComponent();
        }

        private void buttonConnectToDb_Click(object sender, EventArgs e)
        {
            apdc = new AstroPhotoDataDataContext();
            LoadProps(apdc);
        }

        private void LoadProps(AstroPhotoDataDataContext dc)
        {
            APImageTypes = (from x in dc.ImageTypes
                            select x).ToList();
            dataGridViewImageTypes.DataSource = APImageTypes;           
            comboBoxImageTypes.DataSource = APImageTypes;
            comboBoxImageTypes.DisplayMember = "Name";
            APImages = (from x in dc.Images
                        select x).ToList();
            dataGridViewImages.DataSource = APImages;
            APProjects = (from x in dc.Projects
                          select x).ToList();
            dataGridViewProjects.DataSource = APProjects;
            comboBoxSelectProject.DataSource = APProjects;
            comboBoxSelectProject.DisplayMember = "Name";
            APSessions = (from x in dc.Sessions
                          select x).ToList();
            dataGridViewSessions.DataSource = APSessions;
            comboBoxSelectSession.DataSource = APSessions;
            comboBoxSelectSession.DisplayMember = "SessionLabel";
        }

        private void AutoAddSessionNow(AstroPhotoDataDataContext dc)
        {
            try
            {
                Session newSession = new Session()
                {
                    SessionLabel = DateTime.Now.ToShortDateString(),
                    DateOfSession = DateTime.Now
                };
                dc.Sessions.InsertOnSubmit(newSession);
                dc.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Add Session Error", ex.Message);
            }
        }

        private void AddProjectByName(String name, AstroPhotoDataDataContext dc)
        {
            try
            {
                Project projectToAdd = new Project()
                {
                    Name = name,
                    DateCreated = DateTime.Now
                };
                dc.Projects.InsertOnSubmit(projectToAdd);
                dc.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Add Project Error", ex.Message);
            }
            
        }

        private void AddImageFile(String path, int imageTypeId, int projectId, int sessionId, AstroPhotoDataDataContext dc)
        {
            try
            {
                Image imageToAdd = new Image()
                {
                    ProjectId = projectId,
                    SessionId = sessionId,
                    FilePath = path,
                    ImageTypeId = imageTypeId,
                    DateAdded = DateTime.Now
                };
                dc.Images.InsertOnSubmit(imageToAdd);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Image Error", ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoAddSessionNow(apdc);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBoxNewProjectName.Text))
            {
                AddProjectByName(textBoxNewProjectName.Text, apdc);
                textBoxNewProjectName.Text = "";
            }
            
        }
    }
}
