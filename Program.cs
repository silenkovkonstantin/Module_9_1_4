using System;
using System.Threading;

namespace Module_9_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new("Что-то пошло не так");
            exception.HelpLink = "www.yandex.ru";

        }
    }
}