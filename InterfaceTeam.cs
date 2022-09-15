using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentProject_Cricket
{
    public interface InterfaceTeam
    {
        void Add(Player player);
        void Remove(int PlayerId);

        Player getPlayerbyId(int PlayerId);
        Player getPlayerbyName(string PlayerName);

        List<Player> getAllPlayers();

    }
}
