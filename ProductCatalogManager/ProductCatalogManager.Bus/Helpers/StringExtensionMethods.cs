﻿using System;

namespace ProductCatalogManager.Bus.Helpers
{
    public static class StringExtensionMethods
    {
        public static bool Contains(this string source, string toFind, StringComparison comparisonCondition)
        {
            return source != null && toFind != null && source.IndexOf(toFind, comparisonCondition) >= 0;
        }
    }
}