using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Exercise 1");
            Oceanarium oceanarium = new Oceanarium();

            oceanarium.AddInhabitant(new Crocodil());
            oceanarium.AddInhabitant(new Turtle());
            oceanarium.AddInhabitant(new Stingray());
            oceanarium.AddInhabitant(new Octopus ());
            oceanarium.AddInhabitant(new Shark());
            oceanarium.AddInhabitant(new Jellyfish());
            oceanarium.AddInhabitant(new Starfish());
            
            foreach (var inhabitant in oceanarium)
            {
                Console.WriteLine(inhabitant.GetInformation());
            }

            Console.WriteLine("Exercise 2");
            FootballTeam team = new FootballTeam();

            // Добавляем игроков в команду
            
            team.AddPlayer(new FootballPlayer(1, "Heorhiy ", "Bushchan"));
            team.AddPlayer(new FootballPlayer(2, "Yukhym ", "Konoplya"));
            team.AddPlayer(new FootballPlayer(3, "Andriy ", "Lunin"));
            team.AddPlayer(new FootballPlayer(4, "Mhaylo", "Mudryk"));
            team.AddPlayer(new FootballPlayer(5, "Aleksandr","Karavaev"));
            team.AddPlayer(new FootballPlayer(6, "Mykola", "Matvienko"));
            team.AddPlayer(new FootballPlayer(7, "Artem", "Dovbyk"));
            team.AddPlayer(new FootballPlayer(8, "Andriyo", "Yarmolenko"));
            team.AddPlayer(new FootballPlayer(9, "Sergey", "Sidorchuk"));
            team.AddPlayer(new FootballPlayer(10, "llia", "Zabarnyi"));
            team.AddPlayer(new FootballPlayer(11, "Oleksandr","Zinchenko"));
            foreach (var player in team)
            {
                Console.WriteLine($"Football player: {player.GetInformation()}");
            }
            Console.WriteLine("Exercise 3");
            Cafe cafe = new Cafe();
            cafe.AddEmployee(new Employee("Director", "Denis Rybak", "Cafe operation management, strategy development"));
            cafe.AddEmployee(new Employee("Administrator", "Ekaterina Naumova", "Organization of visitor services, personnel management"));
            cafe.AddEmployee(new Employee("Cook", "Victor Kravchenko", "Cooking according to the menu"));
            cafe.AddEmployee(new Employee("Bartender", "Vitaly Kokin", "Drink preparation, bar service"));
            cafe.AddEmployee(new Employee("Waiter", "Dmitry Simirenko", "Serving visitors, serving food"));
            cafe.AddEmployee(new Employee("Cashier", "Kristina Luchko", "Conducting cash transactions, processing payments"));
            foreach (var employee in cafe)
            {
                Console.WriteLine($"Employee: {employee.GetInformation()}\n");
            }
        }
    }
}
  





    

    

