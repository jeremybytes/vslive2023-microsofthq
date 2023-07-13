﻿using System.Text.Json;
using UsingTask.Shared;

namespace UsingTask.Library;

public class PersonReader
{
    private readonly HttpClient client = new() { BaseAddress = new Uri("http://localhost:9874") };
    private readonly JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true };

    public async Task<List<Person>> GetAsync(
        CancellationToken cancelToken = new CancellationToken())
    {
        await Task.Delay(3000, cancelToken);

        //throw new NotImplementedException("Jeremy did not implement GetAsync");

        cancelToken.ThrowIfCancellationRequested();

        HttpResponseMessage response =
            await client.GetAsync("people", cancelToken).ConfigureAwait(false);

        response.EnsureSuccessStatusCode();

        var stringResult =
            await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        var result = JsonSerializer.Deserialize<List<Person>>(stringResult, options);
        return result ?? new List<Person>();
    }
}
