﻿// ***********************************************************************
// Assembly         : nem1-sdk
// Author           : kailin
// Created          : 01-25-2018
//
// Last Modified By : kailin
// Last Modified On : 02-01-2018
// ***********************************************************************
// <copyright file="XEM.cs" company="Nem.io">
// Copyright 2018 NEM
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace io.nem1.sdk.Model.Mosaics
{
    /// <summary>
    /// Describes the XEM mosaic definition.
    /// </summary>
    /// <seealso cref="Mosaic" />
    /// <inheritdoc />
    public class Xem : Mosaic
     {
        /// <summary>
        /// Divisibility
        /// </summary>
        public static  int Divisibility = 6;

        /// <summary>
        /// Initial supply
        /// </summary>
        public static  ulong InitialSupply = 8999999999;

        /// <summary>
        /// Is transferable
        /// </summary>
        public static  bool  IsTransferable = true;

        /// <summary>
        /// Is supply mutable
        /// </summary>
        public static  bool IsSupplyMutable = false;

        /// <summary>
        /// Is levy mutable
        /// </summary>
        public static bool IsLevyMutable = false;

        /// <summary>
        /// The mosaic name
        /// </summary>
        public new static string MosaicName = "xem";

        /// <summary>
        /// The namespace name
        /// </summary>
        public new static string NamespaceName = "nem";

        /// <summary>
        /// Initializes a new instance of the <see cref="Xem"/> class.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public Xem(ulong amount) : base("nem", "xem", amount)
         {
                
         }

        /// <summary>
        /// Create xem using whole xem as the unit.
        /// </summary>
        /// <param name="amount">The amount of XEM.</param>
        /// <returns>An instance of XEM.</returns>
        public static Xem CreateRelative(ulong amount)
         {
             var relativeAmount = (ulong)Math.Pow(10, Divisibility) * amount;

             return new Xem(relativeAmount);
         }

        /// <summary>
        /// Create xem using micro xem as the unit, 1 XEM = 1000000 micro XEM.
        /// </summary>
        /// <param name="amount">The amount of XEM.</param>
        /// <returns>An instance of XEM.</returns>
        public static Xem CreateAbsolute(ulong amount)
         {
             return new Xem(amount);
         }
     }
}
