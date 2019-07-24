using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Text;

namespace EMap.MapServer.OpenLayers
{
    public abstract class JavaScriptConverter : IJavaScriptConverter
    {
        public string JavaScriptName { get; set; }
        public JavaScriptConverter(string javaScriptName)
        {
            JavaScriptName = javaScriptName;
        }
        public virtual string ToJavaScriptInstance()
        {
            if (string.IsNullOrEmpty(JavaScriptName))
            {
                throw new Exception("JavaScriptName不能为空");
            }
            StringBuilder sb = new StringBuilder();
            sb.Append($"new {JavaScriptName} ({{");
            sb.Append("})");
            Type type = GetType();
            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            int k = 0;
            for (int i = 0; i < propertyInfos.Length; i++)
            {
                var propertyInfo = propertyInfos[i];
                if (propertyInfo.Name != nameof(JavaScriptName))
                {
                    object value = propertyInfo.GetValue(this);
                    if (value != null && !value.Equals(DBNull.Value))
                    {
                        string appendStr = null;
                        if (value is IJavaScriptConverter javaScriptConverter)
                        {
                            appendStr = $"{propertyInfo.Name}:{javaScriptConverter.ToJavaScriptInstance()}";
                        }
                        else if (value is Array )
                        {
                            value = JsonConvert.SerializeObject(value);
                            appendStr = $"{propertyInfo.Name}:{value}";
                        }
                        else
                        {
                            appendStr = $"{propertyInfo.Name}:{value}"; 
                        }
                        if (k == 0)
                        {
                            sb.Append(appendStr);
                        }
                        else
                        {
                            sb.Append($",{appendStr}");
                        }
                        k++;
                    }
                }
            }
            return sb.ToString();
        }
    }
}