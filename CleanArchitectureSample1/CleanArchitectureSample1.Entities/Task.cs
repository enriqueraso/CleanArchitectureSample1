using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample1.Entities
{

    public class Task
    {
        public Task(string title, DateTimeOffset dueDate)
        {
            Title = title;
            DueDate = dueDate;
        }

        public string Title { get; private set; }

        public DateTimeOffset DueDate { get; private set; }

        public bool Finished { get; private set; }

        public void Postpone(int days)
        {
            if (Finished)
                throw new InvalidOperationException("It's not allowed to postpone a complete task.");

            if (days <= 0)
                throw new ArgumentOutOfRangeException();

            DueDate = DueDate.AddDays(days);
        }

        public void Complete()
        {
            Finished = true;
        }
    }
}
