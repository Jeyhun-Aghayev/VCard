using System.ComponentModel;
using System.Text;
using CSharp.VCardCreation.Models;
using Newtonsoft.Json;

namespace CSharp.VCardCreation;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Olusturmak istediginiz kullanici sayisini belirtin:");
        int userCount = Convert.ToInt32(Console.ReadLine());

        try
        {
            await RequestApi.RequestFromApi(userCount);
            Console.WriteLine("Kullanici olusturma islemi basarili!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex}:{ex.Message}");
        }
    }
}