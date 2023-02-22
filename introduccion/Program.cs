using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PracticasC
{
    internal class Program
    {
        //fuera del metodo solo se pueden declarar variables con *static* recordar ejemplo de la casa, toalla, torre Eiffel
        static int numero_global;
        static void Main(string[] args)
        {
            //se puede crear regiones con #region para abrir y #endregion para cierre
            // dentro de las regiones creadas se pueden crear regiones anidadas similar a administracion e datos de .xls
            #region tipos numericos
            Console.WriteLine("Tipos numericos");
            Console.WriteLine("enteros");
            //las variables deben existir (declaradas) antes de ser utilizadas primero declaro luego uso
            //nombre de variable no puede ser numero 123
            //no puede contener espacios: el numero debe ser con barra baja 
            //el nombre de variable debe ser descriptivo que permita identificarla
            //el nombre de variable no puede iniciar con numero
            //para la separacion si no se quiere utilizar barra baja puede emplear CamelCase
            //SIEMPRE ; AL FINAL DE LA LINEA DE CODIGO
            //no se debe emplear palabras reservadas propias del sistema etc
            // REALES>ENTERO
            int el_numero = 123;
            int OtroNumero;
            OtroNumero = 321;
            el_numero = 70;

            // las constantes deben escribirse en mayusculas (acuerdo entre programadores)
            //para las variables se emplean minusculas o camelcase
            const int valor = 12;
            const int PI = 3;

            int respuesta = 4 + 4;
            respuesta = 4 / el_numero;
            Console.WriteLine(respuesta);
            respuesta = PI + OtroNumero - 3;
            respuesta = respuesta * el_numero;
            //orden de asignacion y ejecucion es de derecha a izquierda del simbolo de igualdad
            int x = 5;
            x = x + 1;

            #endregion tipos numericos

            #region Decimales

            Console.WriteLine("Decimales");
            //num = 3.1416 dara error debido a que no hay un solo tipo para expresar decimales, el otro tipo es el double y permite utilizar mas decimales
            // los float no tienen tanta precision
            // si se va autilizar float con decimales se debe añadir f al final 3.1416f y recien guardara la informacion
            // double tiene capacidad de almacenaje mas grande 
            //doble>float los dobles contienen a los flotantes flotante dentro de double

            float num;
            num = 3.1416f;

            double num2 = 3.1416;
            numero_global = 10;
            num2 = 4.5f;
            // esto seria error num=4.5; porque este es valor de double precicion porque le falta la flo trata como si fuera doble pero la variable es float, no cuadra
            // EL NUMERO = 5.8 EROR DE ORDEN DE ASIGNACION
            // para nuero reales>enteros
            num = 4;
            num2 = 8;
            Console.WriteLine("Introduzca valor numerico");
            //Console.WriteLine espera que el usuario ingrese por pantalla algun valor
            //Console.Read(); retorna valor entero y debe ponerse al lado derecho de una asignacion de vriable

            int cero = 5;
            num2 = 4 / cero;
            Console.WriteLine(num2);
            #endregion decimales

            #region tipo texto y parseo

            Console.WriteLine("Tipos Texto");
            //en el string no se puede poner directamente las palabras, debe ir encerrado en comillas dobles, aunque se pongan numeros se considera como texto
            //string txt = "Pepito es mi amigo";
            string txt = Console.ReadLine();
            Console.WriteLine(txt + 4);

            //Console.Read(); tener cuidado con esta sentencia ya que podria terminar el programa si esta en medio del codigo,
            //string txt3 = Console.ReadLine(); 
            //Console.WriteLine(txt3 + 44); 
            //el numero en esta sentencia se convierte en unio de 2 cadenas de texto concatenacion "txt3"+"4"->el string de txt3seguido del 4
            //cuando queremos convertir string a numero hablamos de parseo "parse"
            //solo cuando hhya valores numericos, si hubiera letras el parseo fallarà
            //int auxiliar = int.Parse(txt3);
            //Console.WriteLine(4 / auxiliar);
            //la variable txt nos permite guardar cualquier valor, pero si fuera unaletra el valor guardado el parseo no funcionara NO OLVIDAR ESTO

            #endregion tipo texto y parseo

            #region try
            // si se pone letras en un parseo se tendra excepciones que se pueden manejar con try catch:
            // convertir string->numeros
            // el bloque try catch permite escribir una o varias lineas de codigo para que intente ejecutar teniendose excepciones con la leyenda "formatException"
            int auxiliar = -1;

            //las variables deben tener valores asignados, de lo contrario marcaran error por ser variable vacia nula

            try
            {
                auxiliar = int.Parse(txt);
                Console.WriteLine(4 / auxiliar);
                //int[] numeros = new int[2]; es posible a;adir casos especiales
                //numeros[10] = 45;

                //lo que esta dentro del bloque try solo se utiliza dentro del bloque, cualqier llamada fuera del bloque, es decir fuera de la llave } no existe y dara excetion
                //try y catch son bloques independientes por lo que no comparten variables, si se quiere emplear variables para ambos bloques debe ir por fuera y arriba
                //se declara la variable auxiliar fuera del try catch antes del try *linea 81*
                /* es importante trar de manera adecuada las excepciones y pueden ser varias lineas de codigo*/
                /* se pude crear una try catch para cada excepcion o puede hacerse todas las excepciones en el mismo bloque debajo del try con un nuevo catch*/
                // las excepciones especificas debe ir al principio
            }
            catch (FormatException fe)

            {

                Console.WriteLine("Debe ingrear solo valores numericos por favor");
                //auxiliar = 99; // si no se quiere mostrara mensaje se puede asignar valor arbitrario, pero no es recomendable, siempre es mejor corregir al usuario

            }
            catch (DivideByZeroException dbze)

            {
                Console.WriteLine("Debe ingresar numeros diferentes a 0 (cero) ");
                // tambien se pueden usar catch generales
                try
                {
                    int nn = 0;
                    int r = 5 / nn;

                }

                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Usted no aprende cierto?");
                }
                catch (IndexOutOfRangeException ioore)
                {
                    Console.WriteLine("Esta fuera de los limites");
                }
            }

            /*
            IMPORTANTE: este catch debe ESTAR AL FINAL siempre es un catch generico, permitira manejar cualquier excepcion desconocida
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado");
                Console.WriteLine(ex.Message);//mostrara mensaje almacenado en ex |
            }
            */

            finally
            {
                Console.WriteLine("Entramos a finally");
            }
            Console.WriteLine("fin del ejemplo try catch");



            #endregion try

            #region arreglos
            Console.WriteLine("Arreglos");
            // existen diferentes arreglos el pimero UNIDIMENSIONAL del tipo 1*N los corchetes identifican al codigo como arreglo, al declarar la variable ya deve contar con un cantidad de espacios
            //es importante definir la cantidad de espacios (analogia con estante de zapatos)
            //fila * columna o columna * fila pero debe mantenerse hasta el final 
            //Inicia en 0 (cero) siempre, y el valor del indice maximo sera la N-1 donde N es la cantidad de celdas
            int[] nums = new int[4];
            nums[0] = 12;
            nums[1] = 56;
            nums[2] = 0;
            nums[3] = -23;
            //no se puede dar posiciones superiores a la posicion maxima nums['4']=54 en este ejemplo ponemos que l celda 4 tenga valos 54, pero nuestro array solo va de 0al3
            //son tratados como variables por lo que pueden sser parte de operaciones            

            num = nums[2] + 3;

            //ARREGLOS BIDIMENCIONALES like tablero de ajedrez
            string[,] matriz = new string[2, 3];//[fila,columna]
            matriz[0, 0] = "Texto";
            matriz[1, 2] = "Maximo";

            //ARREGLOS TRIIMENSIONALES "cubo de rubik"
            //se recomienda primero analizar y asignar orden, el mismo deberia mantener uniformidad
            //el orden [altura,lado,profundida]
            //otra opcion es qudarse con los valores maximos
            float[,,] cubo = new float[3, 2, 2];
            cubo[2, 1, 1] = 34.6f;

            //NDIMENSIONALES MULTIDEMNCIONALES
            //estos arreglos tridimensionales no son de uso comun
            //casos inconcebibles>

            int[,,,,,,,] octo_path_traveler = new int[3, 4, 5, 6, 7, 8, 2, 10];
            octo_path_traveler[0, 0, 0, 0, 0, 0, 0, 1] = 56;
            Console.WriteLine("El resultado es: " + (octo_path_traveler[0, 0, 0, 0, 0, 0, 0, 1] + cubo[2, 1, 1] - 1));


            //revision de caso de espacios de bits asignados para cada tipo de dato, en e, caso de que se exceda el limite permitido se devlvera el valor en negativo
            int numero_grandote = 2147483647;
            numero_grandote = numero_grandote + 1;
            Console.WriteLine(numero_grandote);

            //estos casos solo quedan como parte conceptual ya que no es ni comun ni concebible pero no imposible, l sintaxisis lo permite

            //video 20230202a

            #endregion arreglos

            #region condicionales
            Console.WriteLine("Condicionales");
            //simple IF
            //en la sentencia if marcara como error de sintaxis si se pusiera un string en la sentencia de consulta
            //se ejecuta cuando hay condicion, si es verdadero se ejecuta la accion o de lo contrario no se ejecuta
            //tipo booleano guarda valores verdadero o falso

            bool esEmpleado;//true or false
            esEmpleado = true;

            if (esEmpleado)
            {
                Console.WriteLine("Claro que es empleado hasta la pregunta ofende");
               /* int xx = 24;
                Console.WriteLine(xx / 3 * 2);*/

            }
            //Compuesta IF ELSE
            //cuando se ingres dentro de la sentencia if algun dato que nunca se ejecutara como ser: 
            //if (3 > 6)
            //esta sentencia jamas se ejecutara y C# marcara en tono mas tenue
            // tomar encuenta que las llaes se emplean para poder administrar un mejor orden, pero no es obligatorio,ya que todo el programa puede escribirse sin saltos de linea(;) 

            if (num > 2)
            {
                Console.WriteLine("numero es mayor a 2");
                /*int xx = 24;
                Console.WriteLine(xx / 3 * 2);*/
            }
            else
            {
                Console.WriteLine("no se que valor tiene pero aca te lo voy a dejar;" + num);
                /*int xx = 24;
                Console.WriteLine(xx / 3 * 2);*/
            }
            // condicional anidado, IF dentro de otro IF
            //cada IF puede tener o no su else, tener cuidado donde se escribe
            if (esEmpleado)
            {
                if (num < 10)
                {
                    Console.WriteLine("Claro que es empleado y su numero es menor a 10");
                }
                else
                {
                    Console.WriteLine("Claro que es empleado pero su numero es mayor a 10");
                    /*int xx = 24;
                    Console.WriteLine(xx / 3 * 2);*/
                }
            }
            else
            {
                Console.WriteLine("no es empleado, nada que decir al respecto");
            }

            //para caso de igualdad se emplea el doble signo de igualdad ==

            Console.WriteLine("Esto seria sobre condicionales if, if else");
            Console.WriteLine("Ahora empezamos con las condicionales compuestas");

            /* logica proposicional:
            (afirmacion simple)
            p: pepe tiene diez años 
            q: pepe estudia en la escuela de la ona
            r: num es menor a 10

            y:  p ^ q
            or: p v q
            negacion:   -p
            entones:    p=>q
            p^(pvq)

            */
            //ejemplo: para p^q con el simbolo && donde ambas expresiones deben ser verdaderas
            if (num > 2 && num2 < 80)
            {
                Console.WriteLine("numero es mayor a 2");
            }
            // ejemplo para or p||q el or es inclusivo porque ambos pueden ser ciertos o uno cierto o uno falso y solamente sera falso si ambos casos son falsos
            if (num > 2 || num2 < 80)
            {
                Console.WriteLine("numero es mayor a 2");
            }
            //ejemplo: para negacion del valor boolean con el uso del signo ! al inicio del parentesis y se negara la sentencia (!esEmpleado) en este caso la interpretacion es NO ES EMPLEADO
            //EL SIMBOLO DE NEGACION ! SOLO PUEDE ESTAR DELANTE DE VALORES BOOLEANOS para otros valores debe ir fuera del parentesis (!())

            if (!esEmpleado)//SE LEE SI NO ES EMPLEADO HACER:
            {
                Console.WriteLine("Claro que NO es empleado hasta la pregunta ofende");
            }

            //SWITCH O CASE
            // apra manejo de varias condicionales por ejemplo semanas, meses, etc
            //ejemplo de semnaa empleando IF para ver la diferencia      
            int num_dia = 10;
            if (num_dia == 1)
                Console.WriteLine("LUNES");
            else
                if (num_dia == 2)
                Console.WriteLine("MARTES");
            else
                    if (num_dia == 3)
                Console.WriteLine("MIERCOLES");
            else
                        if (num_dia == 4)
                Console.WriteLine("JUEVES");
            else
                             if (num_dia == 5)
                Console.WriteLine("VIERNES");
            else
                                if (num_dia == 6)
                Console.WriteLine("SABADO");
            else
                                    if (num_dia == 7)
                Console.WriteLine("DOMINGO");
            else Console.WriteLine("no es un numero valido para dia de semana");
            //ejemplo con switch
            switch (num_dia)
            {
                case 1: Console.WriteLine("LUNES");
                    break; case 2: Console.WriteLine("MARTES");
                    break; case 3: Console.WriteLine("MIERCOLES");
                    break; case 4: Console.WriteLine("JUEVES");
                    break; case 5: Console.WriteLine("VIERNES");
                    break; case 6: Console.WriteLine("SABADO");
                    break; case 7: Console.WriteLine("DOMINGO");
                    break;
                    default: Console.WriteLine("no es un numero valido");
                    break;
            }
            #endregion condicionales

            #region arrays
            Console.WriteLine("Iteraciones o bucles");
            Console.WriteLine("while");
            //instruccion de hacer alguna aaccion miestras se cumpla una condicion
            //ejemplo de bucle infinito
            /*int contador = 5;
            while (contador > 0)
            {
                Console.WriteLine(contador);
            }
            Console.WriteLine("Uff se termino");*/
            
            //este ejemplo nunca se va a terminar de ejecutar ya que la sentencia siempre sera verdadera entrando en un bucle infinito
            //para estos casos se debe cambiar dentro la sentencia while
            int contador = 5;
            while (contador > 0)
            {
                Console.WriteLine(contador);
                contador--;
                --contador;
            }
            
            //contador -- :primero usa y luego decrementa
            //--contador : primero decrementa y luego usa

            int c = 10;
            Console.WriteLine(c);   //10
            Console.WriteLine(c++); //10
            Console.WriteLine(c);   //11
            Console.WriteLine(++c); //12   
            Console.WriteLine(c);   //12

            int[,] mtx = new int[3, 5]; // se debe establecer una forma de llenar la matriz como dijimos lineas arriba  el orden que emplearemos es de llenado de toda la primera fila y recien pasamos a l segunda fila hasta completar las columnas y luego a la tercera y asi sucesivamente
            int fila, columna;
            fila=0; columna=0;
            while (fila <= 4)
            {
                columna = 0;
                while (columna <= 2)
                {
                    mtx[columna++, fila] = 1; //debe ser en este orden siempre, dentro del ultimo while anidado se rdena segun nuestra matriz para no excedernos la dimension de nuestra matriz, el valor maximo de nuestra matriz
                }
                fila++;
            }
            //mostrando la matriz
            Console.WriteLine("colores en todo el array");
            Console.BackgroundColor = ConsoleColor.Blue;//modifica colores de consola de toda la iteracion
            Console.ForegroundColor = ConsoleColor.Yellow;//modifica a los colores de las letras de todo el array
            fila = 0;
                while (fila <= 4)
            {
                columna = 0;
                while (columna <= 2)
                {
                    Console.Write("["+ mtx[columna++,fila]+"}");
                }
                Console.WriteLine();
                fila++;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //mostrando la matriz
            Console.WriteLine();
            Console.WriteLine("colores solo lara la matriz");
            Console.BackgroundColor = ConsoleColor.Blue;//modifica colores de consola de toda la iteracion
            Console.ForegroundColor = ConsoleColor.Yellow;//modifica a los colores de las letras de todo el array
            fila = 0;
            while (fila <= 4)
            {
                columna = 0;
                while (columna <= 2)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;//modifica colores de consola de solo el codigo si va solo antes y despues del corchete
                    Console.ForegroundColor = ConsoleColor.Yellow;//modifica a los colores de las letras de todo el array solo en la matriz
                    Console.Write("[" + mtx[columna++, fila] + "}");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
                fila++;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Ciclo FOR - una estructura de iteracion interesante");
            // tiene tres partes
            //1ra. instacia la variable, gralmente desde la letra i, j,k etc
            //2da. amplitud de la variable es decir hasta cuanto va a realizarse el ciclo
            //3ra. incremento de la variable, de 1 en 1, 2 en 2, etc.
            Console.WriteLine("ascendente");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("hola" + i);
            }
            Console.WriteLine();
            //tambie se puede ir de manera regresiva
            Console.WriteLine("descendente");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("hola" + i);
            }
            Console.WriteLine() ;
            //incrementos/decrementos diferentes a 1 en 1
            Console.WriteLine("incremento de 3 en 3");
            for (int i = 2; i <= 10; i+=3)
            {
                Console.WriteLine("hola" + i);
                
            }
            Console.WriteLine();

            //caso especial e interesante
            Console.WriteLine("caso especial con booleano");
            bool yaPaso = false;
            // es posible que exista la variable del for instanciada antes del ciclo for es decir por fuera del parentesis
            for(int i = 2;i <= 10; i += 2)
            {
                Console.WriteLine("hola" + 1);
                if (!yaPaso && i > 5)
                {
                    i = -3;
                    yaPaso = true;
                }
            }
            //Do While
            // se recomienda su uso para la validacion de contrase;as 
            Console.WriteLine();
            Console.WriteLine("do while - ejecutar antes de preguntar");
            do
            {
                Console.WriteLine("Mira que la variable tiene el valor" + fila);
            }
            while (fila <= 4);

            /*Console.WriteLine();
            Console.WriteLine("encontrar donde esta el valor 100");
            int[] arreglo = new int[4];
            arreglo[0] = arreglo[1] = arreglo[2] = arreglo[3] = 0;
            arreglo[3] = 100;

            int indices_respuesta = -1;
            for (int i=0;i<4; i++)
            {
                if (arreglo[i] == 100)
                    indices_respuesta == i;
                break;// se emplea para que no se realice mas nada con el codigo
            }
            if (indices_respuesta > -1)
                Console.WriteLine("el num 100 esta en el indice" + indices_respuesta);
            else
                Console.WriteLine("No se encontro el numero 100 en todo el arreglo") ;*/
            #endregion arrays

            #region POO
            Console.WriteLine();
            Console.WriteLine("Programacion orientada a objetos ...mejor lo vemos en otra solucion =) ");
            //ejemplo de la bicicleta, del humano
            //bicicleta = objeto
            //tareas, acciones que hace el objeto
            //cualidades = atributos caracteristicas del objeto todo lo que nos podria permitir a realizauna buena descripcion

            #endregion POO

        }

    }
}


