using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace CacaoTech.BLL
{
    public class Seguridad
    {
        public string cifrarTexto(string textoCifrar)
        {
            string clave = "";
            Byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(textoCifrar);
            clave = Convert.ToBase64String(encriptar);
            return clave;
        }


        public string descifrarTexto(string textoCifrado)
        {
            string clave = "";
            Byte[] desencriptar = Convert.FromBase64String(textoCifrado);
            clave = System.Text.Encoding.Unicode.GetString(desencriptar);
            return clave;
        }
    }
}
