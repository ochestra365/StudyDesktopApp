using System;

namespace IoTSensorMonApp
{
    internal class SensorData
    {
        public DateTime Current { get; set; }
        public int Value { get; set; }

        public SensorData(DateTime current, int value)
        {
            Current = current;
            Value = value;
        }
        //속성값(속성은 기본적으로 대문자로 시작하고 변수는 소문자로 시작한다.)
        //생성자, Alt+Enter로 생성자를 쓸 수 있다.
    }
}
