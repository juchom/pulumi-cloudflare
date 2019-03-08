// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a Cloudflare Access Policy resource. Access Policies are used
 * in conjunction with Access Applications to restrict access to a
 * particular resource.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cloudflare from "@pulumi/cloudflare";
 * 
 * // Allowing `test@example.com` to access but only when coming from a
 * // specific IP.
 * const testPolicy = new cloudflare.AccessPolicy("test_policy", {
 *     applicationId: "cb029e245cfdd66dc8d2e570d5dd3322",
 *     decision: "allow",
 *     includes: [{
 *         emails: ["test@example.com"],
 *     }],
 *     name: "staging policy",
 *     precedence: 1,
 *     requires: [{
 *         ips: [var_office_ip],
 *     }],
 *     zoneId: "d41d8cd98f00b204e9800998ecf8427e",
 * });
 * ```
 * 
 * ## Conditions
 * 
 * `require`, `exclude` and `include` arguments share the available
 * conditions which can be applied. The conditions are:
 * 
 * * `ip` - (Optional) A list of IP addresses or ranges. Example:
 *   `ip = ["1.2.3.4", "10.0.0.0/2"]`
 * * `email` - (Optional) A list of email addresses. Example:
 *   `email = ["test@example.com"]`
 * * `email_domain` - (Optional) A list of email domains. Example:
 *   `email_domain = ["example.com"]`
 * * `everyone` - (Optional) Boolean indicating permitting access for all
 *   requests. Example: `everyone = true`
 */
export class AccessPolicy extends pulumi.CustomResource {
    /**
     * Get an existing AccessPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AccessPolicyState, opts?: pulumi.CustomResourceOptions): AccessPolicy {
        return new AccessPolicy(name, <any>state, { ...opts, id: id });
    }

    /**
     * The ID of the application the policy is
     * associated with.
     */
    public readonly applicationId: pulumi.Output<string>;
    /**
     * The complete URL of the asset you wish to put
     * Cloudflare Access in front of. Can include subdomains or paths. Or both.
     */
    public readonly decision: pulumi.Output<string>;
    /**
     * A series of access conditions, see below for
     * full list.
     */
    public readonly excludes: pulumi.Output<{ emails?: string[], emailDomains?: string[], everyone?: boolean, ips?: string[] }[] | undefined>;
    /**
     * A series of access conditions, see below for
     * full list.
     */
    public readonly includes: pulumi.Output<{ emails?: string[], emailDomains?: string[], everyone?: boolean, ips?: string[] }[]>;
    /**
     * Friendly name of the Access Application.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * The unique precedence for policies on a single application. Integer.
     */
    public readonly precedence: pulumi.Output<number | undefined>;
    /**
     * A series of access conditions, see below for
     * full list.
     */
    public readonly requires: pulumi.Output<{ emails?: string[], emailDomains?: string[], everyone?: boolean, ips?: string[] }[] | undefined>;
    /**
     * The DNS zone to which the access rule should be
     * added.
     */
    public readonly zoneId: pulumi.Output<string>;

    /**
     * Create a AccessPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccessPolicyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AccessPolicyArgs | AccessPolicyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: AccessPolicyState = argsOrState as AccessPolicyState | undefined;
            inputs["applicationId"] = state ? state.applicationId : undefined;
            inputs["decision"] = state ? state.decision : undefined;
            inputs["excludes"] = state ? state.excludes : undefined;
            inputs["includes"] = state ? state.includes : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["precedence"] = state ? state.precedence : undefined;
            inputs["requires"] = state ? state.requires : undefined;
            inputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as AccessPolicyArgs | undefined;
            if (!args || args.applicationId === undefined) {
                throw new Error("Missing required property 'applicationId'");
            }
            if (!args || args.decision === undefined) {
                throw new Error("Missing required property 'decision'");
            }
            if (!args || args.includes === undefined) {
                throw new Error("Missing required property 'includes'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.zoneId === undefined) {
                throw new Error("Missing required property 'zoneId'");
            }
            inputs["applicationId"] = args ? args.applicationId : undefined;
            inputs["decision"] = args ? args.decision : undefined;
            inputs["excludes"] = args ? args.excludes : undefined;
            inputs["includes"] = args ? args.includes : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["precedence"] = args ? args.precedence : undefined;
            inputs["requires"] = args ? args.requires : undefined;
            inputs["zoneId"] = args ? args.zoneId : undefined;
        }
        super("cloudflare:index/accessPolicy:AccessPolicy", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AccessPolicy resources.
 */
export interface AccessPolicyState {
    /**
     * The ID of the application the policy is
     * associated with.
     */
    readonly applicationId?: pulumi.Input<string>;
    /**
     * The complete URL of the asset you wish to put
     * Cloudflare Access in front of. Can include subdomains or paths. Or both.
     */
    readonly decision?: pulumi.Input<string>;
    /**
     * A series of access conditions, see below for
     * full list.
     */
    readonly excludes?: pulumi.Input<pulumi.Input<{ emails?: pulumi.Input<pulumi.Input<string>[]>, emailDomains?: pulumi.Input<pulumi.Input<string>[]>, everyone?: pulumi.Input<boolean>, ips?: pulumi.Input<pulumi.Input<string>[]> }>[]>;
    /**
     * A series of access conditions, see below for
     * full list.
     */
    readonly includes?: pulumi.Input<pulumi.Input<{ emails?: pulumi.Input<pulumi.Input<string>[]>, emailDomains?: pulumi.Input<pulumi.Input<string>[]>, everyone?: pulumi.Input<boolean>, ips?: pulumi.Input<pulumi.Input<string>[]> }>[]>;
    /**
     * Friendly name of the Access Application.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The unique precedence for policies on a single application. Integer.
     */
    readonly precedence?: pulumi.Input<number>;
    /**
     * A series of access conditions, see below for
     * full list.
     */
    readonly requires?: pulumi.Input<pulumi.Input<{ emails?: pulumi.Input<pulumi.Input<string>[]>, emailDomains?: pulumi.Input<pulumi.Input<string>[]>, everyone?: pulumi.Input<boolean>, ips?: pulumi.Input<pulumi.Input<string>[]> }>[]>;
    /**
     * The DNS zone to which the access rule should be
     * added.
     */
    readonly zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AccessPolicy resource.
 */
export interface AccessPolicyArgs {
    /**
     * The ID of the application the policy is
     * associated with.
     */
    readonly applicationId: pulumi.Input<string>;
    /**
     * The complete URL of the asset you wish to put
     * Cloudflare Access in front of. Can include subdomains or paths. Or both.
     */
    readonly decision: pulumi.Input<string>;
    /**
     * A series of access conditions, see below for
     * full list.
     */
    readonly excludes?: pulumi.Input<pulumi.Input<{ emails?: pulumi.Input<pulumi.Input<string>[]>, emailDomains?: pulumi.Input<pulumi.Input<string>[]>, everyone?: pulumi.Input<boolean>, ips?: pulumi.Input<pulumi.Input<string>[]> }>[]>;
    /**
     * A series of access conditions, see below for
     * full list.
     */
    readonly includes: pulumi.Input<pulumi.Input<{ emails?: pulumi.Input<pulumi.Input<string>[]>, emailDomains?: pulumi.Input<pulumi.Input<string>[]>, everyone?: pulumi.Input<boolean>, ips?: pulumi.Input<pulumi.Input<string>[]> }>[]>;
    /**
     * Friendly name of the Access Application.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The unique precedence for policies on a single application. Integer.
     */
    readonly precedence?: pulumi.Input<number>;
    /**
     * A series of access conditions, see below for
     * full list.
     */
    readonly requires?: pulumi.Input<pulumi.Input<{ emails?: pulumi.Input<pulumi.Input<string>[]>, emailDomains?: pulumi.Input<pulumi.Input<string>[]>, everyone?: pulumi.Input<boolean>, ips?: pulumi.Input<pulumi.Input<string>[]> }>[]>;
    /**
     * The DNS zone to which the access rule should be
     * added.
     */
    readonly zoneId: pulumi.Input<string>;
}