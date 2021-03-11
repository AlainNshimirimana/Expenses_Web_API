using Expenses.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Expenses.Core
{
    public interface IExpensesServices
    {
        List<Expense> GetExpenses();
    }
}
