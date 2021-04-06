using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;

namespace NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : Controller
    {
        [HttpGet]
        public object Get([FromBody]DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.GetStates(), loadOptions);
        }
    }
}