// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package cloudflare

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Cloudflare Zone resource. Zone is the basic resource for working with Cloudflare and is roughly equivalent to a domain name that the user purchases.
// 
// > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/zone.html.markdown.
type Zone struct {
	pulumi.CustomResourceState

	// Boolean of whether to scan for DNS records on creation. Ignored after zone is created. Default: false.
	JumpStart pulumi.BoolPtrOutput `pulumi:"jumpStart"`
	Meta ZoneMetaOutput `pulumi:"meta"`
	// Cloudflare-assigned name servers. This is only populated for zones that use Cloudflare DNS.
	NameServers pulumi.StringArrayOutput `pulumi:"nameServers"`
	// Boolean of whether this zone is paused (traffic bypasses Cloudflare). Default: false.
	Paused pulumi.BoolPtrOutput `pulumi:"paused"`
	// The name of the commercial plan to apply to the zone, can be updated once the one is created; one of `free`, `pro`, `business`, `enterprise`.
	Plan pulumi.StringOutput `pulumi:"plan"`
	// Status of the zone. Valid values: `active`, `pending`, `initializing`, `moved`, `deleted`, `deactivated`.
	Status pulumi.StringOutput `pulumi:"status"`
	// A full zone implies that DNS is hosted with Cloudflare. A partial zone is typically a partner-hosted zone or a CNAME setup. Valid values: `full`, `partial`. Default is `full`.
	Type pulumi.StringPtrOutput `pulumi:"type"`
	// List of Vanity Nameservers (if set).
	// * `meta.wildcard_proxiable` - Indicates whether wildcard DNS records can receive Cloudflare security and performance features.
	// * `meta.phishing_detected` - Indicates if URLs on the zone have been identified as hosting phishing content.
	VanityNameServers pulumi.StringArrayOutput `pulumi:"vanityNameServers"`
	// Contains the TXT record value to validate domain ownership. This is only populated for zones of type `partial`. 
	VerificationKey pulumi.StringOutput `pulumi:"verificationKey"`
	// The DNS zone name which will be added.
	Zone pulumi.StringOutput `pulumi:"zone"`
}

// NewZone registers a new resource with the given unique name, arguments, and options.
func NewZone(ctx *pulumi.Context,
	name string, args *ZoneArgs, opts ...pulumi.ResourceOption) (*Zone, error) {
	if args == nil || args.Zone == nil {
		return nil, errors.New("missing required argument 'Zone'")
	}
	if args == nil {
		args = &ZoneArgs{}
	}
	var resource Zone
	err := ctx.RegisterResource("cloudflare:index/zone:Zone", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetZone gets an existing Zone resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetZone(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ZoneState, opts ...pulumi.ResourceOption) (*Zone, error) {
	var resource Zone
	err := ctx.ReadResource("cloudflare:index/zone:Zone", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Zone resources.
type zoneState struct {
	// Boolean of whether to scan for DNS records on creation. Ignored after zone is created. Default: false.
	JumpStart *bool `pulumi:"jumpStart"`
	Meta *ZoneMeta `pulumi:"meta"`
	// Cloudflare-assigned name servers. This is only populated for zones that use Cloudflare DNS.
	NameServers []string `pulumi:"nameServers"`
	// Boolean of whether this zone is paused (traffic bypasses Cloudflare). Default: false.
	Paused *bool `pulumi:"paused"`
	// The name of the commercial plan to apply to the zone, can be updated once the one is created; one of `free`, `pro`, `business`, `enterprise`.
	Plan *string `pulumi:"plan"`
	// Status of the zone. Valid values: `active`, `pending`, `initializing`, `moved`, `deleted`, `deactivated`.
	Status *string `pulumi:"status"`
	// A full zone implies that DNS is hosted with Cloudflare. A partial zone is typically a partner-hosted zone or a CNAME setup. Valid values: `full`, `partial`. Default is `full`.
	Type *string `pulumi:"type"`
	// List of Vanity Nameservers (if set).
	// * `meta.wildcard_proxiable` - Indicates whether wildcard DNS records can receive Cloudflare security and performance features.
	// * `meta.phishing_detected` - Indicates if URLs on the zone have been identified as hosting phishing content.
	VanityNameServers []string `pulumi:"vanityNameServers"`
	// Contains the TXT record value to validate domain ownership. This is only populated for zones of type `partial`. 
	VerificationKey *string `pulumi:"verificationKey"`
	// The DNS zone name which will be added.
	Zone *string `pulumi:"zone"`
}

type ZoneState struct {
	// Boolean of whether to scan for DNS records on creation. Ignored after zone is created. Default: false.
	JumpStart pulumi.BoolPtrInput
	Meta ZoneMetaPtrInput
	// Cloudflare-assigned name servers. This is only populated for zones that use Cloudflare DNS.
	NameServers pulumi.StringArrayInput
	// Boolean of whether this zone is paused (traffic bypasses Cloudflare). Default: false.
	Paused pulumi.BoolPtrInput
	// The name of the commercial plan to apply to the zone, can be updated once the one is created; one of `free`, `pro`, `business`, `enterprise`.
	Plan pulumi.StringPtrInput
	// Status of the zone. Valid values: `active`, `pending`, `initializing`, `moved`, `deleted`, `deactivated`.
	Status pulumi.StringPtrInput
	// A full zone implies that DNS is hosted with Cloudflare. A partial zone is typically a partner-hosted zone or a CNAME setup. Valid values: `full`, `partial`. Default is `full`.
	Type pulumi.StringPtrInput
	// List of Vanity Nameservers (if set).
	// * `meta.wildcard_proxiable` - Indicates whether wildcard DNS records can receive Cloudflare security and performance features.
	// * `meta.phishing_detected` - Indicates if URLs on the zone have been identified as hosting phishing content.
	VanityNameServers pulumi.StringArrayInput
	// Contains the TXT record value to validate domain ownership. This is only populated for zones of type `partial`. 
	VerificationKey pulumi.StringPtrInput
	// The DNS zone name which will be added.
	Zone pulumi.StringPtrInput
}

func (ZoneState) ElementType() reflect.Type {
	return reflect.TypeOf((*zoneState)(nil)).Elem()
}

type zoneArgs struct {
	// Boolean of whether to scan for DNS records on creation. Ignored after zone is created. Default: false.
	JumpStart *bool `pulumi:"jumpStart"`
	// Boolean of whether this zone is paused (traffic bypasses Cloudflare). Default: false.
	Paused *bool `pulumi:"paused"`
	// The name of the commercial plan to apply to the zone, can be updated once the one is created; one of `free`, `pro`, `business`, `enterprise`.
	Plan *string `pulumi:"plan"`
	// A full zone implies that DNS is hosted with Cloudflare. A partial zone is typically a partner-hosted zone or a CNAME setup. Valid values: `full`, `partial`. Default is `full`.
	Type *string `pulumi:"type"`
	// The DNS zone name which will be added.
	Zone string `pulumi:"zone"`
}

// The set of arguments for constructing a Zone resource.
type ZoneArgs struct {
	// Boolean of whether to scan for DNS records on creation. Ignored after zone is created. Default: false.
	JumpStart pulumi.BoolPtrInput
	// Boolean of whether this zone is paused (traffic bypasses Cloudflare). Default: false.
	Paused pulumi.BoolPtrInput
	// The name of the commercial plan to apply to the zone, can be updated once the one is created; one of `free`, `pro`, `business`, `enterprise`.
	Plan pulumi.StringPtrInput
	// A full zone implies that DNS is hosted with Cloudflare. A partial zone is typically a partner-hosted zone or a CNAME setup. Valid values: `full`, `partial`. Default is `full`.
	Type pulumi.StringPtrInput
	// The DNS zone name which will be added.
	Zone pulumi.StringInput
}

func (ZoneArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*zoneArgs)(nil)).Elem()
}

