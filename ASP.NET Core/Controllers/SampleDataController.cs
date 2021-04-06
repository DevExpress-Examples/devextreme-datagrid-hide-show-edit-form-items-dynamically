using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using ASP_NET_Core.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.GetEmployees(), loadOptions);
        }

        [HttpPost]
        public object Post(string values)
        {
            return Ok();
        }
        [HttpPut]
        public object Put(int key, string values)
        {
            return Ok();
        }

    }
}