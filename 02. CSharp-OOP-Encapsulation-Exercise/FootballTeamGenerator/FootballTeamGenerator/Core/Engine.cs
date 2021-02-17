using System;
using System.Collections.Generic;
using System.Linq;

using FootballTeamGenerator.Models;
using FootballTeamGenerator.Common;

namespace FootballTeamGenerator.Core
{
    public class Engine
    {
        public Engine()
        {

        }

        public void Run() 
        {
            List<Team> teams = new List<Team>();

            while (true)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg[0] == "END")
                {
                    break;
                }

                try
                {
                    CommandCenter(cmdArg, teams);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            }
        
        }

        private void CommandCenter(string[] cmdArg, IList<Team> teams)
        {
            switch (cmdArg[0])
            {
                case "Team":
                    AddTeam(teams, cmdArg[1]);
                    break;
                case "Add":
                    Add(teams, cmdArg);
                    break;
                case "Remove":
                    Remove(teams.First(t => t.Name == cmdArg[1]), cmdArg[2]);
                    break;
                case "Rating":
                    GetRating(teams, cmdArg[1]);
                    break;
            }
        }

        private void AddTeam(IList<Team> teams, string teamName) 
        {
            teams.Add(new Team(teamName));
        }

        private void Add(IList<Team> teams, string[] cmdArg)
        {
            string teamName = cmdArg[1];
            Team team = teams.FirstOrDefault(t => t.Name == teamName );

            if (team == null)
            {
                throw new ArgumentException(string.Format(GlobalConstatnts.InvalidMissingTeamMsg, teamName));
            }

            team.AddPlayer(CreatePlayer(cmdArg));
        }

        private void Remove(Team team, string name) 
        {
            team.RemovePlayer(name);
        }

        private void GetRating(IList<Team> teams, string teamName) 
        {
            Team team = teams.FirstOrDefault(t => t.Name == teamName );

            if (team == null)
            {
                throw new ArgumentException(string.Format(GlobalConstatnts.InvalidMissingTeamMsg, teamName));
            }

            Console.WriteLine(team);
        }

        private Player CreatePlayer(string[] cmdArg) 
        {
            string name = cmdArg[2];

            int[] stats = cmdArg.Skip(3).Select(int.Parse).ToArray();

            int endurance = stats[0];
            int sprint = stats[1];
            int dribble = stats[2];
            int passing = stats[3];
            int shooting = stats[4];

            Player player = new Player(name, null);
            Stats newStats = new Stats(endurance, sprint, dribble, passing, shooting);
            player.Stats = newStats;
            return player;
        }
    }
}
