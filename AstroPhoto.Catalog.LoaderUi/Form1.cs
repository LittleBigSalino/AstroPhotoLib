
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public List<ImagesView> IV { get; set; }
        public AstroPhotoDataDataContext apdc { get; set; }
        public FormCatalogFunctionsDriver()
        {
            InitializeComponent();
        }

        private void buttonConnectToDb_Click(object sender, EventArgs e)
        {
            apdc = new AstroPhotoDataDataContext();
            try
            {
                LoadProps(apdc);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LoadProps(AstroPhotoDataDataContext dc)
        {
            APImageTypes = (from x in dc.ImageTypes
                            select x).ToList();
            dataGridViewImageTypes.DataSource = APImageTypes;
            //comboBoxImageTypes.DataSource = APImageTypes;
            //comboBoxImageTypes.DisplayMember = "Name";
            //APImages = (from x in dc.Images
            //            select x).ToList();
            IV = dc.ImagesViews.ToList();
                        
            dataGridViewImages.DataSource = IV;
            APProjects = (from x in dc.Projects
                          select x).ToList();
            dataGridViewProjects.DataSource = APProjects;
            //comboBoxSelectProject.DataSource = APProjects;
            //comboBoxSelectProject.DisplayMember = "Name";
            APSessions = (from x in dc.Sessions
                          select x).ToList();
            dataGridViewSessions.DataSource = APSessions;
            //comboBoxSelectSession.DataSource = APSessions;
            //comboBoxSelectSession.DisplayMember = "SessionLabel";
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

 

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialogAddNewFiles.ShowDialog()==DialogResult.OK)
            {
                List<FileInfo> fileList = new List<FileInfo>();
                List<String> paths = openFileDialogAddNewFiles.FileNames.ToList();
                if(paths.Count<1)
                {
                    return;
                }
                foreach(String x in paths)
                {
                    FileInfo fileToAdd = new FileInfo(x);
                    fileList.Add(fileToAdd);
                }

                //Image imageToAdd = new Image()
                //{
                //    ImageTypeId = (comboBoxImageTypes.SelectedItem as ImageType).ImageTypeId,
                //    ProjectId = (comboBoxSelectProject.SelectedItem as Project).ProjectId,
                //    SessionId = (comboBoxSelectSession.SelectedItem as Session).SessionId,
                //    FilePath = fileList[0].FullName,
                //    DateAdded = DateTime.Now
                //};
                //apdc.Images.InsertOnSubmit(imageToAdd);
                //apdc.SubmitChanges();
            }
        }

        private void buttonShowAddDataDlg_Click(object sender, EventArgs e)
        {
            FormAddData newAddDataDlg = new FormAddData(apdc);
            if(newAddDataDlg.ShowDialog()==DialogResult.OK)
            {

                MessageBox.Show("Something was added");
            }
            else
            {

            }
        }
    }
}
