using System.Text.Json;

namespace JsonProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Sabine", 27, false);
            Worker worker2 = new Worker("Jan", 28, true);
            Worker worker3 = new Worker("Bil", 27, false);


            string jsonStringWorker1 = JsonSerializer.Serialize(worker1); //serializer - helps us to make object as json string
            Console.WriteLine(jsonStringWorker1);


            File.WriteAllText("ThisIsWorker1.json", jsonStringWorker1); //making that info into a json file
            Console.WriteLine("++++++++++++++++++++++++++");

            Worker sameObjectWorker = JsonSerializer.Deserialize<Worker>(jsonStringWorker1); //json back to object

            Console.WriteLine($"Worker name: {sameObjectWorker.Name}");
            Console.WriteLine($"Worker age: {sameObjectWorker.Age}");
            Console.WriteLine($"Does worker has a car: {sameObjectWorker.Car}");

            List<Worker> workers = new List<Worker>();

            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);

            //now we want to put our list to json
            var jsonDataWorkers = JsonSerializer.Serialize(workers);

            Console.WriteLine(jsonDataWorkers);


            var listFromJson = JsonSerializer.Deserialize<List<Worker>>(jsonDataWorkers);

            var getLinq = from item in listFromJson
                          select item;


            ShowListValues(getLinq);

        }

        static void ShowListValues(IEnumerable<Worker> list)
        {
            foreach (Worker elementData in list)
            {
                Console.WriteLine($"Worker name: {elementData.Name}");
                Console.WriteLine($"Worker age: {elementData.Age}");
                Console.WriteLine($"Does worker has a car: {elementData.Car}");
            }
        }
    }
}