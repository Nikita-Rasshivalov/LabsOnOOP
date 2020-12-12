﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Peoples;

namespace InfoAboutHumans
{
    public class Reader
    {
        public static List<Human> GetTrips(string path)
        {
            List<Human> humans = new List<Human>();
            int addedNumber = 0;
            List<string> data = GetData(path);
            foreach (var stringHuman in data)
            {
                string[] humanValues = stringHuman.Split();
                string secondName = humanValues[0];

                StatusOfHuman status;
                Enum.TryParse(humanValues[2], out status);
                int birthDate;
                int.TryParse(humanValues[1], out birthDate);
                
       
                List<string> stringLoad = new List<string>();
                for (var i = 3; i < humanValues.Length; i++)
                {
                    stringLoad.Add(humanValues[i]);
                }

                int[] load = ParseLoad(stringLoad);

                Human human = HumansCreator.CreateHuman(secondName, birthDate, status, load);
                if (human != null)
                {
                    humans.Add(human);
                    addedNumber++;
                }
            }
            return humans;
        }

        static int[] ParseLoad(List<string> values)
        {
            List<int> loadList = new List<int>();
            int numberOfLoad = 0;
            foreach (string value in values)
            {
                int load;
                if (int.TryParse(value, out load))
                {
                    loadList.Add(load);
                    numberOfLoad++;
                }
            }
            int[] loads = new int[numberOfLoad];
            loadList.CopyTo(loads);
            return loads;
        }
        /// <summary>
        /// Gets data
        /// </summary>
        /// <returns>Data</returns>

        private static List<string> GetData(string path)
        {
            List<string> data = new List<string>();
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    data.Add(sr.ReadLine());
                }
            }
            return data;
        }

       
        public static void UpdateFile(List<Human> humans, string path)
        {
            using (var sw = new StreamWriter(path))
            {
                foreach (var human in humans)
                {
                    sw.WriteLine(human.GetInfo());
                }

            }
        }
    }
}
