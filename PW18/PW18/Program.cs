using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using CsvHelper;

namespace PW18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons;
            using (var reader = new StreamReader("persons.csv"))
            {
                using (var csv = new CsvReader(reader))
                {
                    persons = csv.GetRecords<Person>().ToList();
                }
            }

            var serializier = new SoapFormatter();

            using (var stream = File.Create("1.txt"))
            {
                serializier.Serialize(stream, persons);
            }


        }
    }
}
