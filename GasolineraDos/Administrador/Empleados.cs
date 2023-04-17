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
                byte[] passwordEncriptada = Encriptar(usuario, passwordEnTexto, empleado.Cargo);

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
        public static byte[] Encriptar(string seguridad,string cadena,string cargo)
        {
            byte[] textoPlano = Encoding.UTF8.GetBytes(cadena);         
            byte[] textoCifrado;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(seguridad);
                aesAlg.IV = Encoding.UTF8.GetBytes(cargo);
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

        public static string Desencriptar(string seguridad,byte[] textoCifrado, string cargo)
        {
            string textoDesencriptado;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(seguridad);
                aesAlg.IV = Encoding.UTF8.GetBytes(cargo); 
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
