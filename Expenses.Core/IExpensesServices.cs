using Expenses.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Expenses.Core
{
    public interface IExpensesServices
    {
        List<Expense> GetExpenses();
        Expense GetExpense(int id);
        Expense CreateExpense(Expense expense);
        void DeleteExpense(Expense expense); //use "void" since we're not returning anything, we're just deleting
        Expense UpdateExpense(Expense expense);
    }
}
