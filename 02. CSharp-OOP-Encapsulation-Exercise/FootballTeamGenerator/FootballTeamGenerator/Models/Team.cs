using System;
using System.Collections.Generic;
using System.Linq;

using FootballTeamGenerator.Common;

namespace FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private readonly ICollection<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstatnts.InvalidNameMsg);
                }
                name = value;
            }
        }

        public void AddPlayer(Player player) 
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName) 
        {
            Player playerToRemove = players.FirstOrDefault(p => p.Name == playerName);

            if (playerToRemove == null)
            {
                throw new InvalidOperationException(string.Format(
                    GlobalConstatnts.InvalidMissingPlayerMsg, playerName, this.Name));
            }

            players.Remove(playerToRemove);
        }

        public int Rating => (int) Math.Round(players.Average(p => p.OverallSkill));

        public override string ToString()
        {
            int rating = players.Count == 0 ? 0 : Rating;

            return $"{Name} - {rating}";
        }
    }
}
