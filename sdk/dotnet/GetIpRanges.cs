// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Cloudflare
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to get the [IP ranges][1] of Cloudflare edge nodes.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/d/ip_ranges.html.md.
        /// </summary>
        public static Task<GetIpRangesResult> GetIpRanges(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetIpRangesResult>("cloudflare:index/getIpRanges:getIpRanges", InvokeArgs.Empty, options.WithVersion());
    }

    [OutputType]
    public sealed class GetIpRangesResult
    {
        public readonly ImmutableArray<string> CidrBlocks;
        public readonly ImmutableArray<string> Ipv4CidrBlocks;
        public readonly ImmutableArray<string> Ipv6CidrBlocks;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetIpRangesResult(
            ImmutableArray<string> cidrBlocks,
            ImmutableArray<string> ipv4CidrBlocks,
            ImmutableArray<string> ipv6CidrBlocks,
            string id)
        {
            CidrBlocks = cidrBlocks;
            Ipv4CidrBlocks = ipv4CidrBlocks;
            Ipv6CidrBlocks = ipv6CidrBlocks;
            Id = id;
        }
    }
}
