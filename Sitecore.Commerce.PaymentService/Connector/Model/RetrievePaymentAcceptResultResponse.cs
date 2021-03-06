﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RetrievePaymentAcceptResultResponse.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
// <summary>
//   Defines the RetrievePaymentAcceptResultResponse class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
// Copyright 2016 Sitecore Corporation A/S 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file  
// except in compliance with the License. You may obtain a copy of the License at 
//       http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed under the  
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,  
// either express or implied. See the License for the specific language governing permissions  
// and limitations under the License. 
// --------------------------------------------------------------------- 

namespace Sitecore.Commerce.PaymentService.Connector
{
    internal class RetrievePaymentAcceptResultResponse : ResponseBase
    {
        internal RetrievePaymentAcceptResultResponse(string locale, string serviceAccountId, string connectorName)
            : base(locale, serviceAccountId, connectorName)
        {
        }

        internal static Response ConvertTo(RetrievePaymentAcceptResultResponse acceptResultResponse)
        {
            var response = new Response();
            acceptResultResponse.WriteBaseProperties(response);
            return response;
        }
    }
}
