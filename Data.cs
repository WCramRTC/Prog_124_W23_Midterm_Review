using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prog_124_W23_Midterm_Review
{
    public class Data
    {
        public static ObservableCollection<Member> members;

        // A static constructor only runs ONCE and once and item from THE class is called.
        static Data()
        {
            members = new ObservableCollection<Member>();
        }
    }
}
