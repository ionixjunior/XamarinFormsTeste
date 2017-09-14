using System;
using System.Globalization;
using Xamarin.Forms;

namespace Core.Converters
{
    public class ShowNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var name = (string)value;

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                return string.Empty;

            return $"Parabéns {name}, o projeto de testes funcionou!";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
