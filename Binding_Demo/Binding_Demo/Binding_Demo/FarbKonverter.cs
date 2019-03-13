using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Binding_Demo
{
    class FarbKonverter : IValueConverter
    {
        // OneWay
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            #region Easy-Version
            //string text = (string)value;
            //if (text == "Red")
            //    return Color.Red;
            //else if (text == "Green")
            //    return Color.Green;
            //else
            //    return Color.White; 
            #endregion

            string text = (string)value;
            var field = typeof(Color).GetFields().FirstOrDefault(x => x.Name.ToLower() == text.ToLower());

            if (field != null)
                return field.GetValue(typeof(Color));
            else
                return Color.White;
            
        }

        // TwoWay
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
