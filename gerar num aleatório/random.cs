using System;
class a{
    static void Main(){

        string cmd;
        int aposta;
        int saldo=1000;
        System.Random random = new System.Random();
        int num;

        inicio:

        Console.WriteLine("comandos: saldo | jogar | apostar");
        Console.WriteLine("");
        cmd = Console.ReadLine();
        cmd = cmd.ToLower();

        if(cmd=="saldo"){
            Console.WriteLine("");
            Console.WriteLine(saldo);
            Console.ReadKey();
            Console.Clear();
            goto inicio;
        }else if(cmd=="jogar"){
            saldo=saldo-100;
            num = random.Next(0,150);
            saldo=saldo+num;
            if(saldo>0){
               Console.WriteLine("você ganhou {0}!!",num);
                Console.ReadKey();
                Console.Clear();
                goto inicio; 
            }else if(saldo<=0){
                falencia();
            }
            
        }else if(cmd=="apostar"){
            aposta:

            Console.WriteLine("Quanto você quer apostar?");
            Console.WriteLine("");
            aposta = int.Parse(Console.ReadLine());
            if(aposta>saldo || aposta<=0){
                Console.WriteLine("Você não pode apostar esse dinheiro.");
                Console.ReadKey();
                Console.Clear();
                goto aposta;
            }
            saldo=saldo-aposta;

            num = random.Next(0,100);
            if(num>=70){
                aposta=aposta*2;
                saldo=saldo+aposta;
                Console.WriteLine("Você conseguiu dobrar sua aposta!!");
                Console.ReadKey();
                Console.Clear();
                goto inicio;
            }else if(num<70){
                if(saldo==0){
                    falencia();
                }
                Console.WriteLine("Você perdeu na aposta :(");
                Console.ReadKey();
                Console.Clear();
                goto inicio;
            }
        }else{
            Console.WriteLine("esse comando não existe");
            Console.ReadKey();
            Console.Clear();
            goto inicio;
        }
    }
    static void falencia(){
        Console.WriteLine("Você faliu :(");
        Console.ReadKey();
        Environment.Exit(0);
    }
}