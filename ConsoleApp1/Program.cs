using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listeler();
            //TryThis();
            HandleException(() =>
            {
                Liste();
            });
            Console.ReadKey();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Liste()
        {
            List<string> students = new List<string> { "Adem", "Mehmet", "Berat" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
        }

        private static void TryThis()
        {
            try
            {
                string[] students = new string[3] { "Adem", "Mehmet", "Hayri" };
                students[3] = "Jonathan";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void Listeler()
        {
            List<string> liste = new List<string>();
            liste.Add("test");
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
