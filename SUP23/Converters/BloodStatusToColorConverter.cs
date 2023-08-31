﻿using SUP23.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SUP23.Converters
{
    public class BloodStatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var bloodStatus = (BloodStatus)value;
            return bloodStatus switch
            {
                BloodStatus.Fullblood => new SolidColorBrush(Colors.Black),
                BloodStatus.Halfblood => new SolidColorBrush(Colors.Blue),
                _ => throw new NotImplementedException(),
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
