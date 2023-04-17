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

        public string? inicioSesion(string usuario, string password)
        {
            // Obtener el hash de la contraseña ingresada por el usuario
            byte[] contraseniaIngresadaH;
            using (var sha512 = SHA512.Create())
            {
                contraseniaIngresadaH = sha512.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

            // Obtener el empleado correspondiente al usuario que intenta iniciar sesión
            Empleado empleado = contexto.Empleados.SingleOrDefault(e => e.Dui.Equals(usuario));

            bool resultado = empleado != null && empleado.Contrasenia != null && empleado.Contrasenia.SequenceEqual(contraseniaIngresadaH) && empleado.Dui.Equals(usuario);

            if (!resultado)
            {
                MessageBox.Show("El usuario o contraseña son erroneos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
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
            using (var context = new ContextBd())
            {
                var eliminar = context.Empleados.Find(dui);
                if (eliminar != null)
                {
                    context.Empleados.Remove(eliminar);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
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
