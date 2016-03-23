﻿namespace ReadyAPI.TestServer.Client.Execution
{
    public class Scheme
    {
        private static readonly string HTTP_SCHEME = "http";
        private static readonly string HTTPS_SCHEME = "https";

        private string _value;

        private Scheme(string value)
        {
            this._value = value;
        }

        public string Value
        {
            get
            {
                return _value;
            }
        }

        public static Scheme HTTP
        {
            get { return new Scheme(HTTP_SCHEME); }
            private set {}
        }

        public static Scheme HTTPS
        {
            get { return new Scheme(HTTPS_SCHEME); }
            private set {}
        }
    }
}
