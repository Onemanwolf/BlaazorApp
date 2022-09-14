using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

public class DataAccessService : IDataAccess
{
    [Inject]
    private  HttpClient _httpClient { get; set; }

    private List<TodoItem> _todoItems = new List<TodoItem>();

    public DataAccessService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<TodoItem>> GetAsync()
    {
        var todos = await Task.Run(() => {return _todoItems;});
        return todos;
    }

    public Task<string> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task PostAsync(TodoItem data)
    {
      await Task.Run(() => _todoItems.Add(data));
    }
}