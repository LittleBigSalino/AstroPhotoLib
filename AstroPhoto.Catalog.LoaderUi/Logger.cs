using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroPhoto.Catalog.LoaderUi
{
    public class Logger
    {
        public String PathForLog { get; set; }
        public String LogFileName { get; set; }
        public Logger(String path, String fileName)
        {
            PathForLog = path;
            LogFileName = fileName;
        }

        public void WriteLog(String text)
        {
            try
            {
                string myfile = Path.Combine(PathForLog, LogFileName);

                // Appending the given texts 
                using (StreamWriter sw = File.AppendText(myfile))
                {
                    sw.WriteLine(DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToShortTimeString());
                    sw.WriteLine(text);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            // code 
        }
    }
}
