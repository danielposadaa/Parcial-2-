using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Catalogo = { "Manzana", "Durazno", "Papaya", "Piña", "Banano", "Naranja", "Mandarina" };

            int[] Precios = { 1100, 1000, 4500, 5000, 300, 500, 400 };
            int PrecioM = 1100;
            int PrecioC = 1000;
            int PrecioB = 4500;
            int PrecioT = 500;
            int PrecioW = 4000;
            int sum = 0;
            int cant = 0;
            int importe = 0;
            int importe1 = 0;
            int importe2 = 0;
            int importe3 = 0;
            int importe4 = 0;
            int importe5 = 0;
            int importe6 = 0;
            int opcion = 0;
            int fiar = 0;
            int cliente = 0;

            bool DetallesProducto = false;
            bool ProductoEncontrado = false;

            // do-while permite repetir una instrucción o una instrucción compuesta hasta que una expresión especificada sea false;
            do
            {
                Console.WriteLine("\tSurti Fruver");
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("\n" +
                    "\n 1.- Nombre" +
                    "\n 2.  Buscar productos" +
                    "\n 3.- Productos a Comprar" +
                    "\n 4.- Pagar cuenta" +
                    "\n 5.- Creditos" +
                    "\n 6.- Salir \n");
                Console.WriteLine("Digite una opción :");
                // Convert.ToInt32=toca convertir la informacion digitada por el usuario a dato numerico para que pueda ser almacenada en la variable opcion
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Daniel Santiago Posada Arana");
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el nombre del producto");
                        string Item = Console.ReadLine();
                        for (int i = 0; i < Catalogo.Length; i++)
                        {
                            if (Catalogo[i].Equals(Item))
                            {
                                DetallesProducto = true;
                                Console.WriteLine("El producto " + Catalogo[i] + " Tiene un valor de: " + Precios[i]);


                            }
                            else if (!DetallesProducto)
                            {
                                Console.WriteLine("El producto que ingreso no existe");
                            }

                        }



                        break;
                    case 3:
                        Console.WriteLine("\n\nProducto1");
                        Console.WriteLine("\nManzana :  ");
                        //art1 = Int32.Parse(Console.ReadLine());


                        Console.WriteLine("Precio Manzana : 1100 ");



                        Console.WriteLine("Cantidad :  ");
                        cant = Int32.Parse(Console.ReadLine());


                        importe = cant * PrecioM;
                        Console.WriteLine("Importe : {0}", importe);


                        Console.WriteLine("\n\nArticulo2");
                        Console.WriteLine("\nDurazno :  ");
                        //  art2 = Int32.Parse(Console.ReadLine());


                        Console.WriteLine("Precio Durazno :1000 ");



                        Console.WriteLine("Cantidad :  ");
                        cant = Int32.Parse(Console.ReadLine());


                        importe1 = cant * PrecioC;
                        Console.WriteLine("Importe : {0}", importe1);


                        Console.WriteLine("\n\nArticulo3");
                        Console.WriteLine("\nPapaya :  ");
                        // art3 = Int32.Parse(Console.ReadLine());


                        Console.WriteLine("Precio Papaya : 4500 ");



                        Console.WriteLine("Cantidad :  ");
                        cant = Int32.Parse(Console.ReadLine());


                        importe2 = cant * PrecioB;
                        Console.WriteLine("Importe : {0}", importe2);

                        Console.WriteLine("\n\nArticulo4");
                        Console.WriteLine("\nPiña :  ");
                        //  art4 = Int32.Parse(Console.ReadLine());


                        Console.WriteLine("Precio Piña : 5000 ");



                        Console.WriteLine("Cantidad :  ");
                        cant = Int32.Parse(Console.ReadLine());

                        importe3 = cant * PrecioT;
                        Console.WriteLine("Importe : {0}", importe3);



                        Console.WriteLine("\n\nArticulo5");
                        Console.WriteLine("\nBanano :  ");
                        // art5 = Int32.Parse(Console.ReadLine());


                        Console.WriteLine("Precio Banano : 300 ");


                        Console.WriteLine("Cantidad :  ");
                        cant = Int32.Parse(Console.ReadLine());

                        importe4 = cant * PrecioW;
                        Console.WriteLine("Importe : {0}", importe4);

                        Console.WriteLine("\n\nArticulo5");
                        Console.WriteLine("\nNaranja :  ");
                        //  art4 = Int32.Parse(Console.ReadLine());


                        Console.WriteLine("Precio Naranja : 500 ");



                        Console.WriteLine("Cantidad :  ");
                        cant = Int32.Parse(Console.ReadLine());

                        importe3 = cant * PrecioT;
                        Console.WriteLine("Importe : {0}", importe5);

                        Console.WriteLine("\n\nArticulo6");
                        Console.WriteLine("\nMandarina :  ");
                        //  art4 = Int32.Parse(Console.ReadLine());


                        Console.WriteLine("Precio Mandarina : 400 ");



                        Console.WriteLine("Cantidad :  ");
                        cant = Int32.Parse(Console.ReadLine());

                        importe3 = cant * PrecioT;
                        Console.WriteLine("Importe : {0}", importe6);


                        sum = importe + importe1 + importe2 + importe3 + importe4 + importe5 + importe6;

                        Console.WriteLine("\n\n\tEl Total a Pagar es de : {0}", sum);

                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Pagar cuenta");
                        Console.WriteLine("1.- Pagar");
                        Console.WriteLine("2.- Fiar");
                        cliente = Convert.ToInt32(Console.ReadLine());
                        //devuelta =- sum;
                        //en caso de pagar
                        if (cliente == 1)
                        {
                            Console.WriteLine("\n\n\t Ha pagado un total de : {0}", sum);
                            sum = 0; //si la cuenta ya fue pagada, vuelve a $0.0
                            Console.WriteLine("Su déuda actual es de: $0.0");
                        }
                        else
                        {
                            fiar = fiar + sum;
                            Console.WriteLine("\n\n\t El total de dinero que debe es de : {0}", fiar);
                        }
                        break;

                

                    case 5:
                        Console.WriteLine("\n" +
                            "\n Este trabajo fue realizado por: " +
                            "\n 1. Daniel Santiago Posada Arana" +
                            "\n 2.  Juan Esteban Suárez Restrepo" +
                            "\n 3.- Sara Marcela Posada Rendón \n");
                        break;

                    case 6:
                        Console.WriteLine("Saliendo de la aplicacion");
                        break;
                    default:
                        Console.WriteLine("Digite una opción valida");
                        break;
                }
                Console.ReadKey();

            } while (opcion != 1000);
        }
    }
}