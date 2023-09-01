using SUP23.Enums;
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

namespace SUP23.Components
{
    /// <summary>
    /// Interaction logic for BloodStatusComponent.xaml
    /// </summary>
    public partial class BloodStatusComponent : UserControl
    {





        public BloodStatus BloodStatus
        {
            get { return (BloodStatus)GetValue(BloodStatusProperty); }
            set { SetValue(BloodStatusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BloodStatus.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BloodStatusProperty =
            DependencyProperty.Register("BloodStatus", typeof(BloodStatus), typeof(BloodStatusComponent), new PropertyMetadata(BloodStatus.Halfblood));




        public BloodStatusComponent()
        {
            InitializeComponent();
        }
    }
}
