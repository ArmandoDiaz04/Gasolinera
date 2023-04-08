using GasolineraDos.Conexion;
using GasolineraDos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }

}
