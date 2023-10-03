using System.ComponentModel.DataAnnotations;

namespace BC.Dal.Entity
{
    public class Config
    {
        [Key]
        public int Id { get; set; }
        public string MacAddress { get; set; }        
        public string IpAddress { get; set; }        
        public int Port { get; set; }
        public int ResizeWidthTo { get; set; }
        public int ResizeHeightTo { get; set; }
        public int SamplingFreq { get; set; }
        public string saveOriginalSizeImage { get; set; }
        public string saveResizedImage { get; set; }
        public string automaticallySaveChart { get; set; }
        public string automaticallyGenerateOutputToFile { get; set; }
        public string captureECG { get; set; }
        public string captureEEG { get; set; }
        public string captureEGG { get; set; }
        public string captureEMG { get; set; }
        public string captureEDA { get; set; }
        public string captureACC { get; set; }

        public int channelECG { get; set; }
        public int channelEEG { get; set; }
        public int channelEGG { get; set; }
        public int channelEMG { get; set; }
        public int channelEDA { get; set; }
        public int channelACC { get; set; }
        public int recordingTimeInterval { get; set; }
        public string enableSpeechRecognition { get; set; }
        public string Language { get; set; }
        
    }
}
