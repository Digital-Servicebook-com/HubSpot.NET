﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using HubSpot.NET.Api.Contact.Dto;
using HubSpot.NET.Api.EmailSubscriptions.Dto;
using HubSpot.NET.Core.Interfaces;

namespace HubSpot.NET.Api.EmailSubscriptions.Dto
{
    [DataContract]
    public class SubscriptionTypeListHubSpotModel : IHubSpotModel
    {
        [DataMember(Name = "subscriptionDefinitions")]
        public IList<SubscriptionTypeHubSpotModel> Types { get; set; } = new List<SubscriptionTypeHubSpotModel>();
        public bool IsNameValue => false;
    }
}
