// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Marketplace.SaaS.Models
{
    public partial class SubscriptionTerm
    {
        internal static SubscriptionTerm DeserializeSubscriptionTerm(JsonElement element)
        {
            Optional<DateTimeOffset> startDate = default;
            Optional<DateTimeOffset> endDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new SubscriptionTerm(Optional.ToNullable(startDate), Optional.ToNullable(endDate));
        }
    }
}
