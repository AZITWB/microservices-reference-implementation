﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System.Threading.Tasks;
using Fabrikam.DroneDelivery.DeliveryService.Models;

namespace Fabrikam.DroneDelivery.DeliveryService.Services
{
    public interface IDeliveryHistoryService
    {
        Task CompleteAsync(InternalDelivery delivery, InternalConfirmation confirmation, params DeliveryTrackingEvent[] deliveryTrackingEvents);
        Task CancelAsync(InternalDelivery delivery, params DeliveryTrackingEvent[] deliveryTrackingEvents);
    }
}