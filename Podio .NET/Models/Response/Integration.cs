﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PodioAPI.Models.Response
{
    public class Integration
    {
        [JsonProperty(PropertyName = "integration_id")]
        public int? IntegrationId { get; set; }

        [JsonProperty(PropertyName = "app_id")]
        public int? AppId { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "silent")]
        public bool? Silent { get; set; }

        [JsonProperty(PropertyName = "config")]
        public Dictionary<string, object> Config { get; set; }

        [JsonProperty(PropertyName = "mapping")]
        public Dictionary<string, object> Mapping { get; set; }

        [JsonProperty(PropertyName = "updating")]
        public bool? Updating { get; set; }

        [JsonProperty(PropertyName = "last_updated_on")]
        public DateTime? LastUpdatedOn { get; set; }

        [JsonProperty(PropertyName = "created_on")]
        public DateTime? CreatedOn { get; set; }

        [JsonProperty(PropertyName = "created_by")]
        public ByLine CreatedBy { get; set; }
    }
}
