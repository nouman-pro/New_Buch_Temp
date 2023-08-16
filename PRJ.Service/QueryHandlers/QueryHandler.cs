namespace PRJ.Service.QueryHandlers;
public static class QueryHandler
{
    public static async Task<bool> Execuete(string query)
    {
        using (var connection = new SqlConnection(ConfigurationStrings.DBConntectionString))
        {
            var result = await connection.ExecuteAsync(query);
            return true;
        }
    }
    public static async Task<T> Query<T>(string query)
	{
        using (var connection = new SqlConnection(ConfigurationStrings.DBConntectionString))
        {
            var result = await connection.QueryAsync<T>(query) ;
            return result.FirstOrDefault();
        }
    }

    public static async Task<List<T>> QueryList<T>(string query)
    {
        using (var connection = new SqlConnection(ConfigurationStrings.DBConntectionString))
        {
            var result = await connection.QueryAsync<T>(query);
            return result.ToList();
        }
    }

    //var results = connection.Query<string>(query);
    //StringBuilder stringBuilder = new StringBuilder();
    //        foreach (var result in results)
    //        {
    //            stringBuilder.Append(result);
    //        }
    //        return JsonConvert.DeserializeObject<List<T>>(stringBuilder.ToString());
}
