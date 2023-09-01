using SUP23.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SUP23.Converters
{
    public class BloodStatusToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var bloodStatus = (BloodStatus)value;

            return bloodStatus switch
            {
                BloodStatus.Halfblood => "Halvblod",
                BloodStatus.Fullblood => "Fullblod",
                _ => throw new NotImplementedException(),
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
