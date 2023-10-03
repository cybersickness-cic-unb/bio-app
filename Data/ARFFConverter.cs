using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BC.Data
{
    public class ARFFConverter
    {
        public async Task<string> ConvertXMLToARFF(string rootDirectory, Action updateProgressBar)
        {
            string strArffContent = "";
            try
            {
                // Get all subdirectories of the root directory
                string[] subdirectories = Directory.GetDirectories(rootDirectory);


                // Process the XML files in each subdirectory asynchronously
                await Task.Run(() =>
                {
                    StringBuilder arffContent = new StringBuilder();

                    // Create the ARFF file
                    arffContent.AppendLine("@relation userdata");
                    arffContent.AppendLine();
                    arffContent.AppendLine("@attribute UserGenere {0, 1}");
                    arffContent.AppendLine("@attribute UserAge {0, 1}");
                    arffContent.AppendLine("@attribute UserExperience {0, 1}");
                    arffContent.AppendLine("@attribute UserSymptoms {0, 1}");
                    arffContent.AppendLine("@attribute UserFlicker {0, 1}");
                    arffContent.AppendLine("@attribute UserGlassesUse {0, 1}");
                    arffContent.AppendLine("@attribute UserVisionProblems {0, 1}");
                    arffContent.AppendLine("@attribute UserPosture {0, 1}");
                    arffContent.AppendLine("@attribute UserEyeDominance {0, 1}");
                    arffContent.AppendLine("@attribute StaticFrame {0, 1}");
                    arffContent.AppendLine("@attribute HapticFeedback {0, 1}");
                    arffContent.AppendLine("@attribute DegreeOfControl {0, 1, 2}");
                    arffContent.AppendLine("@attribute DofSimulation {False, True}");
                    arffContent.AppendLine("@attribute Locomotion {False, True}");
                    arffContent.AppendLine("@attribute CameraAutoMovement {False, True}");
                    arffContent.AppendLine("@attribute RegionOfInterest {foreground, middleground}");
                    arffContent.AppendLine("@attribute TimeStamp NUMERIC");
                    arffContent.AppendLine("@attribute CameraFieldOfView NUMERIC");
                    arffContent.AppendLine("@attribute PlayerSpeed NUMERIC");
                    arffContent.AppendLine("@attribute PlayerAcceleration NUMERIC");
                    arffContent.AppendLine("@attribute CameraRotationX NUMERIC");
                    arffContent.AppendLine("@attribute CameraRotationY NUMERIC");
                    arffContent.AppendLine("@attribute CameraRotationZ NUMERIC");
                    arffContent.AppendLine("@attribute PlayerPositionX NUMERIC");
                    arffContent.AppendLine("@attribute PlayerPositionY NUMERIC");
                    arffContent.AppendLine("@attribute PlayerPositionZ NUMERIC");
                    arffContent.AppendLine("@attribute GameFps NUMERIC");
                    arffContent.AppendLine("@attribute DiscomfortLevel {0, 1, 2 ,3}");
                    arffContent.AppendLine();
                    arffContent.AppendLine("@data");

                    // Rest of the code to define the attributes and header of the ARFF file
                    foreach (string subdirectory in subdirectories)
                    {
                        string xmlFilePath = Path.Combine(subdirectory, "FILE.xml");

                        if (File.Exists(xmlFilePath))
                        {
                            // Open the XML file
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.Load(xmlFilePath);

                            // Read the <Data> elements from the XML
                            XmlNodeList dataNodes = xmlDoc.SelectNodes("//Data");
                            foreach (XmlNode dataNode in dataNodes)
                            {
                                StringBuilder instance = new StringBuilder();
                                XmlNodeList attributes = dataNode.ChildNodes;

                                foreach (XmlNode attribute in attributes)
                                {
                                    if (attribute.Name != "TimeStamp")
                                    {
                                        string attributeName = attribute.Name;
                                        string attributeValue = attribute.InnerText;
                                        string formattedValue = FormatAttributeValue(attributeName, attributeValue);
                                        instance.Append(formattedValue);
                                        instance.Append(",");
                                    }
                                }

                                // Add the Discomfort Level class as the last attribute (removing the final comma)
                                string discomfortLevel = dataNode.SelectSingleNode("DiscomfortLevel").InnerText;
                                instance.Append(discomfortLevel);

                                arffContent.AppendLine(instance.ToString());
                            }

                            // Update the progress bar
                            updateProgressBar.Invoke();

                        }
                        strArffContent = arffContent.ToString();
                                            
                    }
                   
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while converting the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return strArffContent;
        }

        private string FormatAttributeValue(string attributeName, string attributeValue)
        {
            string formattedValue = attributeValue;

            switch (attributeName)
            {
                case "UserGenere":
                    formattedValue = (formattedValue == "masculino") ? "0" : "1";
                    break;
                case "UserAge":
                    formattedValue = GetAgeRangeCategory(formattedValue);
                    break;
                case "UserExperience":
                    formattedValue = (formattedValue == "NENHUMA") ? "0" : "1";
                    break;
                case "UserSymptoms":
                    formattedValue = (formattedValue == "SIM") ? "1" : "0";
                    break;
                case "UserFlicker":
                    formattedValue = (formattedValue == "NENHUMA") ? "0" : "1";
                    break;
                case "UserGlassesUse":
                    formattedValue = (formattedValue == "SIM") ? "1" : "0";
                    break;                
                case "DofSimulation":
                    formattedValue = (formattedValue == "True") ? "1" : "0";
                    break;
                case "Locomotion":
                    formattedValue = (formattedValue == "True") ? "1" : "0";
                    break;
                case "CameraAutoMovement":
                    formattedValue = (formattedValue == "True") ? "1" : "0";
                    break;
                case "StaticFrame":
                    formattedValue = (formattedValue == "True") ? "1" : "0";
                    break;
                case "HapticFeedback":
                    formattedValue = (formattedValue == "SIM") ? "1" : "0";
                    break;
                case "UserVisionProblems":
                    formattedValue = GetVisionProblemsCategory(formattedValue);
                    break;
                case "UserPosture":
                    formattedValue = (formattedValue == "SENTADO") ? "0" : "1";
                    break;
                case "UserEyeDominance":
                    formattedValue = (formattedValue == "ESQUERDO") ? "0" : "1";
                    break;
                case "DegreeOfControl":
                    formattedValue = GetDegreeOfControlCategory(formattedValue);
                    break;
                case "RegionOfInterest":
                    formattedValue = GetRegionOfInterestCategory(formattedValue);
                    break;
                
            }

            return formattedValue;
        }

        private string GetDegreeOfControlCategory(string degreeValue)
        {
            switch (degreeValue)
            {
                case "TOTAL":
                    return "2";
                case "PARCIAL":
                    return "1";
                case "NENHUM":
                    return "0";
                default:
                    return "";
            }
        }


        private string GetRegionOfInterestCategory(string regionValue)
        {
            switch (regionValue)
            {
                case "foreground":
                    return "0";
                case "middleground":
                    return "1";
                case "Background":
                    return "2";
                default:
                    return "";

            }
        }

        private string GetVisionProblemsCategory(string visionProblemsValue)
        {
            switch (visionProblemsValue)
            {
                case "NENHUM":
                    return "0";
                case "MIOPIA":
                    return "1";
                case "ASTIGMATISMO":
                    return "2";
                case "ASTIGMATISMO E MIOPIA":
                    return "3";
                case "HIPERMETROPIA":
                    return "4";
                case "ASTIGMATISMO E HIPERMETROPIA":
                    return "5";
                default:
                    return "";
            }
        }

        private string GetAgeRangeCategory(string ageValue)
        {
            if (String.Compare(ageValue, "18 A 36") == 0)
                return "0";
            else if (String.Compare(ageValue, "37 A 50") == 0) 
                return "1";
            else
                return "2";
            
        }
    }
}
