using System;

namespace Forecast
{
    class Author
    {
        public string id;
        public bool IsOnline;
        public void InfoAuthor()
        {
            Console.WriteLine($"ID:#{id} | | Status:{IsOnline}");
        }
        class Program
        {
            static void Main(string[] args)
            {
                Author user = new Author();
                user.id = "1234";
                user.IsOnline = false;
                user.InfoAuthor();

                Message message = new Message("petya");
                message.sendTime = DateTime.Now;
                message.content = "SuperSecret text";
                message.isReply = true;
                message.WriteMessageToConsole();

            }
        }
        class Message
        {
            public string username;
            public DateTime sendTime;
            public string content;
            public bool isRead = false;
            public bool isReply;
            public Message(string username)
            {
                this.username = username;
            }
            public void WriteMessageToConsole()
            {
                Console.WriteLine($"@{username}: {content} | {sendTime} | is read:{isRead}| is reply: {isReply}");
            }
        }

    }
}