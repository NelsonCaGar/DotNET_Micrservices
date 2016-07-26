﻿using Microsoft.Extensions.Logging;

namespace Cik.Shared.Core
{
    public static class LoggerHelper
    {
        public static ILogger GetLogger<TType>() where TType : class
        {
            var loggerFactory = new LoggerFactory().AddConsole().AddDebug();
            return loggerFactory.CreateLogger<TType>();
        }
    }
}