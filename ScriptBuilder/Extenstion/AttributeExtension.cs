using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ScriptBuilder.Extenstion
{
    public static class AttributeExtension
    {
        public static string? GetDescription(this object value)
        {
            DescriptionAttribute? description = value?.GetAttributeOfType<DescriptionAttribute>();
            return description?.Description ?? value?.ToString();
        }

        public static T? GetAttributeOfType<T>(this object value) where T : Attribute
        {
            T[]? attributes = value?.GetAttributesOfType<T>();
            return attributes?[0];
        }

        public static T[]? GetAttributesOfType<T>(this object value) where T : Attribute
        {
            if (value == null)
                return null;

            T[] attributes;

            // Check whether the value itself is of MemberInfo type and has the attribute defined.
            MemberInfo? memberInfo = value as MemberInfo;
            if (memberInfo != null)
            {
                attributes = (T[])memberInfo.GetCustomAttributes(typeof(T), false);
                if (attributes.Length > 0)
                    return attributes;
            }

            // Try to extract the attribute as a field value.
            FieldInfo? fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo != null)
            {
                attributes = (T[])fieldInfo.GetCustomAttributes(typeof(T), false);
                return attributes.Length > 0 ? attributes : null;
            }

            // Try to extract the attribute as a property value.
            PropertyInfo? propertyInfo = value.GetType().GetProperty(value.ToString());
            if (propertyInfo != null)
            {
                attributes = (T[])propertyInfo.GetCustomAttributes(typeof(T), false);
                return (attributes.Length > 0) ? attributes : null;
            }

            // If nothing found, try to get an attribute for the value as a class.
            var info = value.GetType();
            //
            // NHibernate creates proxy objects if any field is marked for lazy loading so look in the base type
            if (info.Name.EndsWith("Proxy") && info.Namespace == null)
            {
                info = info.BaseType;
                if (info == null)
                {
                    return null;
                }
            }
            attributes = (T[])info.GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? attributes : null;

        }
    }
}

