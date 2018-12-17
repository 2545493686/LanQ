using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LanQ
{
    public static class EnumExpand
    {
        /// <summary>
        /// 需要提前加上 "Description" 特性
        /// </summary>
        /// <param name="enum"></param>
        /// <returns></returns>
        public static string GetText(this Enum @enum)
        {
            FieldInfo fieldInfo = @enum.GetType().GetField(@enum.ToString());
            Attribute attribute = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));
            DescriptionAttribute description = (DescriptionAttribute)attribute;
            return description == null ? "" : description.Description;
        }
    }
}
