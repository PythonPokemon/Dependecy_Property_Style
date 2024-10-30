using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
Dependency ==   Abhängigkeit
Properties ==   Eigenschaften
Controls   ==   Steuerung


 */

namespace Dependecy_Property_Style
{
    public partial class MainWindow : Window
    {

        // Eigenen Property anlegen | Eigenschaft
        public int MyProperty
        {
            get { return (int)GetValue(myDependencyProperty); }
            set { SetValue(myDependencyProperty, value); }
        }

        public static readonly DependencyProperty myDependencyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();
        }


    }
}