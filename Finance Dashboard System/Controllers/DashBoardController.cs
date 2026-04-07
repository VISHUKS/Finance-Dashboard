using Finance_Dashboard_System.Interfaces;
using Finance_Dashboard_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Dashboard_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
        private IFinancialServices _financialServices;
        public DashBoardController(IFinancialServices financialServices)
        {
            _financialServices = financialServices;
        }
        [HttpPost("GetIncomeExpense")]
        [Authorize(Roles = "Admin,Viewer,Analyst")]
        public decimal GetIncomeExpense([FromBody] string RecordType)
        {
            if (RecordType.ToUpper() == "NetBalance".ToUpper())
            {
                var frRecord = _financialServices.GetFinancialRecords().Sum(x => x.Amount);
                return frRecord;
            }
            else {
                var frRecord = _financialServices.GetFinancialRecords().Where(m => m.RecordType.ToUpper() == RecordType.ToUpper()).Sum(x => x.Amount);
                return frRecord;
            }
        }

        [HttpPost("GetCategoryWiseTotal")]
        [Authorize(Roles = "Admin,Viewer,Analyst")]
        public decimal GetCategoryWiseTotal([FromBody] string CategoryType)
        {
            var frRecord = _financialServices.GetFinancialRecords().Where(m => m.Category.ToUpper() == CategoryType.ToUpper()).Sum(x => x.Amount);
            return frRecord;
        }
        [HttpPost("GetMonthlyTrend")]
        [Authorize(Roles = "Admin,Viewer,Analyst")]
        public object GetMonthlyTrend([FromHeader] int Year, [FromHeader] int Month)
        {
            var frRecord = _financialServices.GetFinancialRecords().Where(m => (m.RecordDate).Year == Year && (m.RecordDate).Month == Month).GroupBy(x => x.RecordType).Select(group => new
            {
                TotalIncome = group.Where(r => r.RecordType == "income").Sum(r => r.Amount),
                TotalExpense = group.Where(r => r.RecordType == "expense").Sum(r => r.Amount)
            });
            return frRecord;
        }

        [HttpPost("GetYearlyTrend")]
        [Authorize(Roles = "Admin,Viewer,Analyst")]
        public object GetYearlyTrend([FromHeader] int Year) 
        {
            var frRecord = _financialServices.GetFinancialRecords().Where(m => (m.RecordDate).Year == Year).GroupBy(x => x.RecordType).Select(group => new
            {
                TotalIncome = group.Where(r => r.RecordType == "income").Sum(r => r.Amount),
                TotalExpense = group.Where(r => r.RecordType == "expense").Sum(r => r.Amount)
            });
            return frRecord;
        }

        [HttpPost("GetRecentActivity")]
        [Authorize(Roles = "Admin,Viewer,Analyst")]
        public object GetRecentActivity([FromHeader] int Year)
        {
            var frRecord = _financialServices.GetFinancialRecords().Where(m => Convert.ToDateTime(m.UpdatedAt) >= Convert.ToDateTime(DateTime.Now.AddMinutes(-120)));
            return frRecord;
        }
    }
}
