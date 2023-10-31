using Datos;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;
using System.Data;
using Entidades;

namespace Materia
{
    public class ListaMaterias : DatosConexionBD
    {

        public int abmMateria(string accion, Materia objMateria)
        {
            int resultado = -1;

            string orden = string.Empty;
            
            if (accion == "Alta")
                orden = $"insert into Materia values ('{objMateria.Categoria}','{objMateria.NombreProducto}','{objMateria.PrecioProducto}')";

            if (accion == "Modificar")
                orden = $"update Producto set Categoria = '{objMateria.Categoria}' where id = {objMateria.Id}; update Producto set NombreProducto = '{objMateria.NombreProducto}' where id = {objMateria.Id}; update Producto set PrecioProducto = '{objMateria.PrecioProducto}' where id = {objMateria.Id}; ";
            //if (accion == "Baja")

            //    orden = $"delete from Producto where Id = {objMateria.Id}";


            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Error al tratar de guardar, borrar o modificar {objMateria} ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoMateria(string id)
        {
            string orden = string.Empty;
            if (id != "Todos")
                orden = $"select * from Materia where id = {int.Parse(id)};";
            else
                orden = "select * from Materia;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;
            }
            catch (Exception e)
            {
                return ds = null;
                throw new Exception("Error al listar Materia", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            //return ds;
        }


        public List<Materia> ObtenerProducto()
        {

            List<Materia> lista = new List<Materia>();


            string OrdenEjecucion = "Select Id, Categoria , NombreProducto , PrecioProducto from Producto";


            SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

            SqlDataReader dataReader;

            try
            {
                Abrirconexion();

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {


                    string productos = dataReader.GetString(2);
                    int precio = dataReader.GetInt32(3);
                    string productoprecio = $"{productos} , ${precio}";



                    Materia materia = new Materia();

                    materia.Id = dataReader.GetInt32(0);

                    //producto.Categoria = dataReader.GetString(1);

                    //producto.NombreProducto = dataReader.GetString(2);

                    //producto.PrecioProducto = dataReader.GetInt32(3);

                    materia.NombreProducto = productoprecio;

                    lista.Add(materia);
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al obtener la lista de materias", e);
            }

            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return lista;
        }

        public DataSet listarMateriaBuscar(string cual)
        {
            string orden = $"select * from Materia where Id like '%{cual}%' or Categoria like '%{cual}%' or NombreProducto like '%{cual}%' or PrecioProducto like '%{cual}%';";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar el materia", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet listarMateriaEliminar(string id)
        {
            string orden = $"delete from Materia where Id = {id};";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar la materia", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
