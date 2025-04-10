using System;
using System.Collections.Generic;

class MergeList
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    static void Main()
    {
        // First list
        List<Person> list1 = new List<Person>
        {
            new Person("Alice", 30),
            new Person("Bob", 25)
        };

        // Second list
        List<Person> list2 = new List<Person>
        {
            new Person("Charlie", 35),
            new Person("David", 40)
        };

        // Merging two lists
        List<Person> mergedList = MergeLists(list1, list2);

        // Output merged list
        foreach (var person in mergedList)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }

    // Method to merge two lists
    static List<Person> MergeLists(List<Person> list1, List<Person> list2)
    {
        List<Person> result = new List<Person>(list1);
        result.AddRange(list2);
        return result;
    }
}
