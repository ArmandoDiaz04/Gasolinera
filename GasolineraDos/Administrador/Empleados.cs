using GasolineraDos.Conexion;
using GasolineraDos.Models;
using System.Security.Cryptography;
using System.Text;

namespace GasolineraDos.Administrador
{
    public class Empleados
    {
     
        private ContextBd contexto;

        public Empleados()
        {
            this.contexto = new ContextBd();
        }

        public void CrearEmpleado(Empleado empleado)
        {
            contexto.Empleados.Add(empleado);
            contexto.SaveChanges();
        }

        public string? inicioSesion(string usuario, string passwordEnTexto)
        {
            // Obtener el empleado correspondiente al usuario que intenta iniciar sesión
            Empleado empleado = contexto.Empleados.SingleOrDefault(e => e.Dui.Equals(usuario));

            bool resultado = false;

            if (empleado != null && empleado.Contrasenia != null)
            {
                // Encriptar la contraseña ingresada en texto con la misma clave y vector de inicialización que se utilizó para encriptar la contraseña almacenada en la base de datos
                byte[] passwordEncriptada = Encriptar( passwordEnTexto);

                // Comparar los bytes de ambas contraseñas encriptadas para ver si son iguales
                resultado = empleado.Contrasenia.SequenceEqual(passwordEncriptada);
            }

            if (!resultado)
            {
                MessageBox.Show("El usuario o contraseña son erróneos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (resultado)
            {
                // Guardar la información del empleado logueado en la clase Properties               
                user.Default.cargo = empleado.Cargo;
                user.Default.nombre = empleado.Nombre;
                user.Default.Save();
            }

            return resultado ? empleado.Cargo : null;
        }

        public bool EliminarEmpleado(int dui)
        {
          
                var eliminar = contexto.Empleados.Find(dui);
                if (eliminar != null)
                {
                contexto.Empleados.Remove(eliminar);
                contexto.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
        public static byte[] Encriptar( string cadena)
        {
            string clave = "2b7e151628aed2a6abf7158809cf4f3c";
            string iv = "000102030405060708090a0b0c0d0e0f";
            byte[] ivBytes = Enumerable.Range(0, iv.Length)
                           .Where(x => x % 2 == 0)
                           .Select(x => Convert.ToByte(iv.Substring(x, 2), 16))
                           .ToArray();

            byte[] textoPlano = Encoding.UTF8.GetBytes(cadena);         
            byte[] textoCifrado;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(clave);
                aesAlg.IV = ivBytes;
                aesAlg.Padding = PaddingMode.PKCS7;
                aesAlg.Mode = CipherMode.CBC;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(textoPlano, 0, textoPlano.Length);
                        csEncrypt.FlushFinalBlock();
                        textoCifrado = msEncrypt.ToArray();
                    }
                }
            }

            return textoCifrado;
        }

        public static string Desencriptar(byte[] textoCifrado)
        {
            string textoDesencriptado;
            string clave = "2b7e151628aed2a6abf7158809cf4f3c";
            string iv = "000102030405060708090a0b0c0d0e0f";

            byte[] ivBytes = Enumerable.Range(0, iv.Length)
                           .Where(x => x % 2 == 0)
                           .Select(x => Convert.ToByte(iv.Substring(x, 2), 16))
                           .ToArray();


            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(clave);
                aesAlg.IV = ivBytes;
                aesAlg.Padding = PaddingMode.PKCS7;
                aesAlg.Mode = CipherMode.CBC;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(textoCifrado))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            textoDesencriptado = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return textoDesencriptado;
        }
        public void EditarEmpleado(int id, string nuevoNombre, string nuevoCargo)
        {
            using (var context = new ContextBd())
            {
                var empleado = context.Empleados.Find(id);
                if (empleado != null)
                {
                    empleado.Nombre = nuevoNombre;
                    empleado.Cargo = nuevoCargo;
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("El empleado no existe en la base de datos.");
                }
            }
        }
    }

}
