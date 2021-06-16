using System;

namespace Week02Task01
{
    struct User
    {
        public string UserName;
        public int PassWord;

        public User(string userName, int passWord)
        {
            this.UserName = userName;
            this.PassWord = passWord;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username daxil edin: ");
            string username = Console.ReadLine();
            Console.Write("Password daxil edin: ");
            int password = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            User u = new User("FikratMammadov", 12345);

            if (u.UserName == username && u.PassWord == password)
            {
                Console.WriteLine("Sayta xos gelmisiniz.");
            }
            else
            {
                Console.WriteLine("Username ve ya Password yalnisdir.");
            }
            
        }
    }
}
