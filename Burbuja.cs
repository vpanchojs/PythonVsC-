using System;

namespace burbuja
{
    class MainClass
    {
        public void ordenamientoBurbuja(string[] lista)
        {
            int x;
            string temp;
            for (int a = lista.Length-1; a >= 0; a--)
            {
                for (int b = 0; b < a; b++)
                {
                    
                    x = string.Compare(lista[b], lista[b + 1], StringComparison.Ordinal);
                    if (x > 0)
                    {
                        temp = lista[b];
                        lista[b] = lista[b + 1];
                        lista[b + 1] = temp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string[] lista = new string[] {"a", "b", "d", "e", "w", "s", "p", "a", "b", "d", "e", "w", "s", "p", "a",
                "b", "d", "e", "w", "s", "p", "t","e","n","x","z","c","i","o","p","k","l","m","h","q","w","e","r","t",
                "u","i","g","v","f","w","t","r","a", "b", "d", "e", "w", "s", "p","a", "b", "d", "e", "w", "s", "p",
                "a", "b", "d", "e", "w", "s", "p", "t","e","n","x","z","c","i","o","p","k","l","m","h","q","w","e",
                "r","t","u","i","g","v","f","w","t","r"};
            
            MainClass obj = new MainClass();
            obj.ordenamientoBurbuja(lista);
        }
    }
}