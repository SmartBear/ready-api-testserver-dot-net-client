using System;
using System.Collections.Generic;

namespace ReadyAPI.TestServer.Client
{
    public class Validator
    {
        public static void ValidateNotEmpty(string value, string message)
        {
            if (value == null || value.Length == 0)
            {
                throw new System.InvalidOperationException(message);
            }
        }

        public static void ValidateNotEmpty(int? value, String message)
        {
            if (value == null)
            { 
                throw new System.InvalidOperationException(message);
            }
        }

        public static void ValidateNotEmpty(List<object> values, String message)
        {
            if (values.Count == 0)
            {
                throw new System.InvalidOperationException(message);
            }
        }

        public static void ValidateNotEmpty(List<int?> values, String message)
        {
            if (values.Count == 0)
            {
                throw new System.InvalidOperationException(message);
            }
        }

    }
}
