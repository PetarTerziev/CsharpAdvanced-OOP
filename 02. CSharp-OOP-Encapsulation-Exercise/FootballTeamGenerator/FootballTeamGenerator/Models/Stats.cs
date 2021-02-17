using System;

using FootballTeamGenerator.Common;

namespace FootballTeamGenerator.Models
{
    public class Stats
    {
        private const int MIN_STATS = 0;
        private const int MAX_STATS = 100;
        private const double STATS_COUNT = 5;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance 
        { 
            get => endurance;
            set 
            {
                if (value < MIN_STATS || value > MAX_STATS)
                {
                    throw new ArgumentException(string.Format(
                        GlobalConstatnts.InvalidStatsMsg, "Endurance", MIN_STATS, MAX_STATS));
                }

                endurance = value;
            }
                
        }
        public int Sprint 
        {
            get => sprint;
            set
            {
                if (value < MIN_STATS || value > MAX_STATS)
                {
                    throw new ArgumentException(string.Format(
                        GlobalConstatnts.InvalidStatsMsg, "Sprint", MIN_STATS, MAX_STATS));
                }

                sprint = value;
            }

        }
        public int Dribble 
        {
            get => dribble;
            set
            {
                if (value < MIN_STATS || value > MAX_STATS)
                {
                    throw new ArgumentException(string.Format(
                        GlobalConstatnts.InvalidStatsMsg, "Dribble", MIN_STATS, MAX_STATS));
                }

                dribble = value;
            }
        }
        public int Passing 
        {
            get => passing;
            set
            {
                if (value < MIN_STATS || value > MAX_STATS)
                {
                    throw new ArgumentException(string.Format(
                        GlobalConstatnts.InvalidStatsMsg, "Passing", MIN_STATS, MAX_STATS));
                }

                passing = value;
            }

        }
        public int Shooting 
        {
            get => shooting;
            set
            {
                if (value < MIN_STATS || value > MAX_STATS)
                {
                    throw new ArgumentException(string.Format(
                        GlobalConstatnts.InvalidStatsMsg, "Shooting", MIN_STATS, MAX_STATS));
                }

                shooting = value;
            }
        }

        public double AverageStats => CalculateSkillLevel();

        private double CalculateSkillLevel()
        {
            return (endurance + sprint + dribble + passing + shooting)/STATS_COUNT;
        }                      
    }                          
}                             
                             