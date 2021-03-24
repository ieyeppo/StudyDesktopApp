using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTextApp
{
    public class PersonList : ObservableCollection<Person>
    {
        public PersonList()
        {
            this.Add(new Person("Willa", "Cather"));
            this.Add(new Person("Isak", "Dinesen"));
            this.Add(new Person("최", "혀나"));
            this.Add(new Person("최", "콩지"));
        }
    }
}
