using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace ExtensionMethods.Extensions
{
    public static class EnumExtension
    {
        public static int ObterId(this Enum enumerador)
        {
            return Convert.ToInt32(enumerador);
        }

        public static string ObterDescricao(this Enum enumerador)
        {
            FieldInfo fi = enumerador.GetType().GetField(enumerador.ToString());

            if (null != fi)
            {
                object[] atributos = fi.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (atributos != null && atributos.Length > 0)
                    return ((DescriptionAttribute)atributos[0]).Description;
            }

            return enumerador.ToString();
        }
    }
}
