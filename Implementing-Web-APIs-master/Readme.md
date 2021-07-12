
## Laboratorio Módulo 13

Fichero de Instrucciones: Instructions\20486D_MOD013_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:** Juan José Salvador Román
2. **Fecha:** 17/12/2020
3. **Resumen del Ejercicio:** 

Se le ha pedido que cree una aplicación de restaurante basada en la web para los clientes de su organización. Para hacer esto, necesita crear una página que muestre todas las sucursales de restaurantes, permitir a los usuarios solicitar una reserva para una sucursal de restaurante seleccionada, agregar una página de anuncios deseados y permitir enviar una solicitud para un trabajo seleccionado.

Creará una aplicación de API web del lado del servidor y una aplicación ASP.NET Core MVC del lado del cliente. 
En la aplicación del lado del cliente llamará a las acciones de la API web mediante HttpClient y jQuery.


**Objetivos**
Después de completar esta práctica de laboratorio, podrá:

- Agregar acciones a una aplicación de API web.

- Llamar a las acciones de la API web mediante HttpClient.

- Llamar a las acciones de la API web mediante jQuer


**Ejercicio 1:**
Agregar acciones y llamarlas mediante Microsoft Edge

En este ejercicio, primero agregará un controlador y una acción a una aplicación API web. Luego, ejecutará la aplicación y verá el resultado con Microsoft Edge. Después de eso, agregará un controlador y una acción que obtiene un parámetro. Luego, ejecutará la aplicación y verá el resultado con Microsoft Edge. Finalmente, agregará una acción Publicar a la aplicación Web API.

Las principales tareas de este ejercicio son las siguientes:

1.Agregar un controlador y una acción a una aplicación API web

2.Ejecutar la aplicación

3.Agrega un controlador y una acción que obtiene un parámetro

4.Ejecutar la aplicación

5.Agregar una acción Publicar a una aplicación API web


**Ejercicio 2:** 
Llamar a una API web mediante código del lado del servidor

En este ejercicio, llamará a la API web que desarrolló en el ejercicio anterior utilizando la clase HttpClient. Para hacer esto, primero registrará el servicio IHttpClientFactory en el archivo Startup.cs. Luego, creará un controlador MVC y usará la clase HttpClient para llamar a una acción Get en la API web. Después de eso, creará otro controlador MVC y usará la clase HttpClient para llamar a una acción de publicación en la API web. Finalmente, agregará una acción al controlador MVC en la que usará la clase HttpClient para llamar a una acción Get en la API web que obtiene un parámetro.

Las principales tareas de este ejercicio son las siguientes:

1.Llamar a un método Get de API web

2.Ejecutar la aplicación

3.Llamar a un método de publicación de API web

4.Llamar a un método Get de API web que obtiene un parámetro

5.Ejecutar la aplicación


**Ejercicio 3:**
llamar a una API web mediante jQuery

En este ejercicio, llamará a una API web mediante jQuery. Primero creará un controlador MVC y usará jQuery para llamar a una acción Get en la API web. Después de eso, creará otro controlador MVC y usará jQuery para llamar a una acción Publicar en la API web.

Las principales tareas de este ejercicio son las siguientes:

1.Llamar a un método Get de API web mediante jQuery

2.Ejecutar la aplicación

3.Llamar a un método Get de API web mediante HttpClient

4.Llamar a un método de publicación de API web mediante jQuery

5.Ejecutar la aplicación


Iniciamo la aplicación y nos lleva a Home para mostrar las sucursales:

![Inicio](https://github.com/JuanjoSalva/Implementing-Web-APIs/blob/master/Client/img/Inicio.PNG)



Introducimos un trabajo:
![Inicio](https://github.com/JuanjoSalva/Implementing-Web-APIs/blob/master/Client/img/PuestoTrabajo.PNG)
![Inicio](https://github.com/JuanjoSalva/Implementing-Web-APIs/blob/master/Client/img/PuestoTrabajoIn.PNG)
![Inicio](https://github.com/JuanjoSalva/Implementing-Web-APIs/blob/master/Client/img/PuestoTrabajoOut.PNG)

Hacemos una reserav:
![Inicio](https://github.com/JuanjoSalva/Implementing-Web-APIs/blob/master/Client/img/Reservation.PNG)
![Inicio](https://github.com/JuanjoSalva/Implementing-Web-APIs/blob/master/Client/img/ReservationIn.PNG)
![Inicio](https://github.com/JuanjoSalva/Implementing-Web-APIs/blob/master/Client/img/ReservationOut.PNG)


4. **Dificultad o problemas presentados y como se resolvieron:** Ninguno
