## Using Task Runners


En esta demostración, aprenderá cómo configurar un ejecutor de tareas básico utilizando gulp para compilar un archivo Sass en un archivo CSS.

Uno de los usos más frecuentes de los corredores de tareas es realizar agrupaciones y minificaciones para el lado del cliente. En este tema, aprenderá cómo puede realizar la agrupación y la minificación mediante gulp y Visual Studio Task Runner Explorer.

Una gran ventaja de la agrupación y la minificación es que al reducir la cantidad de archivos (agrupación), es posible garantizar que se realicen menos solicitudes de archivos al servidor y al reducir el tamaño de los archivos (minificación), las solicitudes al servidor se producen más rápido. . Ambos ayudan a que las aplicaciones web se vuelvan dinámicas y receptivas, lo que reduce la posibilidad de que un usuario se sienta frustrado por la aplicación por ser “lenta”.

Para realizar la agrupación y la minificación, se pueden agregar los siguientes complementos de gulp:

- gulp-concat. Se utiliza para combinar varios archivos realizando una operación de agrupación.

- gulp-cssmin. Minifica los archivos CSS.

- tragar-uglificar. Minifica los archivos JavaScript.

Para agregar estos complementos de gulp a una aplicación web, puede agregarlos a la sección devDependencies del archivo de configuración de npm, package.json.

El siguiente código demuestra cómo agregar complementos de gulp al archivo package.json:

Agregar complementos de gulp a package.json:
<pre> <code>
{
  "version": "1.0.0",
  "name": "asp.net",
  "private": true,
  "dependencies": {
    "bootstrap": "4.1.3",
    "jquery": "3.3.1",
    "popper.js": "1.14.3"
  },
  "devDependencies": {
    "gulp": "3.9.1",
    "gulp-sass": "4.0.1",
    "gulp-concat": "2.6.1",
    "gulp-cssmin": "0.2.0",
    "gulp-uglify": "3.0.1"
  }
}
</code> </pre>


Al usar estos complementos, podrá realizar agrupaciones y minificaciones. A lo largo de este tema, verá varias tareas separadas de minificación y agrupación y aprenderá posibilidades adicionales para trabajar con gulp.

El siguiente ejemplo de código demuestra cómo minificar un archivo CSS que se encuentra en la carpeta node_modules y agregar el resultado a la carpeta wwwroot:

Un ejemplo de minificación de archivos CSS

<pre> <code>
var gulp = require('gulp');
var concat = require("gulp-concat");
var cssmin = require("gulp-cssmin");
 
var paths = {
    webroot: "./wwwroot/",
    nodeModules: "./node_modules/"
};
 
paths.bootstrapCss = paths.nodeModules + "bootstrap/dist/css/bootstrap.css";
paths.vendorCssFileName = "vendor.min.css";
paths.destinationCssFolder = paths.webroot + "styles/";
 
gulp.task("minify-vendor-css", function() {
    return gulp.src(paths.bootstrapCss)
        .pipe(concat(paths.vendorCssFileName))
        .pipe(cssmin())
        .pipe(gulp.dest(paths.destinationCssFolder));
});
</code> </pre>


En este ejemplo, el archivo bootstrap.css se lee de la carpeta node_modules y se guarda como vendor.min.css llamando a la función concat. Luego, el contenido CSS dentro de él se minimiza llamando a la función cssmin. Finalmente, el archivo se escribe en la carpeta de estilos de la carpeta wwwroot. En este punto, el archivo se puede vincular fácilmente desde un diseño o una vista. Una gran ventaja de este enfoque es que si se agregan nuevas bibliotecas CSS, se pueden agregar fácilmente al archivo gulpfile.js sin afectar al cliente.

El siguiente código es un ejemplo de compilación, agrupación y minificación de archivos Sass:

Preprocesamiento Sass

<pre> <code>
var gulp = require('gulp');
var concat = require("gulp-concat");
var cssmin = require("gulp-cssmin");
var sass = require('gulp-sass');
 
var paths = {
    webroot: "./wwwroot/",
    nodeModules: "./node_modules/"
};
 
paths.sassFiles = "./Styles/*.scss";
paths.compiledCssFileName = "style.min.css";
paths.destinationCssFolder = paths.webroot + "styles/";
 
gulp.task("minify-sass", function() {
    return gulp.src(paths.sassFiles)
        .pipe(sass().on('error', sass.logError))
        .pipe(concat(paths.compiledCssFileName))
        .pipe(cssmin())
        .pipe(gulp.dest(paths.destinationCssFolder));
});
</code> </pre>


En este ejemplo de código, se leen todos los archivos .scss dentro de la carpeta de estilos de la aplicación. A continuación, todos los archivos .scss se compilan en archivos CSS normales. Luego, los archivos CSS se combinan en un solo archivo llamado style.min.css. Luego, el archivo CSS combinado se minimiza. Finalmente, el archivo se escribe en la carpeta de estilos de la carpeta wwwroot. En este punto, puede vincular este archivo al diseño o una vista y será completamente utilizable.

El siguiente código es un ejemplo de cómo agrupar y minimizar varios archivos JavaScript del lado del cliente:

Agrupación y minificación de JavaScript
<pre> <code>
</code> 
var gulp = require('gulp');
var concat = require("gulp-concat");
var uglify = require("gulp-uglify");
 
var paths = {
    webroot: "./wwwroot/",
    nodeModules: "./node_modules/"
};
 
paths.bootstrapjs = paths.nodeModules + "bootstrap/dist/js/bootstrap.js";
paths.jqueryjs = paths.nodeModules + "jquery/dist/jquery.js";
paths.vendorJsFiles = [paths.bootstrapjs, paths.jqueryjs];
paths.vendorJsFileName = "vendor.min.js";
paths.destinationJsFolder = paths.webroot + "scripts/";
 
gulp.task("minify-vendor-js", function() {
    return gulp.src(paths.vendorJsFiles)
        .pipe(concat(paths.vendorJsFileName))
        .pipe(uglify())
        .pipe(gulp.dest(paths.destinationJsFolder));
});
</pre>


Este ejemplo de código demuestra cómo servir Bootstrap y jQuery en un solo archivo JavaScript minificado. Esta tarea comienza leyendo bootstrap.js y jquery.js usando una matriz de rutas de archivo. La tarea luego fusiona ambos archivos con el nombre de archivo vendor.min.js, y luego minimiza el archivo resultante llamando a la función uglify. Finalmente, el archivo se escribe en scripts / vendor.min.js. En el futuro, si surgiera la necesidad de agregar más archivos JavaScript, se pueden agregar a gulpfile.js sin necesidad de actualizar el diseño o una vista.
