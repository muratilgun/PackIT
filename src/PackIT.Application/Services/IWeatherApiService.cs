using System.Threading.Tasks;
using PackIT.Application.DTO.External;
using PackIT.Domain.ValueObjects;

namespace PackIT.Application.Services
{
    public interface IWeatherApiService
    {
        Task<WeatherDto> GetWeatherAsync(Localization localization);
    }
}