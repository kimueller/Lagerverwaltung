using WarehouseManagment.Data.Models;

namespace WarehouseManagment.Data.Services
{
    public interface IWarehouseService
    {
        List<Article> GetArticles();

        List<BusinessCase> GetBusinessCases();
        int NewBusinessCase(string eMail);
        void DeleteBusinessCase(BusinessCase businessCase);
        void EditBusinessCase(BusinessCase businessCase, string eMail);

        List<ProcessType> GetProcessTypes();

        List<StockMovement> GetStockMovements(int businessCaseID);
        void NewStockMovement(StockMovement movement);
        void DeleteStockMovement(StockMovement movement);

        List<Employee> GetEmployees();
    }
}
