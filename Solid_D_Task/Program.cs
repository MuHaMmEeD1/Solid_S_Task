

namespace D_Befor // bu duzgun bir code deyil ve Solid prinsiblerine uymur cunki Library boyuk classi Student clasindan aslidi 
{


    public class WorkerLibrary
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        
    }


    public class Student
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }

        internal void show()
        {
            Console.WriteLine($"name {Name}");
            Console.WriteLine($"surname {Surname}");
            Console.WriteLine($"age {Age}");
        }
    }




    public class Library
    {
        public WorkerLibrary? workerLibrary { get; set; }
        public List<Student>? student { get; set; }   


        public void showStudent()
        {
            for (int i = 0; i < student!.Count; i++)
            {
                student[i].show();
            }
        }





    }







}



namespace D_After // bu ise duzgundu cunku Library boyuk classi Student clasindan asli deyil onun basesinden aslidi
{


    public class WorkerLibrary
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }


    }


    public interface Customer
    {
        void show();

    }



    public class Student : Customer
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }

        public void show()
        {
            Console.WriteLine($"name {Name}");
            Console.WriteLine($"surname {Surname}");
            Console.WriteLine($"age {Age}");
        }
    }




    public class Library
    {
        public WorkerLibrary? workerLibrary { get; set; }
        public List<Customer>? customer { get; set; }


        public void showCustomer()
        {
            for (int i = 0; i < customer!.Count; i++)
            {
                customer[i].show();
            }
        }





    }







}






