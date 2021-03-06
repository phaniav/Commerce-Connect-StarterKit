﻿// ----------------------------------------------------------------------------------------------
// <copyright file="GetShippingMethodsRequest.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2016
// </copyright>
// <summary>Defines the GetShippingMethodsRequest class.</summary>
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
namespace Sitecore.Commerce.Connectors.NopCommerce.Services.Shipping
{
  using Commerce.Entities;
  using Commerce.Entities.Carts;
  using Commerce.Entities.Shipping;

  /// <summary>
  /// Defines the GetShippingMethodsRequest class.
  /// </summary>
  public class GetShippingMethodsRequest : Commerce.Services.Shipping.GetShippingMethodsRequest
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="GetShippingMethodsRequest" /> class.
    /// </summary>
    /// <param name="shippingOption">The shipping option.</param>
    /// <param name="party">The party.</param>
    public GetShippingMethodsRequest([NotNull] ShippingOption shippingOption,  [CanBeNull] Party party = null)
      : base(shippingOption, party)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GetShippingMethodsRequest" /> class.
    /// </summary>
    /// <param name="shippingOption">The shipping option.</param>
    /// <param name="cart">The cart.</param>
    /// <param name="party">The party.</param>
    public GetShippingMethodsRequest([NotNull] ShippingOption shippingOption, [CanBeNull] Cart cart, [CanBeNull] Party party = null)
      : base(shippingOption, party)
    {
      this.Cart = cart;
    }

    /// <summary>
    /// Gets or sets the cart.
    /// </summary>
    /// <value>
    /// The cart.
    /// </value>
    [CanBeNull]
    public Cart Cart { get; set; }
  }
}