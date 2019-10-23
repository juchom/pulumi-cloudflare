// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Cloudflare Spectrum Application. You can extend the power of Cloudflare's DDoS, TLS, and IP Firewall to your other TCP-based services.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as cloudflare from "@pulumi/cloudflare";
 * 
 * // Define a spectrum application proxies ssh traffic
 * const sshProxy = new cloudflare.SpectrumApplication("sshProxy", {
 *     dns: {
 *         name: "ssh.example.com",
 *         type: "CNAME",
 *     },
 *     originDirects: ["tcp://109.151.40.129:22"],
 *     protocol: "tcp/22",
 *     trafficType: "direct",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/spectrum_application.html.markdown.
 */
export class SpectrumApplication extends pulumi.CustomResource {
    /**
     * Get an existing SpectrumApplication resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SpectrumApplicationState, opts?: pulumi.CustomResourceOptions): SpectrumApplication {
        return new SpectrumApplication(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'cloudflare:index/spectrumApplication:SpectrumApplication';

    /**
     * Returns true if the given object is an instance of SpectrumApplication.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SpectrumApplication {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SpectrumApplication.__pulumiType;
    }

    /**
     * The name and type of DNS record for the Spectrum application. Fields documented below.
     */
    public readonly dns!: pulumi.Output<outputs.SpectrumApplicationDns>;
    /**
     * Enables the IP Firewall for this application. Defaults to `true`.
     */
    public readonly ipFirewall!: pulumi.Output<boolean | undefined>;
    /**
     * A list of destination addresses to the origin. e.g. `tcp://192.0.2.1:22`.
     */
    public readonly originDirects!: pulumi.Output<string[] | undefined>;
    /**
     * A destination DNS addresses to the origin. Fields documented below.
     */
    public readonly originDns!: pulumi.Output<outputs.SpectrumApplicationOriginDns | undefined>;
    /**
     * If using `originDns` this is a required attribute. Origin port to proxy traffice to e.g. `22`.
     */
    public readonly originPort!: pulumi.Output<number>;
    /**
     * The port configuration at Cloudflare’s edge. e.g. `tcp/22`.
     */
    public readonly protocol!: pulumi.Output<string>;
    /**
     * Enables Proxy Protocol v1 to the origin. Defaults to `false`.
     */
    public readonly proxyProtocol!: pulumi.Output<boolean | undefined>;
    /**
     * TLS configuration option for Cloudflare to connect to your origin. Valid values are: `off`, `flexible`, `full` and `strict`. Defaults to `off`.
     */
    public readonly tls!: pulumi.Output<string | undefined>;
    /**
     * Set's application type. Valid values are: `direct`, `http`, `https`.  Defaults to `direct`.
     */
    public readonly trafficType!: pulumi.Output<string | undefined>;
    public readonly zoneId!: pulumi.Output<string>;

    /**
     * Create a SpectrumApplication resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SpectrumApplicationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SpectrumApplicationArgs | SpectrumApplicationState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as SpectrumApplicationState | undefined;
            inputs["dns"] = state ? state.dns : undefined;
            inputs["ipFirewall"] = state ? state.ipFirewall : undefined;
            inputs["originDirects"] = state ? state.originDirects : undefined;
            inputs["originDns"] = state ? state.originDns : undefined;
            inputs["originPort"] = state ? state.originPort : undefined;
            inputs["protocol"] = state ? state.protocol : undefined;
            inputs["proxyProtocol"] = state ? state.proxyProtocol : undefined;
            inputs["tls"] = state ? state.tls : undefined;
            inputs["trafficType"] = state ? state.trafficType : undefined;
            inputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as SpectrumApplicationArgs | undefined;
            if (!args || args.dns === undefined) {
                throw new Error("Missing required property 'dns'");
            }
            if (!args || args.originPort === undefined) {
                throw new Error("Missing required property 'originPort'");
            }
            if (!args || args.protocol === undefined) {
                throw new Error("Missing required property 'protocol'");
            }
            if (!args || args.zoneId === undefined) {
                throw new Error("Missing required property 'zoneId'");
            }
            inputs["dns"] = args ? args.dns : undefined;
            inputs["ipFirewall"] = args ? args.ipFirewall : undefined;
            inputs["originDirects"] = args ? args.originDirects : undefined;
            inputs["originDns"] = args ? args.originDns : undefined;
            inputs["originPort"] = args ? args.originPort : undefined;
            inputs["protocol"] = args ? args.protocol : undefined;
            inputs["proxyProtocol"] = args ? args.proxyProtocol : undefined;
            inputs["tls"] = args ? args.tls : undefined;
            inputs["trafficType"] = args ? args.trafficType : undefined;
            inputs["zoneId"] = args ? args.zoneId : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(SpectrumApplication.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SpectrumApplication resources.
 */
export interface SpectrumApplicationState {
    /**
     * The name and type of DNS record for the Spectrum application. Fields documented below.
     */
    readonly dns?: pulumi.Input<inputs.SpectrumApplicationDns>;
    /**
     * Enables the IP Firewall for this application. Defaults to `true`.
     */
    readonly ipFirewall?: pulumi.Input<boolean>;
    /**
     * A list of destination addresses to the origin. e.g. `tcp://192.0.2.1:22`.
     */
    readonly originDirects?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A destination DNS addresses to the origin. Fields documented below.
     */
    readonly originDns?: pulumi.Input<inputs.SpectrumApplicationOriginDns>;
    /**
     * If using `originDns` this is a required attribute. Origin port to proxy traffice to e.g. `22`.
     */
    readonly originPort?: pulumi.Input<number>;
    /**
     * The port configuration at Cloudflare’s edge. e.g. `tcp/22`.
     */
    readonly protocol?: pulumi.Input<string>;
    /**
     * Enables Proxy Protocol v1 to the origin. Defaults to `false`.
     */
    readonly proxyProtocol?: pulumi.Input<boolean>;
    /**
     * TLS configuration option for Cloudflare to connect to your origin. Valid values are: `off`, `flexible`, `full` and `strict`. Defaults to `off`.
     */
    readonly tls?: pulumi.Input<string>;
    /**
     * Set's application type. Valid values are: `direct`, `http`, `https`.  Defaults to `direct`.
     */
    readonly trafficType?: pulumi.Input<string>;
    readonly zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SpectrumApplication resource.
 */
export interface SpectrumApplicationArgs {
    /**
     * The name and type of DNS record for the Spectrum application. Fields documented below.
     */
    readonly dns: pulumi.Input<inputs.SpectrumApplicationDns>;
    /**
     * Enables the IP Firewall for this application. Defaults to `true`.
     */
    readonly ipFirewall?: pulumi.Input<boolean>;
    /**
     * A list of destination addresses to the origin. e.g. `tcp://192.0.2.1:22`.
     */
    readonly originDirects?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A destination DNS addresses to the origin. Fields documented below.
     */
    readonly originDns?: pulumi.Input<inputs.SpectrumApplicationOriginDns>;
    /**
     * If using `originDns` this is a required attribute. Origin port to proxy traffice to e.g. `22`.
     */
    readonly originPort: pulumi.Input<number>;
    /**
     * The port configuration at Cloudflare’s edge. e.g. `tcp/22`.
     */
    readonly protocol: pulumi.Input<string>;
    /**
     * Enables Proxy Protocol v1 to the origin. Defaults to `false`.
     */
    readonly proxyProtocol?: pulumi.Input<boolean>;
    /**
     * TLS configuration option for Cloudflare to connect to your origin. Valid values are: `off`, `flexible`, `full` and `strict`. Defaults to `off`.
     */
    readonly tls?: pulumi.Input<string>;
    /**
     * Set's application type. Valid values are: `direct`, `http`, `https`.  Defaults to `direct`.
     */
    readonly trafficType?: pulumi.Input<string>;
    readonly zoneId: pulumi.Input<string>;
}
