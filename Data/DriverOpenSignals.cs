using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
using BC.Dal.Business;
using Newtonsoft.Json;
using BC.Dal.Entity;

namespace BC.Resources
{
    public class DriverOpenSignals
    {

        FrmMain obFrmMain;

        FrmChartBiosignal obFrmChartECG;
        FrmChartBiosignal obFrmChartEEG;
        FrmChartBiosignal obFrmChartEGG;
        FrmChartBiosignal obFrmChartEMG;
        FrmChartBiosignal obFrmChartEDA;
        FrmChartBiosignal obFrmChartACC;

        BConfigurationChart oBConfigurationChart = new BConfigurationChart();
        ChartConfiguration chartConfigurationECG;
        ChartConfiguration chartConfigurationEEG;
        ChartConfiguration chartConfigurationEGG;
        ChartConfiguration chartConfigurationEMG;
        ChartConfiguration chartConfigurationEDA;
        ChartConfiguration chartConfigurationACC;

        private static BConfig bConfig = new BConfig();
        private static Config eConfig = new Config();

        public static StringBuilder StrBuilder = new StringBuilder();
     
        public DriverOpenSignals(FrmMain _obFrmMain, FrmChartBiosignal _obFrmChartECG, FrmChartBiosignal _obFrmChartEEG, FrmChartBiosignal _obFrmChartEGG, FrmChartBiosignal _obFrmChartEMG, FrmChartBiosignal _obFrmChartEDA, FrmChartBiosignal _obFrmChartACC)
        {
            obFrmMain = _obFrmMain;
            obFrmChartECG = _obFrmChartECG;
            obFrmChartEEG = _obFrmChartEEG;
            obFrmChartEGG = _obFrmChartEGG;
            obFrmChartEMG = _obFrmChartEMG;
            obFrmChartEDA = _obFrmChartEDA;
            obFrmChartACC = _obFrmChartACC;
            
            chartConfigurationECG = JsonConvert.DeserializeObject<ChartConfiguration>(oBConfigurationChart.GetConfigurationChart("ECG").Json); 
            chartConfigurationEEG = JsonConvert.DeserializeObject<ChartConfiguration>(oBConfigurationChart.GetConfigurationChart("EEG").Json);
            chartConfigurationEGG = JsonConvert.DeserializeObject<ChartConfiguration>(oBConfigurationChart.GetConfigurationChart("EGG").Json);
            chartConfigurationEMG = JsonConvert.DeserializeObject<ChartConfiguration>(oBConfigurationChart.GetConfigurationChart("EMG").Json);
            chartConfigurationEDA = JsonConvert.DeserializeObject<ChartConfiguration>(oBConfigurationChart.GetConfigurationChart("EDA").Json);
            chartConfigurationACC = JsonConvert.DeserializeObject<ChartConfiguration>(oBConfigurationChart.GetConfigurationChart("ACC").Json);

            eConfig = bConfig.GetConfig();
        }


        private bool conected = false;
        private Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public void StartClient(IPAddress Ip, int Port)
        {
            // Data buffer for incoming data.
            byte[] bytes = new byte[1024*10];

            // Connect to a remote device.
            try
            {
                IPAddress ipAddress = IPAddress.Parse(Ip.ToString());
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, Port);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    sender.Connect(remoteEP);
                    conected = true;
                   // Log.writeLog("Connected: " + sender.RemoteEndPoint.ToString(), Config.GetNameLog);
                    obFrmMain.UpdatingTextBox("Connected: " + sender.RemoteEndPoint.ToString());
                    
                    while (conected)
                    {
                           
                        string Received = "";
                        // Receive the response from the remote device.
                        int bytesRec = sender.Receive(bytes);
                        Received = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                        if (bytesRec > 0)
                        {
                         
                            if (Received.IndexOf("{\"returnCode\": 0, \"returnData\": {\"packetLoss\": 0,") <= -1)
                            {
                                if (Received.IndexOf("{\"returnCode\": 0, \"returnData\": {\"" + eConfig.MacAddress + "\":") > -1)
                                {
                                    obFrmMain.UpdatingTextBox(" [Input] " + Received);
                                    try
                                    {
                                        if (IsFormOpen("FrmECG"))
                                            obFrmChartECG.UpdateChart(Received, chartConfigurationECG, "ECG");

                                        if (IsFormOpen("FrmEEG"))
                                            obFrmChartEEG.UpdateChart(Received, chartConfigurationEEG, "EEG");

                                        if (IsFormOpen("FrmEGG"))
                                            obFrmChartEGG.UpdateChart(Received, chartConfigurationEGG, "EGG");

                                        if (IsFormOpen("FrmEMG"))
                                            obFrmChartEMG.UpdateChart(Received, chartConfigurationEMG, "EMG");

                                        if (IsFormOpen("FrmEDA"))
                                            obFrmChartEDA.UpdateChart(Received, chartConfigurationEDA, "EDA");

                                        if (IsFormOpen("FrmACC"))
                                            obFrmChartACC.UpdateChart(Received, chartConfigurationACC, "ACC");

                                        obFrmMain.AddJsonBiosignals(Received);

                                        
                                    }
                                    catch (Exception ex)
                                    {
                                        Log.writeLog(ex.Message, ConfigSystem.GetNameLog);
                                    }

                                }
                            }
                        }
                    }

                    if (!conected)
                    {
                        // Release the socket.
                        sender.Shutdown(SocketShutdown.Both);
                        sender.Close();
                    }
                }
                catch (ArgumentNullException ane)
                {
                    obFrmMain.UpdatingTextBox("ArgumentNullException: " + ane.ToString());
                }
                catch (SocketException se)
                {
                   // obFrmMain.UpdatingTextBox("SocketException: " + se.ToString());                  
                }
                catch (Exception e)
                {
                   // obFrmMain.UpdatingTextBox("Unexpected exception");            
                }
            }
            catch (Exception e)
            {
                Log.writeLog(e.ToString(), ConfigSystem.GetNameLog);                   
            }
        }

        public bool IsFormOpen(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.Equals(formName))
                {
                    return true; //The form is open
                }
            }
            return false; //The form is not open
        }



        public void SendCommand(string strMsg)
        {
            try
            {
                // Encode the data string into a byte array.
                byte[] msg = Encoding.ASCII.GetBytes(strMsg);
                sender.Send(msg);
                obFrmMain.UpdatingTextBox(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " [Output] " + strMsg);

            }
            catch(Exception ex)
            {
                obFrmMain.UpdatingTextBox(ex.Message);
            }
            
        }

        /// <summary>
        /// CloseClient
        /// </summary>
        public void CloseClient()
        {
            // Release the socket.
            try
            {
               
                sender.Shutdown(SocketShutdown.Both);
                sender.Close(); 
                conected = false;
            }
            catch (Exception e)
            {
              
            }

        }

    }

}
