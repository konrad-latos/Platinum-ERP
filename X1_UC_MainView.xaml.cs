using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
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

namespace Platinum_ERP
{
    
    public partial class X1_UC_MainView : UserControl
    {
        public X1_UC_MainView()
        {
            InitializeComponent();
            C1_Sqlite X1_Main_Show = new C1_Sqlite();
            X1_Main_Show.SqliteShow("truck_lst.db", "SELECT * FROM truck_lst", X1_Main_DGV1);
           
        }

        private void X1_Btn_Check_Click(object sender, RoutedEventArgs e)
        {
            X1_WW_Check X1_Review_Window = new X1_WW_Check();
            X1_Review_Window.Title = "Przeglądy Techniczne";
            X1_Review_Window.X1_Check_C1.Width = 0;
            X1_Review_Window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            X1_Review_Window.ShowDialog();
        }

        private void X1_Btn_Check2_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
