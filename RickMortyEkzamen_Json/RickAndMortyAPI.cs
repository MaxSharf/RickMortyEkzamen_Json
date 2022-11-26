using System.Collections.Generic;

namespace RickMortyEkzamen_Json
{
    public class RickAndMortyAPI
    {

        public Info info { get; set; }

        public List<Character> results { get; set; }

    }

    public class Character
    {
        public string name { get; set; }

        public string image { get; set; }

        public string url { get; set; }

        public override string ToString()
        {
            return $"{name}";
        }
    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }

        public string next { get; set; }
    }
}