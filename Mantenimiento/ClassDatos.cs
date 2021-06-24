using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento
{
    class ClassDatos
    {
        internal int codigo, edad;
        internal string nombre, apellido, direccion, departamento;

        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
             return apellido; 
        }
        public string GetDireccion()
        {
            return direccion; 
        }
        public string GetDepartamento()
        {
            return departamento; 
        }
        public int GetCodigo()
        {
            return codigo; 
        }
        public int GetEdad()
        {
            return edad; 
        }

        public void setNombre(string n)
        {
            nombre = n;
        }
        public void setApellido(string a)
        {
            apellido = a;
        }
        public void setEdad(int e)
        {
            edad = e;
        }
        public void setDireccion(string d)
        {
            direccion = d;
        }
        public void setDepartamento(string de)
        {
            departamento = de;
        }
        public void setCodigo(int c)
        {
            codigo = c;
        }

    }
}
