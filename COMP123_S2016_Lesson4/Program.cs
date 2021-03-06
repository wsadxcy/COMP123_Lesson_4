﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Student class
            Student Chen = new Student("Chen",22,"300709228");
            Chen.Age = 22;
            Chen.Name = "Chen";
            Chen.SaysHello();
            Chen.Studies();

            Chen.Courses.Add(new Course("COMP123", "Programming 2"));

            Teacher Xie = new Teacher("Xie", 22, "1231735671");
            Xie.SaysHello();
            Xie.Teaches();
            
        }
    }

}
