

namespace O_Befor
{


    public class Teatr // bu code Solid prinsipilerine tamamiyle sefdi cunku sabah filimlerin qimeti ve ya sayi va ya filimin ozu deyisse alem deyecey bir birine
                       // gerek birde herseyi 0 dan deyisesen
    {

        public List<Filim>? Films { get; set; }   


        public void ShowFilmsBiletPrices()
        {


            for (int i = 0; i < Films?.Count; i++)
            {

                if (Films[i]?.filim_Bilet?.FilimName == "FILIM_ADI_1") { Console.WriteLine($"{Films[i]?.filim_Bilet?.FilimName} {Films[i]?.filim_Bilet?.Price * 0.9}"); } // 100 de 10 endirim
                else if (Films[i]?.filim_Bilet?.FilimName == "FILIM_ADI_2") { Console.WriteLine($"{Films[i]?.filim_Bilet?.FilimName} {Films[i]?.filim_Bilet?.Price * 0.85}"); } // 100 de 15 endirim
                else if (Films[i]?.filim_Bilet?.FilimName == "FILIM_ADI_3") { Console.WriteLine($"{Films[i]?.filim_Bilet?.FilimName} {Films[i]?.filim_Bilet?.Price * 0.80}"); } // 100 de 20 endirim
                else if (Films[i]?.filim_Bilet?.FilimName == "FILIM_ADI_4") { Console.WriteLine($"{Films[i]?.filim_Bilet?.FilimName} {Films[i]?.filim_Bilet?.Price * 0.75}"); } // 100 de 25 endirim
                else if (Films[i]?.filim_Bilet?.FilimName == "FILIM_ADI_5") { Console.WriteLine($"{Films[i]?.filim_Bilet?.FilimName} {Films[i]?.filim_Bilet?.Price * 0.70}"); } // 100 de 30 endirim
                else if (Films[i]?.filim_Bilet?.FilimName == "FILIM_ADI_6") { Console.WriteLine($"{Films[i]?.filim_Bilet?.FilimName} {Films[i]?.filim_Bilet?.Price * 0.65}"); } // 100 de 35 endirim
                else if (Films[i]?.filim_Bilet?.FilimName == "FILIM_ADI_7") { Console.WriteLine($"{Films[i]?.filim_Bilet?.FilimName} {Films[i]?.filim_Bilet?.Price * 0.60}"); } // 100 de 40 endirim
                else if (Films[i]?.filim_Bilet?.FilimName == "FILIM_ADI_8") { Console.WriteLine($"{Films[i]?.filim_Bilet?.FilimName} {Films[i]?.filim_Bilet?.Price * 0.55}"); } // 100 de 45 endirim

            }



        }


    }

    public class Filim
    {
        public Filim_Bilet? filim_Bilet { get; set; }




    }



    public class Filim_Bilet
    {
        public string? FilimName { get; set; }
        public double Price { get; set; }




    }






}


namespace O_After
{


    public class Teatr // hindi Solid pirinsiplerine uyur // yeni filimler ve ya endirim deyisse bile alem deymir bir birne
    {

        public List<Filim>? Films { get; set; }


        public void ShowFilmsBiletPrices()
        {


            for (int i = 0; i < Films?.Count; i++)
            {
                Films[i]?.filim_Bilet?.Show();
            }



        }


    }

    public class Filim
    {
        public Filim_Bilet? filim_Bilet { get; set; }




    }



    public class Filim_Bilet
    {
        public string? FilimName { get; set; }
        public double Price { get; set; }
        public double Endirim { get; set; } 

        public void Show()
        {

            
            Console.WriteLine($"{FilimName} {Price - (Price * Endirim)/100}");

        }

        


    }






}




