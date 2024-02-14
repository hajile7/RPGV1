//welcome
using RPG_V1._0;
using System.Reflection.Metadata;

//Getting user input(class + name)
Console.WriteLine("Welcome to (placeholder)! Which class would you like to play as?");
Console.WriteLine("Options: Rogue, Warrior, Wizard");
string classChoice = Validator.Validator.GetValidString("rogue", "warrior", "wizard");
Console.Clear();
Console.WriteLine($"You've selected the {classChoice}.");
Console.Write("Before you embark on your adventure, please enter your character's name: ");
string name = Console.ReadLine().Trim();

//Thinking this is where we begin the program loop
if (classChoice == "rogue")
{
    Rogue user = new Rogue(name);
    user.ListStats(user);
    Console.WriteLine("As you begin your journey, you are ambushed by a Fiend! Prepare to defend yourself.");
    Fiend firstEncounter = new Fiend(); //create param for enemies that takes in their level so we can scale them appropriately
    user.DefaultAttack(user, firstEncounter);
    user.DefaultAttack(user, firstEncounter);

}

//battle test














//methods
static bool getRandomCrit()
{
    Random random = new Random();
    if (random.Next(1, 21) == 20)
    {
        return true;
    }
    else return false;
}