using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfPracticeApp.BusinessLogic
{
    public class Car : Notifier
    {
        // public double Speed{ get; set; } 아래와 똑같음.
        private double speed;//멤버변수
        public double Speed {//속성
            get { return speed; }
            set 
            {
                if (value > 350)
                {
                    speed = 350;
                }
                else
                {
                    speed = value;
                }
                speed = value;
                OnPropertyChanged("Speed");//속성값 변경된 것을 알려줌(프로그램)
            } //부가적으로 값을 받아서 처리할 부분이 존재할 때 쓰는 Property이다.
        }

        private Color maincolor;
        public Color MainColor
        {
            get { return maincolor; }
            set
            {
                maincolor = value;
                OnPropertyChanged("MainColor");
            } 
        }//시스템함수와 충돌나지 않게 쓰는 것이 좋다.
        public Human Driver { get; set; }
    }

    public class Human
    {
        public string Name { get; set; }
        public bool HasDriveLicense { get; set; }
    }
}
