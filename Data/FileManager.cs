
using System.IO;
using System.Windows.Forms;

namespace BC.Resources
{
    public static class FileManager
    {
        public static bool ToRemove(string baseFolder, string[] folders=null)
        {
            bool returnOk = false;
            try
            {
                string folderPath = "";
                if (folders != null)
                {
                    foreach (string folder in folders)
                    {
                        folderPath = Path.Combine(Application.StartupPath, "biosignal-data\\" + baseFolder + "\\" + folder);
                        
                        if (Directory.Exists(folderPath))
                        {
                            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

                            foreach (FileInfo file in directoryInfo.GetFiles())
                            {
                                file.Delete();
                            }

                            foreach (DirectoryInfo subDirectory in directoryInfo.GetDirectories())
                            {
                                subDirectory.Delete(true);
                            }
                        }
                    }
                }
                else
                {
                    folderPath = Path.Combine(Application.StartupPath, "biosignal-data\\" + baseFolder);
                    DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
                    foreach (FileInfo file in directoryInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }

                returnOk = true;
            }
            catch 
            {
                throw;
            }

            return returnOk;
        }
    }
}
