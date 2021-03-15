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

        // delete an expense
        public void DeleteExpense(Expense expense)
        {
            _context.Expenses.Remove(expense);
            _context.SaveChanges();
        }

        // pass in an id and return an expense with that same id
        public Expense GetExpense(int id)
        {
            return _context.Expenses.First(e => e.Id == id);
        }

        // Gets all of the expenses
        public List<Expense> GetExpenses()
        {
            return _context.Expenses.ToList();
        }

        public Expense UpdateExpense(Expense expense)
        {
            var dbExpense = _context.Expenses.First(e => e.Id == expense.Id); // 1st find the expense that you want to update
            dbExpense.Description = expense.Description;  //update the old description with the new
            dbExpense.Amount = expense.Amount; //update the amount
            _context.SaveChanges(); //save the new changes

            return dbExpense;
        }
    }
}
