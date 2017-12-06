import timeit
from memory_profiler import profile


# Se define profile para poder medir el uso de ram utilizado mediante la ejecucion del algoritmo
#@profile
def ordenamientoBurbuja(unaLista):
    for numPasada in range(len(unaLista) - 1, 0, -1):
        for i in range(numPasada):
            if unaLista[i] > unaLista[i + 1]:
                temp = unaLista[i]
                unaLista[i] = unaLista[i + 1]
                unaLista[i + 1] = temp

unaLista = ["a", "b", "d", "e", "w", "s", "p", "a", "b", "d", "e", "w", "s", "p", "a", "b", "d", "e", "w", "s", "p",
            "t","e","n","x","z","c","i","o","p","k","l","m","h","q","w","e","r","t","u","i","g","v","f","w","t","r",
            "a", "b", "d", "e", "w", "s", "p","a", "b", "d", "e", "w", "s", "p", "a", "b", "d", "e", "w", "s", "p",
            "t","e","n","x","z","c","i","o","p","k","l","m","h","q","w","e","r","t","u","i","g","v","f","w","t","r"]

ordenamientoBurbuja(unaLista)
print ("Tiempo de Ejecucion",timeit.timeit("ordenamientoBurbuja(unaLista)", setup = "from __main__ import ordenamientoBurbuja,unaLista",number=1))

