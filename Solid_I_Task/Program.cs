

namespace I_Befor
{

    public interface HereketEt // HereketEt interfac e si Person butun metodlari tam uydu amma Car a uymadi ona gorede biz HereketEt interfacesini parcalamaliyiq 
    {

        void start();
        void finis();

        void sagaDon();
        void solaDon();

        void dirmas();
        void uz();

    }

    public class Person : HereketEt
    {
        public void dirmas()
        {
            Console.WriteLine("dirmas");
        }

        public void finis()
        {
            Console.WriteLine("dayan");
        }

        public void sagaDon()
        {
            Console.WriteLine("saga don");
        }

        public void solaDon()
        {
            Console.WriteLine("sola don");
        }

        public void start()
        {
            Console.WriteLine("basla");
        }

        public void uz()
        {
            Console.WriteLine("uz");
        }
    }




    public class Car : HereketEt
    {
        public void dirmas()
        {
            throw new NotImplementedException();
        }

        public void finis()
        {
            Console.WriteLine("dayan");
        }

        public void sagaDon()
        {
            Console.WriteLine("saga don");
        }

        public void solaDon()
        {
            Console.WriteLine("sola don");
        }

        public void start()
        {
            Console.WriteLine("basla");
        }

        public void uz()
        {
            throw new NotImplementedException();
        }
    }




}


namespace I_After
{

    public interface HereketEt  // burda ise interfacelerin meqsedi tam duzeldi ve Solide uyqun oldu
    {

        void start();
        void finis();

    }
    
    public interface DonusEt 
    {

        void sagaDon();
        void solaDon();

    }
     
    public interface Dirman
    {
        void dirman();
    }     
    public interface Uz
    {
        void uz();
    }






    public class Person : HereketEt , DonusEt, Dirman, Uz
    {
        public void dirman()
        {
            Console.WriteLine("dirmas");
        }

        public void finis()
        {
            Console.WriteLine("dayan");
        }

        public void sagaDon()
        {
            Console.WriteLine("saga don");
        }

        public void solaDon()
        {
            Console.WriteLine("sola don");
        }

        public void start()
        {
            Console.WriteLine("basla");
        }

        public void uz()
        {
            Console.WriteLine("uz");
        }
    }




    public class Car : HereketEt ,DonusEt
    {
      
        public void finis()
        {
            Console.WriteLine("dayan");
        }

        public void sagaDon()
        {
            Console.WriteLine("saga don");
        }

        public void solaDon()
        {
            Console.WriteLine("sola don");
        }

        public void start()
        {
            Console.WriteLine("basla");
        }

       
    }




}





