using System;
using System.IO;

namespace Proyecto_arreglado__1_
{
    class Program
    {

        struct admin
        {
            public clientes clientes;
            public articulos_limpieza limpieza;
            public Productos_cereales cereales;
            public bebidas bebidas;
            public bebidasalcoholicas alcocholicas;
            public producto todo;
        }



            struct clientes
        {
            public string nombre;
            public int numero;
            public int nit;
            public string email;

        }
        struct ventas
        {
            public string fecha;
            public string vendedor;
            public int precio;
            public string productosvendidos;

        }
        // Seccion Limpieza Nº1
        struct articulos_limpieza
        {
            public string detergente_omo;
            public string detergente_ace;
            public string detergente_liquido;
            public string suavisante_ropa;
            public string jaboncillo_dove;
            public string shampoo_sedal;
            public string colino_colgate;
            public string cepillo_dental;
            public string escoba_trapeador_recojedor;
            public string antisarro_ola;
            public string limpia_vidrio_ola;
            public string antigrasa_ola;
            public string desodorante_rexona;
            public string desodorante_nivea;
            public string lava_vajilla_archer;
            public string ambientador;
            public string jabon_bolivar;
            public string esponja_scotch_brite;
            public string lavandina;
            public string alcohol_gel;
            public precio_limpieza precios;
        }
        struct precio_limpieza
        {
            public int detergente_omo;
            public int detergente_ace;
            public int detergente_liquido;
            public int suavisante_ropa;
            public int jaboncillo_dove;
            public int shampoo_sedal;
            public int colino_colgate;
            public int cepillo_dental;
            public int escoba_trapeador_recojedor;
            public int antisarro_ola;
            public int limpia_vidrio_ola;
            public int antigrasa_ola;
            public int desodorante_rexona;
            public int desodorante_nivea;
            public int lava_vajilla_archer;
            public int ambientador;
            public int jabon_bolivar;
            public int esponja_scotch_brite;
            public int lavandina;
            public int alcohol_gel;
        }

        static int limpieza()
        {
            articulos_limpieza limpieza;
            limpieza.detergente_omo = " 1.-  Detergente OMO 3kg. 40 bs";
            limpieza.precios.detergente_omo = 40;
            limpieza.detergente_ace = " 2.-  Detergente ACE 1kg. 15 bs";
            limpieza.precios.detergente_ace = 15;
            limpieza.detergente_liquido = " 3.-  Detergente Líquido 1Lt. 50 bs";
            limpieza.precios.detergente_liquido = 50;
            limpieza.suavisante_ropa = " 4.-  Suavisante De Ropa 1Lt. 60 bs";
            limpieza.precios.suavisante_ropa = 60;
            limpieza.jaboncillo_dove = " 5.-  Jaboncillo Dove 10 bs";
            limpieza.precios.jaboncillo_dove = 10;
            limpieza.shampoo_sedal = " 6.-  Shampoo Sedal 20 bs";
            limpieza.precios.shampoo_sedal = 20;
            limpieza.colino_colgate = " 7.-  Colino Colgate 12 bs";
            limpieza.precios.colino_colgate = 12;
            limpieza.cepillo_dental = " 8.-  Cepillo Colgate 15 bs";
            limpieza.precios.cepillo_dental = 15;
            limpieza.escoba_trapeador_recojedor = " 9.-  Escoba + Trapeador + Recogedor 30 bs";
            limpieza.precios.escoba_trapeador_recojedor = 30;
            limpieza.antisarro_ola = " 10.- Antisarro Ola 25 bs";
            limpieza.precios.antisarro_ola = 25;
            limpieza.limpia_vidrio_ola = " 11.- Limpia Vidrios Ola 20 bs";
            limpieza.precios.limpia_vidrio_ola = 20;
            limpieza.antigrasa_ola = " 12.- Antigrasa Ola 20 bs";
            limpieza.precios.antigrasa_ola = 20;
            limpieza.desodorante_rexona = " 13.- Desodorante Rexona 15 bs";
            limpieza.precios.desodorante_rexona = 15;
            limpieza.desodorante_nivea = " 14.- Desodorante Nivea 17 bs";
            limpieza.precios.desodorante_nivea = 17;
            limpieza.lava_vajilla_archer = " 15.- Lava Vajilla Archer 20 bs";
            limpieza.precios.lava_vajilla_archer = 20;
            limpieza.ambientador = " 16.- Ambientador de ambientes 12 bs";
            limpieza.precios.ambientador = 12;
            limpieza.jabon_bolivar = " 17.- Jabón Bolivar 4 bs";
            limpieza.precios.jabon_bolivar = 4;
            limpieza.esponja_scotch_brite = " 18.- Esponja Scotch  Brite Paquete 13 bs";
            limpieza.precios.esponja_scotch_brite = 13;
            limpieza.lavandina = " 19.- Lavandina 1Lt. 10 bs";
            limpieza.precios.lavandina = 10;
            limpieza.alcohol_gel = " 20.- Alcohol en Gel 1Lt. 20 bs";
            limpieza.precios.alcohol_gel = 20;
            string respuesta = "";

            int suma = 0, suma1 = 0, suma2 = 0, suma3 = 0, suma4 = 0, suma5 = 0, suma6 = 0, suma7 = 0, suma8 = 0, suma9 = 0, suma10 = 0, suma11 = 0;
            int suma12 = 0, suma13 = 0, suma14 = 0, suma15 = 0, suma16 = 0, suma17 = 0, suma18 = 0, suma19 = 0, suma20 = 0; ;
            int cant = 0, cant1 = 0, cant2 = 0, cant3 = 0, cant4 = 0, cant5 = 0, cant6 = 0, cant7 = 0, cant8 = 0, cant9 = 0, cant10 = 0, cant11 = 0;
            int cant12 = 0, cant13 = 0, cant14 = 0, cant15 = 0, cant16 = 0, cant17 = 0, cant18 = 0, cant19 = 0, cant20 = 0;

            do
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("                     Menu Articulos De Limpieza                             ");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.detergente_omo);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.detergente_ace);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.detergente_liquido);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.suavisante_ropa);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.jaboncillo_dove);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.shampoo_sedal);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.colino_colgate);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.cepillo_dental);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.escoba_trapeador_recojedor);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.antisarro_ola);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.limpia_vidrio_ola);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.antigrasa_ola);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.desodorante_rexona);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.desodorante_nivea);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.lava_vajilla_archer);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.ambientador);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.jabon_bolivar);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.esponja_scotch_brite);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.lavandina);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(limpieza.alcohol_gel);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                int opcionalchol = int.Parse(Console.ReadLine());
                switch (opcionalchol)
                {
                    case 1:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant1 = int.Parse(Console.ReadLine());
                            suma1 = limpieza.precios.detergente_omo * cant1;
                            suma = suma1 + suma;
                            cant = cant1 + cant;
                            Console.WriteLine(" la suma es: " + suma1);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant2 = int.Parse(Console.ReadLine());
                            suma2 = limpieza.precios.detergente_ace * cant2;
                            suma = suma2 + suma;
                            cant = cant2 + cant;
                            Console.WriteLine(" la suma es: " + suma2);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant3 = int.Parse(Console.ReadLine());
                            suma3 = limpieza.precios.detergente_liquido * cant3;
                            suma = suma3 + suma;
                            cant = cant3 + cant;
                            Console.WriteLine(" la suma es: " + suma3);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant4 = int.Parse(Console.ReadLine());
                            suma4 = limpieza.precios.suavisante_ropa * cant4;
                            suma = suma4 + suma;
                            cant = cant4 + cant;
                            Console.WriteLine(" la suma es: " + suma4);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant5 = int.Parse(Console.ReadLine());
                            suma5 = limpieza.precios.jaboncillo_dove * cant5;
                            suma = suma5 + suma;
                            cant = cant5 + cant;
                            Console.WriteLine(" la suma es: " + suma5);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant6 = int.Parse(Console.ReadLine());
                            suma6 = limpieza.precios.shampoo_sedal * cant6;
                            suma = suma6 + suma;
                            cant = cant6 + cant;
                            Console.WriteLine(" la suma es: " + suma6);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant7 = int.Parse(Console.ReadLine());
                            suma7 = limpieza.precios.colino_colgate * cant7;
                            suma = suma7 + suma;
                            cant = cant7 + cant;
                            Console.WriteLine(" la suma es: " + suma7);

                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant8 = int.Parse(Console.ReadLine());
                            suma8 = limpieza.precios.cepillo_dental * cant8;
                            suma = suma8 + suma;
                            cant = cant8 + cant;
                            Console.WriteLine(" la suma es: " + suma8);

                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant9 = int.Parse(Console.ReadLine());
                            suma9 = limpieza.precios.escoba_trapeador_recojedor * cant9;
                            suma = suma9 + suma;
                            cant = cant9 + cant;
                            Console.WriteLine(" la suma es: " + suma9);

                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant10 = int.Parse(Console.ReadLine());
                            suma10 = limpieza.precios.antisarro_ola * cant10;
                            suma = suma10 + suma;
                            cant = cant10 + cant;
                            Console.WriteLine(" la suma es: " + suma10);
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant11 = int.Parse(Console.ReadLine());
                            suma11 = limpieza.precios.limpia_vidrio_ola * cant11;
                            suma = suma11 + suma;
                            cant = cant11 + cant;
                            Console.WriteLine(" la suma es: " + suma11);
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant12 = int.Parse(Console.ReadLine());
                            suma12 = limpieza.precios.antigrasa_ola * cant12;
                            suma = suma12 + suma;
                            cant = cant12 + cant;
                            Console.WriteLine(" la suma es: " + suma12);
                            break;
                        }
                    case 13:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant13 = int.Parse(Console.ReadLine());
                            suma13 = limpieza.precios.desodorante_rexona * cant13;
                            suma = suma13 + suma;
                            cant = cant13 + cant;
                            Console.WriteLine(" la suma es: " + suma13);
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant14 = int.Parse(Console.ReadLine());
                            suma14 = limpieza.precios.desodorante_nivea * cant14;
                            suma = suma14 + suma;
                            cant = cant14 + cant;
                            Console.WriteLine(" la suma es: " + suma14);
                            break;
                        }
                    case 15:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant15 = int.Parse(Console.ReadLine());
                            suma15 = limpieza.precios.lava_vajilla_archer * cant15;
                            suma = suma15 + suma;
                            cant = cant15 + cant;
                            Console.WriteLine(" la suma es: " + suma15);

                            break;
                        }
                    case 16:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant16 = int.Parse(Console.ReadLine());
                            suma16 = limpieza.precios.ambientador * cant16;
                            suma = suma16 + suma;
                            cant = cant16 + cant;
                            Console.WriteLine(" la suma es: " + suma16);
                            break;
                        }
                    case 17:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant17 = int.Parse(Console.ReadLine());
                            suma17 = limpieza.precios.jabon_bolivar * cant17;
                            suma = suma17 + suma;
                            cant = cant17 + cant;
                            Console.WriteLine(" la suma es: " + suma17);
                            break;
                        }
                    case 18:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant18 = int.Parse(Console.ReadLine());
                            suma18 = limpieza.precios.esponja_scotch_brite * cant18;
                            suma = suma18 + suma;
                            cant = cant18 + cant;
                            Console.WriteLine(" la suma es: " + suma18);
                            break;
                        }
                    case 19:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant19 = int.Parse(Console.ReadLine());
                            suma19 = limpieza.precios.lavandina * cant19;
                            suma = suma19 + suma;
                            cant = cant19 + cant;
                            Console.WriteLine(" la suma es: " + suma19);
                            break;
                        }
                    case 20:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant20 = int.Parse(Console.ReadLine());
                            suma20 = limpieza.precios.alcohol_gel * cant20;
                            suma = suma20 + suma;
                            cant = cant20 + cant;
                            Console.WriteLine(" la suma es: " + suma20);
                            break;
                        }
                }
                Console.WriteLine("Desea continuar: si o no");

                respuesta = Console.ReadLine();
            } while (respuesta != "no");
            Console.Clear();

            string ruta = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\cantidadlimpieza.txt", ruta2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\cantidadlimpiezacliente.txt";

            using (StreamWriter archivo = File.CreateText(ruta2))
            {
                if (cant1 > 0)
                {
                    archivo.WriteLine(limpieza.detergente_omo + " Cantidad vendida: " + cant1);
                }
                if (cant2 > 0)
                {
                    archivo.WriteLine(limpieza.detergente_ace + " Cantidad vendida: " + cant2);
                }
                if (cant3 > 0)
                {
                    archivo.WriteLine(limpieza.detergente_liquido + " Cantidad vendida: " + cant3);
                }
                if (cant4 > 0)
                {
                    archivo.WriteLine(limpieza.suavisante_ropa + " Cantidad vendida: " + cant4);
                }
                if (cant5 > 0)
                {
                    archivo.WriteLine(limpieza.jaboncillo_dove + " Cantidad vendida: " + cant5);
                }
                if (cant6 > 0)
                {
                    archivo.WriteLine(limpieza.shampoo_sedal + " Cantidad vendida: " + cant6);
                }
                if (cant7 > 0)
                {
                    archivo.WriteLine(limpieza.suavisante_ropa + " Cantidad vendida: " + cant7);
                }
                if (cant8 > 0)
                {
                    archivo.WriteLine(limpieza.cepillo_dental + " Cantidad vendida: " + cant8);
                }
                if (cant9 > 0)
                {
                    archivo.WriteLine(limpieza.escoba_trapeador_recojedor + " Cantidad vendida: " + cant9);
                }
                if (cant10 > 0)
                {
                    archivo.WriteLine(limpieza.antisarro_ola + " Cantidad vendida: " + cant10);
                }
                if (cant11 > 0)
                {
                    archivo.WriteLine(limpieza.limpia_vidrio_ola + " Cantidad vendida: " + cant11);
                }
                if (cant12 > 0)
                {
                    archivo.WriteLine(limpieza.antigrasa_ola + " Cantidad vendida: " + cant12);
                }
                if (cant13 > 0)
                {
                    archivo.WriteLine(limpieza.desodorante_rexona + " Cantidad vendida: " + cant13);
                }
                if (cant14 > 0)
                {
                    archivo.WriteLine(limpieza.desodorante_nivea + " Cantidad vendida: " + cant14);
                }
                if (cant15 > 0)
                {
                    archivo.WriteLine(limpieza.lava_vajilla_archer + " Cantidad vendida: " + cant15);
                }
                if (cant16 > 0)
                {
                    archivo.WriteLine(limpieza.ambientador + " Cantidad vendida: " + cant16);
                }
                if (cant17 > 0)
                {
                    archivo.WriteLine(limpieza.jabon_bolivar + " Cantidad vendida: " + cant17);
                }
                if (cant18 > 0)
                {
                    archivo.WriteLine(limpieza.esponja_scotch_brite + " Cantidad vendida: " + cant18);
                }
                if (cant19 > 0)
                {
                    archivo.WriteLine(limpieza.lavandina + " Cantidad vendida: " + cant19);
                }
                if (cant20 > 0)
                {
                    archivo.WriteLine(limpieza.alcohol_gel + " Cantidad vendida: " + cant20);
                }
            }
            using (StreamWriter archivo = File.AppendText(ruta))
            {

                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine("               Lista: cantidad de productos vendidos                        ");
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.detergente_omo + " Cantidad vendida:" + cant1);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.detergente_ace + " Cantidad vendida: " + cant2);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.detergente_liquido + " Cantidad vendida: " + cant3);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.suavisante_ropa + " Cantidad vendida: " + cant4);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.jaboncillo_dove + " Cantidad vendida: " + cant5);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.shampoo_sedal + " Cantidad vendida: " + cant6);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.colino_colgate + " Cantidad vendida: " + cant7);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.cepillo_dental + " Cantidad vendida: " + cant8);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.escoba_trapeador_recojedor + " Cantidad vendida: " + cant9);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.antisarro_ola + " Cantidad vendida: " + cant10);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.limpia_vidrio_ola + " Cantidad vendida: " + cant11);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.antigrasa_ola + " Cantidad vendida: " + cant12);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.desodorante_rexona + " Cantidad vendida: " + cant13);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.desodorante_nivea + " Cantidad vendida: " + cant14);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.lava_vajilla_archer + " Cantidad vendida: " + cant15);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.ambientador + " Cantidad vendida: " + cant16);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.jabon_bolivar + " Cantidad vendida: " + cant17);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.esponja_scotch_brite + " Cantidad vendida: " + cant18);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.lavandina + " Cantidad vendida: " + cant19);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(limpieza.alcohol_gel + " Cantidad vendida: " + cant20);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine("La suma total es: " + suma);
                archivo.WriteLine("----------------------------------------------------------------------------");
            }
            Console.WriteLine("La cantidad total es:" + cant);
            Console.WriteLine("La suma total es: " + suma);

            return suma;
        }


        // Seccion cereales Nº2
        struct Productos_cereales
        {
            public string miel;
            public string relleno_de_leche;
            public string chocopotamos;
            public string froties;
            public string choco_krispi;
            public string froot_loops;
            public string chocapic;
            public string golden_grahams;
            public string smocks;
            public string trix;
            public string all_bran_chose;
            public string nesquik;
            public precio_cereales precio;
        }
        struct precio_cereales
        {
            public int miel;
            public int relleno_de_leche;
            public int chocopotamos;
            public int froties;
            public int choco_krispi;
            public int froot_loops;
            public int chocapic;
            public int golden_grahams;
            public int smocks;
            public int trix;
            public int all_bran_chose;
            public int nesquik;
        }

        static int cereales()
        {
            Productos_cereales cereales;
            cereales.miel = " 1.- Miel  10 bs";
            cereales.precio.miel = 10;
            cereales.relleno_de_leche = " 2.- Relleno de leche 10 bs";
            cereales.precio.relleno_de_leche = 10;
            cereales.chocopotamos = " 3.- Chocopotamos 15 bs";
            cereales.precio.chocopotamos = 15;
            cereales.choco_krispi = " 4.- Choco Krispi  15 bs";
            cereales.precio.choco_krispi = 15;
            cereales.froot_loops = " 5.- Froot Loops 15 bs";
            cereales.precio.froot_loops = 15;
            cereales.chocapic = " 6.- Chocapic 25 bs";
            cereales.precio.chocapic = 25;
            cereales.golden_grahams = " 7.- Golden Grahams 20 bs";
            cereales.precio.golden_grahams = 20;
            cereales.smocks = " 8.- Smocks 25 bs";
            cereales.precio.smocks = 25;
            cereales.trix = " 9.- Trix 20 bs";
            cereales.precio.trix = 20;
            cereales.all_bran_chose = " 10.- All Bran Chose 35 bs";
            cereales.precio.all_bran_chose = 35;
            cereales.nesquik = " 11.- Nesquik 30 bs";
            cereales.precio.nesquik = 30;
            cereales.froties = " 12.- Froties 15 bs";
            cereales.precio.froties = 15;
            string respuesta = "";

            int suma = 0, suma1 = 0, suma2 = 0, suma3 = 0, suma4 = 0, suma5 = 0, suma6 = 0, suma7 = 0, suma8 = 0, suma9 = 0, suma10 = 0, suma11 = 0;
            int suma12 = 0, suma13 = 0, suma14 = 0, suma15 = 0, suma16 = 0, suma17 = 0, suma18 = 0, suma19 = 0, suma20 = 0; ;
            int cant = 0, cant1 = 0, cant2 = 0, cant3 = 0, cant4 = 0, cant5 = 0, cant6 = 0, cant7 = 0, cant8 = 0, cant9 = 0, cant10 = 0, cant11 = 0;
            int cant12 = 0, cant13 = 0, cant14 = 0, cant15 = 0, cant16 = 0, cant17 = 0, cant18 = 0, cant19 = 0, cant20 = 0;
            do
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("                           Menu Cereales                                    ");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.miel);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.relleno_de_leche);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.chocopotamos);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.froties);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.choco_krispi);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.froot_loops);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.chocapic);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.golden_grahams);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.smocks);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.trix);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.all_bran_chose);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(cereales.nesquik);
                Console.WriteLine("----------------------------------------------------------------------------");
                int opcionalchol = int.Parse(Console.ReadLine());
                switch (opcionalchol)
                {
                    case 1:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant1 = int.Parse(Console.ReadLine());
                            suma1 = cereales.precio.miel * cant1;
                            suma = suma1 + suma;
                            cant = cant1 + cant;
                            Console.WriteLine(" la suma es: " + suma1);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant2 = int.Parse(Console.ReadLine());
                            suma2 = cereales.precio.relleno_de_leche * cant2;
                            suma = suma2 + suma;
                            cant = cant2 + cant;
                            Console.WriteLine(" la suma es: " + suma2);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant3 = int.Parse(Console.ReadLine());
                            suma3 = cereales.precio.chocopotamos * cant3;
                            suma = suma3 + suma;
                            cant = cant3 + cant;
                            Console.WriteLine(" la suma es: " + suma3);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant4 = int.Parse(Console.ReadLine());
                            suma4 = cereales.precio.froties * cant4;
                            suma = suma4 + suma;
                            cant = cant4 + cant;
                            Console.WriteLine(" la suma es: " + suma4);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant5 = int.Parse(Console.ReadLine());
                            suma5 = cereales.precio.choco_krispi * cant5;
                            suma = suma5 + suma;
                            cant = cant5 + cant;
                            Console.WriteLine(" la suma es: " + suma5);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant6 = int.Parse(Console.ReadLine());
                            suma6 = cereales.precio.froot_loops * cant6;
                            suma = suma6 + suma;
                            cant = cant6 + cant;
                            Console.WriteLine(" la suma es: " + suma6);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant7 = int.Parse(Console.ReadLine());
                            suma7 = cereales.precio.chocapic * cant7;
                            suma = suma7 + suma;
                            cant = cant7 + cant;
                            Console.WriteLine(" la suma es: " + suma7);

                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant8 = int.Parse(Console.ReadLine());
                            suma8 = cereales.precio.golden_grahams * cant8;
                            suma = suma8 + suma;
                            cant = cant8 + cant;
                            Console.WriteLine(" la suma es: " + suma8);

                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant9 = int.Parse(Console.ReadLine());
                            suma9 = cereales.precio.smocks * cant9;
                            suma = suma9 + suma;
                            cant = cant9 + cant;
                            Console.WriteLine(" la suma es: " + suma9);

                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant10 = int.Parse(Console.ReadLine());
                            suma10 = cereales.precio.trix * cant10;
                            suma = suma10 + suma;
                            cant = cant10 + cant;
                            Console.WriteLine(" la suma es: " + suma10);
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant11 = int.Parse(Console.ReadLine());
                            suma11 = cereales.precio.all_bran_chose * cant11;
                            suma = suma11 + suma;
                            cant = cant11 + cant;
                            Console.WriteLine(" la suma es: " + suma11);
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant12 = int.Parse(Console.ReadLine());
                            suma12 = cereales.precio.nesquik * cant12;
                            suma = suma12 + suma;
                            cant = cant12 + cant;
                            Console.WriteLine(" la suma es: " + suma12);
                            break;
                        }
                }
                Console.WriteLine("Desea continuar: si o no");

                respuesta = Console.ReadLine();
            } while (respuesta != "no");
            Console.Clear();

            string ruta = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\cantidadcereales.txt", ruta2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\CantidadcerealeS.txt";

            using (StreamWriter archivo = File.CreateText(ruta2))
            {
                if (cant1 > 0)
                {
                    archivo.WriteLine(cereales.miel + " Cantidad vendida: " + cant1);
                }
                if (cant2 > 0)
                {
                    archivo.WriteLine(cereales.relleno_de_leche + " Cantidad vendida: " + cant2);
                }
                if (cant3 > 0)
                {
                    archivo.WriteLine(cereales.chocopotamos + " Cantidad vendida: " + cant3);
                }
                if (cant4 > 0)
                {
                    archivo.WriteLine(cereales.choco_krispi + " Cantidad vendida: " + cant4);
                }
                if (cant5 > 0)
                {
                    archivo.WriteLine(cereales.froot_loops + " Cantidad vendida: " + cant5);
                }
                if (cant6 > 0)
                {
                    archivo.WriteLine(cereales.chocapic + " Cantidad vendida: " + cant6);
                }
                if (cant7 > 0)
                {
                    archivo.WriteLine(cereales.golden_grahams + " Cantidad vendida: " + cant7);
                }
                if (cant8 > 0)
                {
                    archivo.WriteLine(cereales.smocks + " Cantidad vendida: " + cant8);
                }
                if (cant9 > 0)
                {
                    archivo.WriteLine(cereales.trix + " Cantidad vendida: " + cant9);
                }
                if (cant10 > 0)
                {
                    archivo.WriteLine(cereales.all_bran_chose + " Cantidad vendida: " + cant10);
                }
                if (cant11 > 0)
                {
                    archivo.WriteLine(cereales.nesquik + " Cantidad vendida: " + cant11);
                }
                if (cant12 > 0)
                {
                    archivo.WriteLine(cereales.froties + " Cantidad vendida: " + cant12);
                }
            }
            using (StreamWriter archivo = File.AppendText(ruta))
            {
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine("               Lista: cantidad de productos vendidos                        ");
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.miel + " Cantidad vendida:" + cant1);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.relleno_de_leche + " Cantidad vendida: " + cant2);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.chocopotamos + " Cantidad vendida: " + cant3);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.choco_krispi + " Cantidad vendida: " + cant4);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.froot_loops + " Cantidad vendida: " + cant5);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.chocapic + " Cantidad vendida: " + cant6);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.golden_grahams + " Cantidad vendida: " + cant7);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.smocks + " Cantidad vendida: " + cant8);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.trix + " Cantidad vendida: " + cant9);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.all_bran_chose + " Cantidad vendida: " + cant10);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.nesquik + " Cantidad vendida: " + cant11);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(cereales.froties + " Cantidad vendida: " + cant12);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine("La suma total es: " + suma);
                archivo.WriteLine("----------------------------------------------------------------------------");
            }
            Console.WriteLine("La cantidad total es:" + cant);
            Console.WriteLine("La suma total es: " + suma);

            return suma;
        }

        // Seccion bedidas o refrescos Nº3
        struct bebidas
        {
            public string cocacola;
            public string cocacolalitro;
            public string cocadiet;
            public string fanta;
            public string fantalitro;
            public string fantadiet;
            public string sprite;
            public string spritediet;
            public string spritelitro;
            public string pepsi;
            public string pepsilitro;
            public string pepsidiet;
            public string drpeper;
            public string mountdew;
            public string agua;
            public string agualitro;
            public string aguacongas;
            public bebidaspre valora;
        }
        struct bebidaspre
        {
            public int cocacolapre;
            public int cocacolalitropre;
            public int cocadietpre;
            public int fantapre;
            public int fantalitropre;
            public int fantadietpre;
            public int spritepre;
            public int spritedietpre;
            public int spritelitropre;
            public int pepsipre;
            public int pepsilitropre;
            public int pepsidietpre;
            public int drpeperpre;
            public int mountdewpre;
            public int aguapre;
            public int agualitropre;
            public int aguacongaspre;

        }
        static int bebidasss()
        {
            bebidas refresco;

            refresco.cocacola = "Coca-Cola Personal";
            refresco.valora.cocacolapre = 6;
            refresco.cocacolalitro = "Coca-Cola 3L";
            refresco.valora.cocacolalitropre = 12;
            refresco.cocadiet = "Coca-Cola Diet";
            refresco.valora.cocadietpre = 6;
            refresco.fanta = "Fanta Personal";
            refresco.valora.fantapre = 6;
            refresco.fantalitro = "Fanta 3L";
            refresco.valora.fantalitropre = 12;
            refresco.fantadiet = "Fanta Diet";
            refresco.valora.fantadietpre = 6;
            refresco.sprite = "Sprite Personal";
            refresco.valora.spritepre = 6;
            refresco.spritelitro = "Sprite 3L";
            refresco.valora.spritelitropre = 12;
            refresco.spritediet = "Sprite Diet";
            refresco.valora.spritedietpre = 6;
            refresco.pepsi = "Pepsi Personal";
            refresco.valora.pepsipre = 6;
            refresco.pepsilitro = "Pepsi 3L";
            refresco.valora.pepsilitropre = 12;
            refresco.pepsidiet = "Pepsi Diet";
            refresco.valora.pepsidietpre = 6;
            refresco.drpeper = "Dr Pepper";
            refresco.valora.drpeperpre = 7;
            refresco.mountdew = "Mountain Dew";
            refresco.valora.mountdewpre = 7;
            refresco.agua = "Agua Personal";
            refresco.valora.aguapre = 4;
            refresco.agualitro = "Agua 2L";
            refresco.valora.agualitropre = 8;
            refresco.aguacongas = "Agua Con Gas";
            refresco.valora.aguacongaspre = 5;


            string respuesta = "";

            int suma = 0, suma1 = 0, suma2 = 0, suma3 = 0, suma4 = 0, suma5 = 0, suma6 = 0, suma7 = 0, suma8 = 0, suma9 = 0, suma10 = 0, suma11 = 0;
            int suma12 = 0, suma13 = 0, suma14 = 0, suma15 = 0, suma16 = 0, suma17 = 0;
            int cant = 0, cant1 = 0, cant2 = 0, cant3 = 0, cant4 = 0, cant5 = 0, cant6 = 0, cant7 = 0, cant8 = 0, cant9 = 0, cant10 = 0, cant11 = 0;
            int cant12 = 0, cant13 = 0, cant14 = 0, cant15 = 0, cant16 = 0, cant17 = 0;
            do
            {

                Console.WriteLine("|                                                              |\n");
                Console.WriteLine("|               Menu de Bebidas Refrescos                      |\n");
                Console.WriteLine("| 1-" + refresco.cocacola + ": " + refresco.valora.cocacolapre + "    | 2-" + refresco.cocacolalitro + ": " + refresco.valora.cocacolalitropre + "              |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 3-" + refresco.cocadiet + ": " + refresco.valora.cocadietpre + "        | 4-" + refresco.fanta + ": " + refresco.valora.fantapre + "             |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 5-" + refresco.fantalitro + ": " + refresco.valora.fantalitropre + "             | 6-" + refresco.fantadiet + ": " + refresco.valora.fantadietpre + "                 |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 7-" + refresco.sprite + ": " + refresco.valora.spritepre + "       | 8-" + refresco.spritelitro + ": " + refresco.valora.spritelitropre + "                 |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 9-" + refresco.spritediet + ": " + refresco.valora.spritedietpre + "           | 10 - " + refresco.pepsi + ": " + refresco.valora.pepsipre + "          |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 11-" + refresco.pepsilitro + ": " + refresco.valora.pepsilitropre + "            | 12-" + refresco.pepsidiet + ": " + refresco.valora.pepsidietpre + "                |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 13-" + refresco.drpeper + ": " + refresco.valora.drpeperpre + "            | 14-" + refresco.mountdew + ": " + refresco.valora.mountdewpre + "              |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 15-" + refresco.agua + ": " + refresco.valora.aguapre + "        | 16-" + refresco.agualitro + ": " + refresco.valora.agualitropre + "                   |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 17-" + refresco.aguacongas + ": " + refresco.valora.aguacongaspre + "         |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                int opcionalchol = int.Parse(Console.ReadLine());

                switch (opcionalchol)
                {

                    case 1:

                        Console.WriteLine("ingrese la cantidad");
                        cant1 = int.Parse(Console.ReadLine());
                        suma1 = refresco.valora.cocacolapre * cant1;
                        suma = suma1 + suma;
                        cant = cant1 + cant;
                        Console.WriteLine(" la suma es: " + suma1);


                        break;

                    case 2:
                        Console.WriteLine("ingrese la cantidad");
                        cant2 = int.Parse(Console.ReadLine());
                        suma2 = refresco.valora.cocacolalitropre * cant2;
                        suma = suma2 + suma;
                        cant = cant2 + cant;
                        Console.WriteLine(" la suma es: " + suma2);

                        break;
                    case 3:
                        Console.WriteLine("ingrese la cantidad");
                        cant3 = int.Parse(Console.ReadLine());
                        suma3 = refresco.valora.cocadietpre * cant3;
                        suma = suma3 + suma;
                        cant = cant3 + cant;
                        Console.WriteLine(" la suma es: " + suma3);

                        break;
                    case 4:
                        Console.WriteLine("ingrese la cantidad");
                        cant4 = int.Parse(Console.ReadLine());
                        suma4 = refresco.valora.fantapre * cant4;
                        suma = suma4 + suma;
                        cant = cant4 + cant;
                        Console.WriteLine(" la suma es: " + suma4);

                        break;
                    case 5:
                        Console.WriteLine("ingrese la cantidad");
                        cant5 = int.Parse(Console.ReadLine());
                        suma5 = refresco.valora.fantalitropre * cant5;
                        suma = suma5 + suma;
                        cant = cant5 + cant;
                        Console.WriteLine(" la suma es: " + suma5);

                        break;
                    case 6:
                        Console.WriteLine("ingrese la cantidad");
                        cant6 = int.Parse(Console.ReadLine());
                        suma6 = refresco.valora.fantadietpre * cant6;
                        suma = suma6 + suma;
                        cant = cant6 + cant;
                        Console.WriteLine(" la suma es: " + suma6);

                        break;
                    case 7:
                        Console.WriteLine("ingrese la cantidad");
                        cant7 = int.Parse(Console.ReadLine());
                        suma7 = refresco.valora.spritepre * cant7;
                        suma = suma7 + suma;
                        cant = cant7 + cant;
                        Console.WriteLine(" la suma es: " + suma7);

                        break;
                    case 8:
                        Console.WriteLine("ingrese la cantidad");
                        cant8 = int.Parse(Console.ReadLine());
                        suma8 = refresco.valora.spritelitropre * cant8;
                        suma = suma8 + suma;
                        cant = cant8 + cant;
                        Console.WriteLine(" la suma es: " + suma8);

                        break;
                    case 9:
                        Console.WriteLine("ingrese la cantidad");
                        cant9 = int.Parse(Console.ReadLine());
                        suma9 = refresco.valora.spritedietpre * cant9;
                        suma = suma9 + suma;
                        cant = cant9 + cant;
                        Console.WriteLine(" la suma es: " + suma9);

                        break;
                    case 10:
                        Console.WriteLine("ingrese la cantidad");
                        cant10 = int.Parse(Console.ReadLine());
                        suma10 = refresco.valora.pepsipre * cant10;
                        suma = suma10 + suma;
                        cant = cant10 + cant;
                        Console.WriteLine(" la suma es: " + suma10);
                        break;

                    case 11:
                        Console.WriteLine("ingrese la cantidad");
                        cant11 = int.Parse(Console.ReadLine());
                        suma11 = refresco.valora.pepsilitropre * cant11;
                        suma = suma11 + suma;
                        cant = cant11 + cant;
                        Console.WriteLine(" la suma es: " + suma11);
                        break;

                    case 12:
                        Console.WriteLine("ingrese la cantidad");
                        cant12 = int.Parse(Console.ReadLine());
                        suma12 = refresco.valora.pepsidietpre * cant12;
                        suma = suma12 + suma;
                        cant = cant12 + cant;
                        Console.WriteLine(" la suma es: " + suma12);
                        break;

                    case 13:
                        Console.WriteLine("ingrese la cantidad");
                        cant13 = int.Parse(Console.ReadLine());
                        suma13 = refresco.valora.drpeperpre * cant13;
                        suma = suma13 + suma;
                        cant = cant13 + cant;
                        Console.WriteLine(" la suma es: " + suma13);
                        break;

                    case 14:
                        Console.WriteLine("ingrese la cantidad");
                        cant14 = int.Parse(Console.ReadLine());
                        suma14 = refresco.valora.mountdewpre * cant14;
                        suma = suma14 + suma;
                        cant = cant14 + cant;
                        Console.WriteLine(" la suma es: " + suma14);
                        break;

                    case 15:
                        Console.WriteLine("ingrese la cantidad");
                        cant15 = int.Parse(Console.ReadLine());
                        suma15 = refresco.valora.aguapre * cant15;
                        suma = suma15 + suma;
                        cant = cant15 + cant;
                        Console.WriteLine(" la suma es: " + suma15);

                        break;

                    case 16:
                        Console.WriteLine("ingrese la cantidad");
                        cant16 = int.Parse(Console.ReadLine());
                        suma16 = refresco.valora.agualitropre * cant16;
                        suma = suma16 + suma;
                        cant = cant16 + cant;
                        Console.WriteLine(" la suma es: " + suma16);
                        break;

                    case 17:
                        Console.WriteLine("ingrese la cantidad");
                        cant17 = int.Parse(Console.ReadLine());
                        suma17 = refresco.valora.aguacongaspre * cant17;
                        suma = suma17 + suma;
                        cant = cant17 + cant;
                        Console.WriteLine(" la suma es: " + suma17);
                        break;

                }

                Console.WriteLine("Desea continuar: si o no");

                respuesta = Console.ReadLine();
            } while (respuesta != "no");
            Console.Clear();

                        
            string ruta = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\refrescoadmin.txt", ruta2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\refrescoclientes.txt";


            using (StreamWriter archivo = File.CreateText(ruta2))
            {
                if (cant1 > 0)
                {
                    archivo.WriteLine("1 - " + refresco.cocacola + " Cantidad vendida: " + cant1);
                }
                if (cant2 > 0)
                {
                    archivo.WriteLine("2 - " + refresco.cocacolalitro + " Cantidad vendida: " + cant2);
                }
                if (cant3 > 0)
                {
                    archivo.WriteLine("3 - " + refresco.cocadiet + " Cantidad vendida: " + cant1);
                }
                if (cant4 > 0)
                {
                    archivo.WriteLine("4 - " + refresco.fanta + " Cantidad vendida: " + cant2);
                }
                if (cant5 > 0)
                {
                    archivo.WriteLine("5 - " + refresco.fantalitro + " Cantidad vendida: " + cant1);
                }
                if (cant6 > 0)
                {
                    archivo.WriteLine("6 - " + refresco.fantadiet + " Cantidad vendida: " + cant2);
                }
                if (cant7 > 0)
                {
                    archivo.WriteLine("7 - " + refresco.sprite + " Cantidad vendida: " + cant1);
                }
                if (cant8 > 0)
                {
                    archivo.WriteLine("8 - " + refresco.spritelitro + " Cantidad vendida: " + cant2);
                }
                if (cant9 > 0)
                {
                    archivo.WriteLine("9 - " + refresco.spritediet + " Cantidad vendida: " + cant1);
                }
                if (cant10 > 0)
                {
                    archivo.WriteLine("10 - " + refresco.pepsi + " Cantidad vendida: " + cant2);
                }
                if (cant11 > 0)
                {
                    archivo.WriteLine("11 - " + refresco.pepsilitro + " Cantidad vendida: " + cant1);
                }
                if (cant12 > 0)
                {
                    archivo.WriteLine("12 - " + refresco.pepsidiet + " Cantidad vendida: " + cant2);
                }
                if (cant13 > 0)
                {
                    archivo.WriteLine("13 - " + refresco.drpeper + " Cantidad vendida: " + cant1);
                }
                if (cant14 > 0)
                {
                    archivo.WriteLine("14 - " + refresco.mountdew + " Cantidad vendida: " + cant2);
                }
                if (cant15 > 0)
                {
                    archivo.WriteLine("15 - " + refresco.agua + " Cantidad vendida: " + cant1);
                }
                if (cant16 > 0)
                {
                    archivo.WriteLine("16 - " + refresco.agualitro + " Cantidad vendida: " + cant2);
                }
                if (cant17 > 0)
                {
                    archivo.WriteLine("17 - " + refresco.aguacongas + " Cantidad vendida: " + cant1);
                }                
                archivo.WriteLine("La cantidad de productos vendidos fue: " + cant +
                "\nLa suma total es: " + suma);


            }

            using (StreamWriter archivo = File.AppendText(ruta))
            {
                archivo.WriteLine("|               Lista: cantidad de productos vendidos                       \n" +
                "| 1-" + refresco.cocacola + " Cantidad vendida: " + cant1 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 2-" + refresco.cocacolalitro + " Cantidad vendida: " + cant2 + " \n" +
                "|----------------------------------------------------------------------------\n" +
                "| 3-" + refresco.cocadiet + " Cantidad vendida: " + cant3 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 4-" + refresco.fanta + " Cantidad vendida: " + cant4 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 5-" + refresco.fantalitro + " Cantidad vendida: " + cant5 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 6-" + refresco.fantadiet + " Cantidad vendida: " + cant6 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 7-" + refresco.sprite + " Cantidad vendida: " + cant7 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 8-" + refresco.spritelitro + " Cantidad vendida: " + cant8 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 9-" + refresco.spritediet + " Cantidad vendida: " + cant9 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 10-" + refresco.pepsi + " Cantidad vendida: " + cant10 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 11-" + refresco.pepsilitro + " Cantidad vendida: " + cant11 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 12-" + refresco.pepsidiet + " Cantidad vendida: " + cant12 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 13-" + refresco.drpeper + " Cantidad vendida: " + cant13 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 14-" + refresco.mountdew + " Cantidad vendida: " + cant14 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 15-" + refresco.agua + " Cantidad vendida: " + cant15 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 16-" + refresco.agualitro + " Cantidad vendida: " + cant16 + "\n" +
                "|----------------------------------------------------------------------------\n" +
                "| 17-" + refresco.aguacongas + " Cantidad vendida: " + cant17 + "\n" +
                "|----------------------------------------------------------------------------\n" +

                "La cantidad de productos vendidos fue: " + cant +
                "\nLa suma total es: " + suma);             
            }


            Console.WriteLine("La cantidad total es:" + cant);
            Console.WriteLine("La suma total es: " + suma);


            return suma;


        }
        // Seccion bebidas alcoholicas Nº4
        struct bebidasalcoholicas
        {
            public string huaribottela;
            public string huerilata;
            public string pacena;
            public string taquinalitro;
            public string conti;
            public string real;
            public string imperial;
            public string heinikeinl;
            public string corona;
            public string ronabuelolitro;
            public string abuelo734;
            public string ronhavana;
            public string havana7lito;
            public string johnnierojo;
            public string johnnienegro;
            public string johnnieazul;
            public string tequilacuervo;
            public string casaazul;
            public string casarojo;
            public string casanegro;
            public bebidasalcholpre valorb;

        }
        struct bebidasalcholpre
        {
            public int huaribotte;
            public int huarilat;
            public int pacen;
            public int taquinalit;
            public int cont;
            public int realpre;
            public int imperialpre;
            public int heinikeinlpre;
            public int coronapre;
            public int ronabuelolitropre;
            public int abuelo7pre;
            public int ronhavanapre;
            public int havana7litopre;
            public int johnnierojopre;
            public int johnnienegropre;
            public int johnnieazulpre;
            public int tequilacuervopre;
            public int casaazulpre;
            public int casarojopre;
            public int casanegropre;
        }
        static int bebidasalcohol()
        {
            //bebidasalcoholicas[] alchol = new bebidasalcoholicas;
            bebidasalcoholicas alchol;

            

            alchol.huaribottela = "Huari 1L";
            alchol.valorb.huaribotte = 18;
            alchol.huerilata = "Huari lata";
            alchol.valorb.huarilat = 10;
            alchol.pacena = "Paceña lata";
            alchol.valorb.pacen = 8;
            alchol.taquinalitro = "Taquiña 1L";
            alchol.valorb.taquinalit = 20;
            alchol.conti = "Conti";
            alchol.valorb.cont = 6;
            alchol.real = "Real";
            alchol.valorb.realpre = 5;
            alchol.imperial = "Imperial";
            alchol.valorb.imperialpre = 5;
            alchol.heinikeinl = "Heineken";
            alchol.valorb.heinikeinlpre = 15;
            alchol.corona = "Corona";
            alchol.valorb.coronapre = 15;
            alchol.ronabuelolitro = "Ron Abuelo 1L";
            alchol.valorb.ronabuelolitropre = 70;
            alchol.abuelo734 = "Ron Abuelo 7 años 3/4";
            alchol.valorb.abuelo7pre = 105;
            alchol.ronhavana = "Ron Havana 1L";
            alchol.valorb.ronhavanapre = 90;
            alchol.havana7lito = "Ron Havana 7 años 1L";
            alchol.valorb.havana7litopre = 110;
            alchol.johnnierojo = "Johnnie Walker Rojo";
            alchol.valorb.johnnierojopre = 130;
            alchol.johnnienegro = "Johnnie Walker Negro";
            alchol.valorb.johnnienegropre = 190;
            alchol.johnnieazul = "Johnnie Walker Azul";
            alchol.valorb.johnnieazulpre = 950;
            alchol.tequilacuervo = "Tequila Jose Cuervo";
            alchol.valorb.tequilacuervopre = 75;
            alchol.casarojo = "Casa Real Rojo";
            alchol.valorb.casarojopre = 25;
            alchol.casaazul = "Casa Real Azul";
            alchol.valorb.casaazulpre = 40;
            alchol.casanegro = "Casa Real Negro";
            alchol.valorb.casanegropre = 60;

            string respuesta = "";

            int suma = 0, suma1 = 0, suma2 = 0, suma3 = 0, suma4 = 0, suma5 = 0, suma6 = 0, suma7 = 0, suma8 = 0, suma9 = 0, suma10 = 0, suma11 = 0;
            int suma12 = 0, suma13 = 0, suma14 = 0, suma15 = 0, suma16 = 0, suma17 = 0, suma18 = 0, suma19 = 0, suma20 = 0; ;
            int cant = 0, cant1 = 0, cant2 = 0, cant3 = 0, cant4 = 0, cant5 = 0, cant6 = 0, cant7 = 0, cant8 = 0, cant9 = 0, cant10 = 0, cant11 = 0;
            int cant12 = 0, cant13 = 0, cant14 = 0, cant15 = 0, cant16 = 0, cant17 = 0, cant18 = 0, cant19 = 0, cant20 = 0;

            do
            {

                Console.WriteLine("|                                                              |\n");
                Console.WriteLine("|               Menu de Bebidas Alcoholicas                    |\n");
                Console.WriteLine("| 1-" + alchol.huaribottela + ": " + alchol.valorb.huaribotte + "             | 2-" + alchol.huerilata + ": " + alchol.valorb.huarilat + "                |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 3-" + alchol.pacena + ": " + alchol.valorb.pacen + "           | 4-" + alchol.taquinalitro + ": " + alchol.valorb.taquinalit + "                |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 5-" + alchol.conti + ": " + alchol.valorb.cont + "                 | 6-" + alchol.real + ": " + alchol.valorb.realpre + "                       |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 7-" + alchol.imperial + ": " + alchol.valorb.imperialpre + "              | 8-" + alchol.heinikeinl + ": " + alchol.valorb.heinikeinlpre + "                  |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 9-" + alchol.corona + ": " + alchol.valorb.coronapre + "               |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 10-" + alchol.ronabuelolitro + ": " + alchol.valorb.ronabuelolitropre + "       | 11-" + alchol.abuelo734 + ": " + alchol.valorb.abuelo7pre + "   |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 12-" + alchol.ronhavana + ": " + alchol.valorb.ronhavanapre + "       | 13-" + alchol.havana7lito + ": " + alchol.valorb.havana7litopre + "    |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 14-" + alchol.johnnierojo + ": " + alchol.valorb.johnnierojopre + "| 15-" + alchol.johnnienegro + ": " + alchol.valorb.johnnienegropre + "    |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 16-" + alchol.johnnieazul + ": " + alchol.valorb.johnnieazulpre + "| 17-" + alchol.tequilacuervo + ": " + alchol.valorb.tequilacuervopre + "      |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 18-" + alchol.casarojo + ": " + alchol.valorb.casarojopre + "      |19-" + alchol.casaazul + ": " + alchol.valorb.casaazulpre + "            |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.WriteLine("| 20-" + alchol.casanegro + ": " + alchol.valorb.casanegropre + "     |\n");
                Console.WriteLine("|----------------------------|---------------------------------|\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                int opcionalchol = int.Parse(Console.ReadLine());


                switch (opcionalchol)
                {

                    case 1:
                        Console.WriteLine("ingrese la cantidad");
                        cant1 = int.Parse(Console.ReadLine());
                        suma1 = alchol.valorb.huaribotte * cant1;
                        suma = suma1 + suma;
                        cant = cant1 + cant;
                        Console.WriteLine(" la suma es: " + suma1);

                        break;
                    case 2:
                        Console.WriteLine("ingrese la cantidad");
                        cant2 = int.Parse(Console.ReadLine());
                        suma2 = alchol.valorb.huarilat * cant2;
                        suma = suma2 + suma;
                        cant = cant2 + cant;
                        Console.WriteLine(" la suma es: " + suma2);

                        break;
                    case 3:
                        Console.WriteLine("ingrese la cantidad");
                        cant3 = int.Parse(Console.ReadLine());
                        suma3 = alchol.valorb.pacen * cant3;
                        suma = suma3 + suma;
                        cant = cant3 + cant;
                        Console.WriteLine(" la suma es: " + suma3);

                        break;
                    case 4:
                        Console.WriteLine("ingrese la cantidad");
                        cant4 = int.Parse(Console.ReadLine());
                        suma4 = alchol.valorb.taquinalit * cant4;
                        suma = suma4 + suma;
                        cant = cant4 + cant;
                        Console.WriteLine(" la suma es: " + suma4);

                        break;
                    case 5:
                        Console.WriteLine("ingrese la cantidad");
                        cant5 = int.Parse(Console.ReadLine());
                        suma5 = alchol.valorb.cont * cant5;
                        suma = suma5 + suma;
                        cant = cant5 + cant;
                        Console.WriteLine(" la suma es: " + suma5);

                        break;
                    case 6:
                        Console.WriteLine("ingrese la cantidad");
                        cant6 = int.Parse(Console.ReadLine());
                        suma6 = alchol.valorb.realpre * cant6;
                        suma = suma6 + suma;
                        cant = cant6 + cant;
                        Console.WriteLine(" la suma es: " + suma6);

                        break;
                    case 7:
                        Console.WriteLine("ingrese la cantidad");
                        cant7 = int.Parse(Console.ReadLine());
                        suma7 = alchol.valorb.imperialpre * cant7;
                        suma = suma7 + suma;
                        cant = cant7 + cant;
                        Console.WriteLine(" la suma es: " + suma7);

                        break;
                    case 8:
                        Console.WriteLine("ingrese la cantidad");
                        cant8 = int.Parse(Console.ReadLine());
                        suma8 = alchol.valorb.heinikeinlpre * cant8;
                        suma = suma8 + suma;
                        cant = cant8 + cant;
                        Console.WriteLine(" la suma es: " + suma8);

                        break;
                    case 9:
                        Console.WriteLine("ingrese la cantidad");
                        cant9 = int.Parse(Console.ReadLine());
                        suma9 = alchol.valorb.coronapre * cant9;
                        suma = suma9 + suma;
                        cant = cant9 + cant;
                        Console.WriteLine(" la suma es: " + suma9);

                        break;
                    case 10:
                        Console.WriteLine("ingrese la cantidad");
                        cant10 = int.Parse(Console.ReadLine());
                        suma10 = alchol.valorb.ronabuelolitropre * cant10;
                        suma = suma10 + suma;
                        cant = cant10 + cant;
                        Console.WriteLine(" la suma es: " + suma10);
                        break;

                    case 11:
                        Console.WriteLine("ingrese la cantidad");
                        cant11 = int.Parse(Console.ReadLine());
                        suma11 = alchol.valorb.abuelo7pre * cant11;
                        suma = suma11 + suma;
                        cant = cant11 + cant;
                        Console.WriteLine(" la suma es: " + suma11);
                        break;

                    case 12:
                        Console.WriteLine("ingrese la cantidad");
                        cant12 = int.Parse(Console.ReadLine());
                        suma12 = alchol.valorb.ronhavanapre * cant12;
                        suma = suma12 + suma;
                        cant = cant12 + cant;
                        Console.WriteLine(" la suma es: " + suma12);
                        break;

                    case 13:
                        Console.WriteLine("ingrese la cantidad");
                        cant13 = int.Parse(Console.ReadLine());
                        suma13 = alchol.valorb.havana7litopre * cant13;
                        suma = suma13 + suma;
                        cant = cant13 + cant;
                        Console.WriteLine(" la suma es: " + suma13);
                        break;

                    case 14:
                        Console.WriteLine("ingrese la cantidad");
                        cant14 = int.Parse(Console.ReadLine());
                        suma14 = alchol.valorb.johnnierojopre * cant14;
                        suma = suma14 + suma;
                        cant = cant14 + cant;
                        Console.WriteLine(" la suma es: " + suma14);
                        break;

                    case 15:
                        Console.WriteLine("ingrese la cantidad");
                        cant15 = int.Parse(Console.ReadLine());
                        suma15 = alchol.valorb.johnnienegropre * cant15;
                        suma = suma15 + suma;
                        cant = cant15 + cant;
                        Console.WriteLine(" la suma es: " + suma15);

                        break;

                    case 16:
                        Console.WriteLine("ingrese la cantidad");
                        cant16 = int.Parse(Console.ReadLine());
                        suma16 = alchol.valorb.johnnieazulpre * cant16;
                        suma = suma16 + suma;
                        cant = cant16 + cant;
                        Console.WriteLine(" la suma es: " + suma16);
                        break;

                    case 17:
                        Console.WriteLine("ingrese la cantidad");
                        cant17 = int.Parse(Console.ReadLine());
                        suma17 = alchol.valorb.tequilacuervopre * cant17;
                        suma = suma17 + suma;
                        cant = cant17 + cant;
                        Console.WriteLine(" la suma es: " + suma17);
                        break;

                    case 18:
                        Console.WriteLine("ingrese la cantidad");
                        cant18 = int.Parse(Console.ReadLine());
                        suma18 = alchol.valorb.casarojopre * cant18;
                        suma = suma18 + suma;
                        cant = cant18 + cant;
                        Console.WriteLine(" la suma es: " + suma18);
                        break;

                    case 19:
                        Console.WriteLine("ingrese la cantidad");
                        cant19 = int.Parse(Console.ReadLine());
                        suma19 = alchol.valorb.casaazulpre * cant19;
                        suma = suma19 + suma;
                        cant = cant19 + cant;
                        Console.WriteLine(" la suma es: " + suma19);

                        break;
                    case 20:
                        Console.WriteLine("ingrese la cantidad");
                        cant20 = int.Parse(Console.ReadLine());
                        suma20 = alchol.valorb.casanegropre * cant20;
                        suma = suma20 + suma;
                        cant = cant20 + cant;
                        Console.WriteLine(" la suma es: " + suma20);
                        break;




                }
                Console.WriteLine("Desea continuar: si o no");

                respuesta = Console.ReadLine();
            } while (respuesta != "no");
            Console.Clear();          



            string ruta = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\alcoholadmin.txt", ruta2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\alcoholclientes.txt";
            
            using (StreamWriter archivo = File.CreateText(ruta2))
            {
                if (cant1>0 ) 
                {
                    archivo.WriteLine("1 - " + alchol.huaribottela + " Cantidad vendida: " + cant1);                   
                }
                if (cant2 > 0)
                {
                    archivo.WriteLine("2 - " + alchol.huerilata + " Cantidad vendida: " + cant2);
                }
                if (cant3 > 0)
                {
                    archivo.WriteLine("3 - " + alchol.pacena + " Cantidad vendida: " + cant1);
                }
                if (cant4 > 0)
                {
                    archivo.WriteLine("4 - " + alchol.taquinalitro + " Cantidad vendida: " + cant2);
                }
                if (cant5 > 0)
                {
                    archivo.WriteLine("5 - " + alchol.conti + " Cantidad vendida: " + cant1);
                }
                if (cant6 > 0)
                {
                    archivo.WriteLine("6 - " + alchol.real + " Cantidad vendida: " + cant2);
                }
                if (cant7 > 0)
                {
                    archivo.WriteLine("7 - " + alchol.imperial + " Cantidad vendida: " + cant1);
                }
                if (cant8 > 0)
                {
                    archivo.WriteLine("8 - " + alchol.heinikeinl + " Cantidad vendida: " + cant2);
                }
                if (cant9 > 0)
                {
                    archivo.WriteLine("9 - " + alchol.corona + " Cantidad vendida: " + cant1);
                }
                if (cant10 > 0)
                {
                    archivo.WriteLine("10 - " + alchol.ronabuelolitro + " Cantidad vendida: " + cant2);
                }
                if (cant11 > 0)
                {
                    archivo.WriteLine("11 - " + alchol.abuelo734 + " Cantidad vendida: " + cant1);
                }
                if (cant12 > 0)
                {
                    archivo.WriteLine("12 - " + alchol.ronhavana + " Cantidad vendida: " + cant2);
                }
                if (cant13 > 0)
                {
                    archivo.WriteLine("13 - " + alchol.havana7lito + " Cantidad vendida: " + cant1);
                }
                if (cant14 > 0)
                {
                    archivo.WriteLine("14 - " + alchol.johnnierojo + " Cantidad vendida: " + cant2);
                }
                if (cant15 > 0)
                {
                    archivo.WriteLine("15 - " + alchol.johnnienegro + " Cantidad vendida: " + cant1);
                }
                if (cant16 > 0)
                {
                    archivo.WriteLine("16 - " + alchol.johnnieazul + " Cantidad vendida: " + cant2);
                }
                if (cant17 > 0)
                {
                    archivo.WriteLine("17 - " + alchol.tequilacuervo + " Cantidad vendida: " + cant1);
                }
                if (cant18 > 0)
                {
                    archivo.WriteLine("18 - " + alchol.casarojo + " Cantidad vendida: " + cant2);
                }
                if (cant19 > 0)
                {
                    archivo.WriteLine("19 - " + alchol.casaazul + " Cantidad vendida: " + cant1);
                }
                if (cant20 > 0)
                {
                    archivo.WriteLine("20 - " + alchol.casanegro + " Cantidad vendida: " + cant2);
                }
                archivo.WriteLine("La cantidad de productos vendidos fue: " + cant +
                "\nLa suma total es: " + suma);
                

            }         

                using (StreamWriter archivo = File.AppendText(ruta))
            {

                archivo.WriteLine("|                                                              |\n" +


              "|               Lista: cantidad de productos vendidos                       \n" +
              "| 1-" + alchol.huaribottela + " Cantidad vendida: " + cant1 + "\n" +
              "|----------------------------------------------------------------------------\n"+
              "| 2-" + alchol.huerilata + " Cantidad vendida: " + cant2 + " \n" +
              "|----------------------------------------------------------------------------\n" +
              "| 3-" + alchol.pacena + " Cantidad vendida: " + cant3 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 4-" + alchol.taquinalitro + " Cantidad vendida: " + cant4 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 5-" + alchol.conti + " Cantidad vendida: " + cant5 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 6-" + alchol.real + " Cantidad vendida: " + cant6 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 7-" + alchol.imperial + " Cantidad vendida: " + cant7 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 8-" + alchol.heinikeinl + " Cantidad vendida: " + cant8 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 9-" + alchol.corona + " Cantidad vendida: " + cant9 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 10-" + alchol.ronabuelolitro + " Cantidad vendida: " + cant10 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 11-" + alchol.abuelo734 + " Cantidad vendida: " + cant11 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 12-" + alchol.ronhavana + " Cantidad vendida: " + cant12 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 13-" + alchol.havana7lito + " Cantidad vendida: " + cant13 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 14-" + alchol.johnnierojo + " Cantidad vendida: " + cant14 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 15-" + alchol.johnnienegro + " Cantidad vendida: " + cant15 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 16-" + alchol.johnnieazul + " Cantidad vendida: " + cant16 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 17-" + alchol.tequilacuervo + " Cantidad vendida: " + cant17 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 18-" + alchol.casarojo + " Cantidad vendida: " + cant18 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 19-" + alchol.casaazul + " Cantidad vendida: " + cant19 + "\n" +
              "|----------------------------------------------------------------------------\n" +
              "| 20-" + alchol.casanegro + " Cantidad vendida: " + cant20 + "\n" +
              "|----------------------------------------------------------------------------\n" +

              "La cantidad de productos vendidos fue: " + cant +
              "\nLa suma total es: " + suma);
            }

            Console.WriteLine("La cantidad total es:" + cant);
            Console.WriteLine("La suma total es: " + suma);
            return suma;

        }

        // Seccion Leches o lacteos Nº5

        struct precioproduct
        {
            public int Precio_Leche_Light;
            public int Precio_Leche_Deslactosada;
            public int Precio_Manjar_1Kl;
            public int Precio_Leche_Natural;
            public int Precio_Leche_Condensada;
            public int Precio_Leche_Evaporada;
            public int Precio_Queso_Premier;
            public int Precio_Yogurt_Delicia_Frutilla;
            public int Precio_Yogurt_Delicia_Durazno;
            public int Precio_Yogurt_Delicia_Coco;
            public int Precio_Mantequilla_Regia;
            public int Precio_Leche_en_Polvo;
            public int Precio_Helado_Pil;
            public int Precio_Helado_Norlan;

            //Frutas y verduras
            public int Precio_Manzana_Verde1kg;
            public int Precio_Chirimolla1kg;
            public int Precio_Durazno1kg;
            public int Precio_Frutilla1kg;
            public int Precio_Ciruelo1pqt;
            public int Precio_Mora1pqt;
            public int Precio_Uva1pqt;
            public int Precio_Arandanos1pqt;
            public int Precio_Limon1Kg;
            public int Precio_Sandia;
            public int Precio_Melon;
            public int Precio_Piña;
            public int Precio_Zanahoria1kg;
            public int Precio_Cebolla1kg;
            public int Precio_Tomate1kg;
            public int Precio_Navo1kg;
            public int Precio_Papa1Kg;
            public int Precio_Pimenton;
            public int Precio_Brocoli;
            public int Precio_Palta;


        }

        struct producto
        {
            //Lacteos
            public string Leche_Light;
            public string Leche_Deslactosada;
            public string Manjar_1Kl;
            public string Leche_Natural;
            public string Leche_Condensada;
            public string Leche_Evaporada;
            public string Queso_Premier;
            public string Yogurt_Delicia_Frutilla;
            public string Yogurt_Delicia_Durazno;
            public string Yogurt_Delicia_Coco;
            public string Mantequilla_Regia;
            public string Leche_en_Polvo;
            public string Helado_Pil;
            public string Helado_Norlan;
            public precioproduct precios;

            //Frutas y verduras
            public string Manzana_Verde1kg;
            public string Chirimolla1kg;
            public string Durazno1kg;
            public string Frutilla1kg;
            public string Ciruelo1pqt;
            public string Mora1pqt;
            public string Uva1pqt;
            public string Arandanos1pqt;
            public string Limon1Kg;
            public string Sandia;
            public string Melon;
            public string Piña;
            public string Zanahoria1kg;
            public string Cebolla1kg;
            public string Tomate1kg;
            public string Navo1kg;
            public string Papa1Kg;
            public string Pimenton;
            public string Brocoli;
            public string Palta;


        }


        public void Lacteos()
        {
            producto lacteos;

            lacteos.Leche_Light = " Leche Light ";
            lacteos.precios.Precio_Leche_Light = 7;

            lacteos.Leche_Deslactosada = " Leche Deslactosada ";
            lacteos.precios.Precio_Leche_Deslactosada = 8;

            lacteos.Manjar_1Kl = " Manjar 1Kg ";
            lacteos.precios.Precio_Manjar_1Kl = 35;

            lacteos.Leche_Natural = " Leche Natural ";
            lacteos.precios.Precio_Leche_Natural = 6;

            lacteos.Leche_Condensada = " Leche Condensada ";
            lacteos.precios.Precio_Leche_Condensada = 12;

            lacteos.Leche_Evaporada = " Leche Evaporada ";
            lacteos.precios.Precio_Leche_Evaporada = 13;

            lacteos.Queso_Premier = " Queso Premier ";
            lacteos.precios.Precio_Queso_Premier = 45;

            lacteos.Yogurt_Delicia_Frutilla = " Yogurt Delicia Frutilla ";
            lacteos.precios.Precio_Yogurt_Delicia_Frutilla = 15;

            lacteos.Yogurt_Delicia_Durazno = " Yogurt Delicia Durazno ";
            lacteos.precios.Precio_Yogurt_Delicia_Durazno = 15;

            lacteos.Yogurt_Delicia_Coco = " Yogurt Delicia Coco ";
            lacteos.precios.Precio_Yogurt_Delicia_Coco = 15;

            lacteos.Mantequilla_Regia = " Mantequilla_Regia ";
            lacteos.precios.Precio_Mantequilla_Regia = 20;

            lacteos.Leche_en_Polvo = " Leche_en_Polvo ";
            lacteos.precios.Precio_Leche_en_Polvo = 18;

            lacteos.Helado_Pil = " Helado Pil ";
            lacteos.precios.Precio_Helado_Pil = 20;

            lacteos.Helado_Norlan = " Helado_Norlan ";
            lacteos.precios.Precio_Helado_Norlan = 10;

            string respuesta = "";

            int suma = 0, suma1 = 0, suma2 = 0, suma3 = 0, suma4 = 0, suma5 = 0, suma6 = 0, suma7 = 0, suma8 = 0, suma9 = 0, suma10 = 0, suma11 = 0;
            int suma12 = 0, suma13 = 0, suma14 = 0;
            int cant = 0, cant1 = 0, cant2 = 0, cant3 = 0, cant4 = 0, cant5 = 0, cant6 = 0, cant7 = 0, cant8 = 0, cant9 = 0, cant10 = 0, cant11 = 0;
            int cant12 = 0, cant13 = 0, cant14 = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("                     Menú de Lacteos                                        ");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   1." + lacteos.Leche_Light + lacteos.precios.Precio_Leche_Light + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   2." + lacteos.Leche_Deslactosada + lacteos.precios.Precio_Leche_Deslactosada + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   3." + lacteos.Manjar_1Kl + lacteos.precios.Precio_Manjar_1Kl + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   4." + lacteos.Leche_Natural + lacteos.precios.Precio_Leche_Natural + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   5." + lacteos.Leche_Condensada + lacteos.precios.Precio_Leche_Condensada + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   6." + lacteos.Leche_Evaporada + lacteos.precios.Precio_Leche_Evaporada + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   7." + lacteos.Queso_Premier + lacteos.precios.Precio_Queso_Premier + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   8." + lacteos.Yogurt_Delicia_Frutilla + lacteos.precios.Precio_Yogurt_Delicia_Frutilla + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   9." + lacteos.Yogurt_Delicia_Durazno + lacteos.precios.Precio_Yogurt_Delicia_Durazno + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   10." + lacteos.Yogurt_Delicia_Coco + lacteos.precios.Precio_Yogurt_Delicia_Coco + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   11." + lacteos.Mantequilla_Regia + lacteos.precios.Precio_Mantequilla_Regia + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   12." + lacteos.Leche_en_Polvo + lacteos.precios.Precio_Leche_en_Polvo + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   13." + lacteos.Helado_Pil + lacteos.precios.Precio_Helado_Pil + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   14." + lacteos.Helado_Norlan + lacteos.precios.Precio_Helado_Norlan + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.Blue;
                int suma_lacteos = int.Parse(Console.ReadLine());

                switch (suma_lacteos)
                {
                    case 1:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Leche_Light + " que desea comprar");
                        cant1 = int.Parse(Console.ReadLine());
                        suma1 = lacteos.precios.Precio_Leche_Light * cant1;
                        suma = suma1 + suma;
                        cant = cant1 + cant;
                        Console.WriteLine("La suma es: " + suma1);

                        break;
                    case 2:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Leche_Deslactosada + " que desea comprar");
                        cant2 = int.Parse(Console.ReadLine());
                        suma2 = lacteos.precios.Precio_Leche_Deslactosada * cant2;
                        suma = suma2 + suma;
                        cant = cant2 + cant;
                        Console.WriteLine(" la suma es: " + suma2);

                        break;
                    case 3:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Manjar_1Kl + " que desea comprar");
                        cant3 = int.Parse(Console.ReadLine());
                        suma3 = lacteos.precios.Precio_Manjar_1Kl * cant3;
                        suma = suma3 + suma;
                        cant = cant3 + cant;
                        Console.WriteLine(" la suma es: " + suma3);

                        break;
                    case 4:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Leche_Natural + " que desea comprar");
                        cant4 = int.Parse(Console.ReadLine());
                        suma4 = lacteos.precios.Precio_Leche_Natural * cant4;
                        suma = suma4 + suma;
                        cant = cant4 + cant;
                        Console.WriteLine(" la suma es: " + suma4);

                        break;
                    case 5:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Leche_Condensada + " que desea comprar");
                        cant5 = int.Parse(Console.ReadLine());
                        suma5 = lacteos.precios.Precio_Leche_Condensada * cant5;
                        suma = suma5 + suma;
                        cant = cant5 + cant;
                        Console.WriteLine(" la suma es: " + suma5);

                        break;
                    case 6:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Leche_Evaporada + " que desea comprar");
                        cant6 = int.Parse(Console.ReadLine());
                        suma6 = lacteos.precios.Precio_Leche_Evaporada * cant6;
                        suma = suma6 + suma;
                        cant = cant6 + cant;
                        Console.WriteLine(" la suma es: " + suma6);

                        break;
                    case 7:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Queso_Premier + " que desea comprar");
                        cant7 = int.Parse(Console.ReadLine());
                        suma7 = lacteos.precios.Precio_Queso_Premier * cant7;
                        suma = suma7 + suma;
                        cant = cant7 + cant;
                        Console.WriteLine(" la suma es: " + suma7);

                        break;
                    case 8:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Yogurt_Delicia_Frutilla + " que desea comprar");
                        cant8 = int.Parse(Console.ReadLine());
                        suma8 = lacteos.precios.Precio_Yogurt_Delicia_Frutilla * cant8;
                        suma = suma8 + suma;
                        cant = cant8 + cant;
                        Console.WriteLine(" la suma es: " + suma8);

                        break;
                    case 9:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Yogurt_Delicia_Durazno + " que desea comprar");
                        cant9 = int.Parse(Console.ReadLine());
                        suma9 = lacteos.precios.Precio_Yogurt_Delicia_Durazno * cant9;
                        suma = suma9 + suma;
                        cant = cant9 + cant;
                        Console.WriteLine(" la suma es: " + suma9);

                        break;
                    case 10:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Yogurt_Delicia_Coco + " que desea comprar");
                        cant10 = int.Parse(Console.ReadLine());
                        suma10 = lacteos.precios.Precio_Yogurt_Delicia_Coco * cant10;
                        suma = suma10 + suma;
                        cant = cant10 + cant;
                        Console.WriteLine(" la suma es: " + suma10);
                        break;

                    case 11:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Mantequilla_Regia + " que desea comprar");
                        cant11 = int.Parse(Console.ReadLine());
                        suma11 = lacteos.precios.Precio_Mantequilla_Regia * cant11;
                        suma = suma11 + suma;
                        cant = cant11 + cant;
                        Console.WriteLine(" la suma es: " + suma11);
                        break;

                    case 12:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Leche_en_Polvo + " que desea comprar");
                        cant12 = int.Parse(Console.ReadLine());
                        suma12 = lacteos.precios.Precio_Leche_en_Polvo * cant12;
                        suma = suma12 + suma;
                        cant = cant12 + cant;
                        Console.WriteLine(" la suma es: " + suma12);
                        break;

                    case 13:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Helado_Pil + " que desea comprar");
                        cant13 = int.Parse(Console.ReadLine());
                        suma13 = lacteos.precios.Precio_Helado_Pil * cant13;
                        suma = suma13 + suma;
                        cant = cant13 + cant;
                        Console.WriteLine(" la suma es: " + suma13);
                        break;

                    case 14:
                        Console.WriteLine("Ingrese la cantidad de " + lacteos.Helado_Norlan + " que desea comprar");
                        cant14 = int.Parse(Console.ReadLine());
                        suma14 = lacteos.precios.Precio_Helado_Norlan * cant14;
                        suma = suma14 + suma;
                        cant = cant14 + cant;
                        Console.WriteLine(" la suma es: " + suma14);
                        break;

                }

                Console.WriteLine("Desea continuar: si o no");
                respuesta = Console.ReadLine();

            } while (respuesta != "no");
            Console.Clear();

            string carpeta = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\CantidadLacteosAdmi.txt", carpeta2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\CantidadLacteosCliente.txt";

            using (StreamWriter archivo = File.CreateText(carpeta2))
            {
                if (cant1 > 0)
                {
                    archivo.WriteLine("   1." + lacteos.Leche_Light + " Cantidad vendida: " + cant1);

                }

                if (cant2 > 0)
                {
                    archivo.WriteLine("   2." + lacteos.Leche_Deslactosada + " Cantidad vendida: " + cant2);
                }

                if (cant3 > 0)
                {
                    archivo.WriteLine("   3." + lacteos.Manjar_1Kl + " Cantidad vendida: " + cant3);
                }

                if (cant4 > 0)
                {
                    archivo.WriteLine("   4." + lacteos.Leche_Natural + " Cantidad vendida: " + cant4);
                }

                if (cant5 > 0)
                {
                    archivo.WriteLine("   5." + lacteos.Leche_Condensada + " Cantidad vendida: " + cant5);
                }

                if (cant6 > 0)
                {
                    archivo.WriteLine("   6." + lacteos.Leche_Evaporada + " Cantidad vendida: " + cant6);
                }

                if (cant7 > 0)
                {
                    archivo.WriteLine("   7." + lacteos.Queso_Premier + " Cantidad vendida: " + cant7);
                }

                if (cant8 > 0)
                {
                    archivo.WriteLine("   8." + lacteos.Yogurt_Delicia_Frutilla + " Cantidad vendida: " + cant8);
                }

                if (cant9 > 0)
                {
                    archivo.WriteLine("   9." + lacteos.Yogurt_Delicia_Durazno + " Cantidad vendida: " + cant9);
                }

                if (cant10 > 0)
                {
                    archivo.WriteLine("   10." + lacteos.Yogurt_Delicia_Coco + " Cantidad vendida: " + cant10);
                }

                if (cant11 > 0)
                {
                    archivo.WriteLine("   11." + lacteos.Mantequilla_Regia + " Cantidad vendida: " + cant11);
                }

                if (cant12 > 0)
                {
                    archivo.WriteLine("   12." + lacteos.Leche_en_Polvo + " Cantidad vendida: " + cant12);
                }

                if (cant13 > 0)
                {
                    archivo.WriteLine("   13." + lacteos.Helado_Pil + " Cantidad vendida: " + cant13);
                }

                if (cant14 > 0)
                {
                    archivo.WriteLine("   14." + lacteos.Helado_Norlan + " Cantidad vendida: " + cant14);
                }

            }
            using (StreamWriter archivo = File.AppendText(carpeta))
            {
                archivo.WriteLine("   1." + lacteos.Leche_Light + " Cantidad vendida: " + cant1 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   2." + lacteos.Leche_Deslactosada + " Cantidad vendida: " + cant2 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   3." + lacteos.Manjar_1Kl + " Cantidad vendida: " + cant3 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   4." + lacteos.Leche_Natural + " Cantidad vendida: " + cant4 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   5." + lacteos.Leche_Condensada + " Cantidad vendida: " + cant5 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   6." + lacteos.Leche_Evaporada + " Cantidad vendida: " + cant6 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   7." + lacteos.Queso_Premier + " Cantidad vendida: " + cant7 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   8." + lacteos.Yogurt_Delicia_Frutilla + " Cantidad vendida: " + cant8 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   9." + lacteos.Yogurt_Delicia_Durazno + " Cantidad vendida: " + cant9 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   10." + lacteos.Yogurt_Delicia_Coco + " Cantidad vendida: " + cant10 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   11." + lacteos.Mantequilla_Regia + " Cantidad vendida: " + cant11 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   12." + lacteos.Leche_en_Polvo + " Cantidad vendida: " + cant12 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   13." + lacteos.Helado_Pil + " Cantidad vendida: " + cant13 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   14." + lacteos.Helado_Norlan + " Cantidad vendida: " + cant14 +
                     "\n|----------------------------------------------------------------------------");
                 archivo.WriteLine("\nLa cantidad de productos vendidos fue: " + cant +
                     "\nLa suma total es: " + suma);
            }

        }

        public void Verduras()
        {
            producto verduras;

            verduras.Manzana_Verde1kg = " Manzana Verde 1kg ";
            verduras.precios.Precio_Manzana_Verde1kg = 10;

            verduras.Chirimolla1kg = " Chirimolla 1kg ";
            verduras.precios.Precio_Chirimolla1kg = 20;

            verduras.Durazno1kg = " Durazno 1kg ";
            verduras.precios.Precio_Durazno1kg = 15;

            verduras.Frutilla1kg = " Frutilla 1 paquete ";
            verduras.precios.Precio_Frutilla1kg = 10;

            verduras.Ciruelo1pqt = " Ciruelo 1 paquete ";
            verduras.precios.Precio_Ciruelo1pqt = 8;

            verduras.Mora1pqt = " Mora 1 paquete ";
            verduras.precios.Precio_Mora1pqt = 15;

            verduras.Uva1pqt = " Uva 1 paquete ";
            verduras.precios.Precio_Uva1pqt = 14;

            verduras.Arandanos1pqt = " Arandanos ";
            verduras.precios.Precio_Arandanos1pqt = 17;

            verduras.Limon1Kg = " Limón 1kg ";
            verduras.precios.Precio_Limon1Kg = 12;

            verduras.Sandia = " Sandía ";
            verduras.precios.Precio_Sandia = 32;

            verduras.Melon = " Melón ";
            verduras.precios.Precio_Melon = 10;

            verduras.Piña = " Piña ";
            verduras.precios.Precio_Piña = 10;

            verduras.Zanahoria1kg = " Zanahoria 1kg ";
            verduras.precios.Precio_Zanahoria1kg = 6;

            verduras.Cebolla1kg = " Cebolla 1kg ";
            verduras.precios.Precio_Cebolla1kg = 7;

            verduras.Tomate1kg = " Tomate 1 kg ";
            verduras.precios.Precio_Tomate1kg = 5;

            verduras.Navo1kg = " Navo 1 kg ";
            verduras.precios.Precio_Navo1kg = 8;

            verduras.Papa1Kg = " Papa 1kg ";
            verduras.precios.Precio_Papa1Kg = 12;

            verduras.Pimenton = " Pimentón ";
            verduras.precios.Precio_Pimenton = 5;

            verduras.Brocoli = " Brocoli ";
            verduras.precios.Precio_Brocoli = 9;

            verduras.Palta = " Palta ";
            verduras.precios.Precio_Palta = 10;

            string respuesta = "";

            int suma = 0, suma1 = 0, suma2 = 0, suma3 = 0, suma4 = 0, suma5 = 0, suma6 = 0, suma7 = 0, suma8 = 0, suma9 = 0, suma10 = 0, suma11 = 0;
            int suma12 = 0, suma13 = 0, suma14 = 0, suma15 = 0, suma16 = 0, suma17 = 0, suma18 = 0, suma19 = 0, suma20 = 0; ;
            int cant = 0, cant1 = 0, cant2 = 0, cant3 = 0, cant4 = 0, cant5 = 0, cant6 = 0, cant7 = 0, cant8 = 0, cant9 = 0, cant10 = 0, cant11 = 0;
            int cant12 = 0, cant13 = 0, cant14 = 0, cant15 = 0, cant16 = 0, cant17 = 0, cant18 = 0, cant19 = 0, cant20 = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("                     Menú de Frutas y Verduras                                       ");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   1." + verduras.Manzana_Verde1kg + verduras.precios.Precio_Manzana_Verde1kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   2." + verduras.Chirimolla1kg + verduras.precios.Precio_Chirimolla1kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   3." + verduras.Durazno1kg + verduras.precios.Precio_Durazno1kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   4." + verduras.Frutilla1kg + verduras.precios.Precio_Frutilla1kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   5." + verduras.Ciruelo1pqt + verduras.precios.Precio_Ciruelo1pqt + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   6." + verduras.Mora1pqt + verduras.precios.Precio_Mora1pqt + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   7." + verduras.Uva1pqt + verduras.precios.Precio_Uva1pqt + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   8." + verduras.Arandanos1pqt + verduras.precios.Precio_Arandanos1pqt + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   9." + verduras.Limon1Kg + verduras.precios.Precio_Limon1Kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   10." + verduras.Sandia + verduras.precios.Precio_Sandia + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   11." + verduras.Melon + verduras.precios.Precio_Melon + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   12." + verduras.Piña + verduras.precios.Precio_Piña + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   13." + verduras.Zanahoria1kg + verduras.precios.Precio_Zanahoria1kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   14." + verduras.Cebolla1kg + verduras.precios.Precio_Cebolla1kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   15." + verduras.Tomate1kg + verduras.precios.Precio_Tomate1kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   16." + verduras.Navo1kg + verduras.precios.Precio_Navo1kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   17." + verduras.Papa1Kg + verduras.precios.Precio_Papa1Kg + " Bs");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   18." + verduras.Pimenton + verduras.precios.Precio_Pimenton + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   19." + verduras.Brocoli + verduras.precios.Precio_Brocoli + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("   20." + verduras.Palta + verduras.precios.Precio_Palta + " Bs (p/u)");
                Console.WriteLine("----------------------------------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.Yellow;
                int suma_verduras = int.Parse(Console.ReadLine());


                switch (suma_verduras)
                {

                    case 1:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Manzana_Verde1kg + " que desea comprar");
                        cant1 = int.Parse(Console.ReadLine());
                        suma1 = verduras.precios.Precio_Manzana_Verde1kg * cant1;
                        suma = suma1 + suma;
                        cant = cant1 + cant;
                        Console.WriteLine(" la suma es: " + suma1);

                        break;
                    case 2:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Chirimolla1kg + " que desea comprar");
                        cant2 = int.Parse(Console.ReadLine());
                        suma2 = verduras.precios.Precio_Chirimolla1kg * cant2;
                        suma = suma2 + suma;
                        cant = cant2 + cant;
                        Console.WriteLine(" la suma es: " + suma2);

                        break;
                    case 3:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Durazno1kg + " que desea comprar");
                        cant3 = int.Parse(Console.ReadLine());
                        suma3 = verduras.precios.Precio_Durazno1kg * cant3;
                        suma = suma3 + suma;
                        cant = cant3 + cant;
                        Console.WriteLine(" la suma es: " + suma3);

                        break;
                    case 4:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Frutilla1kg + " que desea comprar");
                        cant4 = int.Parse(Console.ReadLine());
                        suma4 = verduras.precios.Precio_Frutilla1kg * cant4;
                        suma = suma4 + suma;
                        cant = cant4 + cant;
                        Console.WriteLine(" la suma es: " + suma4);

                        break;
                    case 5:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Ciruelo1pqt + " que desea comprar");
                        cant5 = int.Parse(Console.ReadLine());
                        suma5 = verduras.precios.Precio_Ciruelo1pqt * cant5;
                        suma = suma5 + suma;
                        cant = cant5 + cant;
                        Console.WriteLine(" la suma es: " + suma5);

                        break;
                    case 6:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Mora1pqt + " que desea comprar");
                        cant6 = int.Parse(Console.ReadLine());
                        suma6 = verduras.precios.Precio_Mora1pqt * cant6;
                        suma = suma6 + suma;
                        cant = cant6 + cant;
                        Console.WriteLine(" la suma es: " + suma6);

                        break;
                    case 7:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Uva1pqt + " que desea comprar");
                        cant7 = int.Parse(Console.ReadLine());
                        suma7 = verduras.precios.Precio_Uva1pqt * cant7;
                        suma = suma7 + suma;
                        cant = cant7 + cant;
                        Console.WriteLine(" la suma es: " + suma7);

                        break;
                    case 8:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Arandanos1pqt + " que desea comprar");
                        cant8 = int.Parse(Console.ReadLine());
                        suma8 = verduras.precios.Precio_Arandanos1pqt * cant8;
                        suma = suma8 + suma;
                        cant = cant8 + cant;
                        Console.WriteLine(" la suma es: " + suma8);

                        break;
                    case 9:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Limon1Kg + " que desea comprar");
                        cant9 = int.Parse(Console.ReadLine());
                        suma9 = verduras.precios.Precio_Limon1Kg * cant9;
                        suma = suma9 + suma;
                        cant = cant9 + cant;
                        Console.WriteLine(" la suma es: " + suma9);

                        break;
                    case 10:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Sandia + " que desea comprar");
                        cant10 = int.Parse(Console.ReadLine());
                        suma10 = verduras.precios.Precio_Sandia * cant10;
                        suma = suma10 + suma;
                        cant = cant10 + cant;
                        Console.WriteLine(" la suma es: " + suma10);
                        break;

                    case 11:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Melon + " que desea comprar");
                        cant11 = int.Parse(Console.ReadLine());
                        suma11 = verduras.precios.Precio_Melon * cant11;
                        suma = suma11 + suma;
                        cant = cant11 + cant;
                        Console.WriteLine(" la suma es: " + suma11);
                        break;

                    case 12:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Piña + " que desea comprar");
                        cant12 = int.Parse(Console.ReadLine());
                        suma12 = verduras.precios.Precio_Piña * cant12;
                        suma = suma12 + suma;
                        cant = cant12 + cant;
                        Console.WriteLine(" la suma es: " + suma12);
                        break;

                    case 13:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Zanahoria1kg + " que desea comprar");
                        cant13 = int.Parse(Console.ReadLine());
                        suma13 = verduras.precios.Precio_Zanahoria1kg * cant13;
                        suma = suma13 + suma;
                        cant = cant13 + cant;
                        Console.WriteLine(" la suma es: " + suma13);
                        break;

                    case 14:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Cebolla1kg + " que desea comprar");
                        cant14 = int.Parse(Console.ReadLine());
                        suma14 = verduras.precios.Precio_Cebolla1kg * cant14;
                        suma = suma14 + suma;
                        cant = cant14 + cant;
                        Console.WriteLine(" la suma es: " + suma14);
                        break;

                    case 15:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Tomate1kg + " que desea comprar");
                        cant15 = int.Parse(Console.ReadLine());
                        suma15 = verduras.precios.Precio_Tomate1kg * cant15;
                        suma = suma15 + suma;
                        cant = cant15 + cant;
                        Console.WriteLine(" la suma es: " + suma15);

                        break;

                    case 16:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Navo1kg + " que desea comprar");
                        cant16 = int.Parse(Console.ReadLine());
                        suma16 = verduras.precios.Precio_Navo1kg * cant16;
                        suma = suma16 + suma;
                        cant = cant16 + cant;
                        Console.WriteLine(" la suma es: " + suma16);
                        break;

                    case 17:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Papa1Kg + " que desea comprar");
                        cant17 = int.Parse(Console.ReadLine());
                        suma17 = verduras.precios.Precio_Papa1Kg * cant17;
                        suma = suma17 + suma;
                        cant = cant17 + cant;
                        Console.WriteLine(" la suma es: " + suma17);
                        break;

                    case 18:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Pimenton + " que desea comprar");
                        cant18 = int.Parse(Console.ReadLine());
                        suma18 = verduras.precios.Precio_Pimenton * cant18;
                        suma = suma18 + suma;
                        cant = cant18 + cant;
                        Console.WriteLine(" la suma es: " + suma18);
                        break;

                    case 19:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Brocoli + " que desea comprar");
                        cant19 = int.Parse(Console.ReadLine());
                        suma19 = verduras.precios.Precio_Brocoli * cant19;
                        suma = suma19 + suma;
                        cant = cant19 + cant;
                        Console.WriteLine(" la suma es: " + suma19);

                        break;
                    case 20:
                        Console.WriteLine("Ingrese la cantidad de " + verduras.Palta + " que desea comprar");
                        cant20 = int.Parse(Console.ReadLine());
                        suma20 = verduras.precios.Precio_Palta * cant20;
                        suma = suma20 + suma;
                        cant = cant20 + cant;
                        Console.WriteLine(" la suma es: " + suma20);
                        break;

                }
                Console.WriteLine("Desea continuar: si o no");
                respuesta = Console.ReadLine();

            } while (respuesta != "no");
            Console.Clear();

            string carpeta = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\CantidadVerdurasAdmi.txt", carpeta2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\CantidadVerdurasCliente.txt";

            using (StreamWriter archivo = File.CreateText(carpeta2))
            {
                if (cant1 > 0)
                {
                    archivo.WriteLine("   1." + verduras.Manzana_Verde1kg + " Cantidad vendida: " + cant1);

                }

                if (cant2 > 0)
                {
                    archivo.WriteLine("   2." + verduras.Chirimolla1kg + " Cantidad vendida: " + cant2);
                }

                if (cant3 > 0)
                {
                    archivo.WriteLine("   3." + verduras.Durazno1kg + " Cantidad vendida: " + cant3);
                }

                if (cant4 > 0)
                {
                    archivo.WriteLine("   4." + verduras.Frutilla1kg + " Cantidad vendida: " + cant4);
                }

                if (cant5 > 0)
                {
                    archivo.WriteLine("   5." + verduras.Ciruelo1pqt + " Cantidad vendida: " + cant5);
                }

                if (cant6 > 0)
                {
                    archivo.WriteLine("   6." + verduras.Mora1pqt + " Cantidad vendida: " + cant6);
                }

                if (cant7 > 0)
                {
                    archivo.WriteLine("   7." + verduras.Uva1pqt + " Cantidad vendida: " + cant7);
                }

                if (cant8 > 0)
                {
                    archivo.WriteLine("   8." + verduras.Arandanos1pqt + " Cantidad vendida: " + cant8);
                }

                if (cant9 > 0)
                {
                    archivo.WriteLine("   9." + verduras.Limon1Kg + " Cantidad vendida: " + cant9);
                }

                if (cant10 > 0)
                {
                    archivo.WriteLine("   10." + verduras.Sandia + " Cantidad vendida: " + cant10);
                }

                if (cant11 > 0)
                {
                    archivo.WriteLine("   11." + verduras.Melon + " Cantidad vendida: " + cant11);
                }

                if (cant12 > 0)
                {
                    archivo.WriteLine("   12." + verduras.Piña + " Cantidad vendida: " + cant12);
                }

                if (cant13 > 0)
                {
                    archivo.WriteLine("   13." + verduras.Zanahoria1kg + " Cantidad vendida: " + cant13);
                }

                if (cant14 > 0)
                {
                    archivo.WriteLine("   14." + verduras.Cebolla1kg + " Cantidad vendida: " + cant14);
                }

                if (cant15 > 0)
                {
                    archivo.WriteLine("   15." + verduras.Tomate1kg + " Cantidad vendida: " + cant15);
                }

                if (cant16 > 0)
                {
                    archivo.WriteLine("   16." + verduras.Navo1kg + " Cantidad vendida: " + cant16);
                }

                if (cant17 > 0)
                {
                    archivo.WriteLine("   17." + verduras.Papa1Kg + " Cantidad vendida: " + cant17);
                }

                if (cant18 > 0)
                {
                    archivo.WriteLine("   18." + verduras.Pimenton + " Cantidad vendida: " + cant18);
                }

                if (cant19 > 0)
                {
                    archivo.WriteLine("   19." + verduras.Brocoli + " Cantidad vendida: " + cant19);
                }

                if (cant20 > 0)
                {
                    archivo.WriteLine("   20." + verduras.Palta + " Cantidad vendida: " + cant20);
                }

            }
            using (StreamWriter archivo = File.AppendText(carpeta))
            {
                archivo.WriteLine("   1." + verduras.Manzana_Verde1kg + " Cantidad vendida: " + cant1+
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   2." + verduras.Chirimolla1kg + " Cantidad vendida: " + cant2 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   3." + verduras.Durazno1kg + " Cantidad vendida: " + cant3 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   4." + verduras.Frutilla1kg + " Cantidad vendida: " + cant4 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   5." + verduras.Ciruelo1pqt + " Cantidad vendida: " + cant5 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   6." + verduras.Mora1pqt + " Cantidad vendida: " + cant6 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   7." + verduras.Uva1pqt + " Cantidad vendida: " + cant7 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   8." + verduras.Arandanos1pqt + " Cantidad vendida: " + cant8 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   9." + verduras.Limon1Kg + " Cantidad vendida: " + cant9 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   10." + verduras.Sandia + " Cantidad vendida: " + cant10 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   11." + verduras.Melon + " Cantidad vendida: " + cant11 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   12." + verduras.Piña + " Cantidad vendida: " + cant12 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   13." + verduras.Zanahoria1kg + " Cantidad vendida: " + cant13 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   14." + verduras.Cebolla1kg + " Cantidad vendida: " + cant14 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   15." + verduras.Tomate1kg + " Cantidad vendida: " + cant15 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   16." + verduras.Navo1kg + " Cantidad vendida: " + cant16 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   17." + verduras.Papa1Kg + " Cantidad vendida: " + cant17 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   18." + verduras.Pimenton + " Cantidad vendida: " + cant18 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   19." + verduras.Brocoli + " Cantidad vendida: " + cant19 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("   20." + verduras.Palta + " Cantidad vendida: " + cant20 +
                     "\n|----------------------------------------------------------------------------");
                archivo.WriteLine("\nLa cantidad de productos vendidos fue: " + cant +
                     "\nLa suma total es: " + suma);

            }

        }

        // Seccion Dulces Y Galletas Nº7
        struct dulce_galletas
        {
            public string club_social;
            public string gauchitas;
            public string moraditas;
            public string maria;
            public string oreo;
            public string papas_pequeñas;
            public string crackers;
            public string choco_soda;
            public string wafers;
            public string choco_chip;
            public string salvado;
            public string san_gabriel;
            public string papas_grande;
            public string chocolate_bauducco;
            public string bom_bom;
            public string ferrari_integral;
            public string agua;
            public precio_galletas precio;

        }
        struct precio_galletas
        {
            public int club_social;
            public int gauchitas;
            public int moraditas;
            public int maria;
            public int oreo;
            public int papas_pequeñas;
            public int crackers;
            public int choco_soda;
            public int wafers;
            public int choco_chip;
            public int salvado;
            public int san_gabriel;
            public int papas_grande;
            public int chocolate_bauducco;
            public int bom_bom;
            public int ferrari_integral;
            public int agua;
        }

        static int galletas()
        {
            dulce_galletas galletas;
            galletas.club_social = "  1.- Club Social 2 bs";
            galletas.precio.club_social = 2;
            galletas.gauchitas = "  2.- Gauchitas 4 bs";
            galletas.precio.gauchitas = 4;
            galletas.moraditas = "  3.- Moraditas 4 bs";
            galletas.precio.moraditas = 4;
            galletas.maria = "  4.- Maria 4 bs";
            galletas.precio.maria = 4;
            galletas.oreo = "  5.- Oreo 4 bs";
            galletas.precio.oreo = 4;
            galletas.papas_pequeñas = "  6.- Papas Fritas (pequeño) 6 bs";
            galletas.precio.papas_pequeñas = 6;
            galletas.crackers = "  7.- Crackers 6 bs";
            galletas.precio.crackers = 6;
            galletas.choco_soda = "  8.- Choco Soda 6 bs";
            galletas.precio.choco_soda = 6;
            galletas.wafers = "  9.- Wafers 6 bs";
            galletas.precio.wafers = 6;
            galletas.choco_chip = "  10.- Choco Chip 8 bs";
            galletas.precio.choco_chip = 8;
            galletas.salvado = " 11.- Salvado 10 bs";
            galletas.precio.salvado = 10;
            galletas.san_gabriel = " 12.- San Gabriel 20 bs";
            galletas.precio.san_gabriel = 20;
            galletas.papas_grande = " 13.- Papas Fritas (grande) 12 bs";
            galletas.precio.papas_grande = 12;
            galletas.bom_bom = " 14.- Bom o Bom (1caja) 20 bs";
            galletas.precio.bom_bom = 20;
            galletas.ferrari_integral = " 15.- Ferrari Integral 30 bs";
            galletas.precio.ferrari_integral = 30;
            galletas.agua = " 16.- Galleta de Agua 20 bs";
            galletas.precio.agua = 20;
            galletas.chocolate_bauducco = " 17.- Chocolate Bauducco (Italiano) 40 bs";
            galletas.precio.chocolate_bauducco = 40;

            string respuesta = "";

            int suma = 0, suma1 = 0, suma2 = 0, suma3 = 0, suma4 = 0, suma5 = 0, suma6 = 0, suma7 = 0, suma8 = 0, suma9 = 0, suma10 = 0, suma11 = 0;
            int suma12 = 0, suma13 = 0, suma14 = 0, suma15 = 0, suma16 = 0, suma17 = 0, suma18 = 0, suma19 = 0, suma20 = 0; ;
            int cant = 0, cant1 = 0, cant2 = 0, cant3 = 0, cant4 = 0, cant5 = 0, cant6 = 0, cant7 = 0, cant8 = 0, cant9 = 0, cant10 = 0, cant11 = 0;
            int cant12 = 0, cant13 = 0, cant14 = 0, cant15 = 0, cant16 = 0, cant17 = 0, cant18 = 0, cant19 = 0, cant20 = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("                        Menú Galletas Y Dulces                              ");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.club_social);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.gauchitas);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.moraditas);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.maria);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.oreo);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.papas_pequeñas);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.crackers);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.choco_soda);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.wafers);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.choco_chip);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.salvado);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.san_gabriel);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.papas_grande);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.bom_bom);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.ferrari_integral);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.agua);
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(galletas.chocolate_bauducco);
                Console.WriteLine("----------------------------------------------------------------------------");
                int opcionalchol = int.Parse(Console.ReadLine());
                switch (opcionalchol)
                {
                    case 1:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant1 = int.Parse(Console.ReadLine());
                            suma1 = galletas.precio.club_social * cant1;
                            suma = suma1 + suma;
                            cant = cant1 + cant;
                            Console.WriteLine(" la suma es: " + suma1);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant2 = int.Parse(Console.ReadLine());
                            suma2 = galletas.precio.gauchitas * cant2;
                            suma = suma2 + suma;
                            cant = cant2 + cant;
                            Console.WriteLine(" la suma es: " + suma2);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant3 = int.Parse(Console.ReadLine());
                            suma3 = galletas.precio.moraditas * cant3;
                            suma = suma3 + suma;
                            cant = cant3 + cant;
                            Console.WriteLine(" la suma es: " + suma3);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant4 = int.Parse(Console.ReadLine());
                            suma4 = galletas.precio.maria * cant4;
                            suma = suma4 + suma;
                            cant = cant4 + cant;
                            Console.WriteLine(" la suma es: " + suma4);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant5 = int.Parse(Console.ReadLine());
                            suma5 = galletas.precio.oreo * cant5;
                            suma = suma5 + suma;
                            cant = cant5 + cant;
                            Console.WriteLine(" la suma es: " + suma5);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant6 = int.Parse(Console.ReadLine());
                            suma6 = galletas.precio.papas_pequeñas * cant6;
                            suma = suma6 + suma;
                            cant = cant6 + cant;
                            Console.WriteLine(" la suma es: " + suma6);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant7 = int.Parse(Console.ReadLine());
                            suma7 = galletas.precio.crackers * cant7;
                            suma = suma7 + suma;
                            cant = cant7 + cant;
                            Console.WriteLine(" la suma es: " + suma7);

                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant8 = int.Parse(Console.ReadLine());
                            suma8 = galletas.precio.choco_soda * cant8;
                            suma = suma8 + suma;
                            cant = cant8 + cant;
                            Console.WriteLine(" la suma es: " + suma8);

                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant9 = int.Parse(Console.ReadLine());
                            suma9 = galletas.precio.wafers * cant9;
                            suma = suma9 + suma;
                            cant = cant9 + cant;
                            Console.WriteLine(" la suma es: " + suma9);

                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant10 = int.Parse(Console.ReadLine());
                            suma10 = galletas.precio.choco_chip * cant10;
                            suma = suma10 + suma;
                            cant = cant10 + cant;
                            Console.WriteLine(" la suma es: " + suma10);
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant11 = int.Parse(Console.ReadLine());
                            suma11 = galletas.precio.salvado * cant11;
                            suma = suma11 + suma;
                            cant = cant11 + cant;
                            Console.WriteLine(" la suma es: " + suma11);
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant12 = int.Parse(Console.ReadLine());
                            suma12 = galletas.precio.san_gabriel * cant12;
                            suma = suma12 + suma;
                            cant = cant12 + cant;
                            Console.WriteLine(" la suma es: " + suma12);
                            break;
                        }
                    case 13:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant13 = int.Parse(Console.ReadLine());
                            suma13 = galletas.precio.papas_grande * cant13;
                            suma = suma13 + suma;
                            cant = cant13 + cant;
                            Console.WriteLine(" la suma es: " + suma13);
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant14 = int.Parse(Console.ReadLine());
                            suma14 = galletas.precio.bom_bom * cant14;
                            suma = suma14 + suma;
                            cant = cant14 + cant;
                            Console.WriteLine(" la suma es: " + suma14);
                            break;
                        }
                    case 15:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant15 = int.Parse(Console.ReadLine());
                            suma15 = galletas.precio.ferrari_integral * cant15;
                            suma = suma15 + suma;
                            cant = cant15 + cant;
                            Console.WriteLine(" la suma es: " + suma15);

                            break;
                        }
                    case 16:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant16 = int.Parse(Console.ReadLine());
                            suma16 = galletas.precio.agua * cant16;
                            suma = suma16 + suma;
                            cant = cant16 + cant;
                            Console.WriteLine(" la suma es: " + suma16);
                            break;
                        }
                    case 17:
                        {
                            Console.WriteLine("ingrese la cantidad");
                            cant17 = int.Parse(Console.ReadLine());
                            suma17 = galletas.precio.chocolate_bauducco * cant17;
                            suma = suma17 + suma;
                            cant = cant17 + cant;
                            Console.WriteLine(" la suma es: " + suma17);
                            break;
                        }
                }
                Console.WriteLine("Desea continuar: si o no");

                respuesta = Console.ReadLine();
            } while (respuesta != "no");
            Console.Clear();

            string ruta = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\cantidadgalletas.txt", ruta2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\cantidadgalletascliente.txt";

            using (StreamWriter archivo = File.CreateText(ruta2))
            {
                if (cant1 > 0)
                {
                    archivo.WriteLine(galletas.club_social + " Cantidad vendida: " + cant1);
                }
                if (cant2 > 0)
                {
                    archivo.WriteLine(galletas.gauchitas + " Cantidad vendida: " + cant2);
                }
                if (cant3 > 0)
                {
                    archivo.WriteLine(galletas.moraditas + " Cantidad vendida: " + cant3);
                }
                if (cant4 > 0)
                {
                    archivo.WriteLine(galletas.maria + " Cantidad vendida: " + cant4);
                }
                if (cant5 > 0)
                {
                    archivo.WriteLine(galletas.oreo + " Cantidad vendida: " + cant5);
                }
                if (cant6 > 0)
                {
                    archivo.WriteLine(galletas.papas_pequeñas + " Cantidad vendida: " + cant6);
                }
                if (cant7 > 0)
                {
                    archivo.WriteLine(galletas.crackers + " Cantidad vendida: " + cant7);
                }
                if (cant8 > 0)
                {
                    archivo.WriteLine(galletas.choco_soda + " Cantidad vendida: " + cant8);
                }
                if (cant9 > 0)
                {
                    archivo.WriteLine(galletas.wafers + " Cantidad vendida: " + cant9);
                }
                if (cant10 > 0)
                {
                    archivo.WriteLine(galletas.choco_chip + " Cantidad vendida: " + cant10);
                }
                if (cant11 > 0)
                {
                    archivo.WriteLine(galletas.salvado + " Cantidad vendida: " + cant11);
                }
                if (cant12 > 0)
                {
                    archivo.WriteLine(galletas.san_gabriel + " Cantidad vendida: " + cant12);
                }
                if (cant13 > 0)
                {
                    archivo.WriteLine(galletas.papas_grande + " Cantidad vendida: " + cant13);
                }
                if (cant14 > 0)
                {
                    archivo.WriteLine(galletas.bom_bom + " Cantidad vendida: " + cant14);
                }
                if (cant15 > 0)
                {
                    archivo.WriteLine(galletas.ferrari_integral + " Cantidad vendida: " + cant15);
                }
                if (cant16 > 0)
                {
                    archivo.WriteLine(galletas.agua + " Cantidad vendida: " + cant16);
                }
                if (cant17 > 0)
                {
                    archivo.WriteLine(galletas.chocolate_bauducco + " Cantidad vendida: " + cant17);
                }
            }
            using (StreamWriter archivo = File.AppendText(ruta))
            {
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine("               Lista: cantidad de productos vendidos                        ");
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.club_social + " Cantidad vendida:" + cant1);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.gauchitas + " Cantidad vendida: " + cant2);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.moraditas + " Cantidad vendida: " + cant3);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.maria + " Cantidad vendida: " + cant4);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.oreo + " Cantidad vendida: " + cant5);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.papas_pequeñas + " Cantidad vendida: " + cant6);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.crackers + " Cantidad vendida: " + cant7);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.choco_soda + " Cantidad vendida: " + cant8);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.wafers + " Cantidad vendida: " + cant9);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.choco_chip + " Cantidad vendida: " + cant10);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.salvado + " Cantidad vendida: " + cant11);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.san_gabriel + " Cantidad vendida: " + cant12);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.papas_grande + " Cantidad vendida: " + cant13);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.bom_bom + " Cantidad vendida: " + cant14);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.ferrari_integral + " Cantidad vendida: " + cant15);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.agua + " Cantidad vendida: " + cant16);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine(galletas.chocolate_bauducco + " Cantidad vendida: " + cant17);
                archivo.WriteLine("----------------------------------------------------------------------------");
                archivo.WriteLine("La suma total es: " + suma);
                archivo.WriteLine("----------------------------------------------------------------------------");
            }
            Console.WriteLine("La cantidad total es:" + cant);
            Console.WriteLine("La suma total es: " + suma);

            return suma;
        }

        static void Main(string[] args)
        {

            clientes persona;            
            bool bandera = false;
            bool bandera2 = false;
            bool bandera3 = false;
            bool bandera4 = false;
            bool bandera5 = false;
            bool bandera6 = false;
            bool bandera7 = false;

            Console.WriteLine("Ingrese cuantos clientes son: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese su nombre: ");
                persona.nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su numero de referencia: ");
                persona.numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su numero NIT: ");
                persona.nit = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su Email: ");
                persona.email = Console.ReadLine();




                string continuar, cant = "";
                int menu_principal = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("   ---> Bienvenido al Mini-Super Mercado  KARMALAND V.1.1 <---    ");
                Console.WriteLine("------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine(" --> Seleccione una seccion para relizar compras <-- ");
                Console.WriteLine("------------------------------------------------------------------");
                do
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("                    ---> Menú de Secciones <---                   ");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" 1. --> Seccion --> Articulos de Limpieza                      <--");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" 2. --> Seccion --> Cereales                                   <--");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" 3. --> Seccion --> Refrescos                                  <--");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" 4. --> Seccion --> Bebidas Alcoholicas                        <--");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" 5. --> Seccion --> Leches o Lácteos                           <--");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" 6. --> Seccion --> Verduras                                   <--");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" 7. --> Seccion --> Galltetas Y Dulces                         <--");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" 8. --> Seccion --> Administrador                              <--");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" 9. --> Seccion --> Factura Cliente                            <--");
                    Console.WriteLine("------------------------------------------------------------------");
                    menu_principal = int.Parse(Console.ReadLine());
                    Console.Clear();
                    
                    switch (menu_principal)
                    {
                        case 1:

                            limpieza();
                            bandera6 = true;
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        case 2:
                            cereales();
                            bandera7 = true;
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        case 3:

                            bebidasss();
                            bandera = true;
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        case 4:

                            bebidasalcohol();
                            bandera2 = true;
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        case 5:

                            Program funtion5 = new Program();
                            funtion5.Lacteos();
                            bandera3 = true;
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        case 6:

                            Program funtion6 = new Program();
                            funtion6.Verduras();
                            
                            bandera4 = true;
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        case 7:

                            galletas();
                            bandera5 = true;
                            Console.ReadKey();
                            Console.Clear();
                           

                            break;
                        case 8:

                            if (bandera6 == true)
                            {
                                string rutalimpierza = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\cantidadlimpieza.txt";

                                using (StreamReader leer = File.OpenText(rutalimpierza))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }

                            if (bandera7 == true)
                            {
                                string rutacereales = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\cantidadcereales.txt";

                                using (StreamReader leer = File.OpenText(rutacereales))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }

                            if (bandera5 == true)
                            {
                                string rutagalletas = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\cantidadgalletas.txt";

                                using (StreamReader leer = File.OpenText(rutagalletas))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }



                            if (bandera3 == true)
                            {
                                string rutalacteos = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\CantidadLacteosAdmi.txt";

                                using (StreamReader leer = File.OpenText(rutalacteos))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }                         

                            if (bandera4 == true)
                            {
                                string rutaverdura = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\CantidadVerdurasAdmi.txt";

                                using (StreamReader leer = File.OpenText(rutaverdura))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }                          


                            if (bandera2 == true)
                            {
                                string rutaalcohol = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\alcoholadmin.txt";

                                using (StreamReader leer = File.OpenText(rutaalcohol))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }
                            

                            if (bandera == true)
                            {
                                string rutarefresco = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Admin\refrescoadmin.txt";
                                using (StreamReader leer = File.OpenText(rutarefresco))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }

                            Console.ReadKey();

                            break;
                        case 9:

                            Console.WriteLine("Ingrese su nombre: " + persona.nombre);

                            Console.WriteLine("Ingrese su numero de referencia: " + persona.numero);

                            Console.WriteLine("Ingrese su numero nit: " + persona.nit);

                            Console.WriteLine("Ingrese su nombre: " + persona.email);

                            if (bandera6 == true)
                            {
                                string rutalimpiezaclientes = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\cantidadlimpiezacliente.txt";

                                using (StreamReader leer = File.OpenText(rutalimpiezaclientes))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }

                            if (bandera7 == true)
                            {
                                string rutacerealesclientes = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\CantidadcerealeS.txt";

                                using (StreamReader leer = File.OpenText(rutacerealesclientes))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }

                            

                            if (bandera5 == true)
                            {
                                string rutagalletasclientes = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\cantidadgalletascliente.txt";

                                using (StreamReader leer = File.OpenText(rutagalletasclientes))
                                {
                                    //variable para acceder a las lineas del archivo
                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }



                            if (bandera3 == true)

                            {


                                string rutaclientelacteos = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\CantidadLacteosCliente.txt";
                                using (StreamReader leer = File.OpenText(rutaclientelacteos))
                                {

                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }                            

                            if (bandera4 == true)

                            {


                                string rutaclienteverdura = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\CantidadVerdurasCliente.txt";
                                using (StreamReader leer = File.OpenText(rutaclienteverdura))
                                {

                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }

                            if (bandera2 == true)

                            {


                                string rutaclientealcohol = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\alcoholclientes.txt";
                                using (StreamReader leer = File.OpenText(rutaclientealcohol))
                                {

                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }
                            }


                            if (bandera == true)
                            {
                                string rutaclienterefres = @"C:\Users\Trigg\OneDrive\Desktop\New folder\Clientes\refrescoclientes.txt";
                                using (StreamReader leer = File.OpenText(rutaclienterefres))
                                {

                                    string lineas = "";

                                    while ((lineas = leer.ReadLine()) != null)
                                    {
                                        Console.WriteLine(lineas);
                                    }
                                }

                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 10:

                            Console.WriteLine("Hasta luego");

                            Console.ReadLine();
                            

                            break;

                    }    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    

                } while (menu_principal != 10);

            }
        }
    }
}

    //Console.WriteLine("Ingrese el nombre del que desea obtener los datos: ");
    //Nombre = Console.ReadLine();
    //for (int i = 0; i < 1; i++)
    //{

//    if (persona.nombre == Nombre)
//    {
//        Console.WriteLine(persona.nombre + persona.numero + persona.nit + persona.email);
//    }
//}
