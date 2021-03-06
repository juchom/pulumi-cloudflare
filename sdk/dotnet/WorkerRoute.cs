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
    /// Provides a Cloudflare worker route resource. A route will also require a `cloudflare..WorkerScript`.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/worker_route.html.markdown.
    /// </summary>
    public partial class WorkerRoute : Pulumi.CustomResource
    {
        /// <summary>
        /// The [route pattern](https://developers.cloudflare.com/workers/about/routes/)
        /// * `script_name` Which worker script to run for requests that match the route pattern. If `script_name` is empty, workers will be skipped for matching requests.
        /// </summary>
        [Output("pattern")]
        public Output<string> Pattern { get; private set; } = null!;

        [Output("scriptName")]
        public Output<string?> ScriptName { get; private set; } = null!;

        /// <summary>
        /// The zone ID to add the route to.
        /// </summary>
        [Output("zoneId")]
        public Output<string> ZoneId { get; private set; } = null!;


        /// <summary>
        /// Create a WorkerRoute resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WorkerRoute(string name, WorkerRouteArgs args, CustomResourceOptions? options = null)
            : base("cloudflare:index/workerRoute:WorkerRoute", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private WorkerRoute(string name, Input<string> id, WorkerRouteState? state = null, CustomResourceOptions? options = null)
            : base("cloudflare:index/workerRoute:WorkerRoute", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing WorkerRoute resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WorkerRoute Get(string name, Input<string> id, WorkerRouteState? state = null, CustomResourceOptions? options = null)
        {
            return new WorkerRoute(name, id, state, options);
        }
    }

    public sealed class WorkerRouteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The [route pattern](https://developers.cloudflare.com/workers/about/routes/)
        /// * `script_name` Which worker script to run for requests that match the route pattern. If `script_name` is empty, workers will be skipped for matching requests.
        /// </summary>
        [Input("pattern", required: true)]
        public Input<string> Pattern { get; set; } = null!;

        [Input("scriptName")]
        public Input<string>? ScriptName { get; set; }

        /// <summary>
        /// The zone ID to add the route to.
        /// </summary>
        [Input("zoneId", required: true)]
        public Input<string> ZoneId { get; set; } = null!;

        public WorkerRouteArgs()
        {
        }
    }

    public sealed class WorkerRouteState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The [route pattern](https://developers.cloudflare.com/workers/about/routes/)
        /// * `script_name` Which worker script to run for requests that match the route pattern. If `script_name` is empty, workers will be skipped for matching requests.
        /// </summary>
        [Input("pattern")]
        public Input<string>? Pattern { get; set; }

        [Input("scriptName")]
        public Input<string>? ScriptName { get; set; }

        /// <summary>
        /// The zone ID to add the route to.
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public WorkerRouteState()
        {
        }
    }
}
