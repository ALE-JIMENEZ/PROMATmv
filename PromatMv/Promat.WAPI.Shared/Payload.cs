using System;

namespace Promat.WAPI.Shared
{
    /// <summary>
    /// Esta enumeracion define el tipo de dato que viene en el campo Data de un Payload: 
    /// PLAIN = Texto Plano,
    /// JSON = Objeto en formato JSON,
    /// XML = Objeto en formato XML,
    /// BASE64 = Datos binarios encodificados en BASE64,
    /// RAW = Datos binarios sin codigicar
    /// </summary>
    public enum PayloadDataType { PLAIN = 0, JSON= 1, XML= 2, BASE64 = 4 }
    
    /// <summary>
    /// Clase Payload
    /// </summary>
    public class Payload
    {
        public string MethodId { get; set; }
        public PayloadDataType DataType { get; set; }   
        public string Data { get; set; }
    }
}
