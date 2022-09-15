using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentProject_Cricket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player pl1 = new Player(1,"rohit",26);
            Player pl2 = new Player(2,"rahul",24);
            Player pl3 = new Player(3, "kohli", 25);
            Player pl4 = new Player(4, "hardik", 22);
            Player pl5 = new Player(5, "deepak", 21);
            Player pl6 = new Player(6, "harshal", 27);
            Player pl7 = new Player(7, "suryakumar", 24);
            Player pl8 = new Player(8, "rishabh", 25);
            Player pl9 = new Player(9, "dinesh", 25);
            Player pl10 = new Player(10, "ashwin", 25);
            Player pl11 = new Player(11, "chahal", 25);
            Player pl12 = new Player(12, "arshdeep", 25);

            ODI_Team team = new ODI_Team();

            team.Add(pl1);
            team.Add(pl2);
            team.Add(pl3);
            team.Add(pl4);
            team.Add(pl5);
            team.Add(pl6);
            team.Add(pl7);
            team.Add(pl8);

            bool con = false;

            do
            {
                Console.WriteLine("1. Add player  2. Remove player(ID)  3. get player by ID  4. get player by name  5. get all players ");
                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        team.Add();
                        break;

                    case 2:
                        Console.WriteLine("enter player id: ");
                        int plid = Int32.Parse(Console.ReadLine());
                        team.Remove(plid);
                        break;

                    case 3:
                        Player p3 = new Player();
                        Console.WriteLine("enter player id: ");
                        int p3id = Int32.Parse(Console.ReadLine());
                        p3 = team.getPlayerbyId(p3id);
                        Console.WriteLine("player id: " + p3.PlayerId);
                        Console.WriteLine("player name: " + p3.PlayerName);
                        Console.WriteLine("player age: " + p3.PlayerAge);
                        break;

                    case 4:
                        Player p4 = new Player();
                        Console.WriteLine("enter player name: ");
                        string p4name = Console.ReadLine();
                        p4 = team.getPlayerbyName(p4name);
                        Console.WriteLine("player id: " + p4.PlayerId);
                        Console.WriteLine("player name: " + p4.PlayerName);
                        Console.WriteLine("player age: " + p4.PlayerAge);
                        break;

                    case 5:
                        team.getAllPlayers1();
                        break;


                    default:
                        break;
                }

                Console.WriteLine("continue? (y/n)");
                string ans =Console.ReadLine();

                if (ans == "y" || ans == "Y")
                {
                    con = true;
                }
                else
                {
                    con = false;
                }

            } while (con);



        }
    }
}
