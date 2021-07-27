using System;
class calc{
    static void Main(){
        float valor1,valor2,resto;
        char sinal;

        
        
        op:
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("digite o primeiro numero");
        valor1=float.Parse(Console.ReadLine());
        Console.WriteLine("digite o segundo numero");
        valor2=float.Parse(Console.ReadLine());
        Console.WriteLine("Escolha uma operação (Adição=+ | subtração=- | divisão=/ | multiplicação=*)");
        sinal=Char.Parse(Console.ReadLine());

        if(sinal=='+'){
            resto=valor1+valor2;
            Resto(resto,sinal,valor1,valor2);
        }
        if(sinal=='-'){
            resto=valor1-valor2;
            Resto(resto,sinal,valor1,valor2);
        }
        if(sinal=='/'){
            if(valor1==0 || valor2==0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("impossivel dividir por zero.");
                Console.WriteLine("Aperte enter para iniciar uma nova operação");
                Console.ReadLine();
                Console.Clear();
                goto op;
            }
            resto=valor1/valor2;
            Resto(resto,sinal,valor1,valor2);
        }
        if(sinal=='*'){
                if(valor1==0 || valor2==0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("impossivel multiplicar por zero.");
                Console.WriteLine("Aperte enter para iniciar uma nova operação");
                Console.ReadLine();
                Console.Clear();
                goto op;
            }
            resto=valor1*valor2;
            Resto(resto,sinal,valor1,valor2);
        }
    }

    static void Resto(float res, char opera, float v1, float v2){
        char oper;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("{0} {1} {2} = {3}", v1, opera, v2, res);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Deseja iniciar uma nova operação? (sim=s || não=n)");
        oper=char.Parse(Console.ReadLine());
        if(oper=='s'){
            Console.Clear();
            Main();
        }
    }
}