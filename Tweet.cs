using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_sandbox
{
    class Tweet
    {
        public string Text;
        Coordinate cord;
        string time; //maybe change not to string

        //static Tweet Parser(string Stweet)
        //{
        //    Tweet buff = new Tweet();
        //    string[] tweet = Stweet.Split('	');
        //    buff.time = tweet[2];
        //    buff.Text = tweet[3];
        //    buff.cord = new Coordinate(tweet[0]);
        //    return buff;
        //}

        public Tweet (string Stweet)
        {
            string[] tweet = Stweet.Split('	');
            time = tweet[2];
            Text = tweet[3];
            cord = new Coordinate(tweet[0]);
        }
        public double Getmood()
        {
            double mood = 0;
            foreach (string text in Database.Getinstance().moodlist.Keys)
                if (Text.Contains(text))
                    mood += Database.Getinstance().moodlist[text];
            return mood;
        }
    }
}
