namespace BC.Resources
{
    public class ChartConfiguration
    {
        public string Name { get; set; }
        public double AxisXMinimum { get; set; }
        public double AxisXMaximum { get; set; }
        public double AxisXInterval { get; set; }
        public string AxisXTitle { get; set; }
        public bool AxisXLabelStyleEnabled { get; set; }

        public double AxisYMinimum { get; set; }
        public double AxisYMaximum { get; set; }
        public double AxisYInterval { get; set; }
        public string AxisYTitle { get; set; }
        public bool AxisYLabelStyleEnabled { get; set; }
        public bool AxisXMajorGridEnabled { get; set; }
        public bool AxisYMajorGridEnabled { get; set; }

        public double AxisYComplement { get; set; }
        public double AxisXMinimumNewPositionAfterMaxingout { get; set; }
        public double AxisXMaximumNewPositionAfterMaxingout { get; set; }
        public double ScaleMovePointToPointOnTheAxisX { get; set; }
        
    }
}