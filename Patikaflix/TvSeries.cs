using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    public class TvSeries
    {
        public string TvName { get; set; }
        public int PublishingYear { get; set; }
        public List<string> Genres { get; set; }
        public int ReleaseYear { get; set; }
        public string Directors { get; set; }
        public string Platform { get; set; }

        //Constructor tanımladık.
        public TvSeries(string tvName, int publishingYear, List<string> genres, int releaseYear, string directors, string platform)
        {
            TvName = tvName;
            PublishingYear = publishingYear;
            Genres = genres;
            ReleaseYear = releaseYear;
            Directors = directors;
            Platform = platform;
        }

        //Tek türlü tv dizileri için overload constructor kullandık, bu şekilde hem tek türlü tv dizilerini yazdırırken hata almayacağız hem de çift türleri ayrı ayrı yazdırabileceğiz
        public TvSeries(string tvName, int publishingYear, string genres, int releaseYear, string directors, string platform) : this(tvName, publishingYear, new List<string> { genres }, releaseYear, directors, platform) { }

        public void GetTvSeries() //metot tanımladık.
        {
            string genresFormatted = string.Join(", ", Genres); //birden fazla türleri yazdırırken birleştirdik.

            Console.WriteLine($"Dizinin Adı: {TvName}");
            Console.WriteLine($"Yapım Yılı: {PublishingYear}");
            Console.WriteLine($"Türü: {genresFormatted}");
            Console.WriteLine($"Yayınlanmaya Başlama Yılı: {ReleaseYear}");
            Console.WriteLine($"Yönetmenler: {Directors}");
            Console.WriteLine($"Yayınlandığı İlk platform: {Platform}");


        }
    }
}
