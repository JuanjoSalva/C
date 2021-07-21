DEMO3_L4



Accedemos a un recurso del web api que devuelve lso aerpuertos

![todos](todos.PNG)

Hacemos un nuevo recurso que, pasado un id a la llamada, nos devuelve ese aeropuerto cuyo id corresponde con el pasado.

![uno](uno.PNG)



Ponemos un id inexistente y vemos el error

![error](error.PNG)

Este error lo hemos provocado nosotros por código al no encontrar el elemento:

<pre><code>
 if (result == null)
                return NotFound();
            return result;
</code></pre>
