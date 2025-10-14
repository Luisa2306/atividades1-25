using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv1
{
    public class Atividades
    {
        public void At1()
        {
            int num1, ant, sus;

            Console.WriteLine("Informe um número inteiro: ");
            num1 = int.Parse(Console.ReadLine());

            ant = num1 - 1;
            sus = num1 + 1;

            Console.WriteLine($"O seu número é: {num1} ");
            Console.WriteLine($"O seu  antecessor é: {ant} ");
            Console.WriteLine($"O o sussesor é: {sus} ");

        }

        public void At2()
        {
            double num1, num2, num3, media;

            Console.WriteLine("Informe o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro  número: ");
            num3 = double.Parse(Console.ReadLine());

            media = (num1 + num2 + num3) / 3;
            Console.WriteLine($"A média é: {media}");


        }

        public void At3()
        {
            double temp, conv;

            Console.WriteLine("Informe uma temperatura em °C: ");
            temp = double.Parse(Console.ReadLine());

            conv = (temp * 9 / 5) + 32;
            Console.WriteLine($"A temperatura em Fahrenheit é: {conv}");

        }

        public void At4()
        {
            double primeira, valor, vtotal;

            Console.WriteLine("Informe o valor total da importância em dólares");
            valor = double.Parse(Console.ReadLine());

            vtotal = (0.30) * valor;
            Console.WriteLine($"A primeira pessoa receberá um aumento de: R${vtotal}");

            vtotal = (0.38) * valor;
            Console.WriteLine($"A segunda pessoa receberá um aumento de: R${vtotal}");

            vtotal = (0.32) * valor;
            Console.WriteLine($"A terceira pessoa receberá um aumento de: R${vtotal}");
        }

        public void At5()
        {
            double latao, zinco, cobre;

            Console.WriteLine("Quantos Kg de latão você deseja? ");
            latao = double.Parse(Console.ReadLine());

            cobre = latao * 0.7;
            zinco = latao * 0.3;


            Console.WriteLine($"É necessário  {cobre}KG de cobre e {zinco}KG de zinco");

        }

        public void At6()
        {
            double num;

            Console.WriteLine("Informe um número: ");
            num = double.Parse(Console.ReadLine());


            if (num > 20)
            {
                Console.WriteLine($"seu número é: {num}");
            }
        }

        public void At7()
        {
            int num1, num2, soma;

            Console.WriteLine("Informe o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            if (soma > 10)
            {
                Console.WriteLine($"A soma dos dois números  é: {soma}");
            }
            else
            {
                Console.WriteLine("A soma é insuficiente!");
            }

        }

        public void At8()
        {
            int num1;

            Console.WriteLine("Informe um número inteiro: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 1)
            {
                Console.WriteLine("O número informado é ímpar");
            }
            else
            {
                Console.WriteLine("O número informado é par");
            }

        }

        public void At9()
        {
            int num1;

            Console.WriteLine("Informe um número: ");
            num1 = int.Parse(Console.ReadLine());

            if (0 < num1)
            {
                Console.WriteLine("O número informado é positivo: ");
            }
            else if (0 > num1)
            {
                Console.WriteLine("O número informado é negativo:");
            }
            else
            {
                Console.WriteLine("O número informado é nulo");
            }

        }

        public void At10()
        {
            int num1, raizQuadrada, quadrado;

            Console.WriteLine("Informe um número: ");
            num1 = int.Parse(Console.ReadLine());

            raizQuadrada = (int)Math.Sqrt(num1);

            quadrado = num1 * num1;

            if (num1 > 0 || num1 == 0)
            {
                Console.WriteLine($"A raiz quadrada de {num1} é {raizQuadrada}");
            }
            else
            {
                Console.WriteLine($"O quadrado do número é: {quadrado}");
            }

        }

        public void At11()
        {
            double A, B, C;

            Console.WriteLine("Informe o primeiro número: ");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número: ");
            C = double.Parse(Console.ReadLine());


            // cria um array que vai pegar os números
            double[] numeros = { A, B, C };

            // ordena os números em ordem crescente
            Array.Sort(numeros);

            Console.WriteLine("\nOs números em ordem crescente são: ");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }




        }

        public void At12()
        {
            double A, B, C;

            Console.WriteLine("Informe o valor do primeiro número: ");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do segundo número: ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do terceiro número: ");
            C = double.Parse(Console.ReadLine());

            double[] numeros = { A, B, C };

            Array.Reverse(numeros);//Sort = crescente Reverse = decrescente

            Console.WriteLine("\n Os números em ordem decrescente são: ");
            foreach(var numero in numeros)
            {
                Console.WriteLine(numeros);
            }



        }

        public void At13()
        {
            int num1;

            Console.WriteLine("Informe um número inteiro: ");
            num1 = int.Parse(Console.ReadLine());

            if(num1 == 5)
            {
                Console.WriteLine("O número informado é igual a 5");
            }else if(num1 == 200)
            {
                Console.WriteLine("O número informado é igual a 200");
            }else if(num1 == 400)
            {
                Console.WriteLine("O número informado é 400");
            }else if (num1 > 500 && num1 < 1000)
            {
                Console.WriteLine($"O número informado é: {num1}");
            }
            else
            {
                Console.WriteLine("Número inválio!");
            }
        }

        public void At14()
        {
            int num1, num2;
            double menor, maior,quadradoMenor,raizMaior;

            Console.WriteLine("Informe o valor de X: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de Y: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 < num2)
            {
                menor = num1;
                maior = num2;
            }else{
                menor = num2;
                maior = num1;
            }
            quadradoMenor = Math.Pow(menor, 2); //vai elevar o menor número a uma potência 2
            Console.WriteLine($"O quadrado do menor número ({menor}) é: {quadradoMenor}");

            if(maior >= 0)
            {
                raizMaior = Math.Sqrt(maior);// calcula a raiz quadrada
                Console.WriteLine($"A raiz quadrada do maior número ({maior}) é: {raizMaior} ");
            }
            else
            {
                Console.WriteLine("Não é possível calcular a riz quadrada pois o número informado é negativo");
            }

          

        }

        public void At15()
        {

        }

        public void At16()
        {

        }

        public void At17()
        {

        }

        public void At18()
        {

        }

        public void At19()
        {

        }

        public void At20()
        {

        }

        public void At21()
        {

        }

        public void At22()
        {

        }

        public void At23()
        {

        }

        public void At24()
        {

        }

        public void At25()
        {

        }

    }
}
