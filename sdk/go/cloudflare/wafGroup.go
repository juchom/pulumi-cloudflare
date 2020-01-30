// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package cloudflare

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Cloudflare WAF rule group resource for a particular zone. This can be used to configure firewall behaviour for pre-defined firewall groups.
// 
// > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/waf_group.html.markdown.
type WafGroup struct {
	pulumi.CustomResourceState

	// The WAF Rule Group ID.
	GroupId pulumi.StringOutput `pulumi:"groupId"`
	// The mode of the group, can be one of ["on", "off"].
	Mode pulumi.StringPtrOutput `pulumi:"mode"`
	// The ID of the WAF Rule Package that contains the group.
	PackageId pulumi.StringOutput `pulumi:"packageId"`
	// The DNS zone ID to apply to.
	ZoneId pulumi.StringOutput `pulumi:"zoneId"`
}

// NewWafGroup registers a new resource with the given unique name, arguments, and options.
func NewWafGroup(ctx *pulumi.Context,
	name string, args *WafGroupArgs, opts ...pulumi.ResourceOption) (*WafGroup, error) {
	if args == nil || args.GroupId == nil {
		return nil, errors.New("missing required argument 'GroupId'")
	}
	if args == nil || args.ZoneId == nil {
		return nil, errors.New("missing required argument 'ZoneId'")
	}
	if args == nil {
		args = &WafGroupArgs{}
	}
	var resource WafGroup
	err := ctx.RegisterResource("cloudflare:index/wafGroup:WafGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWafGroup gets an existing WafGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWafGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WafGroupState, opts ...pulumi.ResourceOption) (*WafGroup, error) {
	var resource WafGroup
	err := ctx.ReadResource("cloudflare:index/wafGroup:WafGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WafGroup resources.
type wafGroupState struct {
	// The WAF Rule Group ID.
	GroupId *string `pulumi:"groupId"`
	// The mode of the group, can be one of ["on", "off"].
	Mode *string `pulumi:"mode"`
	// The ID of the WAF Rule Package that contains the group.
	PackageId *string `pulumi:"packageId"`
	// The DNS zone ID to apply to.
	ZoneId *string `pulumi:"zoneId"`
}

type WafGroupState struct {
	// The WAF Rule Group ID.
	GroupId pulumi.StringPtrInput
	// The mode of the group, can be one of ["on", "off"].
	Mode pulumi.StringPtrInput
	// The ID of the WAF Rule Package that contains the group.
	PackageId pulumi.StringPtrInput
	// The DNS zone ID to apply to.
	ZoneId pulumi.StringPtrInput
}

func (WafGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*wafGroupState)(nil)).Elem()
}

type wafGroupArgs struct {
	// The WAF Rule Group ID.
	GroupId string `pulumi:"groupId"`
	// The mode of the group, can be one of ["on", "off"].
	Mode *string `pulumi:"mode"`
	// The ID of the WAF Rule Package that contains the group.
	PackageId *string `pulumi:"packageId"`
	// The DNS zone ID to apply to.
	ZoneId string `pulumi:"zoneId"`
}

// The set of arguments for constructing a WafGroup resource.
type WafGroupArgs struct {
	// The WAF Rule Group ID.
	GroupId pulumi.StringInput
	// The mode of the group, can be one of ["on", "off"].
	Mode pulumi.StringPtrInput
	// The ID of the WAF Rule Package that contains the group.
	PackageId pulumi.StringPtrInput
	// The DNS zone ID to apply to.
	ZoneId pulumi.StringInput
}

func (WafGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*wafGroupArgs)(nil)).Elem()
}

