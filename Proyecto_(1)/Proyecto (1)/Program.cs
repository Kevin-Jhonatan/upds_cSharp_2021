using System;

namespace Proyecto__1_
{
    class Program
    {
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
            public float detergente_omo;
            public float detergente_ace;
            public float detergente_liquido;
            public float suavisante_ropa;
            public float jaboncillo_dove;
            public float shampoo_sedal;
            public float colino_colgate;
            public float cepillo_dental;
            public float escoba_trapeador_recojedor;
            public float antisarro_ola;
            public float limpia_vidrio_ola;
            public float antigrasa_ola;
            public float desodorante_rexona;
            public float desodorante_nivea;
            public float lava_vajilla_archer;
            public float ambientador;
            public float jabon_bolivar;
            public float esponja_scotch_brite;
            public float lavandina;
            public float alcohol_gel;
        }
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
            public float miel;
            public float relleno_de_leche;
            public float chocopotamos;
            public float froties;
            public float choco_krispi;
            public float froot_loops;
            public float chocapic;
            public float golden_grahams;
            public float smocks;
            public float trix;
            public float all_bran_chose;
            public float nesquik;
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

        public void bebidasalcohol()
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
            Console.WriteLine("| 14-" + alchol.ronhavana + ": " + alchol.valorb.ronhavanapre + "       | 15-" + alchol.havana7lito + ": " + alchol.valorb.havana7litopre + "    |\n");
            Console.WriteLine("|----------------------------|---------------------------------|\n");
            Console.WriteLine("| 12-" + alchol.johnnierojo + ": " + alchol.valorb.johnnierojopre + "| 13-" + alchol.johnnienegro + ": " + alchol.valorb.johnnienegropre + "    |\n");
            Console.WriteLine("|----------------------------|---------------------------------|\n");
            Console.WriteLine("| 16-" + alchol.johnnieazul + ": " + alchol.valorb.johnnieazulpre + "| 17-" + alchol.tequilacuervo + ": " + alchol.valorb.tequilacuervopre + "      |\n");
            Console.WriteLine("|----------------------------|---------------------------------|\n");
            Console.WriteLine("| 18-" + alchol.casarojo + ": " + alchol.valorb.casarojopre + "      |19-" + alchol.casaazul + ": " + alchol.valorb.casaazulpre + "            |\n");
            Console.WriteLine("|----------------------------|---------------------------------|\n");
            Console.WriteLine("| 20-" + alchol.casanegro + ": " + alchol.valorb.casanegropre + "     |\n");
            Console.WriteLine("|----------------------------|---------------------------------|\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int opcionalchol = int.Parse(Console.ReadLine());
            int suma = 0;
            int cant = 0;
            switch (opcionalchol)
            {

                case 1:
                    Console.WriteLine("ingrese la cantidad");
                    cant = int.Parse(Console.ReadLine());
                    suma = alchol.valorb.huaribotte *cant;

                    Console.WriteLine(" la suma es: " + suma);
                    
                    break;



            }
        }

        int f;
        public void gaurdo()
        
        {
            




        }
        public void bebidasss()
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

            //string respuesta, cant = "";
            //do
            //{

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
                //int opcionalchol = int.Parse(Console.ReadLine());

                ////switch (opcionalchol)
                ////{

                ////    case 1:




                ////        break;

                ////}
            //    Console.WriteLine("Desea comprar otros productos o pagar");

            //    Console.WriteLine("Respuesta: ");

            //    respuesta = Console.ReadLine();
            //} while (respuesta != "pagar");









        }


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




        static void Main(string[] args)
        {
            int suma = 0;
            string respuesta="";
            int cant = 0;
            do
            {
                
                Console.WriteLine(string.Format("{0}             Menu               {0}{0}1.Bebidas Alcoholicas{0}2. Refrescos{0}3. Lacteos{0}4. Verduras{0}5. Lacteos {0}6. Verduras {0}7. salir {0}8. factura", Environment.NewLine));
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(string.Format("{0}Elija una opcion: ", Environment.NewLine));
                Console.ForegroundColor = ConsoleColor.Yellow;

                int opcionTres = 0;
                opcionTres = int.Parse(Console.ReadLine());
            

                switch (opcionTres)
                {
                    case 1:
                        //Ingreso de datos de los estudiantes


                        Program al = new Program();
                        al.bebidasalcohol();


                        break;
                    case 2:

                        Program be = new Program();
                        be.bebidasss();
                        break;

                    case 3:

                        Program LLacteos = new Program();
                        LLacteos.Lacteos();
                        break;

                    case 4:

                        Program VVerduras = new Program();
                        VVerduras.Verduras();
                        break;


                    case 5:

                        Program pv = new Program();
                        pv.limpieza();

                        break;

                    case 6:

                        Program funcion = new Program();
                        funcion.cereales();

                        break;

                        
                    case 7:

                        Console.WriteLine("Hasta luego");
                        Console.ReadLine();
                        Environment.Exit(0);
                            

                        break;
                    case 8:
                        
                        Console.WriteLine(suma);
                        

                        break;

                }

                Console.WriteLine("Respuesta: ");

                respuesta = Console.ReadLine();
            } while (respuesta != "pagar");

        }
    }    
}
