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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Platinum_ERP
{
    /// <summary>
    /// Logika interakcji dla klasy X1_WW_Check.xaml
    /// </summary>
    public partial class X1_WW_Check : Window
    {
        public X1_WW_Check()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            C1_Sqlite X1_Review_Show = new C1_Sqlite();
            X1_Review_Show.SqliteShow("truck_lst.db", "SELECT * FROM truck_lst", X1_Check_DGV1);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            C2_Procedures animation = new C2_Procedures();
            animation.Animation_1(X1_Check_C1, 477, 1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            C1_Sqlite x = new C1_Sqlite();
            x.SqliteWrite("truck_check_dt.db", "truck_check_dt", "1,2,3,4,5,6", "truck_type,internal_no,sn_no,current_mth,check_date,comments");

            






            
        }
    }
}
