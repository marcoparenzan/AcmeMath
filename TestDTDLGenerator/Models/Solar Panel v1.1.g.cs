using GenericMathLib;
using System.ComponentModel;

namespace solarPanelMonitoring
{
    public class Solar_Panel_v1_1_7k6
    {
        [DescriptionAttribute("dtmi:solarPanelMonitoring:Solar_Panel_v1_1_7k6:PowerAmountKW;1")]
        public Double PowerAmountKW { get; set; }

        [DescriptionAttribute("dtmi:solarPanelMonitoring:Solar_Panel_v1_1_7k6:NominalVoltage;1")]
        public Voltage NominalVoltage { get; set; }

        [DescriptionAttribute("dtmi:solarPanelMonitoring:Solar_Panel_v1_1_7k6:Efficiency;1")]
        public Double Efficiency { get; set; }

        [DescriptionAttribute("dtmi:solarPanelMonitoring:Solar_Panel_v1_1_7k6:EnergyAmountkWh;1")]
        public Current EnergyAmountkWh { get; set; }

        [DescriptionAttribute("dtmi:solarPanelMonitoring:Solar_Panel_v1_1_7k6:PanelStatus;1")]
        public Enum PanelStatus { get; set; }

        [DescriptionAttribute("dtmi:solarPanelMonitoring:Solar_Panel_v1_1_7k6:Temperature;1")]
        public Double Temperature { get; set; }
    }
}