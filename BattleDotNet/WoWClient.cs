﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleDotNet.Objects.WoW;
using Newtonsoft.Json;

namespace BattleDotNet
{
    public class WoWClient : Client
    {
        public WoWClient(string publicKey = null, string signature = null)
            : base(publicKey, signature)
        {
        }

        #region Private Types
        private class RealmStatusData
        {
            [JsonProperty("realms")]
            IEnumerable<RealmStatus> Realms { get; private set; }
        }
        #endregion

        public IEnumerable<RealmStatus> GetRealmStatuses(params string[] realms)
        {
            return Enumerable.Empty<RealmStatus>();
        }
    }
}