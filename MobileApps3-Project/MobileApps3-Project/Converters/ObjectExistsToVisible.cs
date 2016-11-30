using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace MobileApps3_Project.Converters
{
    public class ObjectExistsToVisible : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            return (value == null) ? Windows.UI.Xaml.Visibility.Collapsed
                : Windows.UI.Xaml.Visibility.Visible;
        }//- End of Convert

        public object ConvertBack(object value, Type targetType,
            object parameter, string culture)
        {
            throw new NotImplementedException();
        }//- End of ConvertBack
    }//- End of ObjectExistsToVisible
}//- End of MobileApps3_Project.Converters
