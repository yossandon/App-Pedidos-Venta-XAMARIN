using System;
using System.IO;
using Xamarin.Forms;

namespace Pedidos.Models
{
    public class ByteArrayToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                ImageSource retSource = null;
                if (value != null)
                {
                    byte[] imageAsBytes = (byte[])value;
                    retSource = ImageSource.FromStream(() => new MemoryStream(imageAsBytes));
                }
                return retSource;
            }
            catch
            {
                return null;
            }

        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
            //throw new NotImplementedException();
        }
    }
}
