using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class FootballTeam : IEnumerable<FootballPlayer>
    {
        private List<FootballPlayer> players = new List<FootballPlayer>();

        
        public void AddPlayer(FootballPlayer player)// Метод для добавления игрока в команду
        {
            players.Add(player);
        }

        
        public IEnumerator<FootballPlayer> GetEnumerator()// Реализация GetEnumerator для IEnumerable
        {
            return players.GetEnumerator();
        }

        
        IEnumerator IEnumerable.GetEnumerator()// Реализация GetEnumerator для IEnumerable (неявный метод)
        {
            return GetEnumerator();
        }
    }
}
    