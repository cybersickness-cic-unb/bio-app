
using System.IO;
using System;
using System.Linq;

namespace BC.Resources
{
    public static class Log
    {

        private static bool displayDateTime = false;
        private static object _lock = new object();
        public static void writeLog(dynamic line, string nameFile, bool _gross = false, bool _displayDateTime = false)
        {

            try
            {
                
                // Get the current directory. 
                string path = Directory.GetCurrentDirectory();
                string target = path + "\\Log";
                string pathFile = target + "\\" + nameFile;

                if (!Directory.Exists(target))
                {
                    Directory.CreateDirectory(target);
                }

                if (!File.Exists(pathFile))
                {

                    using (System.IO.FileStream fs = System.IO.File.Create(pathFile))
                    {

                    }

                }

                if (File.Exists(pathFile))
                {
                   
                    lock (_lock)
                    {
                        using (TextWriter tw = new StreamWriter(pathFile, true))
                        {
                            if (_gross)
                                tw.Write(line);
                            else
                            {
                                if (_displayDateTime)
                                    tw.WriteLine("[" + DateTime.Now + "] - " + line);
                                else
                                    tw.WriteLine(line);

                                tw.Flush();
                            }
                            tw.Close();
                        }
                    }


                    // collect information from the file
                    FileInfo fileInfo = new FileInfo(pathFile);
                    if (fileInfo.Length > 4096000)
                    {
                        //Copy Log file and remove
                        System.IO.File.Copy(pathFile, pathFile + "_" + DateTime.Now.ToString("ddMMyyyy_HHmmss"), true);
                        System.IO.File.Delete(pathFile);

                        var sortedFiles = new DirectoryInfo(target).GetFiles()
                                                  .OrderByDescending(f => f.LastWriteTime)
                                                  .ToList();

                        //Remove old logs
                        int i = 1;
                        foreach (var file in sortedFiles)
                        {

                            if (i > 10)
                            {
                                string pathFileRemover = target + "\\" + file.Name;
                                // let's remove
                                System.IO.File.Delete(pathFileRemover);
                            }
                            i++;
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}