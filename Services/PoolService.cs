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
        public async Task<(List<BranchInspectionRecord> Items, int TotalCount)> GetBranchInspectionRecordsAsync(int skip, int take)
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var totalCount = await context.BranchInspections.CountAsync();
            var items = await context.BranchInspections
                .OrderBy(r => r.Id)
                .Skip(skip)
                .Take(take)
                .ToListAsync();

            return (items, totalCount);
        }

        public async Task<(List<Dictionary<string, object>> Items, int TotalCount)> GetDynamicRecordsAsync(string poolName, int skip, int take, string? filterProject = null, int? filterYear = null)
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

                // Build Where Clause
                var whereClauses = new List<string>();
                var parameters = new List<Microsoft.Data.SqlClient.SqlParameter>();

                if (!string.IsNullOrEmpty(filterProject))
                {
                    whereClauses.Add("Project = @Project");
                    parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@Project", filterProject));
                }
                if (filterYear.HasValue)
                {
                    whereClauses.Add("Year = @Year");
                    parameters.Add(new Microsoft.Data.SqlClient.SqlParameter("@Year", filterYear.Value));
                }

                string whereSql = whereClauses.Any() ? "WHERE " + string.Join(" AND ", whereClauses) : "";

                // Get Total Count
                string countQuery = $"SELECT COUNT(*) FROM [{pool.TableName}] {whereSql}";
                using (var countCmd = new Microsoft.Data.SqlClient.SqlCommand(countQuery, connection))
                {
                    foreach (var p in parameters) countCmd.Parameters.Add(new Microsoft.Data.SqlClient.SqlParameter(p.ParameterName, p.Value));
                    totalCount = (int)await countCmd.ExecuteScalarAsync();
                }

                // Get Data
                string dataQuery = $@"
                    SELECT * FROM [{pool.TableName}]
                    {whereSql}
                    ORDER BY Id
                    OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY";

                using (var dataCmd = new Microsoft.Data.SqlClient.SqlCommand(dataQuery, connection))
                {
                     foreach (var p in parameters) dataCmd.Parameters.Add(new Microsoft.Data.SqlClient.SqlParameter(p.ParameterName, p.Value));
                     
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching dynamic data for {poolName}: {ex.Message}");
                // In production, log this properly
            }

            return (result, totalCount);
        }
        public async Task<List<SearchResultItem>> SearchGlobalAsync(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return new List<SearchResultItem>();

            var results = new List<SearchResultItem>();
            using var context = await _dbContextFactory.CreateDbContextAsync();

            // 1. Search Projects
            var projects = await context.ProjectRecords
                .Where(p => p.ProjectName.Contains(query) || p.CustomerName.Contains(query))
                .Take(10)
                .ToListAsync();

            results.AddRange(projects.Select(p => new SearchResultItem
            {
                Id = p.Id.ToString(),
                Title = p.ProjectName,
                Subtitle = $"Müşteri: {p.CustomerName}",
                Type = "Proje",
                Url = "/data-pool-3",
                Icon = "bi-kanban"
            }));

            // 2. Search Commercial Records (DataPool2)
            var commercials = await context.CommercialRecords
                .Where(c => c.CustomerName.Contains(query) || c.Region.Contains(query) || c.Category.Contains(query))
                .Take(10)
                .ToListAsync();

            results.AddRange(commercials.Select(c => new SearchResultItem
            {
                Id = c.Id.ToString(),
                Title = c.CustomerName,
                Subtitle = $"Bölge: {c.Region} | Kategori: {c.Category}",
                Type = "Ticari",
                Url = "/data-pool-2",
                Icon = "bi-shop"
            }));

            // 3. Search Data Pool (Unified Data / SampleDatas)
            var generalData = await context.SampleDatas
                .Where(d => d.Name.Contains(query) || d.Customer.Contains(query) || d.Description.Contains(query))
                .Take(10)
                .ToListAsync();

            results.AddRange(generalData.Select(d => new SearchResultItem
            {
                Id = d.Id.ToString(),
                Title = d.Name,
                Subtitle = $"Müşteri: {d.Customer} | {d.Description}",
                Type = "Veri Havuzu",
                Url = "/data", // Main DataGrid page
                Icon = "bi-table"
            }));

            return results;
        }
    }
}
