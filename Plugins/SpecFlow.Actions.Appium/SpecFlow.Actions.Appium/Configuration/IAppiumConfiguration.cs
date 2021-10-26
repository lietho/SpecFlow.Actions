﻿using System;
using System.Collections.Generic;

namespace SpecFlow.Actions.Appium.Configuration
{
    internal interface IAppiumConfiguration
    {
        Dictionary<string, string>? Capabilities { get; }

        int? Timeout { get; }

        bool LocalAppiumServerRequired { get; }

        Uri? ServerAddress { get; }
    }
}