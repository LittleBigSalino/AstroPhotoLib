using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AstroPhoto.Catalog.LoaderUi
{


    public class AstroData
    {

        public const String IMAGETYPE = "ImageType";
        public const String TARGET = "Target";
        public const String DURATION = "Duration";
        public const String TEMP = "Temperature";
        public const String ISO = "ISO";
        public const String SEQUENCENUMBER = "SequenceNumber";
        public const String SESSIONDATE = "SessionDate";
        public const String CREATEDDATETIME = "CreatedDateTime";

        public const int LIGHTFRAME = 1;
        public const int DARKFRAME = 2;
        public const int FLATFRAME = 3;
        public const int BIASFRAME = 4;
        public const int DARKFLATFRAME = 5;
        public const int STACKED = 6;
        public const int PROCESSED = 7;
        public const int INPROCESS = 8;
        public const int FINALIMAGERAW = 9;
        public const int FINALIMAGEJPG = 10;


        public AstroPhotoDataDataContext Dc { get; set; }
        public Logger LogWriter { get; set; }

        public bool AutoCreateSubItemsNotCreated { get; set; }
        public AstroData()
        {
            this.LogWriter = new Logger("", "logFile.txt");
            this.Dc = new AstroPhotoDataDataContext();
            this.AutoCreateSubItemsNotCreated = true;
        }

        //public Image CreateImageObjectFromFile(String path)
        //{
            
        //}

        public DateTime DetermineSessionDate(DateTime fileDate)
        {
            if (fileDate.Hour > 18)
            {
                return new DateTime(fileDate.Year, fileDate.Month, fileDate.Day);
            }
            else
            {
                return new DateTime(fileDate.AddDays(-1).Year, fileDate.AddDays(-1).Month, fileDate.AddDays(-1).Day);
            }
        }

        public KeyValuePair<String, String> EvaluateNamePart(String namePart)
        {
            if (namePart == "CR2")
            {
                return new KeyValuePair<string, string>();
            }
            String patternStartImageType = "[LDFB]{1}";
            String targetPattern = "NGC|NG|IC|M[0-9]+";
            String sequencePatter = "[0-9]+";
            String ISOPattern = "ISO[0-9]+";
            String DurationPattern = "[0-9]+s";
            String TempPattern = "[0-9]+[C]{1}";

            Match imageTypeMatch = Regex.Match(namePart, patternStartImageType);
            if (imageTypeMatch.Success == true)
            {
                return new KeyValuePair<string, string>(IMAGETYPE, namePart);
            }
            Match targetTypeMath = Regex.Match(namePart, targetPattern);
            if (targetTypeMath.Success == true)
            {
                return new KeyValuePair<string, string>(TARGET, namePart);
            }
            Match isoTypeMatch = Regex.Match(namePart, ISOPattern);
            if (isoTypeMatch.Success == true)
            {
                return new KeyValuePair<string, string>(ISO, namePart);
            }
            Match durationTypeMatch = Regex.Match(namePart, DurationPattern);
            if (durationTypeMatch.Success == true)
            {
                return new KeyValuePair<string, string>(DURATION, namePart);
            }
            Match tempTypeMatch = Regex.Match(namePart, TempPattern);
            if (tempTypeMatch.Success == true)
            {
                return new KeyValuePair<string, string>(TEMP, namePart);
            }
            Match sequenceTypeMatch = Regex.Match(namePart, sequencePatter);
            if (sequenceTypeMatch.Success == true)
            {
                return new KeyValuePair<string, string>(SEQUENCENUMBER, namePart);
            }
            return new KeyValuePair<string, string>();
        }

        public Image ParseFileNameToImageInfo(String filename, AstroPhotoDataDataContext dc)
        {
            this.LogWriter.WriteLog("In parseFileNameToImage. Data: " + filename);
            try
            {
                List<KeyValuePair<String, String>> infosInFileName = new List<KeyValuePair<string, string>>();


                FileInfo inputFileName = new FileInfo(filename);                
                if ((inputFileName.Name.StartsWith("Incomplete"))||(inputFileName.Name.Length<7))
                {
                    return null;
                }               
                char[] splitters = new char[2];
                splitters[0] = '_';
                splitters[1] = '.';
                List<String> attribs = inputFileName.Name.Split(splitters).ToList();

                ///Match resultMatch = Regex.Match(filename, (patternStartImageType + targetPattern + DurationPattern + ISOPattern + sequencePatter + TempPattern));
                foreach (String x in attribs)
                {
                    KeyValuePair<String, String> newInfoItem = EvaluateNamePart(x);
                    if (newInfoItem.Value != null)
                    {
                        infosInFileName.Add(newInfoItem);
                    }
                }
                DateTime sesssionDate = this.DetermineSessionDate(inputFileName.CreationTime);
                infosInFileName.Add(new KeyValuePair<string, string>(SESSIONDATE, sesssionDate.ToShortDateString()));
                infosInFileName.Add(new KeyValuePair<string, string>(CREATEDDATETIME, (inputFileName.CreationTime.ToShortDateString() + " " +inputFileName.CreationTime.ToShortTimeString())));
                infosInFileName.Add(new KeyValuePair<string, string>("FilePath", filename));
                Image imgStub = GenerateImageStubFromInfos(infosInFileName, dc);
                return imgStub;
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog("Error in ParseFileNameForInfo");
                LogWriter.WriteLog(ex.Message);
                return null;
            }
        }

        private int GetIdForImageType(String letter)
        {
            switch(letter)
            {
                case "L":
                    return LIGHTFRAME;
                case "F":
                    return FLATFRAME;
                case "B":
                    return BIASFRAME;
                case "D":
                    return DARKFRAME;
                case "DF":
                    return DARKFLATFRAME;
                default:
                    break;
            }
            return -1;
        }

        public Image GenerateImageStubFromInfos(List<KeyValuePair<String, String>> infos, AstroPhotoDataDataContext dc)
        {

            var x = infos.Where(ky => ky.Key == "FilePath").FirstOrDefault();
            string filepath = x.Value;
            var y = infos.Where(ky => ky.Key == CREATEDDATETIME).FirstOrDefault();
            string createdDataTime = y.Value;
            var z = infos.Where(ky => ky.Key == SESSIONDATE).FirstOrDefault();
            string sessionData = z.Value;
            var a = infos.Where(ky => ky.Key == SEQUENCENUMBER).FirstOrDefault();
            string sequenceNumber = a.Value;
            var b = infos.Where(ky => ky.Key == TEMP).FirstOrDefault();
            string temperature = b.Value;
            var c = infos.Where(ky => ky.Key == DURATION).FirstOrDefault();
            string duration = c.Value;
            var d = infos.Where(ky => ky.Key == ISO).FirstOrDefault();
            string iso= d.Value;
            var e = infos.Where(ky => ky.Key == TARGET).FirstOrDefault();
            string target = e.Value;
            var f = infos.Where(ky => ky.Key == IMAGETYPE).FirstOrDefault();
            string imageType = f.Value;
            LogWriter.WriteLog("Before Create Image");
            String dateToParse = (sessionData.Split(' '))[0];
            DateTime sessionDate = DateTime.Parse(sessionData);
            LogWriter.WriteLog("SessionData :" + dateToParse);
            if(target==null)
            {
                target="Unassigned";
            }
            Image retVal = new Image()
            {
                FilePath = filepath,
                DateAdded = DateTime.Parse(createdDataTime),
                ImageTypeId = GetIdForImageType(imageType),
                ProjectId = AddProject(target, dc),
                SessionId = AddSessionDate(sessionDate, dc)
            };
            logImage(retVal, LogWriter);
            return retVal;
        }

        public void logImage(Image imageToLog, Logger logger)
        {
            logger.WriteLog("ImageLogger:\nProjectId : " + imageToLog.ImageTypeId.ToString() + "\nSessionId: " + imageToLog.SessionId.ToString() + "\nImageTypeId: " + imageToLog.ImageTypeId.ToString()
                + "\nFilePath : " + imageToLog.FilePath);            
        }

        public int SessionExists(DateTime seshToCheck, AstroPhotoDataDataContext dc)
        {
            try
            {
                var result = (from x in dc.Sessions
                             where x.SessionLabel == seshToCheck.ToShortDateString()
                             select x).FirstOrDefault();
                if (result == null)
                {
                    LogWriter.WriteLog("Checking for existince of Session: " + seshToCheck.ToShortDateString());
                    LogWriter.WriteLog("Session Exists check returned false");
                    
                    return -1;
                }
                else
                {
                    LogWriter.WriteLog("Checking for existince of Session: " + seshToCheck.ToShortDateString());
                    LogWriter.WriteLog("Session Exists check returned true");
                    return result.SessionId;
                }
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog(ex.Message);
                return -1;
            }
        }



        public int ProjectExists(String name, AstroPhotoDataDataContext dc)
        {
            try
            {
                var result = (from x in dc.Projects
                             where x.Name == name
                             select x).FirstOrDefault();
                if (result == null)
                {
                    LogWriter.WriteLog("Checking for existince of Project: " + name);
                    LogWriter.WriteLog("Session Exists check returned false");
                    return -1;
                }
                else
                {
                    LogWriter.WriteLog("Checking for existince of Project: " + name);
                    LogWriter.WriteLog("Session Exists check returned true");
                    return result.ProjectId;
                }
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog(ex.Message);
                return -1;
            }
        }


        


        public bool ImageFileExistsInDb(String fullName, AstroPhotoDataDataContext dc)
        {
            try
            {
                var result = (from x in dc.Images
                             where x.FilePath == fullName
                             select x).FirstOrDefault();
                if (result == null)
                {
                    LogWriter.WriteLog("Checking for existince of Image: " + fullName);
                    LogWriter.WriteLog("Image exists returned false");
                    return false;
                }
                else
                {
                    LogWriter.WriteLog("Checking for existince of Image: " + fullName);
                    LogWriter.WriteLog("Image exists returned true");
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog("------ERROR------\n" + ex.Message);
                return false;
            }
        }

        public int AddSessionDate(DateTime seshToAdd, AstroPhotoDataDataContext dc)
        {
            int idExists = SessionExists(seshToAdd, dc);
            if (idExists==-1)
            {
                try
                {

                    Session toAdd = new Session()
                    {
                        DateOfSession = seshToAdd,
                        SessionLabel = seshToAdd.ToShortDateString()
                    };
                    dc.Sessions.InsertOnSubmit(toAdd);
                    dc.SubmitChanges();
                    LogWriter.WriteLog("Successfully added new Session entry to database");
                    LogWriter.WriteLog("Session Date : " + seshToAdd.ToShortDateString());
                    return toAdd.SessionId;
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLog("------ERROR------\n" + ex.Message);
                    return -1;
                }
            }
            else
            {
                return idExists;
            }
        }

        public int AddProject(String name, AstroPhotoDataDataContext dc)
        {
            int idExists = ProjectExists(name, dc);
            if (idExists==-1)
            {
                try
                {
                    Project toAdd = new Project()
                    {
                        Name = name,
                        DateCreated = DateTime.Now
                    };
                    dc.Projects.InsertOnSubmit(toAdd);
                    dc.SubmitChanges();
                    LogWriter.WriteLog("Successfully added new Project entry to database");
                    LogWriter.WriteLog("Project Name: " + name);
                    return toAdd.ProjectId;
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLog("------ERROR------\n" + ex.Message);
                    return -1;
                }
            }                    
            else
            {
                return idExists;
            }
        }



        public int AddImage(Image toAdd, AstroPhotoDataDataContext dc)
        {
            bool fileExists = ImageFileExistsInDb(toAdd.FilePath, dc);
            if ((!fileExists)&&(toAdd.ImageTypeId!=-1))
            {
                try
                {  
                    
                    dc.Images.InsertOnSubmit(toAdd);
                    dc.SubmitChanges();
                    LogWriter.WriteLog("Successfully added new Image entry to database");
                    LogWriter.WriteLog("ImagePath : " + toAdd.FilePath);
                    return toAdd.ImageId;
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLog("------ERROR------\n" + ex.Message);
                    return -1;
                }

            }
            else
            {
                return 0;
            }
        }
    }
}
