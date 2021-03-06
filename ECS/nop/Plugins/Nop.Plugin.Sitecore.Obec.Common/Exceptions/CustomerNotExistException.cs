﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomerNotExistException.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
// <summary>Defines the CustomerNotExistException class.</summary>
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
// -----------------------------------------------------------------
namespace Nop.Plugin.Sitecore.Commerce.Common.Exceptions
{
    using System;

    /// <summary>
    /// Customer does not exist exception.
    /// </summary>
    public class CustomerNotExistException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerNotExistException"/> class.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        public CustomerNotExistException(Guid customerId)
            : base(string.Format("The customer with ID {0} is not exist.", customerId))
        {
            this.CustomerId = customerId;
        }

        /// <summary>
        /// Gets the customer ID.
        /// </summary>
        public Guid CustomerId { get; private set; }
    }
}