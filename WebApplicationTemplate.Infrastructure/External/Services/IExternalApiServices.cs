using WebApplicationTemplate.Infrastructure.Model;

namespace WebApplicationTemplate.Infrastructure.External.Services;

public interface IExternalApiServices
{
    public Task<string> GetToken();
    public Task<string> GetProductType(ProductTypeModel model);
}