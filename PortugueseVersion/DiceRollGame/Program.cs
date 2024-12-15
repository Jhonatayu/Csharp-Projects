// O jogo consiste em 3 números aleatórios, se a soma total dos números for maior que 15 vence, se for menor, perde.

Random dado = new Random();

int roll1 = dado.Next(1, 7);
int roll2 = dado.Next(1, 7);
int roll3 = dado.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"\nNúmeros dos Dados: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){

    if ((roll1 == roll2) && (roll2 == roll3)){
        Console.WriteLine("Você conseguiu 3 números iguas! +6 Pontos bônus adicionados ao total!");
        total += 6;
    }else{
        Console.WriteLine("Você conseguiu 2 números iguas! +2 Pontos bônus adicionados ao total!");
    }
} 

if (total >= 15){
    Console.WriteLine("Você Ganhou!!\n");
} else{
    Console.WriteLine("Você perdeu, tente novamente.\n");
}