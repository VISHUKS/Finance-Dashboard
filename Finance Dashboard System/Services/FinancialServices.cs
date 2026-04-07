using Finance_Dashboard_System.Context;
using Finance_Dashboard_System.Interfaces;
using Finance_Dashboard_System.Models;

namespace Finance_Dashboard_System.Services
{
    public class FinancialServices:IFinancialServices
    {
        private readonly JwtContext _Context;
        public FinancialServices(JwtContext context)
        {
            _Context = context;
        }

        public FinancialRecord AddFinancialRecords(FinancialRecord fr)
        {
            var finRecord = _Context.FinancialRecords.Add(fr);
            _Context.SaveChanges();
            return finRecord.Entity;
        }
        public FinancialRecord UpdateFinancialRecords(FinancialRecord fr)
        {
            var finRecord = _Context.FinancialRecords.Update(fr);
            _Context.SaveChanges();
            return finRecord.Entity;
        }
        public FinancialRecord DeleteFinancialRecords(FinancialRecord fr)
        {
            var finRecord = _Context.FinancialRecords.Remove(fr);
            _Context.SaveChanges();
            return finRecord.Entity;
        }
        public List<FinancialRecord> GetFinancialRecords()
        {
            var finRecord = _Context.FinancialRecords.ToList();
            return finRecord;
        }

        public List<FinancialRecord> GetRecordByCategory(string Category)
        {
            var finRecord = _Context.FinancialRecords.ToList().Where(m=>m.Category== Category).ToList();
            return finRecord;
        }
        public List<FinancialRecord> GetRecordByType(string Type)
        {
            var finRecord = _Context.FinancialRecords.ToList().Where(m => m.RecordType == Type).ToList();
            return finRecord;
        }
        public List<FinancialRecord> GetRecordByRecordDate(DateTime RecordDate)
        {
            var finRecord = _Context.FinancialRecords.ToList().Where(m => Convert.ToDateTime(m.RecordDate).ToShortDateString() == Convert.ToDateTime(RecordDate).ToShortDateString()).ToList();
            return finRecord;
        }
    }
}
