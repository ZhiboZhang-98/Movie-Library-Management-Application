using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieLibraryApplication.BUS
{
    [Serializable]
    class Time
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }

        public Time()
        {

        }
        public Time(int hour, int minute, int second)
        {
            this.hour = Hour;
            this.minute = Minute;
            this.second = Second;
        }
        override 
        public string ToString()
        {
            string output;
            output = Hour + " : " + Minute + " : " + Second;
            return output;
        }
    }
    [Serializable]
    class Movie
    {
        private string movietitle;
        private Time duration;
        private EnumMovieType type;
        private string country;
        private string director;
        private int year;
        private EnumMovieLanguage language;
        private EnumMovieSubtitle subtitle;
        private string actor;
        private string awards;

        public string Movietitle { get => movietitle; set => movietitle = value; }
        
        public string Country { get => country; set => country = value; }
        public string Director { get => director; set => director = value; }
        public int Year { get => year; set => year = value; }
        public string Actor { get => actor; set => actor = value; }
        public string Awards { get => awards; set => awards = value; }
        internal EnumMovieType Type { get => type; set => type = value; }
        internal EnumMovieLanguage Language { get => language; set => language = value; }
        internal EnumMovieSubtitle Subtitle { get => subtitle; set => subtitle = value; }
        internal Time Duration { get => duration; set => duration = value; }

        public Movie()
        {

        }

        public Movie(string movietitle, Time duration, EnumMovieType type, string country, string director, int year, EnumMovieLanguage language, EnumMovieSubtitle subtitle, string actor, string awards)
        {
            this.Movietitle = movietitle; this.Duration = duration; this.Type = type; this.Country = country; this.Director = director; this.Year = year; this.Language = language; this.Subtitle = subtitle; this.Actor = actor; this.Awards = awards;
        }

        public String GetInfos()
        {
            String output;
            output = this.movietitle + "\t" + this.duration + "\t" + this.type + "\t" + this.country + "\t" + this.country + "\t " + this.director + "\t" + this.year + "\t" + this.language + "\t" + this.subtitle + "\t" + this.actor + "\t" + this.awards + "\n";
            return output;
        }
    }
}
