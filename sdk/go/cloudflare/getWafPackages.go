// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package cloudflare

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to look up [WAF Rule Packages][1].
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/d/waf_packages.html.md.
func GetWafPackages(ctx *pulumi.Context, args *GetWafPackagesArgs, opts ...pulumi.InvokeOption) (*GetWafPackagesResult, error) {
	var rv GetWafPackagesResult
	err := ctx.Invoke("cloudflare:index/getWafPackages:getWafPackages", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getWafPackages.
type GetWafPackagesArgs struct {
	Filter *GetWafPackagesFilter `pulumi:"filter"`
	ZoneId string `pulumi:"zoneId"`
}


// A collection of values returned by getWafPackages.
type GetWafPackagesResult struct {
	Filter *GetWafPackagesFilter `pulumi:"filter"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	Packages []GetWafPackagesPackage `pulumi:"packages"`
	ZoneId string `pulumi:"zoneId"`
}

