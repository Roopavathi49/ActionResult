using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ReceipeController : Controller
    {
       public string[] GetDishes()
        {
            string[] dishes = { "pottato", "chicken", "mutton" };
            return dishes;
        }
    }
}
