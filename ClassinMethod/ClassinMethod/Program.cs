using System;

namespace ClassinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class user = new Class();
            Method1(ref user);
            Discord a = new Discord("Olgerd");
            Method2(a);
        }
        static void Method1(ref Class user) 
        {
            Console.WriteLine($"Имя:{user.name} || Фамилия:{user.surname} || Возраст:{user.age}");
        }

        static void Method2(Discord a) 
        {
            Console.WriteLine(a.nickname, a.ID, a.server);
        }

    }
    class Class
    {
        public int age = 16;
        public string name = "Олег";
        public string surname = "неизвестно";
    }
    class Discord 
    {
        public string nickname;
        public int ID = 1234;
        public string server = "DiscordServer";
        public void Nickname(string nickname) 
        {
            this.nickname = nickname;
        }
    }
}
