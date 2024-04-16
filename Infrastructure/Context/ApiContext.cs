using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{
    
}
