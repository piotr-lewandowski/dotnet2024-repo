using TerevintoSoftware.AspNetCore.Authentication.ApiKeys.Abstractions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class CacheService : IApiKeysCacheService
{
    private readonly KeyContext _keyContext;

    public CacheService(KeyContext keyContext)
    {
        _keyContext = keyContext;
    }

    public async ValueTask<string?> GetOwnerIdFromApiKey(string apiKey)
    {
        var key = await _keyContext.ApiKeys.SingleOrDefaultAsync(x => x.Value == apiKey);
        return key?.Client;
    }

    public async Task InvalidateApiKey(string apiKey)
    {
        var key = await _keyContext.ApiKeys.SingleOrDefaultAsync(x => x.Value == apiKey);
        if (key != null)
        {
            _keyContext.ApiKeys.Remove(key);
            await _keyContext.SaveChangesAsync();
        }
    }
}