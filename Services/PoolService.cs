using BlazorWebApp.Data;
using BlazorWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebApp.Services
{
    public class PoolService
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly IConfiguration _configuration;

        public PoolService(IDbContextFactory<AppDbContext> dbContextFactory, IConfiguration configuration)
        {
            _dbContextFactory = dbContextFactory;
            _configuration = configuration;
        }

        public async Task<List<PoolColumn>> GetPoolColumnsAsync(string poolName)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var pool = await context.PoolDefinitions
                .Include(p => p.Columns)
                .FirstOrDefaultAsync(p => p.Name == poolName);

            if (pool == null) return new List<PoolColumn>();

            return pool.Columns
                .OrderBy(c => c.OrderIndex)
                .Where(c => c.IsVisible)
                .ToList();
        }

        public async Task<(List<CommercialRecord> Items, int TotalCount)> GetCommercialRecordsAsync(int skip, int take)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var totalCount = await context.CommercialRecords.CountAsync();
            var items = await context.CommercialRecords
                .OrderBy(r => r.Id)
                .Skip(skip)
                .Take(take)
                .ToListAsync();

            return (items, totalCount);
        }

        public async Task<(List<ProjectRecord> Items, int TotalCount)> GetProjectRecordsAsync(int skip, int take)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var totalCount = await context.ProjectRecords.CountAsync();
            var items = await context.ProjectRecords
                .OrderBy(r => r.Id)
                .Skip(skip)
                .Take(take)
                .ToListAsync();

            return (items, totalCount);
        }
        public async Task<(List<Dictionary<string, object>> Items, int TotalCount)> GetDynamicRecordsAsync(string poolName, int skip, int take)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var pool = await context.PoolDefinitions.FirstOrDefaultAsync(p => p.Name == poolName);
            if (pool == null || string.IsNullOrEmpty(pool.TableName))
                return (new List<Dictionary<string, object>>(), 0);

            // Determine connection string
            string connectionString = !string.IsNullOrEmpty(pool.ConnectionString) 
                ? pool.ConnectionString 
                : _configuration.GetConnectionString("DefaultConnection");

            var result = new List<Dictionary<string, object>>();
            int totalCount = 0;

            try
            {
                using var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                await connection.OpenAsync();

                // Get Total Count
                string countQuery = $"SELECT COUNT(*) FROM [{pool.TableName}]";
                using (var countCmd = new Microsoft.Data.SqlClient.SqlCommand(countQuery, connection))
                {
                    totalCount = (int)await countCmd.ExecuteScalarAsync();
                }

                // Get Data
                // Note: We need a primary key for pagination. Assuming 'Id' exists for now.
                // In a truly generic scenario, we might need to define the PK in PoolDefinition.
                string dataQuery = $@"
                    SELECT * FROM [{pool.TableName}]
                    ORDER BY Id
                    OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY";

                using (var dataCmd = new Microsoft.Data.SqlClient.SqlCommand(dataQuery, connection))
                using (var reader = await dataCmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var columnName = reader.GetName(i);
                            var value = reader.GetValue(i);
                            row[columnName] = value == DBNull.Value ? null : value;
                        }
                        result.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching dynamic data for {poolName}: {ex.Message}");
                // In production, log this properly
            }

            return (result, totalCount);
        }
    }
}
