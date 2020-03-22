// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package cloudflare

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Cloudflare Zone Lockdown resource. Zone Lockdown allows you to define one or more URLs (with wildcard matching on the domain or path) that will only permit access if the request originates from an IP address that matches a safelist of one or more IP addresses and/or IP ranges.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/zone_lockdown.html.markdown.
type ZoneLockdown struct {
	pulumi.CustomResourceState

	// A list of IP addresses or IP ranges to match the request against specified in target, value pairs.  It's a complex value. See description below.   The order of the configuration entries is unimportant.
	Configurations ZoneLockdownConfigurationArrayOutput `pulumi:"configurations"`
	// A description about the lockdown entry. Typically used as a reminder or explanation for the lockdown.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Boolean of whether this zone lockdown is currently paused. Default: false.
	Paused pulumi.BoolPtrOutput `pulumi:"paused"`
	Priority pulumi.IntPtrOutput `pulumi:"priority"`
	// A list of simple wildcard patterns to match requests against. The order of the urls is unimportant.
	Urls pulumi.StringArrayOutput `pulumi:"urls"`
	// The DNS zone ID to which the access rule should be added.
	ZoneId pulumi.StringOutput `pulumi:"zoneId"`
}

// NewZoneLockdown registers a new resource with the given unique name, arguments, and options.
func NewZoneLockdown(ctx *pulumi.Context,
	name string, args *ZoneLockdownArgs, opts ...pulumi.ResourceOption) (*ZoneLockdown, error) {
	if args == nil || args.Configurations == nil {
		return nil, errors.New("missing required argument 'Configurations'")
	}
	if args == nil || args.Urls == nil {
		return nil, errors.New("missing required argument 'Urls'")
	}
	if args == nil || args.ZoneId == nil {
		return nil, errors.New("missing required argument 'ZoneId'")
	}
	if args == nil {
		args = &ZoneLockdownArgs{}
	}
	var resource ZoneLockdown
	err := ctx.RegisterResource("cloudflare:index/zoneLockdown:ZoneLockdown", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetZoneLockdown gets an existing ZoneLockdown resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetZoneLockdown(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ZoneLockdownState, opts ...pulumi.ResourceOption) (*ZoneLockdown, error) {
	var resource ZoneLockdown
	err := ctx.ReadResource("cloudflare:index/zoneLockdown:ZoneLockdown", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ZoneLockdown resources.
type zoneLockdownState struct {
	// A list of IP addresses or IP ranges to match the request against specified in target, value pairs.  It's a complex value. See description below.   The order of the configuration entries is unimportant.
	Configurations []ZoneLockdownConfiguration `pulumi:"configurations"`
	// A description about the lockdown entry. Typically used as a reminder or explanation for the lockdown.
	Description *string `pulumi:"description"`
	// Boolean of whether this zone lockdown is currently paused. Default: false.
	Paused *bool `pulumi:"paused"`
	Priority *int `pulumi:"priority"`
	// A list of simple wildcard patterns to match requests against. The order of the urls is unimportant.
	Urls []string `pulumi:"urls"`
	// The DNS zone ID to which the access rule should be added.
	ZoneId *string `pulumi:"zoneId"`
}

type ZoneLockdownState struct {
	// A list of IP addresses or IP ranges to match the request against specified in target, value pairs.  It's a complex value. See description below.   The order of the configuration entries is unimportant.
	Configurations ZoneLockdownConfigurationArrayInput
	// A description about the lockdown entry. Typically used as a reminder or explanation for the lockdown.
	Description pulumi.StringPtrInput
	// Boolean of whether this zone lockdown is currently paused. Default: false.
	Paused pulumi.BoolPtrInput
	Priority pulumi.IntPtrInput
	// A list of simple wildcard patterns to match requests against. The order of the urls is unimportant.
	Urls pulumi.StringArrayInput
	// The DNS zone ID to which the access rule should be added.
	ZoneId pulumi.StringPtrInput
}

func (ZoneLockdownState) ElementType() reflect.Type {
	return reflect.TypeOf((*zoneLockdownState)(nil)).Elem()
}

type zoneLockdownArgs struct {
	// A list of IP addresses or IP ranges to match the request against specified in target, value pairs.  It's a complex value. See description below.   The order of the configuration entries is unimportant.
	Configurations []ZoneLockdownConfiguration `pulumi:"configurations"`
	// A description about the lockdown entry. Typically used as a reminder or explanation for the lockdown.
	Description *string `pulumi:"description"`
	// Boolean of whether this zone lockdown is currently paused. Default: false.
	Paused *bool `pulumi:"paused"`
	Priority *int `pulumi:"priority"`
	// A list of simple wildcard patterns to match requests against. The order of the urls is unimportant.
	Urls []string `pulumi:"urls"`
	// The DNS zone ID to which the access rule should be added.
	ZoneId string `pulumi:"zoneId"`
}

// The set of arguments for constructing a ZoneLockdown resource.
type ZoneLockdownArgs struct {
	// A list of IP addresses or IP ranges to match the request against specified in target, value pairs.  It's a complex value. See description below.   The order of the configuration entries is unimportant.
	Configurations ZoneLockdownConfigurationArrayInput
	// A description about the lockdown entry. Typically used as a reminder or explanation for the lockdown.
	Description pulumi.StringPtrInput
	// Boolean of whether this zone lockdown is currently paused. Default: false.
	Paused pulumi.BoolPtrInput
	Priority pulumi.IntPtrInput
	// A list of simple wildcard patterns to match requests against. The order of the urls is unimportant.
	Urls pulumi.StringArrayInput
	// The DNS zone ID to which the access rule should be added.
	ZoneId pulumi.StringInput
}

func (ZoneLockdownArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*zoneLockdownArgs)(nil)).Elem()
}

