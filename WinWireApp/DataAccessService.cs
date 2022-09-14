using System.Net;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using Newtonsoft.Json;

public class DataAccessService : IDataAccess
{

    [Inject]
    private  IHttpClientFactory _httpClient { get; set; }
    private HttpClient _client { get; set; }
    public List<TodoItem>? todos { get; private set; }

    private List<TodoItem> _todoItems = new List<TodoItem>();

    public DataAccessService(IHttpClientFactory httpClient)
    {
        _httpClient = httpClient;

       _client = _httpClient.CreateClient("WinWireApp");


    }

    public async Task<List<TodoItem>> GetAsync()
    {


        try{
             _todoItems = await _client.GetFromJsonAsync<List<TodoItem>>("Todo");
        ;


        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);


        }


        return _todoItems;
    }

    public Task<string> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task PostAsync(TodoItem data)
    {
        data.Id = "1";
   
        try{
            await _client.PostAsJsonAsync<TodoItem>("Todo", data);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}