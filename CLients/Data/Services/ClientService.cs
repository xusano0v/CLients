using CLients.Data.Interfaces;
using CLients.Models;
using Microsoft.EntityFrameworkCore;

namespace CLients.Data.Services;

public class ClientService(AppDbContext dbContext) : IClientInterface
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task CreateAsync(Client client)
    {
        var entity = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Email == client.Email);
        if (entity == null)
        {
            await _dbContext.Clients.AddAsync(client);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Id == id);
        if(entity is not null)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<List<Client>> GetAllAsync()
    {
        return await _dbContext.Clients.ToListAsync();
    }

    public async Task<Client> GetByIdAsync(int id)
    {
        var entity = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Id == id);

        if(entity is not null)
        {
            return entity;
        }
        return null;
    }

    public async Task UpdateAsync(Client client)
    {
        var entity = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Id == client.Id);

        if( entity is not null)
        {
            _dbContext.Update(client);
            await _dbContext.SaveChangesAsync();
        }
    }
}
