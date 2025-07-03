namespace bootcamp.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            else
            {
                Console.WriteLine($"{x} / {y} = {x / y}");    
            }
            
        }

        public void RestoDivisao(int x, int y)
        {
           Console.WriteLine($"{x} % {y} = {x % y}");    
            
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"seno de {angulo}º = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"coseno de {angulo}º = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tan = Math.Tan(radiano);
            Console.WriteLine($"tangente de {angulo}º = {Math.Round(tan, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"raiz quadrada de {x} = {raiz}");
        }
    }
}