using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeInventarios
{
    class Inventario
    {
        Producto producto;
        private Producto[] _Inventario;
        private int _contador;
        Producto auxiliar;
        //int dato;
        //Producto siguiente;
        Producto inicio;

        public Inventario()
        {
            inicio = null;
        }

        public bool agregarProducto(Producto producto)
        {
            bool agregar = true;

            if (inicio == null)
            {
                inicio = producto;
            }
            else
            {
                Producto tmp = inicio;

                while (tmp.siguiente != null && agregar == true)
                {
                    if (tmp.codigo == producto.codigo)
                    {
                        agregar = false;
                    }
                    tmp = tmp.siguiente;
                }

                if (tmp.codigo != producto.codigo && agregar)
                {
                    tmp.siguiente = producto;
                }
            }

            return agregar;
        }

        public void agregarInicio(Producto producto)
        {
            producto.siguiente = inicio;
            inicio = producto;
        }
        public void eliminarProducto(int posicion)
        {
            Producto tmp = inicio;
            bool existe = true;

            if (tmp != null)
            {
                if (tmp.codigo == posicion)
                {
                    inicio = tmp.siguiente;
                    tmp = inicio;
                }
                else
                {
                    while (tmp.siguiente != null)
                    {
                        tmp = tmp.siguiente;
                    }
                }
            }

            //for (int i = 0; i < _contador; i++)
            //{
            //    if (_Inventario[i].codigo == posicion)
            //    {
            //        while (i < _contador)
            //        {
            //            _Inventario[i] = _Inventario[i + 1];
            //            i++;
            //        }
            //        _Inventario[_contador] = null;
            //        _contador--;
            //    }
            //    else
            //    {
            //        existe = false;
            //    }
            //}
            //return existe;
        }

        public Producto buscarProducto(int posicion)
        {
            Producto tmp = inicio;

            while(tmp != null && tmp.codigo != posicion)
            {
                tmp = tmp.siguiente;
            }

            return tmp;
        }

        public void insertarProducto(Producto producto, int posicion)
        {
            int cont = 2;
            Producto tmp = inicio;

            tmp = inicio;

            if (posicion == 1)
            {
                producto.siguiente = tmp;
                inicio = producto;
            }
            else
            {
                while (tmp.siguiente != null && cont != posicion)
                {
                    cont++;
                    tmp = tmp.siguiente;
                }
                producto.siguiente = tmp.siguiente;
                tmp.siguiente = producto;
            }
            //Producto producto2;
            //posicion = posicion - 1;
            //_contador++;

            //for (int i = posicion; i < _contador; i++)
            //{
            //    //_Inventario[i] = _Inventario[i - 1];
            //    auxiliar = _Inventario[i];
            //    _Inventario[i] = producto;
            //    producto = auxiliar;
            //}
            ////_contador++;
            ////_Inventario[posicion] = producto;
        }

        public override string ToString()
        {
            string mostrar = "";
            Producto tmp = inicio;

            while (tmp != null)
            {
                mostrar += tmp.ToString();
                tmp = tmp.siguiente;
            }
            return mostrar;
        }
    }
}
