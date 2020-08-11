using EvoRPG.Pages.Map.Castel;
using EvoRPGDemo;
using EvoRPGDemo.Pages.Dialogs.Castel.Map1;
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

namespace EvoRPG.Pages.MENU
{
    /// <summary>
    /// Interaction logic for Intro.xaml
    /// </summary>
    public partial class Intro : Page
    {
        public Uri IntroSource{ get {return new Uri(creatAbsoultPath(@"\Resource\MenuIMG\introreal.wmv"), UriKind.Absolute);} }

        public Intro()
        {

            InitializeComponent();
            Inntro.DataContext = this;
            
            
        }

        private string creatAbsoultPath(string path)
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName + path;
            
        }

        private void skipBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Dialoge1_0());
            //Application.Current.Shutdown();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Inntro.Play();

        }
    }
}
