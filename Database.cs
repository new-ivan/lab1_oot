using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab1_sandbox
{
    class Database
    {
        static Database instance;
        public Dictionary<string, double> moodlist;
        public List<Tweet> alltweets;

        private Database()
        {
            //Reading moodlist
            moodlist = new Dictionary<string, double>();
            alltweets = new List<Tweet>();
            StreamReader sr = new StreamReader("sentiments.csv");
            if (!File.Exists("31 Seconds.mp3"))
                throw new FileNotFoundException("31 Seconds.mp3 missed");
            string[] buff1;
            buff1 = sr.ReadToEnd().Split('\n');
            foreach (string st in buff1)
            {
                if (st != string.Empty)
                    moodlist.Add(st.Split(',')[0], double.Parse(st.Split(',')[1].Replace('.', ',')));
            }
            //Reading tweets
            Readtweets("cali_tweets2014.txt");
            Readtweets("family_tweets2014.txt");
            Readtweets("football_tweets2014.txt");
            Readtweets("high_school_tweets2014.txt");
            Readtweets("movie_tweets2014.txt");
            Readtweets("shopping_tweets2014.txt");
            Readtweets("snow_tweets2014.txt");
            Readtweets("texas_tweets2014.txt");
            Readtweets("weekend_tweets2014.txt");
        }
        public static Database Getinstance()
        {
            if (instance == null) instance = new Database();
            return instance;
        }
        private void Readtweets(string name)
        {
            StreamReader sr = new StreamReader(name);
            string[] arr = sr.ReadToEnd().Split('\n');
            foreach (string tweet in arr)
                if (tweet != string.Empty)
                    alltweets.Add(new Tweet(tweet));
        }
    }
}
