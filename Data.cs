using Newtonsoft.Json;
using Sky.Data.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DMR_Contact_List_Generator
{
    public class Data
    {
        private System.Windows.Forms.TextBox txt_Console;
        public Data(System.Windows.Forms.TextBox logs)
        {
            txt_Console = logs;
            Log("System ready.");
            
        }

        public void Download(String radioModel, String[] countries)
        {
            Log("Downloading DMR Contact Lists from RadioID.Net");
            Model.DMRContact[] contacts = DownloadDMRList(countries);
            switch(radioModel)
            {
                case "Baofeng DM-1701":
                    Log("Converting list for Baofend DM-1701");
                    WriteDM1701List(contacts);
                    Log("Data conversion complete. See Export File");
                    break;
                default:
                    Log("No radio model was chosen");
                    break;
            }
        }

        public void WriteDM1701List(Model.DMRContact[] contacts)
        {
            List<Model.RadioClass.DM1701> returnList = new List<Model.RadioClass.DM1701>();
            Log("Writing CSV File " + "data.csv");
            using (TextWriter tw = new StreamWriter("data.csv"))
            {
                tw.WriteLine("Radio ID,CallSign,Name,NickName,City,State,Country");
                foreach (var item in contacts)
                {
                    Model.RadioClass.DM1701 classItem = new Model.RadioClass.DM1701();
                    classItem.Callsign = item.callsign;
                    classItem.City = item.city;
                    classItem.Country = item.country;
                    classItem.Name = item.fname + " " + item.surname;
                    classItem.NickName = item.fname;
                    classItem.RadioID = item.id;
                    classItem.State = item.state;
                    returnList.Add(classItem);
                    //Log("Seen " + item.callsign + " - " + classItem.Name);

                    tw.WriteLine(classItem.RadioID + ", "
                               + classItem.Callsign + ", " 
                               + classItem.Name + ", "
                               + classItem.NickName + ", "
                               + classItem.City + ", "
                               + classItem.State + ", "
                               + classItem.Country);
                    tw.Flush();
                }
            }

        }

        public Model.DMRContact[] DownloadDMRList(String[] countries)
        {
            String baseURL = "https://www.radioid.net/api/dmr/user/?";
            baseURL = baseURL + GenerateContriesString(countries);
            String dmrData;
            using var wc = new System.Net.WebClient();
            dmrData = wc.DownloadString(baseURL);
            Model.DMRFile jsonFile = JsonConvert.DeserializeObject<Model.DMRFile>(dmrData);
            Log("Download Complete");
            return jsonFile.results;
        }

        private String GenerateContriesString(String[] countries)
        {
            return "country=United%20States&country=Canada";
        }

        public void Log(String logMsg)
        {
            txt_Console.Text += logMsg + Environment.NewLine;
            txt_Console.SelectionStart = txt_Console.Text.Length;
            txt_Console.ScrollToCaret();
        }

    }
}
