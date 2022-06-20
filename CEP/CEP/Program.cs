using CEP;
using System.Text.Json;

Console.WriteLine("Digite seu Cep: ") ;

string? cep = Console.ReadLine();

 
using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://viacep.com.br/");

    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, String.Format("ws/{0}/json/",cep));

    var response = client.Send(request);

    var end = JsonSerializer.Deserialize<Endereco>(response.Content.ReadAsStringAsync().Result);

   Console.WriteLine(end.cep+" ,"+ end.bairro + "," + end.localidade+ "," + end.complemento+ "," +end.ddd + "," +end.gia + "," + end.siafi);
    
  
}