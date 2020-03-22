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
    /// Provides a Cloudflare Access Group resource. Access Groups are used
    /// in conjunction with Access Policies to restrict access to a
    /// particular resource based on group membership.
    /// 
    /// ## Conditions
    /// 
    /// `require`, `exclude` and `include` arguments share the available
    /// conditions which can be applied. The conditions are:
    /// 
    /// * `ip` - (Optional) A list of IP addresses or ranges. Example:
    ///   `ip = ["1.2.3.4", "10.0.0.0/2"]`
    /// * `email` - (Optional) A list of email addresses. Example:
    ///   `email = ["test@example.com"]`
    /// * `email_domain` - (Optional) A list of email domains. Example:
    ///   `email_domain = ["example.com"]`
    /// * `everyone` - (Optional) Boolean indicating permitting access for all
    ///   requests. Example: `everyone = true`
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/access_group.html.markdown.
    /// </summary>
    public partial class AccessGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of the account the group is
        /// associated with.
        /// </summary>
        [Output("accountId")]
        public Output<string> AccountId { get; private set; } = null!;

        /// <summary>
        /// A series of access conditions, see below for
        /// full list.
        /// </summary>
        [Output("excludes")]
        public Output<ImmutableArray<Outputs.AccessGroupExcludes>> Excludes { get; private set; } = null!;

        /// <summary>
        /// A series of access conditions, see below for
        /// full list.
        /// </summary>
        [Output("includes")]
        public Output<ImmutableArray<Outputs.AccessGroupIncludes>> Includes { get; private set; } = null!;

        /// <summary>
        /// Friendly name of the Access Group.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A series of access conditions, see below for
        /// full list.
        /// </summary>
        [Output("requires")]
        public Output<ImmutableArray<Outputs.AccessGroupRequires>> Requires { get; private set; } = null!;


        /// <summary>
        /// Create a AccessGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AccessGroup(string name, AccessGroupArgs args, CustomResourceOptions? options = null)
            : base("cloudflare:index/accessGroup:AccessGroup", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private AccessGroup(string name, Input<string> id, AccessGroupState? state = null, CustomResourceOptions? options = null)
            : base("cloudflare:index/accessGroup:AccessGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AccessGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AccessGroup Get(string name, Input<string> id, AccessGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new AccessGroup(name, id, state, options);
        }
    }

    public sealed class AccessGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the account the group is
        /// associated with.
        /// </summary>
        [Input("accountId", required: true)]
        public Input<string> AccountId { get; set; } = null!;

        [Input("excludes")]
        private InputList<Inputs.AccessGroupExcludesArgs>? _excludes;

        /// <summary>
        /// A series of access conditions, see below for
        /// full list.
        /// </summary>
        public InputList<Inputs.AccessGroupExcludesArgs> Excludes
        {
            get => _excludes ?? (_excludes = new InputList<Inputs.AccessGroupExcludesArgs>());
            set => _excludes = value;
        }

        [Input("includes", required: true)]
        private InputList<Inputs.AccessGroupIncludesArgs>? _includes;

        /// <summary>
        /// A series of access conditions, see below for
        /// full list.
        /// </summary>
        public InputList<Inputs.AccessGroupIncludesArgs> Includes
        {
            get => _includes ?? (_includes = new InputList<Inputs.AccessGroupIncludesArgs>());
            set => _includes = value;
        }

        /// <summary>
        /// Friendly name of the Access Group.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("requires")]
        private InputList<Inputs.AccessGroupRequiresArgs>? _requires;

        /// <summary>
        /// A series of access conditions, see below for
        /// full list.
        /// </summary>
        public InputList<Inputs.AccessGroupRequiresArgs> Requires
        {
            get => _requires ?? (_requires = new InputList<Inputs.AccessGroupRequiresArgs>());
            set => _requires = value;
        }

        public AccessGroupArgs()
        {
        }
    }

    public sealed class AccessGroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the account the group is
        /// associated with.
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        [Input("excludes")]
        private InputList<Inputs.AccessGroupExcludesGetArgs>? _excludes;

        /// <summary>
        /// A series of access conditions, see below for
        /// full list.
        /// </summary>
        public InputList<Inputs.AccessGroupExcludesGetArgs> Excludes
        {
            get => _excludes ?? (_excludes = new InputList<Inputs.AccessGroupExcludesGetArgs>());
            set => _excludes = value;
        }

        [Input("includes")]
        private InputList<Inputs.AccessGroupIncludesGetArgs>? _includes;

        /// <summary>
        /// A series of access conditions, see below for
        /// full list.
        /// </summary>
        public InputList<Inputs.AccessGroupIncludesGetArgs> Includes
        {
            get => _includes ?? (_includes = new InputList<Inputs.AccessGroupIncludesGetArgs>());
            set => _includes = value;
        }

        /// <summary>
        /// Friendly name of the Access Group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("requires")]
        private InputList<Inputs.AccessGroupRequiresGetArgs>? _requires;

        /// <summary>
        /// A series of access conditions, see below for
        /// full list.
        /// </summary>
        public InputList<Inputs.AccessGroupRequiresGetArgs> Requires
        {
            get => _requires ?? (_requires = new InputList<Inputs.AccessGroupRequiresGetArgs>());
            set => _requires = value;
        }

        public AccessGroupState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class AccessGroupExcludesArgs : Pulumi.ResourceArgs
    {
        [Input("emails")]
        private InputList<string>? _emails;
        public InputList<string> Emails
        {
            get => _emails ?? (_emails = new InputList<string>());
            set => _emails = value;
        }

        [Input("emailDomains")]
        private InputList<string>? _emailDomains;
        public InputList<string> EmailDomains
        {
            get => _emailDomains ?? (_emailDomains = new InputList<string>());
            set => _emailDomains = value;
        }

        [Input("everyone")]
        public Input<bool>? Everyone { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("ips")]
        private InputList<string>? _ips;
        public InputList<string> Ips
        {
            get => _ips ?? (_ips = new InputList<string>());
            set => _ips = value;
        }

        public AccessGroupExcludesArgs()
        {
        }
    }

    public sealed class AccessGroupExcludesGetArgs : Pulumi.ResourceArgs
    {
        [Input("emails")]
        private InputList<string>? _emails;
        public InputList<string> Emails
        {
            get => _emails ?? (_emails = new InputList<string>());
            set => _emails = value;
        }

        [Input("emailDomains")]
        private InputList<string>? _emailDomains;
        public InputList<string> EmailDomains
        {
            get => _emailDomains ?? (_emailDomains = new InputList<string>());
            set => _emailDomains = value;
        }

        [Input("everyone")]
        public Input<bool>? Everyone { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("ips")]
        private InputList<string>? _ips;
        public InputList<string> Ips
        {
            get => _ips ?? (_ips = new InputList<string>());
            set => _ips = value;
        }

        public AccessGroupExcludesGetArgs()
        {
        }
    }

    public sealed class AccessGroupIncludesArgs : Pulumi.ResourceArgs
    {
        [Input("emails")]
        private InputList<string>? _emails;
        public InputList<string> Emails
        {
            get => _emails ?? (_emails = new InputList<string>());
            set => _emails = value;
        }

        [Input("emailDomains")]
        private InputList<string>? _emailDomains;
        public InputList<string> EmailDomains
        {
            get => _emailDomains ?? (_emailDomains = new InputList<string>());
            set => _emailDomains = value;
        }

        [Input("everyone")]
        public Input<bool>? Everyone { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("ips")]
        private InputList<string>? _ips;
        public InputList<string> Ips
        {
            get => _ips ?? (_ips = new InputList<string>());
            set => _ips = value;
        }

        public AccessGroupIncludesArgs()
        {
        }
    }

    public sealed class AccessGroupIncludesGetArgs : Pulumi.ResourceArgs
    {
        [Input("emails")]
        private InputList<string>? _emails;
        public InputList<string> Emails
        {
            get => _emails ?? (_emails = new InputList<string>());
            set => _emails = value;
        }

        [Input("emailDomains")]
        private InputList<string>? _emailDomains;
        public InputList<string> EmailDomains
        {
            get => _emailDomains ?? (_emailDomains = new InputList<string>());
            set => _emailDomains = value;
        }

        [Input("everyone")]
        public Input<bool>? Everyone { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("ips")]
        private InputList<string>? _ips;
        public InputList<string> Ips
        {
            get => _ips ?? (_ips = new InputList<string>());
            set => _ips = value;
        }

        public AccessGroupIncludesGetArgs()
        {
        }
    }

    public sealed class AccessGroupRequiresArgs : Pulumi.ResourceArgs
    {
        [Input("emails")]
        private InputList<string>? _emails;
        public InputList<string> Emails
        {
            get => _emails ?? (_emails = new InputList<string>());
            set => _emails = value;
        }

        [Input("emailDomains")]
        private InputList<string>? _emailDomains;
        public InputList<string> EmailDomains
        {
            get => _emailDomains ?? (_emailDomains = new InputList<string>());
            set => _emailDomains = value;
        }

        [Input("everyone")]
        public Input<bool>? Everyone { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("ips")]
        private InputList<string>? _ips;
        public InputList<string> Ips
        {
            get => _ips ?? (_ips = new InputList<string>());
            set => _ips = value;
        }

        public AccessGroupRequiresArgs()
        {
        }
    }

    public sealed class AccessGroupRequiresGetArgs : Pulumi.ResourceArgs
    {
        [Input("emails")]
        private InputList<string>? _emails;
        public InputList<string> Emails
        {
            get => _emails ?? (_emails = new InputList<string>());
            set => _emails = value;
        }

        [Input("emailDomains")]
        private InputList<string>? _emailDomains;
        public InputList<string> EmailDomains
        {
            get => _emailDomains ?? (_emailDomains = new InputList<string>());
            set => _emailDomains = value;
        }

        [Input("everyone")]
        public Input<bool>? Everyone { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("ips")]
        private InputList<string>? _ips;
        public InputList<string> Ips
        {
            get => _ips ?? (_ips = new InputList<string>());
            set => _ips = value;
        }

        public AccessGroupRequiresGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class AccessGroupExcludes
    {
        public readonly ImmutableArray<string> Emails;
        public readonly ImmutableArray<string> EmailDomains;
        public readonly bool? Everyone;
        public readonly ImmutableArray<string> Groups;
        public readonly ImmutableArray<string> Ips;

        [OutputConstructor]
        private AccessGroupExcludes(
            ImmutableArray<string> emails,
            ImmutableArray<string> emailDomains,
            bool? everyone,
            ImmutableArray<string> groups,
            ImmutableArray<string> ips)
        {
            Emails = emails;
            EmailDomains = emailDomains;
            Everyone = everyone;
            Groups = groups;
            Ips = ips;
        }
    }

    [OutputType]
    public sealed class AccessGroupIncludes
    {
        public readonly ImmutableArray<string> Emails;
        public readonly ImmutableArray<string> EmailDomains;
        public readonly bool? Everyone;
        public readonly ImmutableArray<string> Groups;
        public readonly ImmutableArray<string> Ips;

        [OutputConstructor]
        private AccessGroupIncludes(
            ImmutableArray<string> emails,
            ImmutableArray<string> emailDomains,
            bool? everyone,
            ImmutableArray<string> groups,
            ImmutableArray<string> ips)
        {
            Emails = emails;
            EmailDomains = emailDomains;
            Everyone = everyone;
            Groups = groups;
            Ips = ips;
        }
    }

    [OutputType]
    public sealed class AccessGroupRequires
    {
        public readonly ImmutableArray<string> Emails;
        public readonly ImmutableArray<string> EmailDomains;
        public readonly bool? Everyone;
        public readonly ImmutableArray<string> Groups;
        public readonly ImmutableArray<string> Ips;

        [OutputConstructor]
        private AccessGroupRequires(
            ImmutableArray<string> emails,
            ImmutableArray<string> emailDomains,
            bool? everyone,
            ImmutableArray<string> groups,
            ImmutableArray<string> ips)
        {
            Emails = emails;
            EmailDomains = emailDomains;
            Everyone = everyone;
            Groups = groups;
            Ips = ips;
        }
    }
    }
}
