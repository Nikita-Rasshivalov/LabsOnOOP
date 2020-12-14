﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peoples
{
    /// <summary>
    /// HumansCreator class
    /// </summary>
    public class HumansCreator
    {
        /// <summary>
        /// Create human
        /// </summary>
        /// <param name="secondNmae"></param>
        /// <param name="birth">birth</param>
        /// <param name="status">status</param>
        /// <param name="data">data</param>
        /// <returnsHuman></returns>
        public static Human CreateHuman(string secondNmae, int birth, StatusOfHuman status,int[] load)
        {
            Human human = null;

            switch (status)
            {
                case StatusOfHuman.Teacher:
                    human = new Teacher(secondNmae, birth, load);
                    break;
                case StatusOfHuman.Student:
                    human = new Student(secondNmae,birth, load);
                    break;
                case StatusOfHuman.Bom:
                    human = new Bom(secondNmae, birth, load);
                    break;
            }
            return human;
        }
    }
}
