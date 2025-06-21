using Patikaflix;

class Program
{
    static void Main()
    {
        //Dizi oluşturuyoruz

        var tvSeriesList = new List<TvSeries>();
        string answer;

        do // en azından bir kere kullanıcıdan giriş almak için do while kullandık.
        {
            Console.Write("Dizinin Adını Giriniz: ");
            string tvName = Console.ReadLine();

            Console.Write("Dizinin Yapım Yılını Giriniz: ");
            int publishingYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dizinin Türünü Giriniz: ");
            string genres = Console.ReadLine();

            Console.Write("Dizinin Yayınlanmaya Başlama Yılını Giriniz: ");
            int releaseYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dizinin Yönetmenlerini Giriniz: ");
            string directors = Console.ReadLine();

            Console.Write("Dizinin Yayınlandığı İlk Platformu Giriniz: ");
            string platform = Console.ReadLine();

            var tvSeries = new TvSeries(tvName, publishingYear, genres, releaseYear, directors, platform);
            tvSeriesList.Add(tvSeries);

            Console.WriteLine();

            Console.Write("Yeni bir dizi eklemek istiyor musunuz?");

            Console.WriteLine();

            Console.Write("Evet/Hayır: ");

            answer = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();

        } while (answer == "evet");


        //Tüm dizileri yazdırıyoruz.

        Console.WriteLine("--Dizi Listesi--");
        Console.WriteLine();
        foreach (var tvSeries in tvSeriesList)
        {
            tvSeries.GetTvSeries();
            Console.WriteLine();
        }

        Console.WriteLine();
        //Linq sorguları

        //İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın (Yani başka bir class ihtiyacınız doğuyor.)
        Console.WriteLine("--Komedi Dizileri--");
        Console.WriteLine();

        var comedyList = tvSeriesList.Where(tvSeriesList => tvSeriesList.Genres.Any(g => g.ToLower().Contains("komedi")))
                                     .OrderBy(tvSeriesList => tvSeriesList.TvName)
                                     .ThenBy(tvSeriesList => tvSeriesList.Directors)
                                     .ToList();

        foreach (var comedy in comedyList) 
        {
            comedy.GetTvSeries();
            Console.WriteLine();
        }


    }
}