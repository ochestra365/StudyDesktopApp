using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfPracticeApp.BusinessLogic
{
    public class Car
    {
        public double Speed { get; set; }
        public Color MainColor { get; set; }//시스템함수와 충돌나지 않게 쓰는 것이 좋다.
    }
}
