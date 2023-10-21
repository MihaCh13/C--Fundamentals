using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersInWagon = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string wagonsOrPassengers = Console.ReadLine();

                if (wagonsOrPassengers == "end")
                {
                    break;
                }

                ProcessInput(passengersInWagon, capacity, wagonsOrPassengers);
            }

            Console.WriteLine(string.Join(" ", passengersInWagon));
        }

        static void ProcessInput(List<int> passengersInWagon, int capacity, string input)
        {
            List<string> passengers = input.Split(' ').ToList();

            if (passengers[0] == "Add")
            {
                passengers.Remove("Add");
                List<int> passenger = passengers.Select(int.Parse).ToList();
                AddWagon(passengersInWagon, passenger);
            }
            else
            {
                List<int> passenger = passengers.Select(int.Parse).ToList();
                ProcessPassengers(passengersInWagon, passenger, capacity);
            }
        }

        static void AddWagon(List<int> passengersInWagon, List<int> newPassengers)
        {
            passengersInWagon.AddRange(newPassengers);
        }

        static void ProcessPassengers(List<int> passengersInWagon, List<int> newPassengers, int capacity)
        {
            int singleNumber = newPassengers[0];
            newPassengers.RemoveAt(0);

            for (int i = 0; i < passengersInWagon.Count; i++)
            {
                if ((passengersInWagon[i] + singleNumber) <= capacity)
                {
                    passengersInWagon[i] += singleNumber;
                    break;
                }
            }
        }
    }
}
