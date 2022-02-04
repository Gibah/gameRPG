using POO.src.Entities;
using static System.Console;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 28, "Knight", 390, 150);
            Wizard wizard = new Wizard("Jennica", 30 , "White Wizard", 360, 450);      
            Ninja ninja = new Ninja("Wedge", 29, "Ninja", 400, 190);  
            BlackWizard blackWizard = new BlackWizard("Topaza", 30, "Black Wizard", 380, 470);         

            //WriteLine(@$"Os meus personagens são: 
            //        {knight}, 
            //        {ninja},
            //        {blackWizard}, 
            //        {wizard}");           

            WriteLine(ninja.Attack()); 
            WriteLine(blackWizard.Attack()); 
            WriteLine(knight.Attack()); 
            WriteLine(wizard.Attack()); 
        }
    }
}
