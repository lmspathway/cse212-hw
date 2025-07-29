using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FeatureCollection
{
    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

public class Feature
{
    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }
}

public class Properties
{
    [JsonPropertyName("place")]
    public string Place { get; set; }

    [JsonPropertyName("mag")]
    public double? Mag { get; set; }
}
