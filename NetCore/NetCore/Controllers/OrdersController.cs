using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using NetCore.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.Controllers
{

    [Route("api/[controller]")]
    public class OrdersController : Controller
    {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.GetEmployees(), loadOptions);
        }
        //stub methods for CRUD operations
        [HttpPost]
        public object Post(string values) {
            return Ok();
        }
        [HttpPut]
        public object Put(int key, string values)
        {
            return Ok();
        }
    }
}