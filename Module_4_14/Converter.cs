using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Module_4_14
{
    class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if((ProductCategory) value == ProductCategory.Food)
            {
                return "Еда";
            }
            return "Бытовая техника";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return DependencyProperty.UnsetValue;
        }
    }
}
