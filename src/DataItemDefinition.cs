﻿// Copyright (c) 2017 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using MTConnect;
using MTConnect.MTConnectDevices;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace TrakHound.DataClient
{
    public class DataItemDefinition
    {
        [JsonIgnore]
        public string Uuid { get; set; }

        //[JsonIgnore]
        //public SendItemType ItemType { get { return SendItemType.DATA_DEFINITION; } }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public DataItemCategory Catergory { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sub_type")]
        public string SubType { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        public DataItemDefinition() { }

        public DataItemDefinition(string deviceId, DataItem dataItem)
        {
            Init(deviceId, dataItem, null);
        }

        public DataItemDefinition(string deviceId, DataItem dataItem, string parentId)
        {
            Init(deviceId, dataItem, parentId);
        }

        private void Init(string deviceId, DataItem dataItem, string parentId)
        {
            DeviceId = deviceId;
            ParentId = parentId;

            Id = dataItem.Id;
            Name = dataItem.Name;
            Catergory = dataItem.Category;
            Type = dataItem.Type;
            SubType = dataItem.SubType;
        }
    }
}
