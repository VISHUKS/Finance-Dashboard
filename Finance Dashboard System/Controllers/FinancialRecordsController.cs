using Finance_Dashboard_System.Interfaces;
using Finance_Dashboard_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Finance_Dashboard_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinancialRecordsController : Controller
    {       
        private IFinancialServices _financialServices;
        public FinancialRecordsController(IFinancialServices financialServices)
        {
            _financialServices=financialServices;
        }

        [HttpPost("AddFRecord")]
        [Authorize(Roles = "Admin")]
        public FinancialRecord AddFinancialRecord([FromBody] FinancialRecord fr)
        {
            var frRecord = _financialServices.AddFinancialRecords(fr);
            return frRecord;
        }
        [HttpPost("UpdateFRecord")]
        [Authorize(Roles = "Admin")]
        public FinancialRecord UpdateFinancialRecords([FromBody] FinancialRecord fr)
        {
            var frRecord = _financialServices.UpdateFinancialRecords(fr);
            return frRecord;
        }
        [HttpPost("DeleteFRecord")]
        [Authorize(Roles = "Admin")]
        public FinancialRecord DeleteFinancialRecords([FromBody] FinancialRecord fr)
        {
            var frRecord = _financialServices.DeleteFinancialRecords(fr);
            return frRecord;
        }
        [HttpPost("GetFRecord")]
        [Authorize(Roles = "Admin,Viewer,Analyst")]
        public List<FinancialRecord> GetFinancialRecords()
        {
            var frRecord = _financialServices.GetFinancialRecords();
            return frRecord;
        }

        [HttpPost("GetRecordByCategory")]
        [Authorize(Roles = "Admin,Viewer,Analyst")]        
        public List<FinancialRecord> GetRecordByCategory([FromBody]string Category)
        {
            var frRecord = _financialServices.GetRecordByCategory(Category);
            return frRecord;
        }
        [HttpPost("GetRecordByType")]
        [Authorize(Roles = "Admin,Viewer,Analyst")]
        public List<FinancialRecord> GetRecordByType([FromBody] string Type)
        {
            var frRecord = _financialServices.GetRecordByType(Type);
            return frRecord;
        }
        [HttpPost("GetRecordByRecordDate")]
        [Authorize(Roles = "Admin,Viewer,Analyst")]
        public List<FinancialRecord> GetRecordByRecordDate([FromBody] DateTime RecordDate)
        {
            var frRecord = _financialServices.GetRecordByRecordDate(RecordDate);
            return frRecord;
        }
    }
}
