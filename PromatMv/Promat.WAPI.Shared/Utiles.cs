using System;
using System.IO;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Promat.WAPI.Shared
{
    public static class Utiles
    {
        /// <summary>
        /// Toma un string encodificado en BASE64 y lo decodifica
        /// </summary>
        /// <param name="valor">Un <seealso cref="string"/> encodificado en BASE64</param>
        /// <returns>El <seealso cref="string"/> decodificado</returns>
        public static string DecodeBase64ToString(string valor)
        {
            byte[] myBase64ret = Convert.FromBase64String(valor);
            string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
            return myStr;
        }

        /// <summary>
        /// Toma un string y lo encodifica en BASE64
        /// </summary>
        /// <param name="valor">El <seealso cref="string"/> a encodificar</param>
        /// <returns>El <seealso cref="string"/> encodificado</returns>
        public static string EncodeStrToBase64(string valor)
        {
            byte[] myByte = System.Text.Encoding.UTF8.GetBytes(valor);
            string myBase64 = Convert.ToBase64String(myByte);
            return myBase64;
        }

        /// <summary>
        /// Toma un <seealso cref="string"/> en formato JSON y lo deserializa en un objeto de tipo T
        /// </summary>
        /// <param name="JSON">El <seealso cref="string"/> en formato JSON</param>
        /// <returns>Un objeto de tipo T</returns>
        public static T JSONDeserialize<T>(string JSON)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(JSON);
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// Toma un objeto y lo serializa en formato JSON
        /// </summary>
        /// <param name="Object">El objeto a serializar</param>
        /// <returns>Un <seealso cref="string"/> con la serialización del objeto</returns>
        public static string JSONSerialize(object Object)
        {
            return JsonConvert.SerializeObject(Object);
        }

        /// <summary>
        /// Toma un objeto y lo serializa en formato XML
        /// </summary>
        /// <param name="Object">El objeto a serializar</param>
        /// <returns>Un <seealso cref="string"/> con la serialización del objeto</returns>
        public static string XMLSerialize(object Object)
        {
            var xmlserializer = new XmlSerializer(typeof(Object));
            using (var stringWriter = new StringWriter())
            {
                xmlserializer.Serialize(stringWriter, Object);
                return stringWriter.ToString();
            }
        }

        /// <summary>
        /// Toma un <seealso cref="string"/> en formato XML y lo deserializa en un objeto de tipo T
        /// </summary>
        /// <param name="XML">El <seealso cref="string"/> en formato XML</param>
        /// <returns>Un objeto de tipo T</returns>
        public static T XMLDeserialize<T>(string XML)
        {
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                using (var stringReader = new StringReader(XML))
                {
                    return (T)xmlserializer.Deserialize(stringReader);
                }
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// Decodifica un KeyToken para su uso.
        /// </summary>
        /// <param name="KT"></param>
        /// <returns></returns>
        public static string DecodeKeyToken(ClientCfg KT)
        {
            // Para mientras
            return DecodeBase64ToString(KT.Token);
        }

    }
}
