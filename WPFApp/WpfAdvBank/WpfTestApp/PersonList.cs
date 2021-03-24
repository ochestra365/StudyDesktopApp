using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    public class PersonList : ObservableCollection<Person>//Person 클래스를 상속받아서 쓴다. 상속이다. (Override)는 재정의다.
    {
        public PersonList()
        {
            this.Add(new Person( "Willa",  "Cather" ));
            this.Add(new Person("Isak", "Dineson"));
            this.Add(new Person("Vitro", "Wigo"));
        }
    }
}
