using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using Microsoft.AspNetCore.Mvc;

namespace BillingSuport.Controllers {

    [Route("api/[controller]")]
    public class ManagerTichHopController : Controller {
        [HttpGet("[action]")]
        public IActionResult Select(string sort, int page = 1, int per_page = 10) {
            try {
                var SQLServer = new TM.Connection.SQLServer();
                var sql = "SELECT TOP 30 * FROM db_goitichhop ORDER BY tengoi";
                var data = SQLServer.Connection.Query<Billing.Core.Models.db_goitichhop>(sql);
                var total = data.Count();
                var from = (page - 1)* per_page;
                data = data.Take(per_page).Skip(from);
                //
                SQLServer.Close();
                var last_page = Math.Ceiling(decimal.Parse(total.ToString())/ decimal.Parse(per_page.ToString()));
                return Json(new {
                    total = total,
                        per_page = per_page,
                        current_page = page,
                        last_page = 2,
                        next_page_url = "",
                        prev_page_url = "",
                        from = from + 1,
                        to = per_page * page,
                        sort = sort,
                        data = data
                });
            } catch (Exception ex) {
                return Json(new { Error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Select(int id) {
            try {
                var SQLServer = new TM.Connection.SQLServer();
                var sql = $"SELECT * FROM db_goitichhop WHERE id_goitichhop={id}";
                var data = await SQLServer.Connection.QueryAsync<Billing.Core.Models.db_goitichhop>(sql);
                var total = data.Count();
                //
                SQLServer.Close();
                return Json(new { total = total, data = data });
            } catch (Exception ex) {
                return Json(new { Error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Insert() {
            try {

                return Json(new { total = "Success" });
            } catch (Exception ex) {
                return Json(new { Error = ex.Message });
            }
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(Billing.Core.Models.db_goitichhop data) {
            try {
                var SQLServer = new TM.Connection.SQLServer();
                var sql = "SELECT TOP 30 * FROM db_goitichhop ORDER BY tengoi";

                //
                SQLServer.Close();
                return Json(new { total = "Success", data = data });
            } catch (Exception ex) {
                return Json(new { Error = ex.Message });
            }
        }

        [HttpPut("{id}"), ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Billing.Core.Models.db_goitichhop data) {
            try {
                var SQLServer = new TM.Connection.SQLServer();
                var sql = "SELECT TOP 30 * FROM db_goitichhop ORDER BY tengoi";

                //
                SQLServer.Close();
                return Json(new { total = "total", data = data });
            } catch (Exception ex) {
                return Json(new { Error = ex.Message });
            }
        }

        [HttpPost("Delete"), ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id) {
            try {
                var SQLServer = new TM.Connection.SQLServer();
                var sql = "SELECT TOP 30 * FROM db_goitichhop ORDER BY tengoi";
                //
                SQLServer.Close();
                return Json(new { total = "total", data = id });
            } catch (Exception ex) {
                return Json(new { Error = ex.Message });
            }
        }

        [HttpDelete, ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(string id) {
            try {
                var SQLServer = new TM.Connection.SQLServer();
                var sql = "SELECT TOP 30 * FROM db_goitichhop ORDER BY tengoi";
                //
                SQLServer.Close();
                return Json(new { total = "total", data = id });
            } catch (Exception ex) {
                return Json(new { Error = ex.Message });
            }
        }
    }
}