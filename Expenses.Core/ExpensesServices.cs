using Expenses.DB;
using System;
using System.Collections.Generic;

namespace Expenses.Core
{
    public class ExpensesServices : IExpensesServices
    {
        // create the constructors
        private AppDbContext _context;
        public ExpensesServices(AppDbContext context)
        {
            _context = context;
        }
        public List<Expense> GetExpenses()
        {
            throw new NotImplementedException();
        }
    }
}
