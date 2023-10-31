using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
	public class ListaAlumno : DatosConexionBD
	{
		public int abmCaja(string accion, Alumno objAlumno)
		{

			int resultado = -1;
			string orden = string.Empty;
			if (accion == "Alta")
				orden = $"insert into Alumno values ('{objAlumno.DNI}','{objCaja.FechaCaja}','{objCaja.productoId}','{objCaja.movimientoId}')";

			if (accion == "Modificar")
				orden = $"update Caja set TipoComprobante = '{objCaja.TipoComprobante}' where id = {objCaja.Id};  update Caja set FechaCaja = '{objCaja.FechaCaja}' where id = {objCaja.Id}; update Caja set productoId = '{objCaja.productoId}' where id = {objCaja.Id}; update Caja set movimientoId = '{objCaja.movimientoId}' where id = {objCaja.Id}; ";

			//if (accion == "Baja")
			//    orden = $"delete from Caja where Id = {objCaja.Id}";


			SqlCommand cmd = new SqlCommand(orden, conexion);
			try
			{
				Abrirconexion();
				resultado = cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception($"Error al tratar de guardar,borrar o modificar {objCaja} ", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return resultado;
		}
	}
}
