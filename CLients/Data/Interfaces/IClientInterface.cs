using CLients.Models;

namespace CLients.Data.Interfaces;

public interface IClientInterface
{
    Task CreateAsync(Client client);
    Task DeleteAsync(int id);
    Task<Client> GetByIdAsync(int id);
    Task<List<Client>> GetAllAsync();
    Task UpdateAsync(Client client);
}
