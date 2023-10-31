using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cursa
    {
        #region Atributos
        private int Id;
        private int DNI_Alumno;
        private int Codigo_Materia;
        private int Nota;
        private string Condicion;
        #endregion

        #region Constructores
        public Cursa()
        {

        }

        public Cursa(int id, int dni_Alumno, int cod_Materia, int nota, string condicion)
        {
            Id = id;
            DNI_Alumno = dni_Alumno;
            Codigo_Materia = cod_Materia;
            Nota = nota;
            Condicion = condicion;
        }

        #endregion
    }
}
