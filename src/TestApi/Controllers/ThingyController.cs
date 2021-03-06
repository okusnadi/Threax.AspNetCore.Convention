﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Model;
using Threax.AspNetCore.ExceptionToJson;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    public class ThingyController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Thingy> Get()
        {
            throw new NotSupportedException();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Thingy Get(int id)
        {
            throw new ErrorResultException("This is a custom error", System.Net.HttpStatusCode.BadRequest);
        }

        // GET api/values/5
        [HttpPost()]
        [AutoValidate("Not a good thingy.")]
        public void Post(Thingy theThing)
        {
            Console.WriteLine(theThing.ToString());
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //[Route("[action]")]
        //public string Exception()
        //{
        //    throw new NotSupportedException();
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //[Route("[action]")]
        //public string CustomError()
        //{
        //    throw new ErrorResultException("This is a custom error", System.Net.HttpStatusCode.BadRequest);
        //}
    }
}
