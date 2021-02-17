using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;
namespace Sistema.Negocio
{
    public class NCategoria
    {
        public static DataTable Listar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(valor);
        }

        public static string Insertar(string nombre, string descripcion)
        {
            DCategoria Datos = new DCategoria();
            string existe = Datos.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "la Categoria ya existe";
            }
            else
            {
                Categoria obj = new Categoria();
                obj.Nombre = nombre;
                obj.Descripcion = descripcion;
                return Datos.Insertar(obj);
            }
            
        }

        public static string Actualizar(int id, string nombre, string descripcion)
        {
            DCategoria Datos = new DCategoria();
            string existe = Datos.Existe(nombre);
            if (existe.Equals("1"))
            {
                return "la Categoria ya existe";
            }
            else
            {
                Categoria obj = new Categoria();
                obj.IdCategoria = id;
                obj.Nombre = nombre;
                obj.Descripcion = descripcion;
                return Datos.Actualizar(obj);
            }
        }

        public static string Eliminar(int id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Desactivar(id);
        }
    }
}
