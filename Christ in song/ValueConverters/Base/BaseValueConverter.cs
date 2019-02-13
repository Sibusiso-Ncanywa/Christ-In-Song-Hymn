using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace Christ_in_song
{
    /// <summary>
    /// A base value converter that allow direct xaml usage
    /// </summary>
    /// <typeparam name="T"> The type of this converter </typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter // MarkupExtension allows direct xaml usage
        where T: class, new()
    {
        #region Private memmbers

        /// <summary>
        /// A single static instance of the value converter.
        /// </summary>
        private static T Converter = null;

        #endregion

        #region Public MarkUp extension

        /// <summary>
        /// Provides a static instance of the value converter
        /// </summary>
        /// <param name="serviceProvider"> The service provider </param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            /*
             the one below says

            if(mConverter == null)
                mConverter = new T();

            return mConverter;
             */
            return Converter ?? (Converter = new T());
        }

        #endregion
        
        #region Value Converter Methods

        /// <summary>
        /// The method to convert one type to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// The method convert a value back to it's original type
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion

    }
}
