using System;

namespace arbolbinario
{
    class Nodo
    {
        public int valor;
        public Nodo izq, der;

        public Nodo()
        {
            this.valor = 0;
            this.izq = null;
            this.der = null;
        }
    }

    class ArbolBinario
    {
        
        Nodo raiz;

        public ArbolBinario()
        {
            
            raiz = null;

        }

        public void insertar(Nodo puntero, int a)
        {
            Nodo aux;
            if (puntero != null)
            {
                if (a < puntero.valor)
                {
                    insertar(puntero.izq, a);
                    puntero.izq = raiz;
                }
                else
                {
                    if (a > puntero.valor)
                    {
                        insertar(puntero.der, a);
                        puntero.der = raiz;
                    }
                }
                raiz = puntero;
            }
            else
            {
                aux = new Nodo();
                aux.valor= a;
                raiz = aux;
            }
        }

        public void preorden(Nodo puntero) 
        {
            if (puntero != null)
            {
                Console.WriteLine(puntero.valor);
                preorden(puntero.izq);
                preorden(puntero.der);
            }
        }

        public Boolean buscar(Nodo puntero, int dato)
        {
            Boolean encontrado = false;
            if (puntero != null)
            {
                if (dato < puntero.valor)
                {
                    encontrado = buscar(puntero.izq, dato);
                } else {
                    if (dato > puntero.valor)
                    {
                        encontrado = buscar(puntero.der, dato);
                    } else {
                        if (dato == puntero.valor)
                        {
                            encontrado = true;
                        }
                    }
                }
            }
            return encontrado;
        }

        public static void Main(string[] args)
        {
            Nodo nodo = new Nodo();
            ArbolBinario abb = new ArbolBinario();
            int[] lista = new int[] { 285, 648, 103, 647, 916, 634, 207, 8, 539, 593, 400, 889, 121, 554, 588, 972, 847, 587, 31, 220, 637, 804, 301, 964, 360, 491, 285, 596, 434, 243, 500, 121, 715, 171, 865, 854, 594, 460, 253, 172, 56, 100, 114, 864, 101, 631, 912, 986, 885, 650, 843, 904, 643, 895, 701, 456, 330, 70, 204, 354, 835, 480, 545, 137, 644, 965, 512, 526, 952, 533, 355, 846, 204, 54, 238, 256, 583, 89, 412, 622, 887, 535, 744, 682, 348, 549, 579, 551, 969, 638, 93, 673, 404, 60, 376, 776, 980, 314, 305, 255 };

            foreach (int a in lista)
            {
                abb.insertar(nodo, a);
            }

            if (abb.buscar(nodo, 330) == true)
            {
                Console.WriteLine("Dato encontrado");
            }
            else
            {
                Console.WriteLine("Dato no encontrado");
            }
        }

    }

}
