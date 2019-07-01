using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EMap.MapServer.Ogc.Services
{
    public static class XmlHelper
    {
        /// <summary>
        /// 将一个对象按指定的编码序列化到指定流中
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="o"></param>
        /// <param name="encoding"></param>
        public static void XmlSerializeInternal(Stream stream, object o, Encoding encoding, XmlSerializerNamespaces namespaces, XmlAttributeOverrides xmlAttributeOverrides = null)
        {
            if (o == null)
                throw new ArgumentNullException("o");
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            XmlSerializer serializer =null;
            if (xmlAttributeOverrides == null)
            {
                serializer = new XmlSerializer(o.GetType());
            }
            else
            {
                serializer = new XmlSerializer(o.GetType(), xmlAttributeOverrides);
            }

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                NewLineChars = "\r\n",
                Encoding = encoding,
                IndentChars = "    "
            };

            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                if (namespaces != null)
                {
                    serializer.Serialize(writer, o, namespaces);
                }
                else
                {
                    serializer.Serialize(writer, o);
                }
                writer.Close();
            }
        }

        /// <summary>
        /// 将一个对象序列化为XML字符串
        /// </summary>
        /// <param name="o">要序列化的对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>序列化产生的XML字符串</returns>
        public static string XmlSerialize(object o, Encoding encoding, XmlSerializerNamespaces namespaces, XmlAttributeOverrides xmlAttributeOverrides = null)
        {
            string value = null;
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializeInternal(stream, o, encoding, namespaces, xmlAttributeOverrides);

                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream, encoding))
                {
                    value = reader.ReadToEnd();
                    reader.Close();
                }
                stream.Close();
            }
            return value;
        }

        /// <summary>
        /// 将一个对象按XML序列化的方式写入到一个文件
        /// </summary>
        /// <param name="o">要序列化的对象</param>
        /// <param name="path">保存文件路径</param>
        /// <param name="encoding">编码方式</param>
        public static void XmlSerializeToFile(object o, string path, Encoding encoding, XmlSerializerNamespaces namespaces, XmlAttributeOverrides xmlAttributeOverrides = null)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("path");

            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                XmlSerializeInternal(file, o, encoding, namespaces, xmlAttributeOverrides);
                file.Close();
            }
        }

        /// <summary>
        /// 从XML字符串中反序列化对象
        /// </summary>
        /// <typeparam name="T">结果对象类型</typeparam>
        /// <param name="s">包含对象的XML字符串</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>反序列化得到的对象</returns>
        public static T XmlDeserialize<T>(string s, Encoding encoding)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentNullException("s");
            if (encoding == null)
                throw new ArgumentNullException("encoding");
            T obj = default(T);
            XmlSerializer mySerializer = new XmlSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream(encoding.GetBytes(s)))
            {
                using (StreamReader sr = new StreamReader(ms, encoding))
                {
                    obj = (T)mySerializer.Deserialize(sr);
                    sr.Close();
                }
                ms.Close();
            }
            return obj;
        }

        /// <summary>
        /// 读入一个文件，并按XML的方式反序列化对象。
        /// </summary>
        /// <typeparam name="T">结果对象类型</typeparam>
        /// <param name="path">文件路径</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>反序列化得到的对象</returns>
        public static T XmlDeserializeFromFile<T>(string path, Encoding encoding)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("path");
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            string xml = File.ReadAllText(path, encoding);
            return XmlDeserialize<T>(xml, encoding);
        }
        public static T XmlDeserialize<T>(Stream stream, Encoding encoding)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (encoding == null)
                throw new ArgumentNullException("encoding");
            StreamReader sr = new StreamReader(stream, encoding);
            string xml = sr.ReadToEnd();
            T t = XmlDeserialize<T>(xml, encoding);
            sr.Close();
            sr.Dispose();
            return t;
        }
    }
}
