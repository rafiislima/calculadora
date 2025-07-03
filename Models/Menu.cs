using System.Net;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;



namespace bootcamp.Models
{
    public class Menu
    {
        Calculadora calc = new Calculadora();
   
        public void MenuIndex()
         {
            bool menuOpen = true;

            while (menuOpen)
            {
              Console.WriteLine("##-------| C A L C U L A D O R A | --------## \n");
              Console.WriteLine("Escolha uma opção: \n");
              Console.WriteLine("0 - Sair\n");
              Console.WriteLine("1 - Adição ");
              Console.WriteLine("2 - Subtração");
              Console.WriteLine("3 - Multiplicação");
              Console.WriteLine("4 - Divisão");
              Console.WriteLine("5 - Resto da Divisão");
              Console.WriteLine("6 - Outros");

              int digito = Convert.ToInt32(Console.ReadLine());
                switch (digito)
                {
                    case 0:
                        Console.WriteLine("Bye");
                        menuOpen = false;
                        break;

                    case 1:
                        Console.WriteLine("Informe dois valores:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());

                        calc.Somar(a, b);
                        break;


                    case 2:
                        Console.WriteLine("Informe dois valores:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());

                        calc.Subtrair(a, b);
                        break;


                    case 3:
                        Console.WriteLine("Informe dois valores:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());

                        calc.Multiplicar(a, b);
                        break;


                    case 4:
                        Console.WriteLine("Informe dois valores:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());

                        calc.Dividir(a, b);
                        break;

                    case 5:
                        Console.WriteLine("Informe dois valores:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());

                        calc.RestoDivisao(a, b);
                        break;

                    case 6:
                        Submenu();
                        break;
              

               }
                
            }

           

        }

        public void Submenu()
        {
            bool submenuOpen = true;
            while (submenuOpen)
            {
                Console.WriteLine("##-------| C A L C U L A D O R A | --------## \n");
                Console.WriteLine("Escolha uma opção:\n ");
                Console.WriteLine("9 - Voltar ao menu principal\n");
                Console.WriteLine(" 1 - Potenciação");
                Console.WriteLine(" 2 - Raiz Quadrada");
                Console.WriteLine(" 3 - Seno");
                Console.WriteLine(" 4 - Coseno");
                Console.WriteLine(" 5 - Tangente");

                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 9:
                        Console.WriteLine("retornar ao menu");
                        submenuOpen = false;
                        break;
                    case 1:
                        Console.WriteLine("Informe dois valores:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());

                        calc.Potencia(a, b);

                        break;

                    case 2:
                        Console.WriteLine("Informe um valor: ");
                        double x = Convert.ToDouble(Console.ReadLine());

                        calc.RaizQuadrada(x);

                        break;

                    case 3:
                        Console.WriteLine("Informe um valor: ");
                        x = Convert.ToDouble(Console.ReadLine());

                        calc.Seno(x);
                        break;

                    case 4:
                        Console.WriteLine("Informe um valor: ");
                        x = Convert.ToDouble(Console.ReadLine());

                        calc.Coseno(x);
                        break;

                    case 5:
                        Console.WriteLine("Informe um valor: ");
                        x = Convert.ToDouble(Console.ReadLine());

                        calc.Tangente(x);

                        break;


               }

                
            }
            
        }

        
    }
}