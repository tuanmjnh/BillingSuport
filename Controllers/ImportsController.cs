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
        public async Task<IActionResult> GetData(string sort, int page, int per_page) {
            var TMAppSettings = new Common.TMAppSettings();
            var a = TMAppSettings.GetSectionConnectionStrings();
            var sql = new TM.Connection.SQLServer();
            var data = await sql.Connection.QueryAsync<Billing.Core.Models.TEST>("SELECT * FROM TEST ORDER BY LEVELS");
            var total = data.Count();
            return Json(new { total = total, data = data });
        }
    }
}