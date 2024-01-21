using BaseDatosInterna.Models;
using BaseDatosInterna.Utils;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatosInterna.Service
{
    public class ProductoRepository
    {
        SQLiteConnection connection;
        public ProductoRepository() {
            connection = new SQLiteConnection(Util.DataBasePath, Util.Flags);
            connection.CreateTable<Productos>();

        }

        public void Add(Productos productos)
        {
            try
            {
                connection.Insert(productos);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public List<Productos> GetAll()
        {
            List<Productos> ListaProductos = new List<Productos>();
            try
            {
                ListaProductos = connection.Table<Productos>().ToList();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ListaProductos;
        }

        public Productos Get(int id)
        {
            Productos producto = new Productos();
            try
            {
                producto = connection.Table<Productos>().FirstOrDefault(x => x.IdProducto == id);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Producto: {ex.Message}");
            }
            return producto;

        }

        public void Delete(int id)
        {
            try
            {
                Productos producto = Get(id);
                connection.Delete(producto);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }

        public void Update(Productos producto)
        {
            try
            {
                if (producto.IdProducto != 0)
                {
                    Productos productoencontrado = Get(producto.IdProducto);
                    connection.Update(producto);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
