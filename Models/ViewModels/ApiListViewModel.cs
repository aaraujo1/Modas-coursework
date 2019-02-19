using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Modas.Models.ViewModels
{
    public class ApiListViewModel
    {
        public IEnumerable<ApiViewEvent> Events { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
    public class ApiViewEvent
    {
        /*
        public int EventId { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Flagged { get; set; }
        public string LocationName { get; set; }
        */

        /*
    [JsonProperty(PropertyName = "id")]
    public int EventId { get; set; }
    [JsonProperty(PropertyName = "ts")]
    public DateTime TimeStamp { get; set; }
    [JsonProperty(PropertyName = "flag")]
    public bool Flagged { get; set; }
    [JsonProperty(PropertyName = "loc")]
    public string LocationName { get; set; }
    */

        [JsonProperty(PropertyName = "")]
        public int EventId { get; set; }
        [JsonProperty(PropertyName = "⏰")]
        public DateTime TimeStamp { get; set; }
        [JsonProperty(PropertyName = "⚐")]
        public bool Flagged { get; set; }
        [JsonProperty(PropertyName = "✆")]
        public string LocationName { get; set; }
    }
}