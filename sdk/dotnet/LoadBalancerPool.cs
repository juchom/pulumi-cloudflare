// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Cloudflare
{
    /// <summary>
    /// Provides a Cloudflare Load Balancer pool resource. This provides a pool of origins that can be used by a Cloudflare Load Balancer. Note that the load balancing feature must be enabled in your Clouflare account before you can use this resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/load_balancer_pool.html.markdown.
    /// </summary>
    public partial class LoadBalancerPool : Pulumi.CustomResource
    {
        /// <summary>
        /// A list of regions (specified by region code) from which to run health checks. Empty means every Cloudflare data center (the default), but requires an Enterprise plan. Region codes can be found [here](https://support.cloudflare.com/hc/en-us/articles/115000540888-Load-Balancing-Geographic-Regions).
        /// </summary>
        [Output("checkRegions")]
        public Output<ImmutableArray<string>> CheckRegions { get; private set; } = null!;

        /// <summary>
        /// The RFC3339 timestamp of when the load balancer was created.
        /// </summary>
        [Output("createdOn")]
        public Output<string> CreatedOn { get; private set; } = null!;

        /// <summary>
        /// Free text description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Whether to enable (the default) this origin within the Pool. Disabled origins will not receive traffic and are excluded from health checks. The origin will only be disabled for the current pool.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// The minimum number of origins that must be healthy for this pool to serve traffic. If the number of healthy origins falls below this number, the pool will be marked unhealthy and we will failover to the next available pool. Default: 1.
        /// </summary>
        [Output("minimumOrigins")]
        public Output<int?> MinimumOrigins { get; private set; } = null!;

        /// <summary>
        /// The RFC3339 timestamp of when the load balancer was last modified.
        /// </summary>
        [Output("modifiedOn")]
        public Output<string> ModifiedOn { get; private set; } = null!;

        /// <summary>
        /// The ID of the Monitor to use for health checking origins within this pool.
        /// </summary>
        [Output("monitor")]
        public Output<string?> Monitor { get; private set; } = null!;

        /// <summary>
        /// A human-identifiable name for the origin.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The email address to send health status notifications to. This can be an individual mailbox or a mailing list.
        /// </summary>
        [Output("notificationEmail")]
        public Output<string?> NotificationEmail { get; private set; } = null!;

        /// <summary>
        /// The list of origins within this pool. Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy. It's a complex value. See description below.
        /// </summary>
        [Output("origins")]
        public Output<ImmutableArray<Outputs.LoadBalancerPoolOrigins>> Origins { get; private set; } = null!;


        /// <summary>
        /// Create a LoadBalancerPool resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LoadBalancerPool(string name, LoadBalancerPoolArgs args, CustomResourceOptions? options = null)
            : base("cloudflare:index/loadBalancerPool:LoadBalancerPool", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private LoadBalancerPool(string name, Input<string> id, LoadBalancerPoolState? state = null, CustomResourceOptions? options = null)
            : base("cloudflare:index/loadBalancerPool:LoadBalancerPool", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LoadBalancerPool resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LoadBalancerPool Get(string name, Input<string> id, LoadBalancerPoolState? state = null, CustomResourceOptions? options = null)
        {
            return new LoadBalancerPool(name, id, state, options);
        }
    }

    public sealed class LoadBalancerPoolArgs : Pulumi.ResourceArgs
    {
        [Input("checkRegions")]
        private InputList<string>? _checkRegions;

        /// <summary>
        /// A list of regions (specified by region code) from which to run health checks. Empty means every Cloudflare data center (the default), but requires an Enterprise plan. Region codes can be found [here](https://support.cloudflare.com/hc/en-us/articles/115000540888-Load-Balancing-Geographic-Regions).
        /// </summary>
        public InputList<string> CheckRegions
        {
            get => _checkRegions ?? (_checkRegions = new InputList<string>());
            set => _checkRegions = value;
        }

        /// <summary>
        /// Free text description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether to enable (the default) this origin within the Pool. Disabled origins will not receive traffic and are excluded from health checks. The origin will only be disabled for the current pool.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The minimum number of origins that must be healthy for this pool to serve traffic. If the number of healthy origins falls below this number, the pool will be marked unhealthy and we will failover to the next available pool. Default: 1.
        /// </summary>
        [Input("minimumOrigins")]
        public Input<int>? MinimumOrigins { get; set; }

        /// <summary>
        /// The ID of the Monitor to use for health checking origins within this pool.
        /// </summary>
        [Input("monitor")]
        public Input<string>? Monitor { get; set; }

        /// <summary>
        /// A human-identifiable name for the origin.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The email address to send health status notifications to. This can be an individual mailbox or a mailing list.
        /// </summary>
        [Input("notificationEmail")]
        public Input<string>? NotificationEmail { get; set; }

        [Input("origins", required: true)]
        private InputList<Inputs.LoadBalancerPoolOriginsArgs>? _origins;

        /// <summary>
        /// The list of origins within this pool. Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy. It's a complex value. See description below.
        /// </summary>
        public InputList<Inputs.LoadBalancerPoolOriginsArgs> Origins
        {
            get => _origins ?? (_origins = new InputList<Inputs.LoadBalancerPoolOriginsArgs>());
            set => _origins = value;
        }

        public LoadBalancerPoolArgs()
        {
        }
    }

    public sealed class LoadBalancerPoolState : Pulumi.ResourceArgs
    {
        [Input("checkRegions")]
        private InputList<string>? _checkRegions;

        /// <summary>
        /// A list of regions (specified by region code) from which to run health checks. Empty means every Cloudflare data center (the default), but requires an Enterprise plan. Region codes can be found [here](https://support.cloudflare.com/hc/en-us/articles/115000540888-Load-Balancing-Geographic-Regions).
        /// </summary>
        public InputList<string> CheckRegions
        {
            get => _checkRegions ?? (_checkRegions = new InputList<string>());
            set => _checkRegions = value;
        }

        /// <summary>
        /// The RFC3339 timestamp of when the load balancer was created.
        /// </summary>
        [Input("createdOn")]
        public Input<string>? CreatedOn { get; set; }

        /// <summary>
        /// Free text description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether to enable (the default) this origin within the Pool. Disabled origins will not receive traffic and are excluded from health checks. The origin will only be disabled for the current pool.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The minimum number of origins that must be healthy for this pool to serve traffic. If the number of healthy origins falls below this number, the pool will be marked unhealthy and we will failover to the next available pool. Default: 1.
        /// </summary>
        [Input("minimumOrigins")]
        public Input<int>? MinimumOrigins { get; set; }

        /// <summary>
        /// The RFC3339 timestamp of when the load balancer was last modified.
        /// </summary>
        [Input("modifiedOn")]
        public Input<string>? ModifiedOn { get; set; }

        /// <summary>
        /// The ID of the Monitor to use for health checking origins within this pool.
        /// </summary>
        [Input("monitor")]
        public Input<string>? Monitor { get; set; }

        /// <summary>
        /// A human-identifiable name for the origin.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The email address to send health status notifications to. This can be an individual mailbox or a mailing list.
        /// </summary>
        [Input("notificationEmail")]
        public Input<string>? NotificationEmail { get; set; }

        [Input("origins")]
        private InputList<Inputs.LoadBalancerPoolOriginsGetArgs>? _origins;

        /// <summary>
        /// The list of origins within this pool. Traffic directed at this pool is balanced across all currently healthy origins, provided the pool itself is healthy. It's a complex value. See description below.
        /// </summary>
        public InputList<Inputs.LoadBalancerPoolOriginsGetArgs> Origins
        {
            get => _origins ?? (_origins = new InputList<Inputs.LoadBalancerPoolOriginsGetArgs>());
            set => _origins = value;
        }

        public LoadBalancerPoolState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class LoadBalancerPoolOriginsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The IP address (IPv4 or IPv6) of the origin, or the publicly addressable hostname. Hostnames entered here should resolve directly to the origin, and not be a hostname proxied by Cloudflare.
        /// </summary>
        [Input("address", required: true)]
        public Input<string> Address { get; set; } = null!;

        /// <summary>
        /// Whether to enable (the default) this origin within the Pool. Disabled origins will not receive traffic and are excluded from health checks. The origin will only be disabled for the current pool.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// A human-identifiable name for the origin.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The weight (0.01 - 1.00) of this origin, relative to other origins in the pool. Equal values mean equal weighting. A weight of 0 means traffic will not be sent to this origin, but health is still checked. Default: 1.
        /// </summary>
        [Input("weight")]
        public Input<double>? Weight { get; set; }

        public LoadBalancerPoolOriginsArgs()
        {
        }
    }

    public sealed class LoadBalancerPoolOriginsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The IP address (IPv4 or IPv6) of the origin, or the publicly addressable hostname. Hostnames entered here should resolve directly to the origin, and not be a hostname proxied by Cloudflare.
        /// </summary>
        [Input("address", required: true)]
        public Input<string> Address { get; set; } = null!;

        /// <summary>
        /// Whether to enable (the default) this origin within the Pool. Disabled origins will not receive traffic and are excluded from health checks. The origin will only be disabled for the current pool.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// A human-identifiable name for the origin.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The weight (0.01 - 1.00) of this origin, relative to other origins in the pool. Equal values mean equal weighting. A weight of 0 means traffic will not be sent to this origin, but health is still checked. Default: 1.
        /// </summary>
        [Input("weight")]
        public Input<double>? Weight { get; set; }

        public LoadBalancerPoolOriginsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class LoadBalancerPoolOrigins
    {
        /// <summary>
        /// The IP address (IPv4 or IPv6) of the origin, or the publicly addressable hostname. Hostnames entered here should resolve directly to the origin, and not be a hostname proxied by Cloudflare.
        /// </summary>
        public readonly string Address;
        /// <summary>
        /// Whether to enable (the default) this origin within the Pool. Disabled origins will not receive traffic and are excluded from health checks. The origin will only be disabled for the current pool.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// A human-identifiable name for the origin.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The weight (0.01 - 1.00) of this origin, relative to other origins in the pool. Equal values mean equal weighting. A weight of 0 means traffic will not be sent to this origin, but health is still checked. Default: 1.
        /// </summary>
        public readonly double? Weight;

        [OutputConstructor]
        private LoadBalancerPoolOrigins(
            string address,
            bool? enabled,
            string name,
            double? weight)
        {
            Address = address;
            Enabled = enabled;
            Name = name;
            Weight = weight;
        }
    }
    }
}
