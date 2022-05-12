using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public int Weight { get; set; }
        public Exercise(string name)
        {
            Name = name;
            Reps = 5;
            Sets = 5;
            Weight = 60;
        }
    }
}
