// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Access Service Tokens are used for service-to-service communication
 * when an application is behind Cloudflare Access.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cloudflare from "@pulumi/cloudflare";
 * 
 * const myApp = new cloudflare.AccessServiceToken("myApp", {
 *     accountId: "d41d8cd98f00b204e9800998ecf8427e",
 *     name: "CI/CD app",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/access_service_token.html.markdown.
 */
export class AccessServiceToken extends pulumi.CustomResource {
    /**
     * Get an existing AccessServiceToken resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AccessServiceTokenState, opts?: pulumi.CustomResourceOptions): AccessServiceToken {
        return new AccessServiceToken(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cloudflare:index/accessServiceToken:AccessServiceToken';

    /**
     * Returns true if the given object is an instance of AccessServiceToken.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AccessServiceToken {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AccessServiceToken.__pulumiType;
    }

    /**
     * The ID of the account where the Access
     * Service is being created.
     */
    public readonly accountId!: pulumi.Output<string>;
    /**
     * UUID client ID associated with the Service Token.
     */
    public /*out*/ readonly clientId!: pulumi.Output<string>;
    /**
     * A secret for interacting with Access protocols.
     */
    public /*out*/ readonly clientSecret!: pulumi.Output<string>;
    /**
     * Friendly name of the token's intent.
     */
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a AccessServiceToken resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccessServiceTokenArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AccessServiceTokenArgs | AccessServiceTokenState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as AccessServiceTokenState | undefined;
            inputs["accountId"] = state ? state.accountId : undefined;
            inputs["clientId"] = state ? state.clientId : undefined;
            inputs["clientSecret"] = state ? state.clientSecret : undefined;
            inputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as AccessServiceTokenArgs | undefined;
            if (!args || args.accountId === undefined) {
                throw new Error("Missing required property 'accountId'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            inputs["accountId"] = args ? args.accountId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["clientId"] = undefined /*out*/;
            inputs["clientSecret"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(AccessServiceToken.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AccessServiceToken resources.
 */
export interface AccessServiceTokenState {
    /**
     * The ID of the account where the Access
     * Service is being created.
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * UUID client ID associated with the Service Token.
     */
    readonly clientId?: pulumi.Input<string>;
    /**
     * A secret for interacting with Access protocols.
     */
    readonly clientSecret?: pulumi.Input<string>;
    /**
     * Friendly name of the token's intent.
     */
    readonly name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AccessServiceToken resource.
 */
export interface AccessServiceTokenArgs {
    /**
     * The ID of the account where the Access
     * Service is being created.
     */
    readonly accountId: pulumi.Input<string>;
    /**
     * Friendly name of the token's intent.
     */
    readonly name: pulumi.Input<string>;
}
