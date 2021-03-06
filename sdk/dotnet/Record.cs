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
    /// Provides a Cloudflare record resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/record.html.markdown.
    /// </summary>
    public partial class Record : Pulumi.CustomResource
    {
        /// <summary>
        /// The RFC3339 timestamp of when the record was created
        /// </summary>
        [Output("createdOn")]
        public Output<string> CreatedOn { get; private set; } = null!;

        /// <summary>
        /// Map of attributes that constitute the record value. Primarily used for LOC and SRV record types. Either this or `value` must be specified
        /// </summary>
        [Output("data")]
        public Output<Outputs.RecordData?> Data { get; private set; } = null!;

        /// <summary>
        /// The FQDN of the record
        /// </summary>
        [Output("hostname")]
        public Output<string> Hostname { get; private set; } = null!;

        /// <summary>
        /// A key-value map of string metadata Cloudflare associates with the record
        /// </summary>
        [Output("metadata")]
        public Output<ImmutableDictionary<string, object>> Metadata { get; private set; } = null!;

        /// <summary>
        /// The RFC3339 timestamp of when the record was last modified
        /// </summary>
        [Output("modifiedOn")]
        public Output<string> ModifiedOn { get; private set; } = null!;

        /// <summary>
        /// The name of the record
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The priority of the record
        /// </summary>
        [Output("priority")]
        public Output<int?> Priority { get; private set; } = null!;

        /// <summary>
        /// Shows whether this record can be proxied, must be true if setting `proxied=true`
        /// </summary>
        [Output("proxiable")]
        public Output<bool> Proxiable { get; private set; } = null!;

        /// <summary>
        /// Whether the record gets Cloudflare's origin protection; defaults to `false`.
        /// </summary>
        [Output("proxied")]
        public Output<bool?> Proxied { get; private set; } = null!;

        /// <summary>
        /// The TTL of the record ([automatic: '1'](https://api.cloudflare.com/#dns-records-for-a-zone-create-dns-record))
        /// </summary>
        [Output("ttl")]
        public Output<int> Ttl { get; private set; } = null!;

        /// <summary>
        /// The type of the record
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The (string) value of the record. Either this or `data` must be specified
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;

        /// <summary>
        /// The DNS zone ID to add the record to
        /// </summary>
        [Output("zoneId")]
        public Output<string> ZoneId { get; private set; } = null!;


        /// <summary>
        /// Create a Record resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Record(string name, RecordArgs args, CustomResourceOptions? options = null)
            : base("cloudflare:index/record:Record", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Record(string name, Input<string> id, RecordState? state = null, CustomResourceOptions? options = null)
            : base("cloudflare:index/record:Record", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Record resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Record Get(string name, Input<string> id, RecordState? state = null, CustomResourceOptions? options = null)
        {
            return new Record(name, id, state, options);
        }
    }

    public sealed class RecordArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Map of attributes that constitute the record value. Primarily used for LOC and SRV record types. Either this or `value` must be specified
        /// </summary>
        [Input("data")]
        public Input<Inputs.RecordDataArgs>? Data { get; set; }

        /// <summary>
        /// The name of the record
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The priority of the record
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        /// <summary>
        /// Whether the record gets Cloudflare's origin protection; defaults to `false`.
        /// </summary>
        [Input("proxied")]
        public Input<bool>? Proxied { get; set; }

        /// <summary>
        /// The TTL of the record ([automatic: '1'](https://api.cloudflare.com/#dns-records-for-a-zone-create-dns-record))
        /// </summary>
        [Input("ttl")]
        public Input<int>? Ttl { get; set; }

        /// <summary>
        /// The type of the record
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The (string) value of the record. Either this or `data` must be specified
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        /// <summary>
        /// The DNS zone ID to add the record to
        /// </summary>
        [Input("zoneId", required: true)]
        public Input<string> ZoneId { get; set; } = null!;

        public RecordArgs()
        {
        }
    }

    public sealed class RecordState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The RFC3339 timestamp of when the record was created
        /// </summary>
        [Input("createdOn")]
        public Input<string>? CreatedOn { get; set; }

        /// <summary>
        /// Map of attributes that constitute the record value. Primarily used for LOC and SRV record types. Either this or `value` must be specified
        /// </summary>
        [Input("data")]
        public Input<Inputs.RecordDataGetArgs>? Data { get; set; }

        /// <summary>
        /// The FQDN of the record
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        [Input("metadata")]
        private InputMap<object>? _metadata;

        /// <summary>
        /// A key-value map of string metadata Cloudflare associates with the record
        /// </summary>
        public InputMap<object> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<object>());
            set => _metadata = value;
        }

        /// <summary>
        /// The RFC3339 timestamp of when the record was last modified
        /// </summary>
        [Input("modifiedOn")]
        public Input<string>? ModifiedOn { get; set; }

        /// <summary>
        /// The name of the record
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The priority of the record
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        /// <summary>
        /// Shows whether this record can be proxied, must be true if setting `proxied=true`
        /// </summary>
        [Input("proxiable")]
        public Input<bool>? Proxiable { get; set; }

        /// <summary>
        /// Whether the record gets Cloudflare's origin protection; defaults to `false`.
        /// </summary>
        [Input("proxied")]
        public Input<bool>? Proxied { get; set; }

        /// <summary>
        /// The TTL of the record ([automatic: '1'](https://api.cloudflare.com/#dns-records-for-a-zone-create-dns-record))
        /// </summary>
        [Input("ttl")]
        public Input<int>? Ttl { get; set; }

        /// <summary>
        /// The type of the record
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// The (string) value of the record. Either this or `data` must be specified
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        /// <summary>
        /// The DNS zone ID to add the record to
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public RecordState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class RecordDataArgs : Pulumi.ResourceArgs
    {
        [Input("algorithm")]
        public Input<int>? Algorithm { get; set; }

        [Input("altitude")]
        public Input<double>? Altitude { get; set; }

        [Input("certificate")]
        public Input<string>? Certificate { get; set; }

        [Input("content")]
        public Input<string>? Content { get; set; }

        [Input("digest")]
        public Input<string>? Digest { get; set; }

        [Input("digestType")]
        public Input<int>? DigestType { get; set; }

        [Input("fingerprint")]
        public Input<string>? Fingerprint { get; set; }

        [Input("flags")]
        public Input<string>? Flags { get; set; }

        [Input("keyTag")]
        public Input<int>? KeyTag { get; set; }

        [Input("latDegrees")]
        public Input<int>? LatDegrees { get; set; }

        [Input("latDirection")]
        public Input<string>? LatDirection { get; set; }

        [Input("latMinutes")]
        public Input<int>? LatMinutes { get; set; }

        [Input("latSeconds")]
        public Input<double>? LatSeconds { get; set; }

        [Input("longDegrees")]
        public Input<int>? LongDegrees { get; set; }

        [Input("longDirection")]
        public Input<string>? LongDirection { get; set; }

        [Input("longMinutes")]
        public Input<int>? LongMinutes { get; set; }

        [Input("longSeconds")]
        public Input<double>? LongSeconds { get; set; }

        [Input("matchingType")]
        public Input<int>? MatchingType { get; set; }

        /// <summary>
        /// The name of the record
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("order")]
        public Input<int>? Order { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("precisionHorz")]
        public Input<double>? PrecisionHorz { get; set; }

        [Input("precisionVert")]
        public Input<double>? PrecisionVert { get; set; }

        [Input("preference")]
        public Input<int>? Preference { get; set; }

        /// <summary>
        /// The priority of the record
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("proto")]
        public Input<string>? Proto { get; set; }

        [Input("protocol")]
        public Input<int>? Protocol { get; set; }

        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        [Input("regex")]
        public Input<string>? Regex { get; set; }

        [Input("replacement")]
        public Input<string>? Replacement { get; set; }

        [Input("selector")]
        public Input<int>? Selector { get; set; }

        [Input("service")]
        public Input<string>? Service { get; set; }

        [Input("size")]
        public Input<double>? Size { get; set; }

        [Input("target")]
        public Input<string>? Target { get; set; }

        /// <summary>
        /// The type of the record
        /// </summary>
        [Input("type")]
        public Input<int>? Type { get; set; }

        [Input("usage")]
        public Input<int>? Usage { get; set; }

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public RecordDataArgs()
        {
        }
    }

    public sealed class RecordDataGetArgs : Pulumi.ResourceArgs
    {
        [Input("algorithm")]
        public Input<int>? Algorithm { get; set; }

        [Input("altitude")]
        public Input<double>? Altitude { get; set; }

        [Input("certificate")]
        public Input<string>? Certificate { get; set; }

        [Input("content")]
        public Input<string>? Content { get; set; }

        [Input("digest")]
        public Input<string>? Digest { get; set; }

        [Input("digestType")]
        public Input<int>? DigestType { get; set; }

        [Input("fingerprint")]
        public Input<string>? Fingerprint { get; set; }

        [Input("flags")]
        public Input<string>? Flags { get; set; }

        [Input("keyTag")]
        public Input<int>? KeyTag { get; set; }

        [Input("latDegrees")]
        public Input<int>? LatDegrees { get; set; }

        [Input("latDirection")]
        public Input<string>? LatDirection { get; set; }

        [Input("latMinutes")]
        public Input<int>? LatMinutes { get; set; }

        [Input("latSeconds")]
        public Input<double>? LatSeconds { get; set; }

        [Input("longDegrees")]
        public Input<int>? LongDegrees { get; set; }

        [Input("longDirection")]
        public Input<string>? LongDirection { get; set; }

        [Input("longMinutes")]
        public Input<int>? LongMinutes { get; set; }

        [Input("longSeconds")]
        public Input<double>? LongSeconds { get; set; }

        [Input("matchingType")]
        public Input<int>? MatchingType { get; set; }

        /// <summary>
        /// The name of the record
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("order")]
        public Input<int>? Order { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("precisionHorz")]
        public Input<double>? PrecisionHorz { get; set; }

        [Input("precisionVert")]
        public Input<double>? PrecisionVert { get; set; }

        [Input("preference")]
        public Input<int>? Preference { get; set; }

        /// <summary>
        /// The priority of the record
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("proto")]
        public Input<string>? Proto { get; set; }

        [Input("protocol")]
        public Input<int>? Protocol { get; set; }

        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        [Input("regex")]
        public Input<string>? Regex { get; set; }

        [Input("replacement")]
        public Input<string>? Replacement { get; set; }

        [Input("selector")]
        public Input<int>? Selector { get; set; }

        [Input("service")]
        public Input<string>? Service { get; set; }

        [Input("size")]
        public Input<double>? Size { get; set; }

        [Input("target")]
        public Input<string>? Target { get; set; }

        /// <summary>
        /// The type of the record
        /// </summary>
        [Input("type")]
        public Input<int>? Type { get; set; }

        [Input("usage")]
        public Input<int>? Usage { get; set; }

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public RecordDataGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class RecordData
    {
        public readonly int? Algorithm;
        public readonly double? Altitude;
        public readonly string? Certificate;
        public readonly string? Content;
        public readonly string? Digest;
        public readonly int? DigestType;
        public readonly string? Fingerprint;
        public readonly string? Flags;
        public readonly int? KeyTag;
        public readonly int? LatDegrees;
        public readonly string? LatDirection;
        public readonly int? LatMinutes;
        public readonly double? LatSeconds;
        public readonly int? LongDegrees;
        public readonly string? LongDirection;
        public readonly int? LongMinutes;
        public readonly double? LongSeconds;
        public readonly int? MatchingType;
        /// <summary>
        /// The name of the record
        /// </summary>
        public readonly string? Name;
        public readonly int? Order;
        public readonly int? Port;
        public readonly double? PrecisionHorz;
        public readonly double? PrecisionVert;
        public readonly int? Preference;
        /// <summary>
        /// The priority of the record
        /// </summary>
        public readonly int? Priority;
        public readonly string? Proto;
        public readonly int? Protocol;
        public readonly string? PublicKey;
        public readonly string? Regex;
        public readonly string? Replacement;
        public readonly int? Selector;
        public readonly string? Service;
        public readonly double? Size;
        public readonly string? Target;
        /// <summary>
        /// The type of the record
        /// </summary>
        public readonly int? Type;
        public readonly int? Usage;
        public readonly int? Weight;

        [OutputConstructor]
        private RecordData(
            int? algorithm,
            double? altitude,
            string? certificate,
            string? content,
            string? digest,
            int? digestType,
            string? fingerprint,
            string? flags,
            int? keyTag,
            int? latDegrees,
            string? latDirection,
            int? latMinutes,
            double? latSeconds,
            int? longDegrees,
            string? longDirection,
            int? longMinutes,
            double? longSeconds,
            int? matchingType,
            string? name,
            int? order,
            int? port,
            double? precisionHorz,
            double? precisionVert,
            int? preference,
            int? priority,
            string? proto,
            int? protocol,
            string? publicKey,
            string? regex,
            string? replacement,
            int? selector,
            string? service,
            double? size,
            string? target,
            int? type,
            int? usage,
            int? weight)
        {
            Algorithm = algorithm;
            Altitude = altitude;
            Certificate = certificate;
            Content = content;
            Digest = digest;
            DigestType = digestType;
            Fingerprint = fingerprint;
            Flags = flags;
            KeyTag = keyTag;
            LatDegrees = latDegrees;
            LatDirection = latDirection;
            LatMinutes = latMinutes;
            LatSeconds = latSeconds;
            LongDegrees = longDegrees;
            LongDirection = longDirection;
            LongMinutes = longMinutes;
            LongSeconds = longSeconds;
            MatchingType = matchingType;
            Name = name;
            Order = order;
            Port = port;
            PrecisionHorz = precisionHorz;
            PrecisionVert = precisionVert;
            Preference = preference;
            Priority = priority;
            Proto = proto;
            Protocol = protocol;
            PublicKey = publicKey;
            Regex = regex;
            Replacement = replacement;
            Selector = selector;
            Service = service;
            Size = size;
            Target = target;
            Type = type;
            Usage = usage;
            Weight = weight;
        }
    }
    }
}
