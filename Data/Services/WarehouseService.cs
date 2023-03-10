using Microsoft.EntityFrameworkCore;
using WarehouseManagment.Data.Models;

namespace WarehouseManagment.Data.Services
{
	public class WarehouseService : IWarehouseService
	{
		private readonly ApplicationDbContext dbc;

		public WarehouseService(ApplicationDbContext dbc) 
		{ 
			this.dbc = dbc;
		}



        public List<Article> GetArticles()
		{
			var articles = from article in dbc.Articles
						   select new Article
						   {
							   ArticleID = article.ArticleID,
							   ArticleName = article.ArticleName,
							   Stock = article.Stock,
							   Unit = article.Unit,
							   Price = article.Price
						   };
			return articles.ToList();

		}

		public List<BusinessCase> GetBusinessCases()
		{
			var businessCases = from bc in dbc.BusinessCases
								join employee in dbc.Users on bc.EmployeeID equals employee.Id into employees
								orderby bc.BusinessCaseID ascending

								select new BusinessCase
								{
									BusinessCaseID = bc.BusinessCaseID,
									CreationTime = bc.CreationTime,
									Employee = bc.Employee
								};

			return businessCases.ToList();
		}

        public List<ProcessType> GetProcessTypes()
        {
			var processTypes = from process in dbc.ProcessTypes
							   select new ProcessType
							   {
								   ProcessTypeID= process.ProcessTypeID,
								   TypeName = process.TypeName
							   };
			return processTypes.ToList();
        }

        public int NewBusinessCase(string eMail)
		{
			var employee = dbc.Employees.Where(e => e.Email == eMail).Select(e => e.Id).FirstOrDefault();
			var businessCase = new BusinessCase();
            businessCase.CreationTime = DateTime.Now;
			businessCase.EmployeeID = employee; 
            dbc.Add(businessCase);
            dbc.SaveChanges();
			return businessCase.BusinessCaseID;
        }

        public void DeleteBusinessCase(BusinessCase businessCase)
        {
            dbc.Remove(businessCase);
			dbc.SaveChanges();
        }

        public void NewStockMovement(StockMovement movement)
        {
			dbc.Add(movement);
			dbc.SaveChanges();
        }

        public List<StockMovement> GetStockMovements(int businessCaseID)
        {
            var stockMovements = dbc.StockMovements
								.Include(movement => movement.Article)
								.Include(movement => movement.ProcessType)
								.Where(movement => movement.BusinessCaseID == businessCaseID)
								.ToList();
            return stockMovements;
        }

        public void DeleteStockMovement(StockMovement stockMovement)
        {
            dbc.Remove(stockMovement);
            dbc.SaveChanges();
        }

        public List<Employee> GetEmployees()
        {
            var employess = dbc.Employees.ToList();
			return employess;
        }

        public void EditBusinessCase(BusinessCase businessCase, string eMail)
        { 
			if(businessCase.EmployeeID == null)
			{
                var employee = dbc.Employees.Where(e => e.Email == eMail).Select(e => e.Id).FirstOrDefault();
				businessCase.EmployeeID = employee;
            }
            dbc.Update(businessCase); 
			dbc.SaveChanges();
        }
    }
}
