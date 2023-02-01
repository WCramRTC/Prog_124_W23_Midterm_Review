using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_124_W23_Midterm_Review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Member> members = new ObservableCollection<Member>();


        public MainWindow()
        {
            InitializeComponent();
            Preload();
            lbMemberNames.ItemsSource = members;


        }

        void Preload()
        {
            members.Add(new Member("Will", "Cram"));
        }
    }
}
