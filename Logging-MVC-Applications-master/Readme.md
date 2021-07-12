### Logging MVC Applications

A lo largo de la vida útil de una aplicación, pueden ocurrir excepciones inesperadas a diario. Si bien suele ser razonablemente fácil de encontrar y depurar en entornos de desarrollo, no se puede decir lo mismo de los entornos de producción. En la mayoría de los casos, como desarrollador, no podrá trabajar directamente en el entorno de producción. Para facilitar la búsqueda de errores, debe agregar registros regulares en toda la aplicación para monitorear el flujo de la aplicación y señalar excepciones. Hacer esto puede ayudarlo a encontrar problemas en sus aplicaciones y lidiar con errores que no se detectaron antes de la producción.


Las excepciones a las que se enfrenta durante el desarrollo se pueden investigar y depurar mediante las herramientas de depuración de Visual Studio. En una situación ideal, no surgirían excepciones cuando su aplicación web esté completa e implementada para los usuarios a través de Internet. Sin embargo, en el mundo real, surgen circunstancias imprevistas que dan lugar a excepciones. Por ejemplo, fallas en la base de datos, problemas de red y errores de configuración en cualquier parte del sistema pueden causar excepciones.

Ya ha visto cómo presentar una página de error personalizada informativa y de marca a los usuarios cuando ocurren excepciones. También es apropiado registrar las excepciones en una aplicación web de producción, para que los administradores y desarrolladores puedan evaluar el alcance del problema, eliminar la causa y mejorar la solidez del código.

Escribir código de registro de errores
Al agregar registros a su aplicación, primero debe decidir dónde le gustaría almacenar los registros. Hay muchas opciones potenciales que puede considerar para su aplicación, y ninguna solución única es la correcta porque cada solución tiene sus pros y sus contras. Los métodos de registro populares incluyen escribir archivos de registro con varios detalles sobre la aplicación, enviar datos de registro a servicios basados ​​en la nube para facilitar el almacenamiento y el análisis, almacenar datos de registro en bases de datos y enviar correos electrónicos sobre excepciones.

Al almacenar registros en archivos, se asegura de que los registros se escriban de manera persistente y se mantengan de manera más confiable. Sin embargo, se debe tener cuidado de equilibrar los registros para mantener una forma coherente de rastrear el flujo de datos y las excepciones porque registrar demasiado puede resultar en archivos grandes y difíciles de usar que ocupan un espacio valioso.

Al almacenar registros en servicios basados ​​en la nube como Microsoft Azure, puede garantizar un acceso fácil y potentes herramientas de investigación para los desarrolladores. Sin embargo, los servicios basados ​​en la nube dependen del acceso constante a Internet.

Al almacenar los registros en una base de datos, puede almacenar y dividir los registros de una manera que facilite su lectura. Sin embargo, esto requiere una conexión constante a la base de datos y una administración adecuada de la base de datos. Además, es posible que los desarrolladores no puedan acceder fácilmente a estos registros a diario.

Al iniciar sesión en el correo electrónico, puede asegurarse de que los desarrolladores estén informados muy rápidamente y puedan manejar el problema casi tan pronto como ocurra. Sin embargo, también puede resultar fácilmente en correos electrónicos repetidos por problemas repetidos, un exceso de correos electrónicos enviados, pérdidas en las conexiones de red y una bandeja de entrada de correo electrónico difícil de administrar.

Asegúrese de discutir estas opciones y cualquier opción adicional con su equipo y decida qué opción es la más apropiada para su aplicación. Recuerde que puede utilizar más de un método si se ajusta a su aplicación. Por ejemplo, puede iniciar sesión en archivos a diario y al mismo tiempo enviar correos electrónicos a los desarrolladores siempre que se produzcan excepciones críticas.

Dónde escribir el código de registro de errores
Cuando decida dónde escribir el código que registra los errores, debe considerar que pueden surgir errores en casi cualquier parte de su aplicación. Debe elegir un enfoque que le permita escribir código de registro de errores una vez que se ejecutará para cualquier excepción en cualquier lugar de su aplicación.

Por ejemplo, no es apropiado escribir código de registro de errores en bloques individuales try / catch. Si hace esto, tendrá que crear un bloque try / catch para cada procedimiento en su aplicación y escribir código de registro duplicado en el bloque catch.

Un enfoque mucho más eficaz es iniciar sesión mediante middleware. Al registrar excepciones mediante el uso de middleware, puede asegurarse de que el código problemático se registre y rastree correctamente. Esto permite un punto singular de falla para manejar todos los errores en la aplicación.

Uso de herramientas de registro de terceros
Debido a que el registro de excepciones es un requisito funcional muy común para las aplicaciones web, existen muchas soluciones de terceros que puede elegir si no desea escribir su propio código de registro. Muchos de estos están disponibles en Visual Studio desde el administrador de paquetes NuGet.


En ASP.NET Core, hay una sólida biblioteca de registro integrada. En lugar de trabajar con una forma específica de registro, utilizando la biblioteca de registro, puede configurar varios proveedores de registro diferentes, incluidos los proveedores integrados y varios proveedores de registro de terceros compatibles. Esto le permite implementar el registro que sea mejor para su aplicación y actualizar su mecanismo de registro sin realizar ningún cambio en el resto de su código.

Configuración de proveedores de registro

El primer paso para configurar su registro es configurar los proveedores que desea utilizar. Esto se hace dentro del método CreateWebHostBuilder del archivo Program.cs. El archivo Program.cs y el método CreateWebHostBuilder se tratarán en el Módulo 14, "Alojamiento e implementación".

Para agregar el registro, deberá agregar una llamada al método ConfigureLogging como parte de la canalización CreateDefaultBuilder. El método ConfigureLogging expone dos parámetros, un parámetro del tipo WebHostBuilderContext, que se puede usar para recuperar el IHostingEnvironment, y un parámetro ILoggingBuilder, que se usa para configurar los proveedores y las configuraciones del registrador.

En el método ConfigureLogging, deberá agregar el proveedor de registro, que habilitará el registro mediante el proveedor específico. Puede iniciar sesión en más de un proveedor al mismo tiempo. ASP.NET Core tiene varios proveedores integrados, que incluyen:

- Consola. Registra el mensaje en la ventana de la consola de la aplicación.

- Depurar. Registra el mensaje en la ventana de depuración de la aplicación.

- EventSource. Utiliza la API de seguimiento de eventos para almacenar el evento, el comportamiento difiere entre los sistemas operativos y es posible que no funcione en todas las plataformas.

- Registro de eventos. Registra el mensaje en el registro de eventos de Windows. Es exclusivo de Windows.

- TraceSource. Crea una fuente de seguimiento que se puede escuchar con una variedad de detectores de seguimiento.

- AzureAppServices. Crea registros que se integran con la plataforma Azure.


Los proveedores se pueden agregar llamando al método add * Provider Name * (). Después de llamar a este método, el proveedor está configurado para iniciar sesión en toda la aplicación.

El siguiente código es un ejemplo del uso del método ConfigureLogging:

El método ConfigureLogging

<pre> <code>
public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
WebHost.CreateDefaultBuilder(args)
    .ConfigureLogging((hostingContext, logging) =>
    {
        if (hostingContext.HostingEnvironment.IsDevelopment())
        {
            logging.AddConsole();
        }
    })
    .UseStartup<Startup>();
</code> </pre>

En este ejemplo, puede ver que la aplicación escribirá registros en la consola. Mientras ejecuta la aplicación desde Visual Studio, esto se puede encontrar en la pestaña Salida en ASP.NET Core Web Server.

Método de registro de llamadas

Una vez configurado el registro, puede agregar registros a componentes individuales inyectando un registrador en el constructor del componente. El registrador que inyecte debe ser del tipo ILogger <* className *> donde el nombre de la clase se usa para crear un identificador para el archivo desde el cual se llama al registrador. Este identificador contiene el espacio de nombres completo para la clase y facilita a los desarrolladores averiguar qué entrada de registro se creó desde dónde.

El siguiente código es un ejemplo de un controlador que escribe en un archivo de registro:

Registro desde el controlador

<pre> <code>
public class HomeController : Controller
{
    private ILogger _logger;
 
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
 
    public IActionResult Index()
    {
        _logger.LogInformation("Adding an entry to the logger.");
        return Content("Result from controller");
    }
}
</code> </pre>



El siguiente código es un ejemplo de cómo usar el registro en el método Configure:

Registro desde el método de configuración

<pre> <code>
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
{
    logger.LogCritical("Critical Message from logger");
 
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
 
    app.UseMvcWithDefaultRoute();
 
    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
}
</code> </pre>


Log Levels

In an ASP.NET Core MVC application, you will often want to keep track of a wide variety of events. At times, you might want to keep track of every individual DB request or every single call to the server, while in other times you might want to track major flows being called and exceptions that occur. For this purpose, you can use log levels to control which logs will be displayed in your application. By setting a log severity, only logs that match the severity or of a higher severity will be displayed.

The log levels and their severity values are as follows:

- Trace (0). These should be used when trying to debug specific things and are often used to track very large amounts of data. By default, trace logs are never displayed and should not be used outside of a development environment.

- Debug (1). Logs of this level are frequently used for development environments and keep track of large amounts of data. Logs of this level should not be logged outside of development environments.

- Information (2). Logs of this level should be used at important points throughout the application to ensure the application is running correctly but should avoid getting to a point where they affect system performance. Information logs are frequently, but not always. enabled in production environments.

- Warning (3). Logs of this level should be used whenever unexpected flows occur. Exceptions that are handled or flows with missing data will often log a warning. These logs should always appear in a development environment, which allows you to find problematic flows.

- Error (4). Logs of this level should occur whenever exceptions cannot be handled. These should be cases in which a flow has broken down but did not result in application wide issues. These logs should always be kept.

- Critical (5). Logs of this level should be used to signify application wide failures. Failures such as an invalid database connection and a failure on the web server should be tracked with critical logs.

To call logs of different levels, you can use the Log*level* method. For example, to create an information level log, you should use LogInformation, and in order to create a critical log, you should use LogCritical.

The following code is an example of log levels:

Log Levels Example

<pre> <code>
[HttpPost]
public IActionResult Update(int id, string name)
{
    if (id > 0)
    {
        _logger.LogInformation("Item has been added");
        return Content("Item added");
    }
    else
    {
        _logger.LogWarning("Invalid ID input");
        return Content("Invalid ID!");
    }
}
</code> </pre>

Log Event ID

An additional measure that can enable tracking specific errors is using log event ID, which is an optional parameter that you can add to as part of a call to a log method in order to track specific event cases. Commonly, these event IDs are declared as constants and used to further distinguish the events.

By supplying an integer as the first parameter to the logging method, you can assign that event to use the specified event ID. This can help find specific events later when trying to find issues.

The following code is an example of using event ID in logs:

Log Event ID

<pre> <code>
const int CALL_INDEX = 1000;
public IActionResult Index()
{
    _logger.LogInformation(CALL_INDEX, "Adding an entry to the logger.");
    return Content("Result from controller");
}
</code> </pre>

Excepciones de registro

Otro parámetro útil que puede ser aceptado por los distintos métodos de registro son las excepciones. Se puede utilizar un registro para mostrar excepciones directamente. Esto es útil para manejar excepciones que ocurren en bloques try / catch porque luego podrá ver los detalles de la excepción en el registro. Esto puede resultar muy útil para encontrar problemas que ocurren en producción. El parámetro para la excepción debe ser el primer parámetro si se omite el ID del evento, o será el segundo parámetro si se usa el ID del evento.

El siguiente código es un ejemplo de registro de excepciones:

Registro de excepciones

<pre> <code>
public IActionResult Index()
{
    try
    {
        int x = 3;
        x -= 3;
        int result = 30 / x;
    }
    catch (Exception ex)
    {
        _logger.LogError(INVALID_DIVISION, ex, "An error occurred while dividing!");
    }
    return Content("Result from controller");
}
</code> </pre>

Configurar el registro

También puede utilizar el archivo appsettings.json para configurar varios detalles para su registro. Se usa más comúnmente para establecer niveles de registro. Esto puede permitirle establecer fácilmente un nivel de registro diferente en diferentes entornos. Para cargar la configuración para el registro, deberá llamar al método AddConfiguration en el parámetro ILoggingBuilder y proporcionarle una configuración mediante el método GetSection en la propiedad Configuration del parámetro WebHostBuilderContext. Una vez hecho esto, se cargará la configuración de registro.

El siguiente código es un ejemplo de configuración de registro de carga:

Carga de la configuración de registro

<pre> <code>
public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
WebHost.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        var env = hostingContext.HostingEnvironment;
        config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
    })
    .ConfigureLogging((hostingContext, logging) =>
    {
        logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
        if (hostingContext.HostingEnvironment.IsDevelopment())
        {
            logging.AddConsole();
        }
        else
        {
            ILoggerProvider provider = new CustomProvider();
            logging.AddProvider(provider);
        }
    })
    .UseStartup<Startup>();
</code> </pre>


El siguiente código es un ejemplo de un archivo appsettings.json que contiene la configuración de registro:

Configuración de registro en 

<pre> <code>
{
  "Logging": {
    "LogLevel": {
      "Default": "Debug"
    }
  }
}
</code> </pre>


Uso de proveedores de registro de terceros

En una aplicación moderna, existen innumerables formas de almacenar registros, ya sea en servidores en la nube, bases de datos u otros. Sería imposible cubrir todos los métodos de almacenamiento posibles en ASP.NET Core y, en ocasiones, es posible que desee utilizar uno de los muchos proveedores de registros de terceros. En este tema, aprenderá cómo implementar fácilmente el registro de archivos Serilog en su aplicación. Sin embargo, puede utilizar fácilmente otros métodos o proveedores de registro como NLog o Loggr.

La primera parte de la importación de un proveedor externo es instalar el paquete NuGet relevante. Por ejemplo, si desea utilizar Serilog, deberá instalar el paquete Serilog.Extensions.Logging.File. Esto le permitirá utilizar una nueva extensión de proveedor denominada AddFile en el parámetro ILoggingBuilder del método ConfigureLogging. El método AddFile requiere una ruta de archivo donde se guarda el archivo de registro. Simplemente proporcione una ruta válida y la aplicación escribirá todos los registros en este archivo.

El siguiente código es un ejemplo de cómo agregar un proveedor externo:

Third-Party Provider

<pre> public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    WebHost.CreateDefaultBuilder(args)
        .ConfigureAppConfiguration((hostingContext, config) =>
        {
            var env = hostingContext.HostingEnvironment;
            config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        })
        .ConfigureLogging((hostingContext, logging) =>
        {
            logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
            logging.AddFile("myLog.txt");
        })
        .UseStartup<Startup>();
</code> </pre>

En esta demostración, verá cómo usar el registro en una aplicación ASP.NET Core. Los mensajes de registro ayudarán a investigar los problemas que ocurren en la aplicación.
