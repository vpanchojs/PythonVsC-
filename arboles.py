import timeit
from memory_profiler import profile

class node():
    def __init__(self, dato):
        self.left = None
        self.right = None
        self.dato = dato


class arbol():
    def __init__(self):
        self.root = None

    @profile
    def insert(self, a, dato):
        if a == None:
            a = node(dato)
        else:
            d = a.dato
            if dato < d:
                a.left = self.insert(a.left, dato )
            else:
                a.right = self.insert(a.right, dato)
        return a


    #@profile
    def buscar(self, dato, a):
        if a == None:
            return False
        else:
            if dato == a.dato:
                return True
            else:
                if dato < a.dato:
                    return self.buscar(dato, a.left)
                else:
                    return self.buscar(dato, a.right)


lista=[285,648, 103, 647, 916, 634, 207, 8, 539, 593, 400, 889, 121, 554, 588, 972, 847, 587, 31, 220, 637, 804, 301,
       964, 360, 491, 285, 596, 434, 243, 500, 121, 715, 171, 865, 854, 594, 460, 253, 172, 56, 100, 114, 864, 101, 631,
       912, 986, 885, 650, 843, 904, 643, 895, 701, 456, 330, 70, 204, 354, 835, 480, 545, 137, 644, 965, 512, 526, 952,
       533, 355, 846, 204, 54, 238, 256, 583, 89, 412, 622, 887, 535, 744, 682, 348, 549, 579, 551, 969, 638, 93, 673,
       404, 60, 376, 776, 980, 314, 305, 255]

arbol=arbol()
for n in lista:
    arbol.root=arbol.insert(arbol.root,n)
if(arbol.buscar(103,arbol.root)):
    print "Encontre"
else:
    print "No encontre"

#print ("Tiempo de Ejecucion Insertar",timeit.timeit("arbol.insert", setup="from __main__ import arbol,n",number=1))
#print ("Tiempo de Ejecucion Buscar",timeit.timeit("arbol.buscar", setup="from __main__ import arbol",number=1))











