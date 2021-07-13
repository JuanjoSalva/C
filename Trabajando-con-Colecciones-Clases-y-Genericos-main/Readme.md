## Clases en Coleciones Genericas 

Todos los ficheros tienen el using, para utilizar directamente WriteLine, en cambio de Console.WriteLine
```
using static System.Console;
```

### Usando Colecciones de Genéricos

Definiciones en Program.cs

```
 var myList = new List<Car>
 {
    car1,
    car2
 };
```

```
var myDictionary = new Dictionary<string, Car>
{
    { car1.VIN, car1 },
    { car2.VIN, car2 }
};
```

### Usando Colecciones de genéricos Configuradas por el usuario

```
GenericList<Employee> empleadoList = new GenericList<Employee>();
``` 

### Usando métodos genéricos

```
Animal vacaGenerica = new Animal(); //("No Country");
```
```
Animal.Save<Animal>(vacaGenerica);
```
### USando Coleciones de genéricos implementando la interface IEnumerable

```
GenericList<EmployeeOfYear> empleadoList = new GenericList<EmployeeOfYear>();
```
```
empleadoList.AddHead(new EmployeeOfYear("Carlos", 25));
```
```
foreach (var empleado in empleadoList)
{
    WriteLine($"{empleado.Name}, {empleado.ID}");
}
```

### Diccionario de Genéricos

Contenido en el fichero DictionaryGenerics

```
var coffeeCodes = new Dictionary<String, String>();
```
```
// Add some entries to the dictionary.
coffeeCodes.Add("CAL", "Café Au Lait");
coffeeCodes.Add("CSM", "Cinammon Spice Mocha");
```
```
WriteLine("Muestra solo Romano y Mocha del diccionario");
var resultado = from string coffee in coffeeCodes.Keys
                where coffeeCodes[coffee].Contains("Mocha") || coffeeCodes[coffee].Contains("Romano")
                select coffee;
foreach (var coffee in resultado)
{
    WriteLine($"Key:{coffee},Value:{coffeeCodes[coffee]}");
}
```
```
WriteLine("Muestra solo Romano y Mocha del diccionario, utilizando dynamic");
var resultado2 = from dynamic coffee in coffeeCodes
                where coffee.Value.Contains("Mocha") || coffee.Value.Contains("Romano")
                select coffee;
foreach (var coffee in resultado2)
{
    WriteLine($"Key:{coffee.Key},Value:{coffee.Value}");
}
```

### Implementando Listas Generícas definidas por el usuario

Definida en el fichero GenericList.cs

Restricciones de tipos en la clase
```
public class GenericList<T> where T : IEmployee
```
```
public IEnumerator<T> GetEnumerator()
```
#### Define la clase Employee a partir de la implementación de la interface IEmployee

```
public class Employee : IEmployee, IComparable
```

#### Define la interface IEnumerable<string>
```
public class EmployeeOfYear : IEmployee, IEnumerable<string>
```
#### Implementa la interface IEnumerator<string> en la clase EmployeeEnumerator
```
public class EmployeeEnumerator : IEnumerator<string>
```
### Explicación Pregunta 11 Batería de preguntas

Contenido en el fichero MetodosGenéricos.cs

Restricciones de tipo en métodos genéricos
```
public static void Save<T>(T target) where T : Animal, new()
```

### Implementación de Listas genéricas enlazadas

Definición en el fichero LinkedListT.cs

```
// Create the link list.
string[] words =
    { "the", "fox", "jumps", "over", "the", "dog" };
LinkedList<string> sentence = new LinkedList<string>(words);
```
### Usando Listas generícas de System.Collection.Generic

List<T>

Definición en fichero ListT.cs

```
List<string> coffeeBeverages = new List<string>{"Latte","Espresso","Americano","Cappuccino","Mocha"};
```
```
coffeeBeverages.Sort();
```
```
foreach (String coffeeBeverage in coffeeBeverages)
{
    WriteLine(coffeeBeverage);
}
```
### Implementando Colas genéricas con Queue<>

Definción en fichero QueueT.cs
```
Queue<string> numbers = new Queue<string>();
numbers.Enqueue("one");
numbers.Enqueue("two");
numbers.Enqueue("three");
numbers.Enqueue("four");
numbers.Enqueue("five");
```
```
WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
```
### Ejemplo de Yield
Definición de Yield en el fichero YieldUnderstanding.cs
```
public IEnumerable<int> Integers()
{
    yield return 1;
    yield return 2;
    yield return 4;
    yield return 8;
    yield return 16;
    yield return 16777216;
}
```
