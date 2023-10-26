using System;
using System.Collections;
using UnityEngine.Networking;
using Newtonsoft.Json;

namespace HADotNet.Core
{
    public abstract class RC_BaseClient
    {
        public Uri Domain { get; private set; }
        public string ApiKey { get; private set; }

        public RC_BaseClient() { }
        public RC_BaseClient(Uri domain, string apikey) => Initialize(domain, apikey);



        private void Initialize(Uri domain, string apikey)
        {
            throw new NotImplementedException();
        }
    }
}
