using Expenses.DB;
using System;
using System.Collections.Generic;
using System.Linq;

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

        // This will be used to add expenses to the list of expenses
        public Expense CreateExpense(Expense expense)
        {
            _context.Add(expense); 
            _context.SaveChanges();  // saves the new expense to the database

            return expense;
        }

        // pass in an id and return an expense with that same id
        public Expense GetExpense(int id)
        {
            return _context.Expenses.First(e => e.Id == id);
        }

        public List<Expense> GetExpenses()
        {
            return _context.Expenses.ToList();
        }
    }
}
