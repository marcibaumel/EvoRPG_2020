using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace EvoRPGDemo.Pages.MENU
{
    /// <summary>
    /// Interaction logic for Outro.xaml
    /// </summary>
    public partial class Outro : Page
    {
        public Uri IntroSource { get { return new Uri(creatAbsoultPath(@"\Resource\MenuIMG\outro.wmv"), UriKind.Absolute); } }

        public Outro()
        {

            InitializeComponent();
            Outtro.DataContext = this;


        }

        private string creatAbsoultPath(string path)
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName + path;

        }

        private void skipBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Application.Current.Shutdown();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Outtro.Play();

        }
    }
}
