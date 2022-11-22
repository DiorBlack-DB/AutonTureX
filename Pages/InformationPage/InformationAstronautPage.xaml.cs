using System;
using System.Collections.Generic;
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
using WPFUIKitProfessional.Data.DBClasses;
using WPFUIKitProfessional.Data.Classes;
using WPFUIKitProfessional.Data.Model;
using WPFUIKitProfessional.Data.Classes.DataClasses;
using WPFUIKitProfessional.Pages.InformationPage;
using System.Security.Principal;

namespace WPFUIKitProfessional.Pages.InformationPage
{
    /// <summary>
    /// Логика взаимодействия для InformationAstronautPage.xaml
    /// </summary>
    public partial class InformationAstronautPage : Page
    {
        public static Astronauts.Rootobject Astronaut;
        public InformationAstronautPage(Astronauts.Rootobject astronaut)
        {
            Astronaut = astronaut;
            InitializeComponent();
        }
    }
}
