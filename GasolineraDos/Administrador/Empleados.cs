using Gasolinera;
using GasolineraDos.Conexion;
using GasolineraDos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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

            return resultado ? empleado.Cargo : null;
        }

    }

}
