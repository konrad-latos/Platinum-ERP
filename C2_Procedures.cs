using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Platinum_ERP
{
    internal class C2_Procedures
    {
        public void Animation_1(StackPanel Object_Name, double To_Width, double Duration_Time)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                From = Object_Name.ActualWidth,
                To = To_Width,
                Duration = TimeSpan.FromSeconds(Duration_Time)
            };
            Object_Name.BeginAnimation(StackPanel.WidthProperty, animation);
        }
    }
}
