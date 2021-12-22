using CEP;
using System.Text.Json;

string cep = "";
cep = Console.ReadLine();

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://viacep.com.br/");

    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, String.Format("ws/{0}/json/",cep));

    var response = client.Send(request);

    var end = JsonSerializer.Deserialize<Endereco>(response.Content.ReadAsStringAsync().Result);

    Console.WriteLine(end.bairro + ", "+end.localidade);
}