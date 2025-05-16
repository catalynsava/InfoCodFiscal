using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace InfoCodFiscal;
class Program
{
    static async Task Main()
    {
        string cui = "19010927";
        string apiKey = "evv86DRmsKZW4SET245D-VMpWkUFzcjgzWfH1jhmXvcRxAcj9Q"; // înlocuiește cu cheia ta reală
        string url = $"https://api.openapi.ro/api/companies/{cui}";

        using (HttpClient client = new HttpClient())
        {
            // Adăugăm cheia API în header
            client.DefaultRequestHeaders.Add("x-api-key", apiKey);

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // ridică excepție dacă status != 2xx

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Răspuns API:");
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Eroare la apelul API: {ex.Message}");
            }
        }
    }
}
