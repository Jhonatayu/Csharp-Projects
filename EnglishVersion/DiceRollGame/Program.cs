﻿Random Dice = new Random();

int roll1 = Dice.Next(1, 7);
int roll2 = Dice.Next(1, 7);
int roll3 = Dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"\nDice Roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){

    if ((roll1 == roll2) && (roll2 == roll3)){
        Console.WriteLine("You Rolled Triples! +6 Bônus points to total!");
        total += 6;
    }else{
        Console.WriteLine("You Rolled Doubles! +2 Bônus points to total!");
    }
} 

if (total >= 15){
    Console.WriteLine("You Win!!\n");
} else{
    Console.WriteLine("You Lose, try again.\n");
}