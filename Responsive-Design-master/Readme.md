### Responsive Design



Hacemos un grid responsive. POdemos cambiar de tamaño y sigue con la misma estructura



**index**

![index](img/index.PNG)



**lo hacemos pequeño**

![pequeño](img/pequeño.PNG)



**lo hacemos más pequeño**

![pequeño1](img/pequeño1.PNG)


En esta demostración, aprenderá a usar el sistema de cuadrícula Bootstrap en una aplicación web ASP.NET Core

CSS flexbox es un módulo agregado a CSS y es compatible con todos los navegadores modernos. Proporciona una forma eficaz de diseñar y alinear elementos dentro de un contenedor principal específico. El sistema de cuadrícula Bootstrap, que se presentó anteriormente en esta lección, se basa en CSS flexbox.

Contenedor principal

El contenedor principal en el contexto del módulo flexbox es un elemento HTML que tiene otros elementos HTML dentro y tiene la propiedad display: flex aplicada. Una de las ideas principales de flexbox es que el contenedor principal puede alterar el ancho, la altura y el orden de los elementos secundarios para llenar el espacio disponible dentro de él de diversas maneras.

Las propiedades del contenedor principal son:

- flex-direction: row | row-reverse | column | column-reverse;

Define la dirección en la que fluyen los hijos del contenedor.

- flex-wrap: nowrap | wrap | wrap-reverse;

Los elementos de Flexbox siempre intentarán caber en una fila o columna. Puede cambiar este comportamiento y permitir que los elementos se ajusten a la segunda línea o columna cuando finalice el espacio disponible utilizando flexbox-wrap.

- justify-content: flex-start | flex-end | center | space-between | space-around | space-evenly;

Define cómo se alinean los elementos en el eje principal.

- align-items: flex-start | flex-end | center | baseline | stretch;

Define cómo se colocan los elementos en el eje transversal de la línea de base.

- align-content: flex-start | flex-end | center | space-between | space-around | stretch;

Similar al justify-content pero en el eje transversal. Permite alinear elementos dentro de un contenedor flexible cuando hay espacio adicional en el eje transversal.
