using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NWProductService.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    [JsonProperty(propertyName: "Name")]
    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    //public byte[]? Picture { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
