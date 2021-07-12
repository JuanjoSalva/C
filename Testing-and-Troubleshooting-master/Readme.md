### Testing and Troubleshooting

## Laboratorio Módulo 10

Fichero de Instrucciones: Instructions\20486D_MOD010_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:** Juan José Salvador Román
2. **Fecha:** 08/12/2020
3. **Resumen del Ejercicio:** 

Escenario
Para mejorar la calidad de una aplicación web para una tienda de camisetas, su equipo de desarrollo ha decidido agregar pruebas y resolución de problemas a la aplicación web. Se le ha pedido que agregue pruebas unitarias para probar un modelo y un controlador. También se le ha dicho que cuando se produce un error, el navegador debe mostrar una página de excepción detallada en el entorno de desarrollo y una página de error personalizada en el entorno de producción. Además, debe agregar el registro a la aplicación web.

Objetivos
Después de completar esta práctica de laboratorio, podrá:

- Pruebe una aplicación ASP.NET Core MVC.

- Agregue manejo de excepciones para los diferentes entornos.

- Agregue el registro a una aplicación ASP.NET Core MVC.

**Index**
![index](https://github.com/JuanjoSalva/Testing-and-Troubleshooting/blob/master/ShirtStoreWebsite/img/index.PNG)


**Ejercicio 1:** prueba de un modelo

Debe desarrollar una aplicación ASP.NET Core MVC en un entorno controlado por pruebas.

En este ejercicio, creará un proyecto de prueba MSTest y lo agregará a la solución, agregará la aplicación del sitio web ASP.NET CoreMVC a su lista de dependencias y luego probará el modelo Shirt.

Las principales tareas de este ejercicio son las siguientes:

1. Agregar un proyecto de prueba

2. Escribe una prueba para un modelo

3. Ejecute la prueba unitaria: debería fallar

4. Implementar la clase modelo para que pase la prueba

5. Ejecute la prueba unitaria - tiene éxito


**Ejercicio 2:** probar un controlador usando un repositorio falso

Después de crear un proyecto de prueba y probar el modelo, ahora debe probar el controlador.

Para hacer esto, deberá crear una interfaz de repositorio como una dependencia para que el controlador obtenga acceso a los datos. Para probar el controlador, creará un repositorio falso como sustituto y luego se lo proporcionará al controlador a través de su constructor.

Las principales tareas de este ejercicio son las siguientes:

1. Crea un repositorio de interfaz

2. Implementar el repositorio de la interfaz usando un repositorio falso

3. Pasa el repositorio falso al constructor de un controlador

4. Escribe una prueba para un controlador

5. Ejecute la prueba unitaria: debería fallar

6. Implementar la clase de controlador para que pase la prueba

7. Ejecute la prueba unitaria - tiene éxito

**Ejercicio 3:** 

implementación de un repositorio en el proyecto MVC
Una vez probado el modelo y el controlador, se le ha pedido que agregue una clase de repositorio para que la aplicación pueda ejecutarse. En este ejercicio, implementará un repositorio ShirtRepository que obtendrá datos de una base de datos y actualizará una base de datos. El repositorio ShirtRepository se registrará en el método ConfigureService.

Las principales tareas de este ejercicio son las siguientes:

1. Implemente el repositorio de interfaz en una clase de repositorio.

2. Registre el repositorio como servicio.

3. Ejecute la aplicación MVC.


**Ejercicio 4:** Agregar manejo de excepciones

Se le ha pedido que agregue el manejo de excepciones a la aplicación web. Si se produce un error mientras se ejecuta la aplicación, se deben implementar dos casos de uso: En el caso de que la aplicación se esté ejecutando en un entorno de desarrollo y se produzca un error, el usuario verá una página de error detallada con información sobre dónde encontrar el error. En el caso de que la aplicación se esté ejecutando en un entorno de producción, se mostrará una página personalizada no informativa alegando que hubo un error. Debe agregar un manejo de excepciones a cada uno de los casos de uso.

Las principales tareas de este ejercicio son las siguientes:

1. Agregar manejo de excepciones en Startup.cs

2. Crea una excepción temporal para la prueba

3. Ejecute la aplicación en el entorno de desarrollo

4. Ejecute la aplicación en el entorno de producción

5. Eliminar la excepción temporal


**Ejercicio 5:** Agregar registro

Debe proporcionar registro a la aplicación ASP.NET Core MVC mediante la biblioteca Serilog, mientras configura el registro por separado mediante archivos appsettings.json en los diferentes entornos. Todos los registros de nivel de registro de seguimiento en desarrollo se mostrarían en la consola, mientras que los registros de nivel de advertencia en producción se escribirían en su archivo dedicado. Esto también requeriría inyectar el ILogger al controlador, por lo que sería necesario actualizar la prueba del controlador.

Las principales tareas de este ejercicio son las siguientes:

1. Agregar registro a la aplicación MVC

2. Pruebe el controlador utilizando un marco de simulación

3. Ejecuta la prueba unitaria

4. Ejecute la aplicación en el entorno de desarrollo

5. Ejecute la aplicación en el entorno de producción


4. **Dificultad o problemas presentados y como se resolvieron:** 
