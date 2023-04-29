using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Класс цветов приложения.
    /// </summary>
    public class ColorsContactsApp
    {
        /// <summary>
        /// Цвет ошибки работы приложения.
        /// </summary>
        public static Color COLOR_ERROR { get; private set; } = Color.LightPink;

        /// <summary>
        /// Цвет правильной работы приложения.
        /// </summary>
        public static Color COLOR_CORRECTLY { get; private set; } = Color.White;
    }
}
