

namespace L_Befor
{


    public class Zoo // burada Bear Animali evez ede bilmir cunki Animals icerisinde Bear saxlansa basedeki metod isleyir
    {
        public List<Animal>? Animals { get; set; }   




        public void ShowAnimalsPover()
        {

            for (int i = 0; i < Animals!.Count; i++)
            {
                Animals[i].LiftingPowe();
            }

        }



    }



    public class Animal
    {

        public string? name { get; set; }
        public int Age { get; set; }
        public double Power { get; set; }


        public void LiftingPowe()
        {
            Console.WriteLine($"{name} gücünün həddi budur {Power} ");
        }

    }

   

    public class Bear : Animal
    {
        public double ForeverPower { get; set; }




    }








}

namespace L_After
{


    public class Zoo // burda ise Animals icinde Bear olas bile direved base ni evez ede bilir
    {
        public List<Animal>? Animals { get; set; }




        public void ShowAnimalsPover()
        {

            for (int i = 0; i < Animals!.Count; i++)
            {
                Animals[i].LiftingPowe();
            }

        }



    }



    public class Animal
    {

        public string? name { get; set; }
        public int Age { get; set; }
        public double Power { get; set; }


        public virtual void LiftingPowe()
        {
            Console.WriteLine($"{name} gücünün həddi budur {Power} ");
        }

    }



    public class Bear : Animal
    {
        public double ForeverPower { get; set; }

        public override void LiftingPowe()
        {
            Console.WriteLine($"{name} gücünün həddi budur {Power + ForeverPower} ");
        }


    }







}














