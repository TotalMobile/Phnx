﻿using System;

namespace MarkSFrancis.AspNet.Core
{
    /// <summary>
    /// Extensions for <see cref="ErrorFactory"/>
    /// </summary>
    public static class ErrorFactoryExtensions
    {
        public static NullReferenceException HttpContextRequired(this ErrorFactory factory)
        {
            return new NullReferenceException("A http context is required");
        }
    }
}