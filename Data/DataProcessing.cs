using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using static BC.Forms.FrmBaseBiosignal;
using BC.Dal.Business;
using BC.Dal.Entity;
using System.Linq;

namespace BC.Resources
{
    public static class DataProcessing
    {

        private static Dictionary<string, int> dyChannels = new Dictionary<string, int>();
        private static BConfig bConfig = new BConfig();
        private static Config eConfig = new Config();
        static DataProcessing()
        {
            eConfig = bConfig.GetConfig();
            SetChannels();
        }

        private static void SetChannels()
        {
            Dictionary<string, int> _dyChannels = new Dictionary<string, int>();
            if (eConfig.channelACC > 0)
                _dyChannels.Add("ACC", eConfig.channelACC);

            if (eConfig.channelECG > 0)
                _dyChannels.Add("ECG", eConfig.channelECG);

            if (eConfig.channelEDA > 0)
                _dyChannels.Add("EDA", eConfig.channelEDA);

            if (eConfig.channelEEG > 0)
                _dyChannels.Add("EEG", eConfig.channelEEG);

            if (eConfig.channelEGG > 0)
                _dyChannels.Add("EGG", eConfig.channelEGG);

            if (eConfig.channelEMG > 0)
                _dyChannels.Add("EMG", eConfig.channelEMG);


            
            List<KeyValuePair<string, int>> dyChannelsSort = _dyChannels.OrderByDescending(x => x.Value).ToList();

            
            int newValue= 1;
            foreach (var item in dyChannelsSort)
            {
                dyChannels[item.Key] = newValue;
                newValue++;
            }

        }


        public static string GetDataJsonSignals(string signals)
        {

            string reply = "";
            
            if (String.Compare(eConfig.captureECG,"S") == 0)
            {
                List<dynamic> dataECG = DataProcessing.LoadDataFromJson(signals, "ECG", true);
                reply += "\"ECG\": " + "[" + string.Join(", ", dataECG) + "],";
            }

            if (String.Compare(eConfig.captureEGG, "S") == 0)
            {
                List<dynamic> dataEGG = DataProcessing.LoadDataFromJson(signals, "EGG", true);
                reply += "\"EGG\": " + "[" + string.Join(", ", dataEGG) + "],";
            }

            if (String.Compare(eConfig.captureEDA, "S") == 0)
            {
                List<dynamic> dataEDA = DataProcessing.LoadDataFromJson(signals, "EDA", true);
                reply += "\"EDA\": " + "[" + string.Join(", ", dataEDA) + "],";
            }

            if (String.Compare(eConfig.captureEEG, "S") == 0)
            {
                List<dynamic> dataEEG = DataProcessing.LoadDataFromJson(signals, "EEG", true);
                reply += "\"EEG\": " + "[" + string.Join(", ", dataEEG) + "]";
            }

            if (String.Compare(eConfig.captureEMG, "S") == 0)
            {
                List<dynamic> dataEMG = DataProcessing.LoadDataFromJson(signals, "EMG", true);
                reply += "\"EMG\": " + "[" + string.Join(", ", dataEMG) + "]";
            }

            if (String.Compare(eConfig.captureACC, "S") == 0)
            {
                List<dynamic> dataACC = DataProcessing.LoadDataFromJson(signals, "ACC", true);
                reply += "\"ACC\": " + "[" + string.Join(", ", dataACC) + "]";
            }
            

            return reply;
        }

        public static List<dynamic> LoadDataFromJson(string _jsonData, string typeBioSignal, bool forceDecimalAsPoint = false)
        {
            List<dynamic> listSignal = new List<dynamic>();

            if (_jsonData.IndexOf("position")  <= -1 && !String.IsNullOrEmpty(_jsonData))
            {
                string jsonData = _jsonData.Replace(eConfig.MacAddress, "MAC_ADDRESS");

                // Define classes to match the JSON structure
                // Deserialize the JSON
                RootObject data = JsonConvert.DeserializeObject<RootObject>(jsonData);

                // Access the data
                List<List<dynamic>> signalData = data.ReturnData.Signal;
                
                foreach (List<dynamic> row in signalData)
                {
                  //  Console.WriteLine(typeBioSignal +"|"+ dyChannels[typeBioSignal]);
                    int position = row.Count() - dyChannels[typeBioSignal];
                    //Console.WriteLine(position);
                    dynamic vrAjust = (row[position]);

                    if (forceDecimalAsPoint)
                        listSignal.Add(vrAjust.ToString().Replace(",", "."));
                    else
                        listSignal.Add(vrAjust);

                }
            }                
            
            
            return listSignal;
        }

        public static string GetChannelsConverted(Config eConfig)
        {
            int[] activeChannels = new int[6];
            activeChannels[0] = eConfig.channelECG;
            activeChannels[1] = eConfig.channelEEG;
            activeChannels[2] = eConfig.channelEGG;
            activeChannels[3] = eConfig.channelEMG;
            activeChannels[4] = eConfig.channelEDA;
            activeChannels[5] = eConfig.channelACC;

            int[] activeChannelsConverted = new int[6];
            Array.Sort(activeChannels);

            string strChannels = "";

            for (int i = 1; i <= 6; i++)
            {
                if (Array.IndexOf(activeChannels, i) >= 0)
                    strChannels += "1";
                else
                    strChannels += "0";
            }

            return strChannels;

        }
    }
}
