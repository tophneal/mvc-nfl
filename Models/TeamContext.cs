using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFL.Models
{
    public class TeamContext : DbContext
    {
       public TeamContext(DbContextOptions<TeamContext> options)
            : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Team> Conferences { get; set; }
        public DbSet<Team> Divisions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Conference>().HasData(
                new Conference { ConferenceId="afc", Name="AFC"},
                new Conference { ConferenceId="nfc", Name="NFC"}
                );

            modelBuilder.Entity<Division>().HasData(
                new Division { DivisionId = "north", Name = "North"},
                new Division { DivisionId = "south", Name = "South" },
                new Division { DivisionId = "east", Name = "East" },
                new Division { DivisionId = "west", Name = "West" }
                );

            modelBuilder.Entity<Team>().HasData(
                new { TeamId = "ari", Name = "Arizona Cardinals", ConferenceId = "nfc", DivisionId = "west", LogoImage = "ARI.png" },
                new { TeamId = "atl", Name = "Atlanta Falcons", ConferenceId = "nfc", DivisionId = "south", LogoImage = "ATL.png" },
                new { TeamId = "bal", Name = "Baltimore Ravens", ConferenceId = "afc", DivisionId = "north", LogoImage = "BAL.png" },
                new { TeamId = "buf", Name = "Buffalo Bills", ConferenceId = "afc", DivisionId = "east", LogoImage = "BUF.png" },
                new { TeamId = "car", Name = "Carolina Panthers", ConferenceId = "nfc", DivisionId = "south", LogoImage = "CAR.png" },
                new { TeamId = "chi", Name = "Chicago Bears", ConferenceId = "nfc", DivisionId = "north", LogoImage = "CHI.png" },
                new { TeamId = "cin", Name = "Cincinnati Bengals", ConferenceId = "afc", DivisionId = "north", LogoImage = "CIN.png" },
                new { TeamId = "cle", Name = "Cleveland Browns", ConferenceId = "afc", DivisionId = "north", LogoImage = "CLE.png" },
                new { TeamId = "dal", Name = "Dallas Cowboys", ConferenceId = "nfc", DivisionId = "east", LogoImage = "DAL.png" },
                new { TeamId = "den", Name = "Denver Broncos", ConferenceId = "afc", DivisionId = "west", LogoImage = "DEN.png" },
                new { TeamId = "det", Name = "Detroit Lions", ConferenceId = "nfc", DivisionId = "north", LogoImage = "DET.png" },
                new { TeamId = "gb", Name = "Green Bay Packers", ConferenceId = "nfc", DivisionId = "north", LogoImage = "GB.png" },
                new { TeamId = "hou", Name = "Houston Texans", ConferenceId = "afc", DivisionId = "south", LogoImage = "HOU.png" },
                new { TeamId = "ind", Name = "Indianapolis Colts", ConferenceId = "afc", DivisionId = "south", LogoImage = "IND.png" },
                new { TeamId = "jax", Name = "Jacksonville Jaguars", ConferenceId = "afc", DivisionId = "south", LogoImage = "JAX.png" },
                new { TeamId = "kc", Name = "Kansas City Chiefs", ConferenceId = "afc", DivisionId = "west", LogoImage = "KC.png" },
                new { TeamId = "lac", Name = "Los Angeles Chargers", ConferenceId = "afc", DivisionId = "west", LogoImage = "LAC.png" },
                new { TeamId = "lar", Name = "Los Angeles Rams", ConferenceId = "nfc", DivisionId = "west", LogoImage = "LAR.png" },
                new { TeamId = "mia", Name = "Miami Dolphins", ConferenceId = "afc", DivisionId = "east", LogoImage = "MIA.png" },
                new { TeamId = "min", Name = "Minnesota Vikings", ConferenceId = "nfc", DivisionId = "north", LogoImage = "MIN.png" },
                new { TeamId = "ne", Name = "New England Patriots", ConferenceId = "afc", DivisionId = "east", LogoImage = "NE.png" },
                new { TeamId = "no", Name = "New Orleans Saints", ConferenceId = "nfc", DivisionId = "south", LogoImage = "NO.png" },
                new { TeamId = "nyg", Name = "New York Giants", ConferenceId = "nfc", DivisionId = "east", LogoImage = "NYG.png" },
                new { TeamId = "nyj", Name = "New York Jets", ConferenceId = "afc", DivisionId = "east", LogoImage = "NYJ.png" },
                new { TeamId = "oak", Name = "Oakland RaIders", ConferenceId = "afc", DivisionId = "west", LogoImage = "OAK.png" },
                new { TeamId = "phi", Name = "Philadelphia Eagles", ConferenceId = "nfc", DivisionId = "east", LogoImage = "PHI.png" },
                new { TeamId = "pit", Name = "Pittsburgh Steelers", ConferenceId = "afc", DivisionId = "north", LogoImage = "PIT.png" },
                new { TeamId = "sea", Name = "Seattle Seahawks", ConferenceId = "nfc", DivisionId = "west", LogoImage = "SEA.png" },
                new { TeamId = "sf", Name = "San Francisco 49ers", ConferenceId = "nfc", DivisionId = "west", LogoImage = "SF.png" },
                new { TeamId = "tb", Name = "Tampa Bay Buccaneers", ConferenceId = "nfc", DivisionId = "south", LogoImage = "TB.png" },
                new { TeamId = "ten", Name = "Tennessee Titans", ConferenceId = "afc", DivisionId = "south", LogoImage = "TEN.png" },
                new { TeamId = "was", Name = "Washington Redskins", ConferenceId = "nfc", DivisionId = "east", LogoImage = "WAS.png" }
                );
        }
    }
}
