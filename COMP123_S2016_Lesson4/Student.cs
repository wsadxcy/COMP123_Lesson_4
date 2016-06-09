using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * <summary>
     * This is the Student class. It is derived from the Person class
     * </summary>
     * 
     * @class Student
     * @extends Person
     */
    class Student : Person
    {
        private string _studentID;
        private List<Course> _courses = new List<Course>();

        /**
         * <summary>
         * This property, StudentID, includes a getter and setter for the private
         * instance variable _studentID
         * </summary>
         * 
         * @property StudentID
         */
         public string StudentID
        {
            get
            {
                return this._studentID;
            }

            set
            {
                this._studentID = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this._courses;
            }
            set
            {
                this._courses = value;
            }
        }
        /**
     * <summary>
     * This constructor takes three parameters: name, age and studentID
     * </summary>
     * 
     * @constructor Student
     * @extends Person
     * @param {string} name
     * @param {int} age
     * @param {string} studentID
     */
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            this.StudentID = studentID;

        }

        /**
         * <summary>
         * This method enables the Studies behaviour for the student
         * </summary>
         * 
         * @method Studies
         * @returns {void}
         */
        public void Studies()
        {
            Console.WriteLine(this.Name + " studies.");
        }
    }
}
