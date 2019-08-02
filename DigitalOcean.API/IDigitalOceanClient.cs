﻿using DigitalOcean.API.Clients;
using DigitalOcean.API.Http;

namespace DigitalOcean.API {
    public interface IDigitalOceanClient {
        IAccountClient Account { get; }
        IActionsClient Actions { get; }
        IDomainRecordsClient DomainRecords { get; }
        IDomainsClient Domains { get; }
        IDropletActionsClient DropletActions { get; }
        IDropletsClient Droplets { get; }
        IImageActionsClient ImageActions { get; }
        IImagesClient Images { get; }
        IKeysClient Keys { get; }
		ILoadBalancerClient LoadBalancers { get;}
        IProjectsClient Projects { get; }
        IProjectResourcesClient ProjectResources { get; }
        IRegionsClient Regions { get; }
        ISizesClient Sizes { get; }

        IRateLimit Rates { get; }
        ITagsClient Tags { get; }
    }
}
