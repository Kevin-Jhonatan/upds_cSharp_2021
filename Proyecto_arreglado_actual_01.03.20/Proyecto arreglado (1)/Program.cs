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
        public void limpieza()
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
            limpieza.escoba_trapeador_recojedor = " 9.-  Escoba + Trapeador + Recogedor 30,90 bs";
            limpieza.precios.escoba_trapeador_recojedor = 30;
            limpieza.antisarro_ola = " 10.- Antisarro Ola 25 bs";
            limpieza.precios.antisarro_ola = 25;
            limpieza.limpia_vidrio_ola = " 11.- Limpia Vidrios Ola 20 bs";
            limpieza.precios.limpia_vidrio_ola = 20;
            limpieza.antigrasa_ola = " 12.- Antigrasa Ola 20 bs";
            limpieza.precios.antigrasa_ola = 20;
            limpieza.desodorante_rexona = " 13.- Desodorante Rexona 15,67 bs";
            limpieza.precios.desodorante_rexona = 15;
            limpieza.desodorante_nivea = " 14.- Desodorante Nivea 17,50 bs";
            limpieza.precios.desodorante_nivea = 17;
            limpieza.lava_vajilla_archer = " 15.- Lava Vajilla Archer 20,50 bs";
            limpieza.precios.lava_vajilla_archer = 20;
            limpieza.ambientador = " 16.- Ambientador de ambientes 12,90 bs";
            limpieza.precios.ambientador = 12;
            limpieza.jabon_bolivar = " 17.- Jabón Bolivar 4,50 bs";
            limpieza.precios.jabon_bolivar = 4;
            limpieza.esponja_scotch_brite = " 18.- Esponja Scotch  Brite Paquete 13,90 bs";
            limpieza.precios.esponja_scotch_brite = 13;
            limpieza.lavandina = " 19.- Lavandina 1Lt. 10 bs";
            limpieza.precios.lavandina = 10;
            limpieza.alcohol_gel = " 20.- Alcohol en Gel 1Lt. 20 bs";
            limpieza.precios.alcohol_gel = 20;
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
            Console.WriteLine(limpieza.antigrasa_ola);
            Console.WriteLine("----------------------------------------------------------------------------");
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
        public void cereales()
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



            string ruta = @"C:\Users\Trigg\OneDrive\Desktop\New folder\cantidadrefresco.txt", ruta2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\cantidadrefrescocliente.txt";

            using (StreamWriter archivo = File.AppendText(ruta2))
            {

                archivo.WriteLine("|                                                              |\n" +
               "|               Lista: cantidad de productos vendidos                       |\n" +
               "| 1-" + refresco.cocacola + " Cantidad vendida: " + cant1 + "   | 2-" + refresco.cocacolalitro + " Cantidad vendida: " + cant2 + "                \n" +

               "| 3-" + refresco.cocadiet + " Cantidad vendida: " + cant3 + "           | 4-" + refresco.fanta + " Cantidad vendida: " + cant4 + "                \n" +

               "| 5-" + refresco.fantalitro + " Cantidad vendida: " + cant5 + "                 | 6-" + refresco.fantadiet + " Cantidad vendida: " + cant6 + "                       \n" +

               "| 7-" + refresco.sprite + " Cantidad vendida: " + cant7 + "              | 8-" + refresco.spritelitro + " Cantidad vendida: " + cant8 + "                  \n" +

               "| 9-" + refresco.spritediet + " Cantidad vendida: " + cant9 + "               \n" +

               "| 10-" + refresco.pepsi + " Cantidad vendida: " + cant10 + "       | 11-" + refresco.pepsilitro + " Cantidad vendida: " + cant11 + "   \n" +

               "| 12-" + refresco.pepsidiet + " Cantidad vendida: " + cant12 + "  | 13-" + refresco.drpeper + " Cantidad vendida: " + cant13 + "    \n" +

               "| 14-" + refresco.mountdew + " Cantidad vendida: " + cant14 + "| 15-" + refresco.agua + " Cantidad vendida: " + cant15 + "    \n" +

               "| 16-" + refresco.agualitro + " Cantidad vendida: " + cant16 + "| 17-" + refresco.aguacongas + " Cantidad vendida: " + cant17 + "      \n");

            }
                using (StreamWriter archivo = File.AppendText(ruta))
            {
            
                archivo.WriteLine("|                                                              |\n" +
                "|               Lista: cantidad de productos vendidos                       |\n" +
                "| 1-" + refresco.cocacola + " Cantidad vendida: " + cant1 + "   | 2-" + refresco.cocacolalitro + " Cantidad vendida: " + cant2 + "                \n" +

                "| 3-" + refresco.cocadiet + " Cantidad vendida: " + cant3 + "           | 4-" + refresco.fanta + " Cantidad vendida: " + cant4 + "                \n" +

                "| 5-" + refresco.fantalitro + " Cantidad vendida: " + cant5 + "                 | 6-" + refresco.fantadiet + " Cantidad vendida: " + cant6 + "                       \n" +

                "| 7-" + refresco.sprite + " Cantidad vendida: " + cant7 + "              | 8-" + refresco.spritelitro + " Cantidad vendida: " + cant8 + "                  \n" +

                "| 9-" + refresco.spritediet + " Cantidad vendida: " + cant9 + "               \n" +

                "| 10-" + refresco.pepsi + " Cantidad vendida: " + cant10 + "       | 11-" + refresco.pepsilitro + " Cantidad vendida: " + cant11 + "   \n" +

                "| 12-" + refresco.pepsidiet + " Cantidad vendida: " + cant12 + "  | 13-" + refresco.drpeper + " Cantidad vendida: " + cant13 + "    \n" +

                "| 14-" + refresco.mountdew + " Cantidad vendida: " + cant14 + "| 15-" + refresco.agua + " Cantidad vendida: " + cant15 + "    \n" +

                "| 16-" + refresco.agualitro + " Cantidad vendida: " + cant16 + "| 17-" + refresco.aguacongas + " Cantidad vendida: " + cant17 + "      \n");

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



            string ruta = @"C:\Users\Trigg\OneDrive\Desktop\New folder\cantidadalcohol.txt", ruta2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\cantidadalcoholcliente.txt";

            using (StreamWriter archivo = File.AppendText(ruta2))
            {
                if (cant1>0 ) 
                {
                    archivo.WriteLine("1 - " + alchol.huaribottela + " Cantidad vendida: " + cant1);
                   
                }

                if (cant2 > 0)
                {
                    archivo.WriteLine("2 - " + alchol.huerilata + " Cantidad vendida: " + cant2);
                }
            }

            //    archivo.WriteLine("|                                                              |\n" +

                 

            // "|               Lista: cantidad de productos vendidos                       |\n" +
            // "| 1-" + alchol.huaribottela + " Cantidad vendida: " + cant1 + "   | 2-" + alchol.huerilata + " Cantidad vendida: " + cant2 + "                \n" +

            // "| 3-" + alchol.pacena + " Cantidad vendida: " + cant3 + "           | 4-" + alchol.taquinalitro + " Cantidad vendida: " + cant4 + "                \n" +

            // "| 5-" + alchol.conti + " Cantidad vendida: " + cant5 + "                 | 6-" + alchol.real + " Cantidad vendida: " + cant6 + "                       \n" +

            // "| 7-" + alchol.imperial + " Cantidad vendida: " + cant7 + "              | 8-" + alchol.heinikeinl + " Cantidad vendida: " + cant8 + "                  \n" +

            // "| 9-" + alchol.corona + " Cantidad vendida: " + cant9 + "               \n" +

            // "| 10-" + alchol.ronabuelolitro + " Cantidad vendida: " + cant10 + "       | 11-" + alchol.abuelo734 + " Cantidad vendida: " + cant11 + "   \n" +

            // "| 12-" + alchol.ronhavana + " Cantidad vendida: " + cant12 + "  | 13-" + alchol.havana7lito + " Cantidad vendida: " + cant13 + "    \n" +

            // "| 14-" + alchol.johnnierojo + " Cantidad vendida: " + cant14 + "| 15-" + alchol.johnnienegro + " Cantidad vendida: " + cant15 + "    \n" +

            // "| 16-" + alchol.johnnieazul + " Cantidad vendida: " + cant16 + "| 17-" + alchol.tequilacuervo + " Cantidad vendida: " + cant17 + "      \n" +

            // "| 18-" + alchol.casarojo + " Cantidad vendida: " + cant18 + "      |19-" + alchol.casaazul + " Cantidad vendida: " + cant19 + "            \n" +

            // "| 20-" + alchol.casanegro + " Cantidad vendida: " + cant20 + "     |\n" +
            // "La suma total es: " + suma);

            //}


            using (StreamWriter archivo = File.AppendText(ruta))
            {

                archivo.WriteLine("|                                                              |\n" +


              "|               Lista: cantidad de productos vendidos                       |\n" +
              "| 1-" + alchol.huaribottela + " Cantidad vendida: " + cant1 + "   | 2-" + alchol.huerilata + " Cantidad vendida: " + cant2 + "                \n" +

              "| 3-" + alchol.pacena + " Cantidad vendida: " + cant3 + "           | 4-" + alchol.taquinalitro + " Cantidad vendida: " + cant4 + "                \n" +

              "| 5-" + alchol.conti + " Cantidad vendida: " + cant5 + "                 | 6-" + alchol.real + " Cantidad vendida: " + cant6 + "                       \n" +

              "| 7-" + alchol.imperial + " Cantidad vendida: " + cant7 + "              | 8-" + alchol.heinikeinl + " Cantidad vendida: " + cant8 + "                  \n" +

              "| 9-" + alchol.corona + " Cantidad vendida: " + cant9 + "               \n" +

              "| 10-" + alchol.ronabuelolitro + " Cantidad vendida: " + cant10 + "       | 11-" + alchol.abuelo734 + " Cantidad vendida: " + cant11 + "   \n" +

              "| 12-" + alchol.ronhavana + " Cantidad vendida: " + cant12 + "  | 13-" + alchol.havana7lito + " Cantidad vendida: " + cant13 + "    \n" +

              "| 14-" + alchol.johnnierojo + " Cantidad vendida: " + cant14 + "| 15-" + alchol.johnnienegro + " Cantidad vendida: " + cant15 + "    \n" +

              "| 16-" + alchol.johnnieazul + " Cantidad vendida: " + cant16 + "| 17-" + alchol.tequilacuervo + " Cantidad vendida: " + cant17 + "      \n" +

              "| 18-" + alchol.casarojo + " Cantidad vendida: " + cant18 + "      |19-" + alchol.casaazul + " Cantidad vendida: " + cant19 + "            \n" +

              "| 20-" + alchol.casanegro + " Cantidad vendida: " + cant20 + "     |\n" +
              "La suma total es: " + suma);




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
            lacteos.Leche_Light = "1. Leche Light ";
            lacteos.precios.Precio_Leche_Light = 7;
            Console.WriteLine(lacteos.Leche_Light + lacteos.precios.Precio_Leche_Light + " Bs (p/u)");

            lacteos.Leche_Deslactosada = "2. Leche Deslactosada ";
            lacteos.precios.Precio_Leche_Deslactosada = 8;
            Console.WriteLine(lacteos.Leche_Deslactosada + lacteos.precios.Precio_Leche_Deslactosada + " Bs (p/u)");

            lacteos.Manjar_1Kl = "3. Manjar 1Kg ";
            lacteos.precios.Precio_Manjar_1Kl = 35;
            Console.WriteLine(lacteos.Manjar_1Kl + lacteos.precios.Precio_Manjar_1Kl + " Bs (p/u)");

            lacteos.Leche_Natural = "4. Leche Natural ";
            lacteos.precios.Precio_Leche_Natural = 6;
            Console.WriteLine(lacteos.Leche_Natural + lacteos.precios.Precio_Manjar_1Kl + " Bs (p/u)");

            lacteos.Leche_Condensada = "5. Leche Condensada ";
            lacteos.precios.Precio_Leche_Condensada = 12;
            Console.WriteLine(lacteos.Leche_Condensada + lacteos.precios.Precio_Leche_Condensada + " Bs (p/u)");

            lacteos.Leche_Evaporada = "6. Leche Evaporada ";
            lacteos.precios.Precio_Leche_Evaporada = 13;
            Console.WriteLine(lacteos.Leche_Evaporada + lacteos.precios.Precio_Leche_Evaporada + " Bs (p/u)");

            lacteos.Queso_Premier = "7. Queso Premier ";
            lacteos.precios.Precio_Queso_Premier = 45;
            Console.WriteLine(lacteos.Queso_Premier + lacteos.precios.Precio_Queso_Premier + " Bs (p/u)");

            lacteos.Yogurt_Delicia_Frutilla = "8. Yogurt Delicia Frutilla ";
            lacteos.precios.Precio_Yogurt_Delicia_Frutilla = 15;
            Console.WriteLine(lacteos.Yogurt_Delicia_Frutilla + lacteos.precios.Precio_Yogurt_Delicia_Frutilla + " Bs (p/u)");

            lacteos.Yogurt_Delicia_Durazno = "9. Yogurt Delicia Durazno ";
            lacteos.precios.Precio_Yogurt_Delicia_Durazno = 15;
            Console.WriteLine(lacteos.Yogurt_Delicia_Durazno + lacteos.precios.Precio_Yogurt_Delicia_Durazno + " Bs (p/u)");

            lacteos.Yogurt_Delicia_Coco = "10. Yogurt Delicia Coco ";
            lacteos.precios.Precio_Yogurt_Delicia_Coco = 15;
            Console.WriteLine(lacteos.Yogurt_Delicia_Coco + lacteos.precios.Precio_Yogurt_Delicia_Coco + " Bs (p/u)");

            lacteos.Mantequilla_Regia = "11. Mantequilla_Regia ";
            lacteos.precios.Precio_Mantequilla_Regia = 20;
            Console.WriteLine(lacteos.Mantequilla_Regia + lacteos.precios.Precio_Mantequilla_Regia + " Bs (p/u)");

            lacteos.Leche_en_Polvo = "12. Leche_en_Polvo ";
            lacteos.precios.Precio_Leche_en_Polvo = 18;
            Console.WriteLine(lacteos.Leche_en_Polvo + lacteos.precios.Precio_Leche_en_Polvo + " Bs (p/u)");

            lacteos.Helado_Pil = "13. Helado Pil ";
            lacteos.precios.Precio_Helado_Pil = 20;
            Console.WriteLine(lacteos.Helado_Pil + lacteos.precios.Precio_Helado_Pil + " Bs (p/u)");

            lacteos.Helado_Norlan = "14. Helado_Norlan ";
            lacteos.precios.Precio_Helado_Norlan = 10;
            Console.WriteLine(lacteos.Helado_Norlan + lacteos.precios.Precio_Helado_Norlan + " Bs (p/u)");
        }
        // Seccion Verduras Nº6
        public void Verduras()
        {
            producto verduras;

            verduras.Manzana_Verde1kg = "1. Manzana Verde 1kg ";
            verduras.precios.Precio_Manzana_Verde1kg = 10;
            Console.WriteLine(verduras.Manzana_Verde1kg + verduras.precios.Precio_Manzana_Verde1kg + " Bs");

            verduras.Chirimolla1kg = "2. Chirimolla 1kg ";
            verduras.precios.Precio_Chirimolla1kg = 20;
            Console.WriteLine(verduras.Chirimolla1kg + verduras.precios.Precio_Chirimolla1kg + " Bs");

            verduras.Durazno1kg = "3. Durazno 1kg ";
            verduras.precios.Precio_Durazno1kg = 15;
            Console.WriteLine(verduras.Durazno1kg + verduras.precios.Precio_Durazno1kg + " Bs");

            verduras.Frutilla1kg = "4. Frutilla 1 paquete ";
            verduras.precios.Precio_Frutilla1kg = 10;
            Console.WriteLine(verduras.Frutilla1kg + verduras.precios.Precio_Frutilla1kg + " Bs");

            verduras.Ciruelo1pqt = "5. Ciruelo 1 paquete ";
            verduras.precios.Precio_Ciruelo1pqt = 8;
            Console.WriteLine(verduras.Ciruelo1pqt + verduras.precios.Precio_Ciruelo1pqt + " Bs");

            verduras.Mora1pqt = "6. Mora 1 paquete ";
            verduras.precios.Precio_Mora1pqt = 15;
            Console.WriteLine(verduras.Mora1pqt + verduras.precios.Precio_Mora1pqt + " Bs");

            verduras.Uva1pqt = "7. Uva 1 paquete ";
            verduras.precios.Precio_Uva1pqt = 14;
            Console.WriteLine(verduras.Uva1pqt + verduras.precios.Precio_Uva1pqt + " Bs");

            verduras.Arandanos1pqt = "8. Arandanos ";
            verduras.precios.Precio_Arandanos1pqt = 17;
            Console.WriteLine(verduras.Arandanos1pqt + verduras.precios.Precio_Arandanos1pqt + " Bs");

            verduras.Limon1Kg = "9. Limón 1kg ";
            verduras.precios.Precio_Limon1Kg = 12;
            Console.WriteLine(verduras.Limon1Kg + verduras.precios.Precio_Limon1Kg + " Bs");

            verduras.Sandia = "10. Sandía ";
            verduras.precios.Precio_Sandia = 32;
            Console.WriteLine(verduras.Sandia + verduras.precios.Precio_Sandia + " Bs (p/u)");

            verduras.Melon = "11. Melón ";
            verduras.precios.Precio_Melon = 10;
            Console.WriteLine(verduras.Melon + verduras.precios.Precio_Melon + " Bs (p/u)");

            verduras.Piña = "12. Piña ";
            verduras.precios.Precio_Piña = 10;
            Console.WriteLine(verduras.Piña + verduras.precios.Precio_Piña + " Bs (p/u)");

            verduras.Zanahoria1kg = "13. Zanahoria 1kg ";
            verduras.precios.Precio_Zanahoria1kg = 6;
            Console.WriteLine(verduras.Zanahoria1kg + verduras.precios.Precio_Zanahoria1kg + " Bs");

            verduras.Cebolla1kg = "14. Cebolla 1kg ";
            verduras.precios.Precio_Cebolla1kg = 7;
            Console.WriteLine(verduras.Cebolla1kg + verduras.Cebolla1kg + " Bs");

            verduras.Tomate1kg = "15. Tomate 1 kg ";
            verduras.precios.Precio_Tomate1kg = 5;
            Console.WriteLine(verduras.Tomate1kg + verduras.precios.Precio_Tomate1kg + " Bs");

            verduras.Navo1kg = "16. Navo 1 kg ";
            verduras.precios.Precio_Navo1kg = 8;
            Console.WriteLine(verduras.Navo1kg + verduras.precios.Precio_Navo1kg + " Bs");

            verduras.Papa1Kg = "17. Papa 1kg ";
            verduras.precios.Precio_Papa1Kg = 12;
            Console.WriteLine(verduras.Papa1Kg + verduras.precios.Precio_Papa1Kg + " Bs");

            verduras.Pimenton = "18. Pimentón ";
            verduras.precios.Precio_Pimenton = 5;
            Console.WriteLine(verduras.Pimenton + verduras.precios.Precio_Pimenton + " Bs (p/u)");

            verduras.Brocoli = "19. Brocoli ";
            verduras.precios.Precio_Brocoli = 9;
            Console.WriteLine(verduras.Brocoli + verduras.precios.Precio_Brocoli + " Bs (p/u)");

            verduras.Palta = "20. Palta ";
            verduras.precios.Precio_Palta = 10;
            Console.WriteLine(verduras.Palta + verduras.precios.Precio_Palta + " Bs (p/u)");

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
        public void galletas()
        {
            dulce_galletas galletas;
            galletas.club_social = "  1.- Club Social 2 bs";
            galletas.precio.club_social = 2;
            galletas.gauchitas = "  2.- Gauchitas 4 bs";
            galletas.precio.gauchitas = 4;
            galletas.moraditas = "  3.- Moraditas 4 bs";
            galletas.precio.moraditas = 4;
            galletas.maria = "  3.- Maria 4 bs";
            galletas.precio.maria = 4;
            galletas.oreo = "  4.- Oreo 4 bs";
            galletas.precio.oreo = 4;
            galletas.papas_pequeñas = "  5.- Papas Fritas (pequeño) 6 bs";
            galletas.precio.papas_pequeñas = 6;
            galletas.crackers = "  6.- Crackers 6 bs";
            galletas.precio.crackers = 6;
            galletas.choco_soda = "  7.- Choco Soda 6 bs";
            galletas.precio.choco_soda = 6;
            galletas.wafers = "  8.- Wafers 6 bs";
            galletas.precio.wafers = 6;
            galletas.choco_chip = "  9.- Choco Chip 8 bs";
            galletas.precio.choco_chip = 8;
            galletas.salvado = " 10.- Salvado 10 bs";
            galletas.precio.salvado = 10;
            galletas.san_gabriel = " 11.- San Gabriel 20 bs";
            galletas.precio.san_gabriel = 20;
            galletas.papas_grande = " 12.- Papas Fritas (grande) 12 bs";
            galletas.precio.papas_grande = 12;
            galletas.bom_bom = " 13.- Bom o Bom (1caja) 20 bs";
            galletas.precio.bom_bom = 20;
            galletas.ferrari_integral = " 14.- Ferrari Integral 30 bs";
            galletas.precio.ferrari_integral = 30;
            galletas.agua = " 15.- Galleta de Agua 20 bs";
            galletas.precio.agua = 20;
            galletas.chocolate_bauducco = " 16.- Chocolate Bauducco (Italiano) 40 bs";
            galletas.precio.chocolate_bauducco = 40;
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
        }
        static void Main(string[] args)
        {
            admin bebe;
            clientes persona;
            string Nombre;
            bool bandera = false;


            Console.WriteLine("Ingrese su nombre: ");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de referencia: ");
            persona.numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre: ");
            persona.nit = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre: ");
            persona.email = Console.ReadLine();




            string continuar, cant = "terminar";
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
                menu_principal = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu_principal)
                {
                    case 1:
                        Program funtion1 = new Program();
                        funtion1.limpieza();
                        break;
                    case 2:
                        Program funtion2 = new Program();
                        funtion2.cereales();
                        break;
                    case 3:

                        bebidasss();
                        bandera = true;

                        break;
                    case 4:

                        bebidasalcohol();

                        break;
                    case 5:
                        Program funtion5 = new Program();
                        funtion5.Lacteos();
                        break;
                    case 6:
                        Program funtion6 = new Program();
                        funtion6.Verduras();
                        break;
                    case 7:
                        Program funtion7 = new Program();
                        funtion7.galletas();
                        break;
                    case 8:
                        string rutaaa = @"C:\Users\Trigg\OneDrive\Desktop\New folder\cantidadalcohol.txt";
                        using (StreamReader leer = File.OpenText(rutaaa))
                        {
                            //variable para acceder a las lineas del archivo
                            string lineas = "";

                            while ((lineas = leer.ReadLine()) != null)
                            {
                                Console.WriteLine(lineas);
                            }
                        }
                        string rutaaa2 = @"C:\Users\Trigg\OneDrive\Desktop\New folder\cantidarefresco";
                        using (StreamReader leer = File.OpenText(rutaaa2))
                        {
                            //variable para acceder a las lineas del archivo
                            string lineas = "";

                            while ((lineas = leer.ReadLine()) != null)
                            {
                                Console.WriteLine(lineas);
                            }
                        }
                        break;
                    case 9:


                        Console.WriteLine("Ingrese su nombre: "+ persona.nombre);
                        
                        Console.WriteLine("Ingrese su numero de referencia: "+ persona.numero);
                        
                        Console.WriteLine("Ingrese su numero nit: "+ persona.nit);
                        
                        Console.WriteLine("Ingrese su nombre: "+ persona.email);
                        


                        string rutaclientealcohol = @"C:\Users\Trigg\OneDrive\Desktop\New folder\cantidadalcoholcliente.txt";
                        using (StreamReader leer = File.OpenText(rutaclientealcohol))
                        {
                            
                            string lineas = "";

                            while ((lineas = leer.ReadLine()) != null)
                            {
                                Console.WriteLine(lineas);
                            }
                        }

                        if (bandera==true)
                        {
                            string rutaclienterefres = @"C:\Users\Trigg\OneDrive\Desktop\New folder\cantidadrefrescocliente.txt";
                            using (StreamReader leer = File.OpenText(rutaclienterefres))
                            {

                                string lineas = "";

                                while ((lineas = leer.ReadLine()) != null)
                                {
                                    Console.WriteLine(lineas);
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



                        break;                     

                       
                    default:
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                continuar = Console.ReadLine();
            }
            while (continuar != "terminar");
        }
    }
}
