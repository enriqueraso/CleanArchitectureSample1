using CleanArchitectureSample1.Entities;

namespace CleanArchitectureSample1.UseCases
{
    public interface ITaskRepository
    {
        void Save(Task task);
    }
}