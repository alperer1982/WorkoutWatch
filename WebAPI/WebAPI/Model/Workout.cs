using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Workout
    {
        public List<Exercise> Exercises { get; set; }
        public int Rest { get; set; }
        public Workout()
        {
            Exercises = new List<Exercise>();
            Rest = 90;
        }
    }
}
