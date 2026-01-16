/*
                                         ▀                                                                    
██     ██ █████▄ █████▄  ██████ █████▄  ██ ▄████▄   ████▄  ██████   ▄█████ ██     ▄████▄ ▄█████ ██████ ▄█████ 
██     ██ ██▄▄██ ██▄▄██▄ ██▄▄   ██▄▄██▄ ██ ██▄▄██   ██  ██ ██▄▄     ██     ██     ██▄▄██ ▀▀▀▄▄▄ ██▄▄   ▀▀▀▄▄▄ 
██████ ██ ██▄▄█▀ ██   ██ ██▄▄▄▄ ██   ██ ██ ██  ██   ████▀  ██▄▄▄▄   ▀█████ ██████ ██  ██ █████▀ ██▄▄▄▄ █████▀                                            
                                             
████▄  ▄████▄ ██████   ███  ██ ██████ ██████ 
██  ██ ██  ██   ██     ██ ▀▄██ ██▄▄     ██   
████▀  ▀████▀   ██     ██   ██ ██▄▄▄▄   ██   

¿QUÉ ES LA BIBLIOTECA DE CLASES .NET?
Es una colección de clases, interfaces y otros tipos que proporcionan funcionalidades (métodos)
reutilizables para desarrollar aplicaciones en la plataforma .NET. 

¿QUÉ ES UNA CLASE?
Una clase es una plantilla o un plano que define las propiedades (atributos) y comportamientos (métodos)
de un objeto en la programación orientada a objetos.

Define dos cosas principales:
Estado (Datos): Campos y Propiedades.
Comportamiento (Lógica): Métodos.

¿QUÉ ES UN OBJETO?
Un objeto es una instancia de una clase que encapsula datos y comportamientos relacionados.  */


//Definición de la CLASE (El plano)
public class Coche
{
    // Estado (Propiedades)
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int VelocidadActual { get; set; }
    // Comportamiento (Método)
    public void Acelerar()
    {
        VelocidadActual += 10;
        Console.WriteLine($"El coche {Marca} ahora va a {VelocidadActual} km/h.");
    }
}
// Uso en el programa principal
class Program
{
    static void Main()
    {
        // Creación del OBJETO (Instancia)
        // 'miCoche' es el objeto. 'Coche' es el tipo/clase.
        Coche miCoche = new Coche();
        miCoche.Marca = "Toyota";
        miCoche.Acelerar(); // El objeto realiza una acción
    }
}

/*
---------------------------------------------------------------------------------------
MODIFICADORES DE ACCESO:
- public: Accesible desde cualquier parte del programa.
- private: Accesible solo dentro de la clase. 
- protected: Accesible dentro de la clase y sus subclases.

---------------------------------------------------------------------------------------
CONSTRUCTORES:
- Un constructor es un método especial que se llama automáticamente cuando se crea una instancia de una clase.
- Se utiliza para inicializar los atributos del objeto.
- Tiene el mismo nombre que la clase y no tiene tipo de retorno.
- Cuando no se define un constructor, el compilador proporciona uno por defecto sin parámetros.
- Se pueden definir múltiples constructores con diferentes parámetros (sobrecarga de constructores).
- Cuando se define un constructor personalizado, el constructor por defecto ya no está disponible a menos que se defina explícitamente.
*/

public class Persona
{
    public string Nombre;
    // Constructor: Tiene el mismo nombre que la clase y NO tiene tipo de retorno
    public Persona(string nombreInicial)
    {
        Nombre = nombreInicial;
    }
}

public class ProgramaConstructor
{
    static void Main()
    {
        Persona p = new Persona("Ana"); // Aquí se llama al constructor
    }
}


/*
             ▄                                     
            ▀                                      
██▄  ▄██ ██████ ██████ ▄████▄ ████▄  ▄████▄ ▄█████ 
██ ▀▀ ██ ██▄▄     ██   ██  ██ ██  ██ ██  ██ ▀▀▀▄▄▄ 
██    ██ ██▄▄▄▄   ██   ▀████▀ ████▀  ▀████▀ █████▀ 
                                                   
Los métodos son bloques de código dentro de una clase que realizan tareas específicas.

PARTES DE UN MÉTODO:
Modificador: Define la visibilidad (public, private, protected).
TipoRetorno: El tipo de dato que el método devuelve (int, void, string, etc.).
NombreMetodo: El nombre del método (debe ser descriptivo).
Parámetros: Valores que el método puede recibir para realizar su tarea.


Ejemplo:
*/

public class Calculadora
{
    /* Método que suma dos números
    [Modificador][TipoRetorno][NombreMetodo] ([Parámetros]) */
    public int Sumar(int a, int b)
    {
        return a + b; // Cuerpo del método
    }

}

/* --------------------------------------------------------------------------------------
MÉTODOS ESTÁTICOS VS. MÉTODOS DE INSTANCIA

MÉTODOS ESTÁTICOS:
- Pertenecen a la clase en sí.
- Se llaman usando el nombre de la clase.
- No requieren una instancia de la clase.
Ejemplo:
*/
public class Utilidades
{
    public static int Multiplicar(int x, int y)
    {
        return x * y;
    }
}
// Uso del método estático
class ProgramaEstático
{
    static void Main()
    {
        int resultado = Utilidades.Multiplicar(3, 4); //No requiere instancia de Utilidades, se llama directamente a la clase
        Console.WriteLine($"Resultado de la multiplicación: {resultado}");
    }
}
//Nota: El método Main también es estático porque es el punto de entrada del programa.


/*MÉTODOS DE INSTANCIA:
Requieren una instancia de la clase para ser llamados.
Pertenecen a un objeto específico.
También se conocen como métodos de estado porque necesitan acceder y modificar el estado del objeto (sus variables).

Ejemplo:
*/

public class Persona1
{
    public string Nombre { get; set; }
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}.");
    }
}
// Uso del método de instancia
class ProgramaInstancia
{
    static void Main()
    {
        Persona1 persona = new Persona1(); // Se crea una instancia de Persona
        persona.Nombre = "Ana";
        persona.Saludar(); // Llama al método a travpes de la instancia
    }
}

/*--------------------------------------------------------------------------------------

TIPOS DE MÉTODOS:

MÉTODOS CON RETORNO:
- Devuelven un valor al código que los llamó.
- Utilizan la palabra clave 'return' para devolver el valor.
- Se debe crear una variable para capturar el valor retornado.
*/

public class CalculadoraConRetorno
{
    public double Restar()
    {
        Console.WriteLine("Ingrese el primer número");
        double a = double.TryParse(Console.ReadLine(), out a) ? a : 0;
        Console.WriteLine("Ingrese el segundo número");
        double b = double.TryParse(Console.ReadLine(), out b) ? b : 0;
        return a - b; // Devuelve la resta de a y b
    }
}

// Uso del método con retorno
class ProgramaConRetorno
{
    static void Main()
    {
        CalculadoraConRetorno calc = new CalculadoraConRetorno();
        double resultado = calc.Restar(); // Captura el valor retornado
        Console.WriteLine($"Resultado de la resta: {resultado}");
    }
}

/*MÉTODOS SIN RETORNO (VOID):
- No devuelven ningún valor.
- Utilizan la palabra clave 'void' en la declaración del método.
- Realizan acciones pero no proporcionan un valor de vuelta específico.
*/

public class CalculadoraSinRetorno
{
    public void restarSinRetorno()
    {
        Console.WriteLine("Ingrese el primer número");
        double n1 = double.TryParse(Console.ReadLine(), out n1) ? n1 : 0;
        Console.WriteLine("Ingrese el segundo número");
        double n2 = double.TryParse(Console.ReadLine(), out n2) ? n2 : 0;
        Console.WriteLine("El resultado de la resta es: " + (n1 - n2));
    }
}

// Uso del método sin retorno
class ProgramaSinRetorno
{
    static void Main()
    {
        CalculadoraSinRetorno calc = new CalculadoraSinRetorno();
        calc.restarSinRetorno(); // No captura ningún valor, solo realiza la acción
    }
}

/*MÉTODOS CON PARÁMETROS:
- Permiten pasar datos al método para que los utilice en su lógica.
- Los parámetros se definen en la declaración del método.
- Pueden tener múltiples parámetros separados por comas.
*/

public class CalculadoraConParametros
{
    public int SumarConParametros(int a, int b)
    {
        return a + b; // Utiliza los parámetros a y b
    }
}
// Uso del método con parámetros
class ProgramaConParametros
{
    static void Main()
    {
        CalculadoraConParametros calc = new CalculadoraConParametros();
        int resultado = calc.SumarConParametros(5, 7); // Pasamos valores a los parámetros (argumentos)
        Console.WriteLine($"Resultado de la suma con parámetros: {resultado}");
    }
}

/*MÉTODOS SIN PARÁMETROS:
- No requieren datos de entrada para ejecutarse.
- Se declaran sin parámetros en la definición del método.
*/
public class CalculadoraSinParametros
{
    public int SumarSinParametros()
    {
        Console.WriteLine("Ingrese el primer número");
        int n1 = int.TryParse(Console.ReadLine(), out n1) ? n1 : 0;
        Console.WriteLine("Ingrese el segundo número");
        int n2 = int.TryParse(Console.ReadLine(), out n2) ? n2 : 0;
        return n1 + n2; 
    }
}
// Uso del método sin parámetros
class ProgramaSinParametros
{
    static void Main()
    {
        CalculadoraSinParametros calc = new CalculadoraSinParametros();
        int resultado = calc.SumarSinParametros(); // No pasamos ningún valor (no hay argumentos)
        Console.WriteLine($"Resultado de la suma sin parámetros: {resultado}");
    }
}

/*--------------------------------------------------------------------------------------
DIFERENCIA ENTRE PARÁMETROS Y ARGUMENTOS:

PARÁMETROS:
- Son variables definidas en la declaración del método.
- Actúan como marcadores de posición para los valores que se pasarán al método.
- Definen qué tipo de datos espera el método recibir.

ARGUMENTOS:
- Son los valores reales que se pasan al método cuando se llama.
- Se proporcionan en la llamada al método.
- Deben coincidir en tipo y orden con los parámetros definidos.

------------------------------------------------------------------------------------------
MÉTODOS SOBRECARGADOS (OVERLOADING):
La sobrecarga permite tener múltiples métodos con el mismo nombre dentro de la misma
clase, siempre y cuando sus firmas sean diferentes.

¿Qué define la firma de un método para la sobrecarga?
1. El nombre del método.
2. El tipo de los parámetros.
3. El orden de los parámetros.
4. La cantidad de parámetros.

Nota: El tipo de retorno NO es parte de la firma para efectos de sobrecarga. No puedes tener
dos métodos iguales que solo varíen en que uno devuelve int y el otro void.
*/

public class ProcesadorPagos
{
    // Versión 1: Pago en efectivo (solo monto)
    public void Pagar(decimal monto)
    {
        Console.WriteLine($"Pagado {monto} en efectivo.");
    }
    // Versión 2: Pago con tarjeta (monto + número de tarjeta)
    public void Pagar(decimal monto, string numeroTarjeta)
    {
        Console.WriteLine($"Pagado {monto} con tarjeta {numeroTarjeta}.");
    }
    // Versión 3: Pago con puntos (cantidad de puntos - tipo int)
    public void Pagar(int puntos)
    {
        Console.WriteLine($"Pagado con {puntos} puntos.");
    }
}

// Uso de métodos sobrecargados
class ProgramaSobrecarga
{
    static void Main()
    {
        ProcesadorPagos procesador = new ProcesadorPagos();
        procesador.Pagar(100.50m); // Llama a la versión 1
        procesador.Pagar(200.75m, "1234-5678-9012-3456"); // Llama a la versión 2
        procesador.Pagar(1500); // Llama a la versión 3
    }
}

