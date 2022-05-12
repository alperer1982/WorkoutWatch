using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public WorkoutController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet] 
        public JsonResult Get(int id)
        {
            Workout workout = new Workout();

            workout.Exercises.Add(new Exercise("Squat"));
            if (id == 0)
            {
                workout.Exercises.Add(new Exercise("Bench press"));
                workout.Exercises.Add(new Exercise("Row"));
            }
            else
            {
                workout.Exercises.Add(new Exercise("Deadlift"));
                workout.Exercises.Add(new Exercise("Overhead press"));
            }

            return new JsonResult(workout);
        }
    }
}
