# TallerProgra1
## Caluladora de Promedios.
Primer proyecto universitarion en lenguaje C# con uso de  con git/github/ VS Community
## Abstracción:
Caluladora de promedios solicita al usuario nombre del alumno, notas obtenidas en los 3 cuatrimestres, calcula promedio final y define si está aprobado o no, si el usuario desea evaluar a otro alumno el proceso se repite de lo contrario cierra.
## Desarrollo:
Se establece la Clase evaluador (): solicita el nombre lo almacene en una variable {nombre}, luego las calificaciones de los 3 cuartrimestres, de igual forma almacenadas en las variables {cuatri1} {cuatri2} {cuatri3}.
Seguidamente calcule el promedio o nota final y lo almacene en una variable de tipo double llamada {notaFinal}, la cual mediante un condicional {if} se definirá si el alumno está en condicíón de aprobado/ reprobado.
La clase main(): Desde su inicio llama a evaluador(), luego se esteblece una variable bool llamada {ciclo = True} 
y con la implementación de un bucle {For} vacío que contiene unicamente el valor de la variable ciclo determina que mientras el for anidado tenga un valor True debe repetirse hasta que el valor de ciclo sea diferente el cual está determinado por un if anidado que según la condición elegida por el usuario en pantalla si desea evaluar otro alumno o no.
En caso de Si (true) repite el proceso y en caso de No(False) la variable ciclo toma un valor de false y se termina el proceso con un ¨Hasta Luego¨.
