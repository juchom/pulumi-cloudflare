// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package cloudflare

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to look up [WAF Rule Groups][1].
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/d/waf_groups.html.markdown.
func LookupWafGroups(ctx *pulumi.Context, args *GetWafGroupsArgs) (*GetWafGroupsResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["filter"] = args.Filter
		inputs["packageId"] = args.PackageId
		inputs["zoneId"] = args.ZoneId
	}
	outputs, err := ctx.Invoke("cloudflare:index/getWafGroups:getWafGroups", inputs)
	if err != nil {
		return nil, err
	}
	return &GetWafGroupsResult{
		Filter: outputs["filter"],
		Groups: outputs["groups"],
		PackageId: outputs["packageId"],
		ZoneId: outputs["zoneId"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getWafGroups.
type GetWafGroupsArgs struct {
	Filter interface{}
	PackageId interface{}
	ZoneId interface{}
}

// A collection of values returned by getWafGroups.
type GetWafGroupsResult struct {
	Filter interface{}
	Groups interface{}
	PackageId interface{}
	ZoneId interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
