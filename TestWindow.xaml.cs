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
    public partial class TestWindow : Window
    {


        public TestWindow()
        {
            InitializeComponent();
            // cbMembers
            cbMembers.ItemsSource = Data.members;
        }

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            Data.members.Add(new Member("Zack", "Zepazauer"));
        }
    }
}
