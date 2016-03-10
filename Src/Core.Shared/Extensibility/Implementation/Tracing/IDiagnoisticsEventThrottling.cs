﻿// -----------------------------------------------------------------------
// <copyright file="IDiagnoisticsEventThrottling.cs" company="Microsoft">
// Copyright © Microsoft. All Rights Reserved.
// </copyright>
// <author>Sergei Nikitin: sergeyni@microsoft.com</author>
// <summary></summary>
// -----------------------------------------------------------------------

namespace Microsoft.HockeyApp.Extensibility.Implementation.Tracing
{
    using System.Collections.Generic;

    internal interface IDiagnoisticsEventThrottling
    {
        bool ThrottleEvent(int eventId, long keywords, out bool justExceededThreshold);

        IDictionary<int, DiagnoisticsEventCounters> CollectSnapshot();
    }
}