﻿//----------------------------------------------------------------------- 
// PDS WITSMLstudio Store, 2017.2
//
// Copyright 2017 PDS Americas LLC
// 
// Licensed under the PDS Open Source WITSML Product License Agreement (the
// "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.pds.group/WITSMLstudio/OpenSource/ProductLicenseAgreement
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using PDS.WITSMLstudio.Data.ChangeLogs;

namespace PDS.WITSMLstudio.Store.Providers.StoreNotification
{
    /// <summary>
    /// Defines a method that can be used to send change notification messages.
    /// </summary>
    public interface IStoreNotificationProducer
    {
        /// <summary>
        /// Sends the notification messages for the speficed entity.
        /// </summary>
        /// <typeparam name="T">The data object type.</typeparam>
        /// <param name="entity">The changed entity.</param>
        /// <param name="auditHistory">The audit history.</param>
        void SendNotifications<T>(T entity, DbAuditHistory auditHistory);
    }
}