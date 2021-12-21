using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello! Welcome to Rock, Paper, Scissors SHOOT. You know the rules to this classic game, best two out of three. Have fun!!\n");

    //Set a string array of what the computer is aloud to chose. 
    string[] randPick = {"rock", "paper", "scissors"};

    //set string input to nothing so that it will enter the do-while loop and if you select Y or y then it will run the program again.
    string input;

    //do-while and while to prompt the user for their pick and then compares that to what the computer selects and if they win it prompts the win string and what the opponent chose and increments the wins. Reverse for the losses as well. 
    do
    {
      int numberWins = 0;
      int numberLosses = 0;
      while(numberWins < 2){
      Random rand = new Random(); 
      int randomNumber = rand.Next(randPick.Length);

      Console.WriteLine("Rock, Paper, Scissors...SHOOT: "); 
      string choice = Console.ReadLine();

      if (choice == "rock" && randPick[randomNumber] == "scissors"){
        winString();
        scissors();
        numberWins++; 
      }
      else if (choice == "rock" && randPick[randomNumber] == "paper"){
        loseString();
        paper();
        numberLosses++;
      }
      else if (choice == "rock" && randPick[randomNumber] == "rock"){
        tieString();
      }
      else if (choice == "paper" && randPick[randomNumber] == "rock"){
        winString();
        rock();
        numberWins++;
      }
      else if (choice == "paper" && randPick[randomNumber] == "scissors"){
        loseString();
        scissors();
        numberLosses++;
      }
      else if (choice == "paper" && randPick[randomNumber] == "paper"){
        tieString();
      }
      else if (choice == "scissors" && randPick[randomNumber] == "paper"){
        winString();
        paper();
        numberWins++;
      }
      else if (choice == "scissors" && randPick[randomNumber] == "rock"){
        loseString();
        rock();
        numberLosses++;
      }
      else if (choice == "scissors" && randPick[randomNumber] == "scissors"){
        tieString();
      }
      else {
        errorString();
      }
      if(numberLosses == 2){
        Console.WriteLine("YOU LOSE!");
        break;
      }
      else if (numberWins == 2){
        Console.WriteLine("YOU WON!!!!"); 
        break;
      }
    }
    //Prompts user if they want to play again. 
    Console.WriteLine("Would you like to play again (y/n): ");
    input = Console.ReadLine();
  } while(input == "y" || input == "Y");    
}

  //82-101 are all functions to display when the user wins, losses, or ties as well as what the computer chose. 
  static void winString(){
    Console.WriteLine("You won this round!");
  }
  static void loseString(){
    Console.WriteLine("You lost this round!"); 
  }
  static void tieString(){
    Console.WriteLine("You tied this round!\n");
  }
  static void errorString(){
    Console.WriteLine("INVALID!\n");
  }
  static void scissors(){
    Console.WriteLine("Your opponent choose scissors.\n");
  }
  static void paper(){
    Console.WriteLine("Your opponent choose paper.\n");
  }
  static void rock(){
    Console.WriteLine("Your opponent choose rock.\n");
  }
}
//Zachary Sweet