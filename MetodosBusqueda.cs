using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoBusquedasConsola
{
    public static class BusquedaSecuencial
    {
        public static int Buscar(int[] arreglo, int valor)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor)
                    return i;
            }
            return -1;
        }
    }

    public static class BusquedaBinaria
    {
        public static int Buscar(int[] arreglo, int valor)
        {
            Array.Sort(arreglo);
            int izquierda = 0, derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (arreglo[medio] == valor)
                    return medio;
                if (arreglo[medio] < valor)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
            return -1;
        }
    }

    public static class BusquedaTransformacionClaves
    {
        public static int Buscar(int[] arreglo, int valor)
        {
            Dictionary<int, int> tabla = new Dictionary<int, int>();

            for (int i = 0; i < arreglo.Length; i++)
            {
                int clave = TransformarClave(arreglo[i]);
                if (!tabla.ContainsKey(clave))
                    tabla[clave] = i;
            }

            int claveBuscada = TransformarClave(valor);
            return tabla.ContainsKey(claveBuscada) ? tabla[claveBuscada] : -1;
        }

        private static int TransformarClave(int valor)
        {
            return valor % 100;
        }
    }
}
