public interface IDataAccess
{

  Task<List<TodoItem>> GetAsync();
  Task<string> GetByIdAsync(string id);
  Task PostAsync(TodoItem data);

}