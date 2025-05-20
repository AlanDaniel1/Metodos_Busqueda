# Metodos de Busqueda C#

Este proyecto tiene como finalidad implementar y comparar diferentes métodos de búsqueda en una aplicación de consola escrita en C#. La búsqueda es una operación clave en el mundo de la informática, ya que nos permite localizar elementos dentro de estructuras de datos de manera eficiente. Se han desarrollado los siguientes métodos:

1. Búsqueda Secuencial: Este método revisa el arreglo, elemento por elemento, hasta dar con el valor que estamos buscando.
2. Búsqueda Binaria: Aquí, se divide el conjunto de datos ordenados en mitades, lo que permite una búsqueda más eficiente.
3. Transformación de Claves: Se utiliza una función de transformación para optimizar la eficiencia de la búsqueda.

Instrucciones para clonar el repositorio en Visual Studio 2022:

1. Descargar e instalar Visual Studio 2022 (si aún no lo tienes)

**Si aún no tienes Visual Studio Community 2022 instalado, sigue estos pasos:**

*Accede al sitio de descargas:

-Abre tu navegador web y ve a Visual Studio Community 2022.
-Descarga e instala la versión gratuita:
-Descarga la versión gratuita Visual Studio Community.
-Ejecuta el instalador y selecciona las cargas de trabajo necesarias. Para este proyecto, asegúrate de instalar ".NET desktop development".

*Configura el entorno:
-Una vez instalado, inicia Visual Studio y asegúrate de que está correctamente configurado.

2. Clonar el repositorio desde GitHub

**Para clonar el repositorio, sigue estos pasos:**

*Obtén el enlace del repositorio GitHub:

-Ve al repositorio de tu código en GitHub:
-Repositorio en GitHub.
-Copia el enlace del repositorio (Clone URL), que generalmente se encuentra en el botón verde "Code" en la parte superior derecha.
-Abre Visual Studio 2022
-Una vez que Visual Studio esté abierto, en la pantalla de bienvenida, busca la opción "Clonar un repositorio".
-Introduce el enlace del repositorio:
-En el cuadro de texto que aparece, pega el enlace copiado de GitHub y presiona Clonar.
-Espera a que Visual Studio descargue el contenido en tu máquina local.

4. Abrir y ejecutar el proyecto en Visual Studio

**Explorar los archivos:**

-Una vez clonado, abre el Explorador de Soluciones (Ctrl + Alt + L si no está visible).
-Dentro del explorador, busca el archivo principal (Program.cs).
-Asegúrate de que todos los archivos de búsqueda (MetodosBusqueda.cs) están en el proyecto.

*Verificar la configuración del proyecto:

-Comprueba que el proyecto esté configurado con la versión adecuada de .NET.
-Si es necesario, puedes verificar la versión instalada ejecutando dotnet --version en una terminal.

*Compilar y ejecutar el código:

-En la barra superior de Visual Studio, busca el botón Ejecutar (Start o Run).
-También puedes presionar Ctrl + F5 para ejecutar el programa sin depuración.
-Visual Studio abrirá la consola donde podrás ingresar valores y probar los métodos de búsqueda.

6. Opcional: Subir cambios al repositorio

**Si realizas modificaciones en el código y deseas subirlas a GitHub:**

*Realizar cambios en el código:

-Edita los archivos dentro de Visual Studio.

*Guardar y confirmar cambios:

-Usa la opción Git -> Commit para confirmar los cambios.

*Subir cambios a GitHub:

-Luego de confirmar los cambios, selecciona Git -> Push para enviarlos al repositorio remoto.


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
