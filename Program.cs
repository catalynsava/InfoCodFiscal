using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace InfoCodFiscal;
class Program
{
    static async Task Main()
    {
        //19010927
        Console.WriteLine("introdu CUI:");

        string cui = Console.ReadLine();
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
                //Console.WriteLine("Răspuns API:");
                //Console.WriteLine(responseBody);

                var firma = JsonSerializer.Deserialize<FirmaInfo>(responseBody);

                Console.WriteLine("=== INFORMAȚII FIRMĂ ===");
                Console.WriteLine($"Denumire: {firma.denumire}");
                Console.WriteLine($"Adresa: {firma.adresa}");
                Console.WriteLine($"CIF: {firma.cif}");
                Console.WriteLine($"Registru com.: {firma.numar_reg_com}");
                Console.WriteLine($"Stare: {firma.stare}");
                Console.WriteLine($"Telefon: {firma.telefon}");
                Console.WriteLine($"TVA: {firma.tva}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Eroare la apelul API: {ex.Message}");
            }
        }
    }
}
