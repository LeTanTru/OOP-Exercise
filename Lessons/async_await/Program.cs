using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.Windows.Forms;
using System.IO;

namespace async_await {
    internal class Program {

        static void DoSomeThing(int seconds, string message, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine($"{message} ...Start");
            Console.ResetColor();

            for(int i = 0; i <= seconds; i++) {

                Console.ForegroundColor = color;
                Console.WriteLine($"{message} {i}");
                Console.ResetColor();

                Thread.Sleep(1000);
            }
            Console.ForegroundColor = color;
            Console.WriteLine($"{message} ...End");
            Console.ResetColor();
        }

        static async Task Task2() {
            Task t2 = new Task(() => {
                DoSomeThing(10, "T2", ConsoleColor.Green);
            });

            t2.Start();

            //t2.Wait();
            await t2;

            Console.WriteLine("T2 da hoan thanh !");

            //return t2;
        }

        static async Task Task3() {
            Task t3 = new Task((Object obj) => {
                string taskName = (string)obj;
                DoSomeThing(4, taskName, ConsoleColor.Yellow);
            }, "T3");

            t3.Start();

            //t3.Wait();

            await t3;

            Console.WriteLine("T3 da hoan thanh !");

            //return t3;
        }

        //static async Task Abc() {
            //Task task = new Task(() => {

            //});
            //task.Start();
            //await task;

            //await File.WriteAlltTextAsync("test.txt", "content");
        //}

        static async Task<string> Task4() {
            Task<string> t4 = new Task<string>(() => {
                DoSomeThing(10, "T2", ConsoleColor.Green);
                return "return from T4";
            });
            t4.Start();
            var kq = await t4;
            Console.WriteLine("T4 hoan thanh");
            return kq;
        }

        static async Task<string> Task5() {
            Task<string> t5 = new Task<string>((object ob) => {

                string t = (string)ob;

                DoSomeThing(4, t, ConsoleColor.Yellow);
                return $"return from {t}";
            }, "T5");

            t5.Start();
            var kq = await t5;
            return kq;
        }

        static async Task<Object> Abc() {
            Task<Object> task = new Task<object>(() => {
                return new object();
            });
            task.Start();
            var kq = await task;
            return kq;
        }

        static async Task<string> GetWebScript(string url) {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
            string scripts = await httpResponseMessage.Content.ReadAsStringAsync();

            return scripts;

        }

        static async Task Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            var task = GetWebScript(@"https://xuanthulab.net/lap-trinh-bat-dong-bo-asynchronou-c-c-sharp-voi-bat-dong-bo-theo-mo-hinh-tac-vu.html");
            var content = await task;
            Console.WriteLine(content);

            //Task t2 = new Task(Action); // () => {}
            //Task t3 = new Task(Action<Object>, Object); // (Object obj) => {}

            //Task t2 = new Task(() => {
            //    DoSomeThing(10, "T2", ConsoleColor.Green);
            //});

            //Task t3 = new Task((Object obj) => {
            //    string taskName = (string)obj;
            //    DoSomeThing(4, taskName, ConsoleColor.Yellow);
            //}, "T3");

            //t2.Start();
            //t3.Start();


            //Task t2 = Task2();
            //Task t3 = Task3();

            //Task<string> t4 = new Task<string>(Func<string>);
            //Task<string> t5 = new Task<string>(Func<object, string>, object);   

            //Task<string> t4 = new Task<string>(() => {
            //    DoSomeThing(10, "T2", ConsoleColor.Green);
            //    return "return from T4";
            //});

            //Task<string> t5 = new Task<string>((object ob) => {

            //    string t = (string)ob;

            //    DoSomeThing(4, t, ConsoleColor.Yellow);
            //    return $"return from {t}";
            //}, "T5");

            //t4.Start();
            //t5.Start();


            //Task<string> t4 = Task4();
            //Task<string> t5 = Task5();

            //DoSomeThing(6, "T1", ConsoleColor.Magenta);
            //DoSomeThing(10, "T2", ConsoleColor.Green);
            //DoSomeThing(4, "T3", ConsoleColor.Yellow);


            //t2.Wait();
            //t3.Wait();
            //Task.WaitAll(t2, t3);
            //await t2;
            //await t3;

            //Task.WaitAll(t4, t5);
            //var kq4 = await t4;
            //var kq5 = await t5;

            //var kq4 = t4.Result;
            //var kq5 = t5.Result;
            //Console.WriteLine(kq4);
            //Console.WriteLine(kq5);

            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
        }
    }
}
