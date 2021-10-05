using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arregloss
{
    class arre
    {
        int i = 0;
        int max = 30;
        string[] A = new string[30];

        public int Max { get => max; set => max = value; }
        public int I { get => i; set => i = value; }
        public string[] A1 { get => A; set => A = value; }

        public void Inicializar()
        {
            string[] A = new string[30];
        }
        public string Insertar(string letra)
        {
            if (i < 31)
            {
                A[i] = letra;
            }
            i++;
            return A[i];
        }
        public void Mostrar()
        {
            for (int j = 0; j < I; j++)
            {
                Console.WriteLine(A[j]);
            }
        }
        public void Buscar(string letra)
        {
            for(int a=0;a<I;a++)
            {
                if(letra==A[a])
                {
                    Console.WriteLine("Letra Encontrada en la poscion " + A[a]);
                }
                else
                {
                    Console.WriteLine("Letra no encontrada");
                }
            }
        }
        
        public void Ordenar()
        {
            char a;
            string let,aux;
            int pos = 0;
            for (int j = 97; j < 123; j++)
            {
                a = (char)j;
                for(int k=0; k<I;k++)
                {
                    string nom = A[k];
                    nom = nom.ToLower();
                    let=nom.Substring(0, 1);
                    if(let[0]==a)
                    {
                        aux = A[pos];
                        A[pos] = A[k];
                        A[k] = aux;
                        pos++;
                    }
                }
            }
        }
    }
}
