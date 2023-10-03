using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using BC.Forms;
using BC.Dal.Business;
using BC.Dal.Entity;
using System.Drawing;

namespace BC
{
    public partial class FrmTest : Form
    {
        
        public FrmTest()
        {
            InitializeComponent();

            string jsonString = "{\"returnCode\": 0, \"returnData\": {\"EC:1B:BD:62:D1:6F\": [[4.0, 0.0, 0.0, 0.0, 0.0, 0.0, -1.5, 0.0, 1.019], [5.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.494, 0.0, 1.019], [6.0, 0.0, 0.0, 0.0, 0.0, 0.0, -1.5, 0.0, 1.01], [7.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.494, 0.0, 1.019], [8.0, 0.0, 0.0, 0.0, 0.0, 0.0, -0.85, 0.0, 1.01], [9.0, 0.0, 0.0, 0.0, 0.0, 0.0, -1.5, 0.0, 1.01], [10.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.494, 0.0, 1.01], [11.0, 0.0, 0.0, 0.0, 0.0, 0.0, -1.5, 0.0, 1.01], [12.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.494, 0.0, 1.01], [13.0, 0.0, 0.0, 0.0, 0.0, 0.0, -0.82, 0.0, 1.019], [14.0, 0.0, 0.0, 0.0, 0.0, 0.0, -1.5, 0.0, 1.019], [15.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.494, 0.0, 1.019], [0.0, 0.0, 0.0, 0.0, 0.0, 0.0, -1.5, 0.0, 1.01], [1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.494, 0.0, 1.019], [2.0, 0.0, 0.0, 0.0, 0.0, 0.0, -0.782, 0.0, 1.01]]}}";

            JObject json = JObject.Parse(jsonString);
            JArray dataArray = (JArray)json["returnData"]["EC:1B:BD:62:D1:6F"];

            int count = dataArray.Count;
            Console.WriteLine("Quantidade de elementos: " + count);
        }
    }
}
