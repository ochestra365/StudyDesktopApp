using System;

namespace IoTSensorMonApp
{
    internal class SensorData
    {
        public DateTime Current { get; set; }//현재 시간
        public int Value { get; set; }//센서값
        public bool SimulFlag { get; set; }//시뮬레이션 여부

        public SensorData(DateTime current, int value, bool simulFlag)
        {
            Current = current;
            Value = value;
            SimulFlag = simulFlag;
        }
        //속성값(속성은 기본적으로 대문자로 시작하고 변수는 소문자로 시작한다.)
        //생성자, Alt+Enter로 생성자를 쓸 수 있다.
    }
}
