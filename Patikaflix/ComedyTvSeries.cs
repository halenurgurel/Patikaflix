using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    public class ComedyTvSeries
        //properties tanımladık
    {
        public string TvName { get; set; }
        public string Genres { get; set; }
        public string Directors { get; set; }

        //structor tanımladık
        public ComedyTvSeries(string tvName, string genres, string directors)
        {
            TvName = tvName;
            Genres = genres;
            Directors = directors;
        }

        public void GetComedyTvSeries() 
        {
            Console.WriteLine($"Dizinin Adı: {TvName}");
            Console.WriteLine($"Dizinin Türü: {Genres}");
            Console.WriteLine($"Dizinin Yönetmeni: {Directors}");
        }
    }
}
