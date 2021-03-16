using System;

namespace IoTSensorMonApp
{
    internal class SensorData
    {
        public DateTime Current { get; set; }
        public int Value { get; set; }

        public bool SimulFlat { get; set; }
        public SensorData(DateTime current, int value, bool SimulFlat)
        {
            Current = current;
            Value = value;
            SimulFlat = SimulFlat;
        }
    }
}
