using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AstroPhoto.Catalog.LoaderUi
{
    

    public partial class FormAddData : Form
    {
        public const String IMAGETYPE = "ImageType";
        public const String TARGET = "Target";
        public const String DURATION = "Duration";
        public const String TEMP = "Temperature";
        public const String ISO = "ISO";
        public const String SEQUENCENUMBER = "SequenceNumber";
        public const String SESSIONDATE = "SessionDate";
        public const String CREATEDDATETIME = "CreatedDateTime";        


        private List<FileInfo> GetFiles(String path)
        {
            List<FileInfo> retVal = new List<FileInfo>();
            List<String> filesInThisDir = Directory.GetFiles(path,"*.cr2").ToList();
            foreach (String x in filesInThisDir)
            {
                FileInfo fiItemToAdd = new FileInfo(x);
                retVal.Add(fiItemToAdd);
            }
            List<String> directoriesInThisDir = Directory.GetDirectories(path).ToList();
            foreach(String y in directoriesInThisDir)
            {
                List<FileInfo> subFiles = GetFiles(y);
                foreach(FileInfo x in subFiles)
                {
                    retVal.Add(x);
                }
            }
            return retVal;
        }





        private int addOneImageAutoImportByFileName(String fileName)
        {
            try
            {
                if (!File.Exists(fileName))  {return -1;}
                FileInfo thisFileInfo = new FileInfo(fileName);
                DateTime fileCreationDate = thisFileInfo.CreationTime;
                String shortFileName = thisFileInfo.Name;
                String extension = thisFileInfo.Extension;
                if(shortFileName.StartsWith("Incomplete"))
                {
                    return -1;
                }                
                char[] underscoredelim = new char[1]
                    {
                        '_'
                    };                
                List<String> nameParts = shortFileName.Split(underscoredelim).ToList();


                MessageBox.Show(shortFileName);
                String imageType = nameParts[0];
                String target = nameParts[1];
                MessageBox.Show("Target: " + target + "\nImageType: " + imageType + "\nCreatedOn: " + fileCreationDate.ToShortDateString(), "Debug");
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return -1;
            }

            return 0;
        }

        public AstroPhotoDataDataContext ADC{ get; set; }
        public String RootPath { get; set; }

        public AstroData APData { get; set; }
        public List<FileInfo> NewFileInfosBuffer { get; set; }
        public List<Image> NewFilesBuffer { get; set; }
        public FormAddData()
        {
            InitializeComponent();
            APData = new AstroData();

        }

        public FormAddData(AstroPhotoDataDataContext adc)
        {
            InitializeComponent();
            ADC = adc;
            var itypes = (from x in adc.ImageTypes
                         select x).ToList();
            comboBoxImageType.DataSource = itypes;
            comboBoxImageType.DisplayMember = "Name";

            var projects = (from x in adc.Projects
                            select x).ToList();

            var sessions = (from x in adc.Sessions
                            select x).ToList();

            comboBoxProjects.DataSource = projects;
            comboBoxProjects.DisplayMember = "Name";
            comboBoxSession.DataSource = sessions;
            comboBoxSession.DisplayMember = "SessionLabel";
            APData = new AstroData();
        }

        private void buttonBrowseForNewData_Click(object sender, EventArgs e)
        {
            if (openFileDialogAddFile.ShowDialog() == DialogResult.OK)
            {
                //////
                Image imageToAdd = new Image()
                {
                    FilePath = openFileDialogAddFile.FileName,
                    Project = (comboBoxProjects.SelectedItem as Project),
                    Session = (comboBoxSession.SelectedItem as Session),
                    ImageType = (comboBoxImageType.SelectedItem as ImageType),
                    DateAdded = DateTime.Now
                };
                ADC.Images.InsertOnSubmit(imageToAdd);
                ADC.SubmitChanges();
            }
            else
            {
                return;
            }
        }

        private void buttonFolderBrowserImport_Click(object sender, EventArgs e)
        {
            try
            {
                progressBarLoadDataTime.Value = 0;
            if(folderBrowserDialogImport.ShowDialog()==DialogResult.OK)
                {
                ///// Parse and Import directory.
                this.RootPath = folderBrowserDialogImport.SelectedPath;
                NewFileInfosBuffer = GetFiles(this.RootPath);
                MessageBox.Show("New FileInfos Buffer count is " + NewFileInfosBuffer.Count);
                if(checkBoxAutoEverything.Checked==true)
                {
                    int progressTracker = 0;
                        int total = NewFileInfosBuffer.Count;
                        
                        foreach (FileInfo x in NewFileInfosBuffer)
                    {
                        int donePct = progressTracker / total * 100;
                            progressBarLoadDataTime.Value = donePct;
                        Image retValStub = APData.ParseFileNameToImageInfo(x.FullName, ADC);
                        if(retValStub!=null)
                        {
                            APData.AddImage(retValStub, ADC);                            
                        }
                            progressTracker++;
                    }
                    
                }
                
            }
            else
            {
                return;
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
