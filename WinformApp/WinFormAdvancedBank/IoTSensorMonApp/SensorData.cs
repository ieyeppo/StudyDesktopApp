using System;

namespace IoTSensorMonApp
{
    internal class SensorData
    {
        public DateTime Current { get; set; }
        public int Value { get; set; }

        public bool SingleFlat { get; set; }
        public SensorData(DateTime current, int value, bool singleFlat)
        {
            Current = current;
            Value = value;
            SingleFlat = singleFlat;
        }
    }
}
