# Figuras

**PRUEBA PROGRAMACIÓN .NET
(Puedes realizarlas en C# o en VisualBasic .NET)**

El ejercicio consiste en desarrollar seis pequeñas clases utilizando
herencia: Figura, Cuadrado, Rectángulo, Rombo y Triángulo. Y una última
clase llamada Principal que simplemente tendrá un pequeño método que
recorra una Lista. La jerarquía de las figuras es la siguiente:

![Figuras](https://ibb.co/167zYc7)

La clase Figura es abstracta y tendrá un método llamado pintar(). El resto
de clases heredarán de Figura (o de sus padres) y reimplementarán el
método pintar. El método pintar simplemente tiene que imprimir por
consola el nombre de la figura.
Por último, la clase Principal tendrá un método main que instanciará un
ArrayList de Figuras en el que meterá la siguiente lista de figuras en este
mismo orden: Triángulo, Rectángulo, Triángulo, Rectángulo y Rombo. A
continación hará dos recorridos de la lista: 1. Recuperará todas las figuras
de tipo cuadrado y para cada una de ellas hará que ejecute su método
pintar(). 2. Recuperará todas los triángulos y para cada uno de ellos hará
que ejecute su método pintar().

Se valorará el uso de Linq y/o Lambdas.
