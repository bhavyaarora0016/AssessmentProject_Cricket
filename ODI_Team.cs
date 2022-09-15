using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentProject_Cricket
{
    public class ODI_Team : InterfaceTeam
    {
        public int count = 0;
        public int Capacity { get; set; }

        public static List<Player> ODIPlayerList = new List<Player>();

        public ODI_Team()
        {
            this.Capacity = 11;
        }

        public void Add()
        {
            if (count < Capacity)
            {
                Player p = new Player();

                Console.WriteLine("enter player id: ");
                p.PlayerId = Int32.Parse(Console.ReadLine());

                Console.WriteLine("enter player name: ");
                p.PlayerName = Console.ReadLine();

                Console.WriteLine("enter player age: ");
                p.PlayerAge = Convert.ToInt32(Console.ReadLine());

                ODIPlayerList.Add(p);
                count++;

            }
            else
            {
                Console.WriteLine("team capacity is full.");
            }
        }

        public void Add(Player player)
        {
            if (count < Capacity)
            {
                ODIPlayerList.Add(player);
                count++;
                Console.WriteLine("player added successfully.");
            }
            else
            {
                Console.WriteLine("team capacity full.");
            }

        }

        public List<Player> getAllPlayers()
        {
            return ODIPlayerList;
        }

        public void getAllPlayers1()
        {
            foreach (var item in ODIPlayerList)
            {
                Console.WriteLine("player id: " + item.PlayerId);
                Console.WriteLine("player name: " + item.PlayerName);
            }
            Console.WriteLine("-------------------");
        }

        public Player getPlayerbyId(int playerid)
        {
            var found = ODIPlayerList.Find(fx=> fx.PlayerId == playerid);

            if (found != null)
            {
                Console.WriteLine("player {0} found", playerid);
                Console.WriteLine("player id: " + found.PlayerId);
                Console.WriteLine("player name: " + found.PlayerName);

                return found;
            }
            else
            {
                Console.WriteLine("player {0} not found.", playerid);
                return null;
            }
        }

        public Player getPlayerbyName(string playername)
        {
            var found = ODIPlayerList.Find(fx => fx.PlayerName == playername);

            if (found != null)
            {
                Console.WriteLine("player {0} found", playername);
                Console.WriteLine("player id: " + found.PlayerId);
                Console.WriteLine("player name: " + found.PlayerName);

                return found;
            }
            else
            {
                Console.WriteLine("player {0} not found.", playername);
                return null;
            }
        }

        public void Remove(int PlayerId)
        {
            var found = ODIPlayerList.Single(rem => rem.PlayerId == PlayerId);

            if (found != null)
            {
                ODIPlayerList.Remove(found);
                this.count--;
                Console.WriteLine("player with ID {0} removed.", PlayerId);
            }
            else
            {
                Console.WriteLine("player with ID {0} not found.", PlayerId);
            }
        }


    }
}
