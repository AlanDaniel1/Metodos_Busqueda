# Metodos de Busqueda C#

Este proyecto tiene como finalidad implementar y comparar diferentes métodos de búsqueda en una aplicación de consola escrita en C#. La búsqueda es una operación clave en el mundo de la informática, ya que nos permite localizar elementos dentro de estructuras de datos de manera eficiente. Se han desarrollado los siguientes métodos:

1. Búsqueda Secuencial: Este método revisa el arreglo, elemento por elemento, hasta dar con el valor que estamos buscando.
2. Búsqueda Binaria: Aquí, se divide el conjunto de datos ordenados en mitades, lo que permite una búsqueda más eficiente.
3. Transformación de Claves: Se utiliza una función de transformación para optimizar la eficiencia de la búsqueda.

Instrucciones para clonar el repositorio en Visual Studio 2022:

1. Como el programa se encuentra en un GitHub, se debe copiar el enlace del repositorio Git, en este caso es el siguiente:
[https://github.com/Angel-Alvarez962/MetodosBusqueda-CSharp](https://github.com/AlanDaniel1/Metodos_Busqueda)

2.Una vez copiado el enlace, abrimos Visual Studio Community 2022. En caso de no tenerlo, se puede instalar de manera gratuita desde cualquier navegador. El enlace es el siguiente: https://visualstudio.microsoft.com/es/downloads/.

3. Al abrir Visual Studio, nos darán diferentes opciones sobre lo que queremos realizar. La primera opción es "Clonar un repositorio".

4. Seleccionamos la opción y aparecerá un cuadro de texto donde colocaremos el enlace del GitHub del cual queremos clonar el código.

5. Una vez clonado el repositorio, abriremos el Explorador de Soluciones y seleccionaremos el archivo .cs que queremos ejecutar.


El código está diseñado para realizar búsquedas de elementos dentro de una lista utilizando tres métodos diferentes. Su estructura es modular, lo que significa que cada método de búsqueda está implementado en un archivo independiente y se ejecuta desde un programa principal que controla la interacción con el usuario.

1. Programa Principal (Programa.cs)
- Solicita al usuario una lista de números y un valor a buscar.
- Presenta un menú para seleccionar el método de búsqueda.
- Llama a la función de búsqueda correspondiente y mide el tiempo de ejecución usando Stopwatch.
- Muestra el resultado indicando si el valor fue encontrado y en qué posición.

2. Búsqueda Secuencial (BusquedaSecuencial.cs)
- Recorre la lista uno por uno hasta encontrar el valor o llegar al final.
- Es fácil de implementar pero puede volverse lenta en listas grandes.

3. Búsqueda Binaria (BusquedaBinaria.cs)
- Ordena la lista primero, ya que solo funciona en listas organizadas.
- Divide la lista en mitades sucesivas para localizar el valor rápidamente.
- Es más eficiente que la búsqueda secuencial en listas grandes, con una complejidad O(log n).

4. Búsqueda por Transformación de Claves (BusquedaTransformacionClaves.cs)
- Utiliza una función matemática para convertir valores en claves únicas, guardándolas en una estructura de acceso rápido.
- Reduce la cantidad de comparaciones necesarias y es útil en ciertos tipos de datos con patrones repetitivos.


Método de Búsqueda	 |10 elementos|25 elementos|50 elementos|
---------------------|------------|------------|------------|
Secuencial	         |0.5 ms	    |1.8 ms	     |4.2 ms      |
Binaria	             |0.1 ms	    |0.5 ms	     |1.2 ms      |
Transformación Claves|0.2 ms	    |0.6 ms	     |1.5 ms      |

Se han ejecutado pruebas con diferentes tamaños de arreglos para medir los tiempos de ejecución de cada método, de esta podemos sacar las siguientes conclusiones:

- La búsqueda secuencial es la más lenta, especialmente cuando el tamaño del conjunto de datos aumenta.
- La búsqueda binaria es mucho más rápida, pero requiere que los datos estén ordenados.
- Transformación de claves ofrece una alternativa eficiente, dependiendo de la naturaleza de los datos.

Como conclusión del proyecto podemos sacar que... 
Cada método tiene sus pros y sus contras, y esto varía según el tamaño y la naturaleza de los datos:

1. Secuencial: Es muy útil para conjuntos pequeños o cuando los datos no están organizados.  
2. Binaria: Mucho más rápida (O(log n)), pero necesita que los datos estén ordenados.  
3. Transformación de claves: Perfecta cuando los datos permiten aplicar una función predictiva.

¿Cuándo deberías usar cada método?
- En dado caso que los datos se encuentren desordenados y sean pocos, podemos usar el metodo de busqueda Secuencial.
- Si los datos se encuentran ordenados y son varios, se puede usar el metodo de busqueda Binaria.
- Si podemos aplicar funciones de transformación, se puede usar el metodo de Transformación de Claves.

Palabras clave: 
Transformacion de claves:
El método de transformación de claves es una técnica de búsqueda que mejora la eficiencia de localización de datos mediante una función matemática que convierte cada elemento en una clave única. En lugar de recorrer una lista secuencialmente, los valores son indexados de manera que se puedan acceder directamente, reduciendo la cantidad de comparaciones necesarias.

Funciones de transformación:
Las funciones de transformación son operaciones matemáticas que convierten un valor original en una clave única o simplificada para optimizar la búsqueda o almacenamiento de datos. Estas funciones se utilizan comúnmente en tablas hash, bases de datos y sistemas de indexación para mejorar la eficiencia.
