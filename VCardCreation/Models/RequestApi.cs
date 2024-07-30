using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace CSharp.VCardCreation.Models;

public class RequestApi
{
    // API'den belirtilen sayıda kullanıcı bilgisi isteyen metot
    static public async Task RequestFromApi(int userCount)
    {
        if (userCount > 5000) throw new ExceptionHandling.UserLimitException("En fazla 5000 yaratabilirsiniz.");
     
        try
        {
            string requestUrl = $"https://randomuser.me/api/?results={userCount}";
            using HttpClient client = new HttpClient();
            using HttpResponseMessage response = await client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode(); // Request unsucces : HTTPRequestException 

            string responseBody = await response.Content.ReadAsStringAsync();
            ResponseApi apiResult = JsonConvert.DeserializeObject<ResponseApi>(responseBody);

            Console.WriteLine($"Toplam olusturulan kullanici sayisi: {apiResult.Results.Count}");
            Console.WriteLine();
            foreach (var employees in apiResult.Results)
            {
                Console.WriteLine($"Id: {employees.Login.Uuid}");
                Console.WriteLine($"Name: {employees.Name.First} {employees.Name.Last}");
                Console.WriteLine($"Mail: {employees.Email}");
                Console.WriteLine($"Phone: {employees.Phone}");
                Console.WriteLine($"Country: {employees.Location.Country}");
                Console.WriteLine($"City: {employees.Location.City}");
                Console.WriteLine();
                VCardCreation.updateVCardContents(
                    employees.Name.First,
                    employees.Name.Last,
                    employees.Email,
                    employees.Phone,
                    employees.Login.Uuid,
                    employees.Location.Country,
                    employees.Location.City);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}