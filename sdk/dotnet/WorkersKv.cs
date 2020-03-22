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
    /// Provides a Workers KV Pair.  *NOTE:*  This resource uses the Cloudflare account APIs.  This requires setting the `CLOUDFLARE_ACCOUNT_ID` environment variable or `account_id` provider argument.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/workers_kv.html.markdown.
    /// </summary>
    public partial class WorkersKv : Pulumi.CustomResource
    {
        /// <summary>
        /// The key name
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// The ID of the Workers KV namespace in which you want to create the KV pair
        /// </summary>
        [Output("namespaceId")]
        public Output<string> NamespaceId { get; private set; } = null!;

        /// <summary>
        /// The string value to be stored in the key
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a WorkersKv resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WorkersKv(string name, WorkersKvArgs args, CustomResourceOptions? options = null)
            : base("cloudflare:index/workersKv:WorkersKv", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private WorkersKv(string name, Input<string> id, WorkersKvState? state = null, CustomResourceOptions? options = null)
            : base("cloudflare:index/workersKv:WorkersKv", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing WorkersKv resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WorkersKv Get(string name, Input<string> id, WorkersKvState? state = null, CustomResourceOptions? options = null)
        {
            return new WorkersKv(name, id, state, options);
        }
    }

    public sealed class WorkersKvArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key name
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// The ID of the Workers KV namespace in which you want to create the KV pair
        /// </summary>
        [Input("namespaceId", required: true)]
        public Input<string> NamespaceId { get; set; } = null!;

        /// <summary>
        /// The string value to be stored in the key
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public WorkersKvArgs()
        {
        }
    }

    public sealed class WorkersKvState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key name
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// The ID of the Workers KV namespace in which you want to create the KV pair
        /// </summary>
        [Input("namespaceId")]
        public Input<string>? NamespaceId { get; set; }

        /// <summary>
        /// The string value to be stored in the key
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public WorkersKvState()
        {
        }
    }
}
