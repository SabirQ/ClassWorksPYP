using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp4.Model
{
    static class TypeValidator
    {
        //public static dynamic GenerateIns<T>(T entity)
        //{          
        //    if (entity.GetType().GetConstructors().Length<1)
        //    {
        //        Type t = entity.GetType();
        //        var newitem=Activator.CreateInstance(Type.GetType(entity.ToString()));
        //        Console.WriteLine("bosh");
        //        newitem = GetInfoOfType(newitem);
        //        return newitem;

        //    }
        //    else
        //    {
        //        entity = GetInfoOfType(entity);
        //        return entity;
        //    }
           
            
        //}
        //public static T GetInfoOfType<T>(T entity)
        //{
        //    PropertyInfo[] properties = entity.GetType().GetProperties();
        //    for (int i = 0; i < properties.Length; i++)
        //    {
        //        var type = properties[i].PropertyType;
        //        if (type==typeof(string))
        //        {
        //            properties[i].SetValue(entity,"HelloWolrd");
        //        }
        //        if (type ==typeof(int))
        //        {
        //            properties[i].SetValue(entity,5);
        //        }
        //        if (type==typeof(bool))
        //        {
        //            properties[i].SetValue(entity,true);
        //        }
               
        //    }
        //    return entity;
        //}


    }
}
