using System;

namespace CleanArchitectureSample1.UseCases
{
    public class AddTaskRequest
    {
        public string Title { get; internal set; }
        public DateTimeOffset DueDate { get; internal set; }
    }
}