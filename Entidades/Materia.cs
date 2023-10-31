using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        #region Atributos
        private int codigo;
        private string nombre;
        private int año_cursado;
        private string dia_cursado;
        private string nombre_carrera;
        #endregion

        #region propiedades
        public int Id
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Año_Cursado
        {
            get { return año_cursado; }
            set { año_cursado = value; }
        }
        public string Dia_cursado
        {
            get { return dia_cursado; }
            set { dia_cursado = value; }
        }

        public string Nombre_carrera
        {
            get { return nombre_carrera; }
            set { nombre_carrera = value; }
        }
        #endregion


        #region Constructores
        public Materia()
        { }
        public Materia(int Codigo, string Nombre, int Año, string Dia_Clases, string Carrera)
        {
            codigo = Codigo;
            nombre = Nombre;
            año_cursado = Año;
            dia_cursado = Dia_Clases;
            nombre_carrera = Carrera;

        }
        #endregion
    }
}
