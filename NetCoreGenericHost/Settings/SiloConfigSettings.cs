﻿namespace NetCoreGenericHost.Settings
{
    public class SiloConfigSettings
    {
        public string ClusterId { get; set; }
        public string ServiceId { get; set; }

        public string AdvertisedIp { get; set; }
        public bool ListenOnAnyHostAddress { get; set; }
        public int SiloPort { get; set; }
        public int GatewayPort { get; set; }
    }
}