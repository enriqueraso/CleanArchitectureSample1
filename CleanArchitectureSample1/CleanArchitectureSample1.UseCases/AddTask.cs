using CleanArchitectureSample1.Entities;
using System;

namespace CleanArchitectureSample1.UseCases
{
    public class AddTask
    {
        private readonly AddTaskRequest _request;
        private readonly ITaskRepository _repository;
        private readonly IClock _clock;

        public AddTask(AddTaskRequest request, ITaskRepository repository, IClock clock)
        {
            _request = request ?? throw new ArgumentNullException(nameof(request));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _clock = clock ?? throw new ArgumentNullException(nameof(clock));
        }

        public IAddRequestResult Execute()
        {
            DateTimeOffset now = _clock.OffsetNow;

            if (string.IsNullOrWhiteSpace(_request.Title))
            {
                return AddRequestResult.Fail("You're trying to add a task with an empty title");
            }

            if (_request.DueDate <= now)
            {
                return AddRequestResult.Fail("You're trying to add a task with a past due date.");
            }

            var task = new Task(_request.Title, _request.DueDate);
            _repository.Save(task);
            return AddRequestResult.Success();
        }
    }
}
