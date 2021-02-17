using System;

using FootballTeamGenerator.Common;
namespace FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;
        private Stats stats;
        public Player(string name, Stats stats)
        {
            Name = name;
            Stats = stats;
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
        public Stats Stats { get => stats; set => stats = value; }

        public double OverallSkill => Stats.AverageStats;

    }
}
