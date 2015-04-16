using System.Threading.Tasks;

namespace LeagueOfLegends.WebServices.Net.Interface
{
    public interface ILoLService
    {
        T Get<T>(IRequest request);

        Task<T> GetAsync<T>(IRequest request);
    }
}