using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStringTestDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonParseString_Click(object sender, EventArgs e)
        {
            parseFileNameForInfo(textBoxStringToParse.Text);

            
            
        }


        private List<KeyValuePair<String, String>> parseFileNameForInfo(String filename)
        {
            String patternStartImageType = "[LDFB]{1}_{1}";
            String targetPattern = "[A-Z]+[0-9]+_";
            String sequencePatter = "[0-9]+_";
            String ISOPattern = "ISO[0-9]+_";
            String DurationPattern = "[0-9]+s_";
            String TempPattern = "[0-9]+";

            List<KeyValuePair<String, String>> infosInFileName = new List<KeyValuePair<string, string>>();
            ///Match resultMatch = Regex.Match(filename, (patternStartImageType + targetPattern + DurationPattern + ISOPattern + sequencePatter + TempPattern));
            Match resultMatch = Regex.Match(filename, (patternStartImageType + targetPattern + DurationPattern+ISOPattern+sequencePatter));
            if(resultMatch.Success==true)
            {
                List<String> attribs = filename.Split('_').ToList();

                KeyValuePair<String, String> pairToAdd = new KeyValuePair<string, string>("ImageType", attribs[0]);
                infosInFileName.Add(pairToAdd);
                KeyValuePair<String, String> pairToAdd2 = new KeyValuePair<string, string>("Target", attribs[1]);
                infosInFileName.Add(pairToAdd2);
                KeyValuePair<String, String> pairToAdd3 = new KeyValuePair<string, string>("Duration", attribs[2]);
                infosInFileName.Add(pairToAdd3);
                KeyValuePair<String, String> pairToAdd4 = new KeyValuePair<string, string>("ISO", attribs[3]);
                infosInFileName.Add(pairToAdd4);
                KeyValuePair<String, String> pairToAdd5 = new KeyValuePair<string, string>("SequenceNumber", attribs[4]);
                infosInFileName.Add(pairToAdd5);
                return infosInFileName;

                //// Parse for those values and populate infos and return it
            }
            Match resultMatch2 = Regex.Match(filename, (patternStartImageType + sequencePatter + ISOPattern + DurationPattern));
            {
                if (resultMatch2.Success == true)
                {
                    List<String> attribs = filename.Split('_').ToList();
                    KeyValuePair<String, String> pairToAdd8 = new KeyValuePair<string, string>("ImageType", attribs[0]);
                    infosInFileName.Add(pairToAdd8);
                    KeyValuePair<String, String> pairToAdd6 = new KeyValuePair<string, string>("SequenceNumber", attribs[1]);
                    infosInFileName.Add(pairToAdd6);
                    KeyValuePair<String, String> pairToAdd7 = new KeyValuePair<string, string>("ISO", attribs[2]);
                    infosInFileName.Add(pairToAdd7);                                       
                    KeyValuePair<String, String> pairToAdd9 = new KeyValuePair<string, string>("Duration", attribs[3]);
                    infosInFileName.Add(pairToAdd9);
                    return infosInFileName;
                }
            }
            return infosInFileName;
        }
    }
}
