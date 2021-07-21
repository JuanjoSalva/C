Vamos a poder convertir json a xmal y éste dice a Autorest como debe generar el código c#

y así poder llamar a las Web Api



Comprobamos que funciona nuestro web api

![web_api_funciona](web_api_funciona.PNG)



Creamos el json:

![creamos el json](creamos el json.PNG)



A partir de ese webapi.json creamos el xmal

![creamos el xmal](creamos el xmal.PNG)

Copiamos en el xmal generado en el directorio Autorest.Sdk

![copiamoselxmal](copiamoselxmal.PNG)



Comando para geneal el CSharp a partir del xmal

![generandocsharp](generandocsharp.PNG)



Se ha generado el Csharp:

![generado_csharp](generado_csharp.PNG)



Se llama al recurso Get:

![recursoGet](recursoGet.PNG)



Que es lo mismo que por web:

![GetWeb](GetWeb.PNG)


El proyecto resultante se encuentra en la carpeta AutoRest.Sdk
