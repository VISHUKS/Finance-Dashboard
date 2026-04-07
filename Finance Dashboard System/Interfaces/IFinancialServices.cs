using Finance_Dashboard_System.Models;

namespace Finance_Dashboard_System.Interfaces
{
    public interface IFinancialServices
    {
        public List<FinancialRecord> GetFinancialRecords();
        public FinancialRecord AddFinancialRecords(FinancialRecord fr);
        public FinancialRecord UpdateFinancialRecords(FinancialRecord fr);
        public FinancialRecord DeleteFinancialRecords(FinancialRecord fr);
        public List<FinancialRecord> GetRecordByCategory(string Category);
        public List<FinancialRecord> GetRecordByType(string Type);
        public List<FinancialRecord> GetRecordByRecordDate(DateTime RecordDate);

    }
}
