public interface ICepService
{
    Task<CepResponseDto> GetCep(string cep);
}