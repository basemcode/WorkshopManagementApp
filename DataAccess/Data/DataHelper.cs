using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess.Data;

public class DataHelper
{
    public static DataTable ToDataTable<T>(IEnumerable<T> items)
    {
        var tb = new DataTable(typeof(T).Name);

        PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var prop in props)
        {
            DataColumn newColumn = new DataColumn(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            Object[] myAttributes = prop.GetCustomAttributes(true);
            if (myAttributes.Length>0)
            {
                newColumn.Caption = ((DescriptionAttribute)myAttributes[0]).Description;
            }
            tb.Columns.Add(newColumn);
        }

        foreach (var item in items)
        {
            var values = new object[props.Length];
            for (var i = 0; i < props.Length; i++)
            {
                values[i] = props[i].GetValue(item, null);
            }

            tb.Rows.Add(values);
        }

        return tb;
    }
    public static Image displayImage(byte[]? photo)
    {
        if (photo != null)
        {
            try
            {
                MemoryStream ms = new MemoryStream(photo);
                return System.Drawing.Image.FromStream(ms);
            }
            catch (Exception)
            {
                return null;
            }
        }
        return null;
    }
}
