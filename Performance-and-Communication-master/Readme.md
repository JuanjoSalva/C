
## Laboratorio Módulo 12

Fichero de Instrucciones: Instructions\20486D_MOD012_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:** Juan José Salvador Román
2. **Fecha:** /
3. **Resumen de/l Ejercicio:** 

Escenario
Se le ha pedido que cree una aplicación de tienda de electricidad basada en la web para los clientes de su organización. La aplicación debe tener una página que
muestre la oferta del día, los productos ordenados por categoría, la capacidad de agregar productos a su lista de compras y una página de chat que permita a los usuarios 
hablar en línea. La aplicación debe contener un ayudante de etiquetas de caché para almacenar en caché el contenido de una vista, una memoria caché en un controlador y una 
configuración del estado de la sesión. Finalmente, escribirás una aplicación de sala de chat usando SignalR.


**Objetivos**

- Implemente una estrategia de almacenamiento en caché.

- Administrar estado.

- Agregue comunicación bidireccional.

**Ejercicio 1:**
implementación de una estrategia de almacenamiento en caché

Para mejorar el rendimiento de una aplicación web, se debe utilizar el almacenamiento en caché en la aplicación web. En este ejercicio, primero agregará un asistente de etiquetas de caché a una vista. Después de eso, usará la memoria caché para almacenar y recuperar elementos.

Las principales tareas de este ejercicio son las siguientes:

1. Agregar un asistente de etiquetas de caché a una vista

2. Insertar datos para ser almacenados en caché por el asistente de etiquetas de caché

3. Ejecutar la aplicación

4. Insertar elementos en una memoria caché

5. Ejecutar la aplicación



Iniciamos la aplicación y vemos como la eqtiqueta muestra la hora de incio de sessión. Si al rato abro otra ventana muestra la misma hora que está en caché

![inicio](https://github.com/JuanjoSalva/Performance-and-Communication/blob/master/ElectricStore/img/etiqueta_cache.PNG)


Al ir a la cesta vemos que no hay nada

![inicio](https://github.com/JuanjoSalva/Performance-and-Communication/blob/master/ElectricStore/img/objetos_inicio.PNG)


Al ir al comrar una impresora hay que mertr los datos personales
![inicio](https://github.com/JuanjoSalva/Performance-and-Communication/blob/master/ElectricStore/img/datos_inicio.PNG)

los metemos y compram,os:
![inicio](https://github.com/JuanjoSalva/Performance-and-Communication/blob/master/ElectricStore/img/primera_compra.PNG)

Al ir a la compra vemos que se ha añadido la impresora

![inicio](https://github.com/JuanjoSalva/Performance-and-Communication/blob/master/ElectricStore/img/ver_primera_compra.PNG)


Vulevo a comrar, ahora un atele, y vemos que mis datos se han guardado en caché

![inicio](https://github.com/JuanjoSalva/Performance-and-Communication/blob/master/ElectricStore/img/seunda_compra.PNG)


Al volver a la lista aprace la tele y la impresora que ya estaba

![inicio](https://github.com/JuanjoSalva/Performance-and-Communication/blob/master/ElectricStore/img/lista_segunda_compra.PNG)

**Exercise 2:** 
GEstión del estado

Para retener información en todas las solicitudes, el estado debe usarse en la aplicación web. En este ejercicio, utilizará el estado de la sesión para administrar el estado en la aplicación web.

Las principales tareas de este ejercicio son las siguientes:

1. Habilite el trabajo con sesiones

2. Utilice la sesión para almacenar valores

3. Recuperar valores de una sesión

4. Ejecute la aplicación y navegue de una vista a otra.


Ponemos tiempo para la sesión, si no se hace nada en 1 minutos la sesión y su datos terminan

![inicio](https://github.com/JuanjoSalva/Performance-and-Communication/blob/master/ElectricStore/img/sesion_cancelada.PNG)

**Ejercicio 3:** 
Comunicación bidireccionalGuión
En este ejercicio, primero agregará una clase de SignalR Hub denominada ChatHub. Luego, agregará una clase de SignalR Hub denominada ChatHub y registrará el ChatHub en la clase de inicio. Luego, agregará una vista de chat. Finalmente, escribirá el código JavaScript para conectarse al servidor, ejecutará la aplicación y navegará de una vista a otra.

Las principales tareas de este ejercicio son las siguientes:

1. Agregar una clase de SignalR Hub denominada ChatHub

2. Registre el ChatHub en la clase de inicio

3. Agregar una vista de chat

4. Escriba el código JavaScript para conectarse al servidor

5. Ejecutar la aplicación

En la lista hay un botón que abe uun chat
![inicio](https://github.com/JuanjoSalva/Performance-and-Communication/blob/master/ElectricStore/img/chat.PNG)
