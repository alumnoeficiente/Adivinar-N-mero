//using System;

//public class AdivinadorConCondicionalesIfParaTenerAlMenosElSuficiente
//{
//    public static void Main(String[] args)
//    {
//        var generadorAleatorio = new Random();
//        int numeroParaAdivinar = generadorAleatorio.Next(0, 16);
//        int respuesta;
//        Console.WriteLine("Bienvenido a la última maravilla del Unreal Engine 5®: ¡Adivinar un número entre 0 y 16!");
//        Console.WriteLine("Tiene tres intentos para demostar sus capacidades adivinatorias o dejar en evidencia" +
//            " su posible falta de capacidades,\n ¡Adelante con el primer intento!");
//        respuesta = Int32.Parse(Console.ReadLine());
//        if (respuesta == numeroParaAdivinar)
//        {
//            Console.WriteLine("¡Felicidades! Hoy, estando a " + DateTime.Now + ", usted ha conseguido adivinar un número" +
//                "vanagloriate, pues tu nombre quedará grabado en los anales de la historia"); 
//        }
//        if (respuesta != numeroParaAdivinar)
//        {
//            Console.WriteLine("¡Vaya! Parece que no lo has averiguado, te quedan dos intentos más");
//            Console.WriteLine("He aquí una pequeña pista...");
//            Console.ReadLine();
//            if (respuesta < numeroParaAdivinar)
//            {
//                Console.WriteLine("El número que usted ha escrito es menor que el número que está buscando");
//                Console.WriteLine("Intente adivinar el número otra vez");
//                int respuesta2;
//                respuesta2 = Int32.Parse(Console.ReadLine());
//                if (respuesta2 == numeroParaAdivinar)
//                {
//                    Console.WriteLine("¡Nice! Solo un 35% de elegidos lo adivinan a la segunda; "
//                        + "\n desde luego usted goza de una mente privilegiada.");
//                }
//                if (respuesta2 != numeroParaAdivinar)
//                {
//                    Console.WriteLine("¡Uff! Parece que has vuelto a fallar, te queda un último intento.");
//                    Console.WriteLine("He aquí la última pista...");
//                    Console.ReadLine();
//                    if (respuesta2 < numeroParaAdivinar)
//                    {
//                        Console.WriteLine("El número que usted ha escrito es menor que el número que está buscando");
//                        Console.WriteLine("Intente adivinar el número.. una última vez");
//                        int respuesta3;
//                        respuesta3 = Int32.Parse(Console.ReadLine());
//                        if (respuesta3 == numeroParaAdivinar)
//                        {
//                            Console.WriteLine("Ha costado pero ya lo tienes ¡Felicidades!");
//                        }
//                        if (respuesta3 != numeroParaAdivinar)
//                        {
//                            Console.WriteLine("¡Vaya! Lamentablemente este juego parece demasiado complejo para usted y ha perdido" +
//                                "\n planteese dedicarse a otra cosa mas sencilla como jugar al parchis o mirar piedras");
//                        }

//                    }
//                    if (respuesta2 > numeroParaAdivinar)
//                    {
//                        Console.WriteLine("El número que usted ha escrito es mayor que el número que está buscando");
//                        Console.WriteLine("Intente adivinar el número otra vez");
//                        int respuesta3;
//                        respuesta3 = Int32.Parse(Console.ReadLine());
//                        if (respuesta3 == numeroParaAdivinar)
//                        {
//                            Console.WriteLine("Ha costado pero ya lo tienes ¡Felicidades!");
//                        }
//                        if (respuesta3 != numeroParaAdivinar)
//                        {
//                            Console.WriteLine("¡Vaya! Lamentablemente este juego parece demasiado complejo para usted y ha perdido" +
//                                "\n planteese dedicarse a otra cosa mas sencilla como jugar al parchis o mirar piedras");
//                        }
//                    }

//                }

//            }
//            if (respuesta > numeroParaAdivinar)
//            {
//                Console.WriteLine("El número que usted ha escrito es mayor que el número que está buscando");
//                Console.WriteLine("Intente adivinar el número otra vez");
//                int respuesta2;
//                respuesta2 = Int32.Parse(Console.ReadLine());
//                if (respuesta2 == numeroParaAdivinar)
//                {
//                    Console.WriteLine("¡Nice! Solo un 35% de elegidos lo adivinan a la segunda; "
//                        + "\n desde luego usted goza de una mente privilegiada.");
//                }
//                if (respuesta2 != numeroParaAdivinar)
//                {
//                    Console.WriteLine("¡Uff! Parece que has vuelto a fallar, te queda un último intento.");
//                    Console.WriteLine("He aquí la última pista...");
//                    Console.ReadLine();
//                    if (respuesta2 < numeroParaAdivinar)
//                    {
//                        Console.WriteLine("El número que usted ha escrito es menor que el número que está buscando");
//                        Console.WriteLine("Intente adivinar el número.. una última vez");
//                        int respuesta3;
//                        respuesta3 = Int32.Parse(Console.ReadLine());
//                        if (respuesta3 == numeroParaAdivinar)
//                        {
//                            Console.WriteLine("Ha costado pero ya lo tienes ¡Felicidades!");
//                        }
//                        if (respuesta3 != numeroParaAdivinar)
//                        {
//                            Console.WriteLine("¡Vaya! Lamentablemente este juego parece demasiado complejo para usted y ha perdido" +
//                                "\n planteese dedicarse a otra cosa mas sencilla como jugar al parchis o mirar piedras");
//                        }

//                    }
//                    if (respuesta2 > numeroParaAdivinar)
//                    {
//                        Console.WriteLine("El número que usted ha escrito es mayor que el número que está buscando");
//                        Console.WriteLine("Intente adivinar el número otra vez");
//                        int respuesta3;
//                        respuesta3 = Int32.Parse(Console.ReadLine());
//                        if (respuesta3 == numeroParaAdivinar)
//                        {
//                            Console.WriteLine("Ha costado pero ya lo tienes ¡Felicidades!");
//                        }
//                        if (respuesta3 != numeroParaAdivinar)
//                        {
//                            Console.WriteLine("¡Vaya! Lamentablemente este juego parece demasiado complejo para usted y ha perdido" +
//                                "\n planteese dedicarse a otra cosa mas sencilla como jugar al parchis o mirar piedras");
//                        }
//                    }

//                }

//            }
//        }
//        }
//        //Console.WriteLine($"El numero a adivinar era {numeroParaAdivinar}");
    //}
    



     