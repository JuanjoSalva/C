###Implementing an Exception Handling Strategy

Es probable que ocurran eventos inesperados de vez en cuando en cualquier sistema complejo, incluidas las aplicaciones web MVC. Ocasionalmente, estos eventos inesperados en tiempo de ejecución provocan un error. Cuando esto sucede, ASP.NET Core o .NET Framework genera una excepción, que es un objeto que puede usar para diagnosticar y resolver el error. La excepción contiene información que puede utilizar para diagnosticar el problema. Las excepciones que no se manejan en su código harán que la aplicación web se detenga y se muestre un mensaje de error al usuario. Como desarrollador web, necesita saber cómo detectar, manejar y generar excepciones e identificar la causa del problema. Visual Studio proporciona una amplia gama de herramientas para depurar excepciones y mejorar la solidez de su código


En esta demostración, verá cómo buscar y resolver excepciones que se generan en una aplicación ASP.NET Core. Durante la investigación de las excepciones, el entorno cambiará de Producción a Desarrollo. Una vez corregidos los errores, el entorno cambiará de Desarrollo a Producción.

**Excepciones no controladas**
Cuando una aplicación no maneja explícitamente una excepción, la aplicación se detiene y el usuario ve un mensaje de error. En las aplicaciones ASP.NET Core MVC, este mensaje de error tiene el formato de una página web. Puede anular las páginas de error predeterminadas de ASP.NET Core para mostrar su propia información de error a los usuarios.

Si surge una excepción no controlada mientras depura la aplicación en Visual Studio, la ejecución se interrumpe en la línea que generó la excepción. Puede utilizar las herramientas de depuración de Visual Studio para investigar qué salió mal, aislar el problema y depurar su código.

A veces, es posible que también desee generar sus propias excepciones para alertar a los componentes de que algo salió mal en su aplicación. Por ejemplo, considere una aplicación que calcula precios de productos después de agregar impuestos. En el modelo de Producto, implementa un método GetPriceWithTax que agrega un porcentaje de impuestos al precio base de un producto. Si el porcentaje de impuestos es un número negativo, es posible que desee plantear una excepción. Este enfoque habilita el código en el controlador que llama al método GetPriceWithTax, para manejar el evento de que se usó un porcentaje de impuestos negativo. Puede usar la palabra clave throw para generar errores en el código C #.

**Detectar errores con bloques Try / Catch**
La forma más común de detectar una excepción, que funciona en cualquier código de Microsoft .NET Framework, es usar el bloque try / catch. Se ejecuta el código en el bloque try. Si algo de ese código genera una excepción, el tipo de excepción se compara con el tipo declarado en el bloque catch. Si el tipo coincide o es de un tipo derivado del tipo declarado en el bloque catch, se ejecuta el código del bloque catch. Puede usar el código en el bloque de captura para obtener información sobre lo que salió mal y resolver la condición de error.

El siguiente ejemplo de código muestra un bloque try / catch que detecta una ArgumentNullException:

Un bloque sencillo de intento / captura:

<pre> <code>
try
{
   Product product = FindProductFromComment(comment);
}
catch (ArgumentNullException ex)
{
   // Handle the exception
}
</code> </pre>


**Crear tipos de excepciones personalizados**

Si bien hay muchos tipos de excepciones integradas en el sistema, a veces es posible que deba generar una excepción que no se ajuste a ninguna de las estándar. Para ello, puede crear una clase de excepción personalizada. Esto puede permitirle crear excepciones que tengan sentido para su aplicación.

Para crear una excepción personalizada, deberá crear una nueva clase que herede de la clase Exception o cualquier otra clase que derive de Exception. Hacer esto le permitirá usar la clase para lanzar excepciones, permitiendo un manejo de excepciones más específico en su aplicación.

El siguiente código es un ejemplo de una clase de excepción personalizada:

Clase de excepción personalizada
<pre> <code>
public class InvalidTaxException : Exception
{
}
</code> </pre>


El siguiente código es un ejemplo de un método que lanza una excepción personalizada:

**Lanzar excepción personalizada**

<pre> <code>
public float GetPriceWithTax(float taxPercent)
{
    if (taxPercent < 0)
    {
        throw new InvalidTaxException();
    }
    return BasePrice + (BasePrice * (taxPercent / 100));
}
</code> </pre>

El siguiente código es un ejemplo de cómo detectar una excepción personalizada:

**Detectar una excepción personalizada**
<pre> <code>
try
{
    float price = product.GetPriceWithTax(-20);
}
catch (InvalidTaxException ex)
{
    return Content("Tax cannot be negative");
}
</code> </pre>

En ASP.NET Core, la variable de entorno **ASPNETCORE_ENVIRONMENT** debe usarse para determinar el entorno de la aplicación para todas las aplicaciones ASP.NET Core. Si no se establece, el valor predeterminado de la variable de entorno **ASPNETCORE_ENVIRONMENT** es Producción. Esto asegura que cualquier aplicación que se ejecute en un entorno sin la especificación siempre se ejecutará en modo de producción. Puede, en cualquier momento, agregarlo a su entorno y darle otros valores. De forma predeterminada, Desarrollo, Puesta en escena y Producción son valores de uso común. Sin embargo, también puede agregar cualquier valor de cadena posible que desee, ya que es posible que desee un entorno específico para pruebas unitarias, múltiples entornos de producción, etc


En una aplicación ASP.NET Core, particularmente al declarar **middleware**, es posible usar el entorno de ejecución actual para tomar decisiones que afecten el comportamiento de su aplicación. Un uso muy común es el manejo de excepciones. Mientras ejecuta una aplicación en modo de desarrollo, a menudo querrá que las páginas de error contengan seguimientos de pila detallados con tanta información como sea posible sobre la excepción que ocurrió. Sin embargo, al hacerlo en un entorno de producción, los clientes recibirán páginas completas llenas de detalles de errores que no significan nada y no son deseables para la mayoría de los usuarios. Estas páginas contienen información que no debe exponer a usuarios malintencionados para que puedan explotarla.

Para resolver esto, puede utilizar el servicio **IHostingEnvironment**. Este servicio se inyecta con frecuencia en el método Configure de la clase Startup. La interfaz **IHostingEnvironment** expone métodos útiles en forma de **IsDevelopment**, **IsStaging**, **IsProduction** e **IsEnvironment** (* Environment Name *). Puede utilizar estos métodos para determinar el entorno que se está ejecutando actualmente.

El siguiente código es un ejemplo del uso del servicio IHostingEnvironment:

**so del servicio IHostingEnvironment**

<pre> <code>
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else if (env.IsStaging() || env.IsProduction() || env.IsEnvironment("ExternalProduction"))
    {
        app.UseExceptionHandler("/error");
    }
 
    app.UseMvcWithDefaultRoute();
 
    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("…");
    });
}
</code> </pre>


**Métodos de clase de Startup para un entorno específico**

También es posible crear métodos Configure y ConfigureServices específicos para un entorno específico. Esto se puede hacer agregando el nombre del entorno al final del nombre del método. Es importante tener en cuenta que usar esto anulará el comportamiento predeterminado Configure o ConfigureServices. Por lo tanto, debe evitar depender de esto con demasiada frecuencia. Como ejemplo de un buen caso de uso, si desea probar middleware específico durante el desarrollo, estos métodos le permitirán ejecutar ese middleware y concentrarse en la depuración sin posiblemente romper los entornos de producción.

El siguiente código es un ejemplo de un método Configure específico del entorno:

**Método de configuración específico del entorno**

<pre> <code>
public void ConfigureExternalProduction(IApplicationBuilder app, IHostingEnvironment env)
{
    app.UseMvcWithDefaultRoute();
 
    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Welcome to external production");
    });
}
</code> </pre>



**Usar entornos en vistas**

Otra ubicación en la que puede resultar útil diferenciar entre entornos pueden ser las vistas interiores, sobre todo al configurar la aplicación. A menudo, querrá usar versiones sin comprimir de archivos JavaScript y CSS mientras se ejecuta en un entorno de desarrollo, en comparación con un entorno de producción en el que querrá usar archivos empaquetados y minificados. Para lograr esto, puede utilizar el asistente de etiquetas de entorno. El asistente de etiquetas de entorno le permite utilizar una etiqueta de entorno y, al establecer la propiedad de inclusión o exclusión en ella, puede especificar en qué entornos se ejecutará el código. Esto es particularmente útil para cargar scripts y archivos CSS.

El siguiente código es un ejemplo del uso del asistente de etiquetas de entorno:

Asistente de etiquetas de entorno
<pre> <code>
<!DOCTYPE html>
<html>
<head>
    <environment include="Development">
        <link rel="stylesheet" href="~/Styles/bootstrap.css" />
    </environment>
    <environment exclude="Development">
        <link rel="stylesheet" href="~/Styles/vendor-min.css" />
    </environment>
</head>
<body>
    <div class="container body-content">
        @RenderBody()
    </div>
    <environment include="Development">
        <script src="~/Scripts/jquery.js"></script>
        <script src="~/Scripts/popper.js"></script>
        <script src="~/Scripts/bootstrap.js"></script>
    </environment>
    <environment include="Production,Staging">
        <script src="~/Scripts/vendor.min.js"></script>
    </environment>
</body>
</html>
</code> </pre>

**Uso de entornos en archivos de configuración**

Hay muchos lugares adicionales en la aplicación, en los que diferenciar entornos es simple y útil. Un ejemplo común es el archivo appsettings.json. Con el siguiente esquema de nomenclatura de archivos, appsettings. * EnvironmentName * .json, puede crear configuraciones específicas del entorno. Usar esto para admitir múltiples cadenas de conexión separadas es particularmente útil porque una base de datos de producción generalmente tendrá bases de datos separadas. Un archivo appsettings.json para un entorno específico siempre tendrá prioridad sobre el archivo appsettings.json general.

