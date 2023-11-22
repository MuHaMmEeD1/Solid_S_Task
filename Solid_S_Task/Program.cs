


namespace Basla
{

    class Program
    {

        static void Main(string[] args)
        {

        }


    }


}



namespace S_Befor
{

    class Biznes // burada 1 class 3 classi evez edir SOLID qanunlarina uyqun deyil
    {

        public void ShowBuildingMaterials()
        {

        }
        public void ShowWeets()
        {

        }
        public void ShowWeapon()
        {

        }

    }

}

namespace S_After
{
    // burda ise SOLID qanunlarina esasen hazirlanmis code var

    // elave melumat muellim burda bu 3 classi Biznes interfac va ya abstract class dan toretmek olardi amma en aciq ve rahat izah bu olar diye fikirlesdim  

    class Building_Biznes
    {
        public void ShowBuildingMaterials() { }
    } 
    
    
    class Weet_Biznes
    {
        public void ShowWeets() { }
    }

     
    class Weapon_Biznes
    {
        public void ShowWeapon() { }
    }

}




