using System;
using System.Data;
using System.Data.SQLite;
using System.Reflection.PortableExecutable;
using System.Windows;
using System.Windows.Controls;

namespace Platinum_ERP
{
    public partial class MainWindow : Window
    {
        double AfterHeight = 1000;
        double AfterWidth = 1780;
        public MainWindow()
        {

            InitializeComponent();
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
       
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double InitHeight = 1000;
            double InitWidth = 1780;
            
            double Aspect;

            Aspect = double.Parse((this.Width / this.Height).ToString("F2"));

            if(Aspect != 1.78 && this.ActualHeight == InitHeight)
            {
                AfterHeight = this.Width / 1.78;
                this.Height = AfterHeight;
            }

            if (Aspect != 1.78 && this.ActualWidth == InitWidth)
            {
                AfterWidth = this.Height * 1.78;
                this.Width = AfterWidth;
            }
            InitWidth = AfterWidth;
            InitHeight = AfterHeight;
            zx.Text = (AfterHeight.ToString());
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            bool X1_Exist = false;
            foreach(TabItem Tab in TabControl1.Items)
            {
                if(Tab.Header.ToString()=="Flota")
                {
                    X1_Exist = true;
                }
            }
            
            if (!X1_Exist)
            {
                TabItem X1_Content = new TabItem();
                X1_Content.Content = new X1_UC_MainView();
                X1_Content.Header = "Flota";               
                TabControl1.Items.Add(X1_Content);
                TabControl1.SelectedItem = X1_Content;
            }          
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }




}
