using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using Microsoft.AspNetCore.Mvc;

namespace BillingSuport.Controllers {

    [Route("api/[controller]")]
    public class ImportsController : Controller {
        [HttpGet("[action]")]
        public List<Billing.Core.Models.TEST> GetData() {
            var TMAppSettings = new Common.TMAppSettings();
            var a = TMAppSettings.GetSectionConnectionStrings();
            var sql = new TM.Connection.SQLServer();
            var rs = sql.Connection.Query<Billing.Core.Models.TEST>("SELECT * FROM TEST ORDER BY LEVELS").ToList();
            return rs;
        }
    }
}