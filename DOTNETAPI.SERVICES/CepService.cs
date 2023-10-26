using System.Text.Json;

namespace DOTNETAPI.SERVICES;

public class CepService : ICepService
{
    private readonly HttpClient _client;
    public CepService(HttpClient client)
    {   
        _client = client;
    }
    public async Task<CepResponseDto> GetCep(string cep = "01001-000")
    {
        var result = await this.GetCepFromApi(cep);
        return result;
    }

    private async Task<CepResponseDto> GetCepFromApi(string cep)
    {
        var response = await this._client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
        var result = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<CepResponseDto>(result);
    }
}