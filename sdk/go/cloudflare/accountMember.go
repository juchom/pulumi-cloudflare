// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package cloudflare

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a resource which manages Cloudflare account members.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/account_member.markdown.
type AccountMember struct {
	pulumi.CustomResourceState

	// The email address of the user who you wish to manage. Note: Following creation, this field becomes read only via the API and cannot be updated.
	EmailAddress pulumi.StringOutput `pulumi:"emailAddress"`
	// Array of account role IDs that you want to assign to a member.
	RoleIds pulumi.StringArrayOutput `pulumi:"roleIds"`
}

// NewAccountMember registers a new resource with the given unique name, arguments, and options.
func NewAccountMember(ctx *pulumi.Context,
	name string, args *AccountMemberArgs, opts ...pulumi.ResourceOption) (*AccountMember, error) {
	if args == nil || args.EmailAddress == nil {
		return nil, errors.New("missing required argument 'EmailAddress'")
	}
	if args == nil || args.RoleIds == nil {
		return nil, errors.New("missing required argument 'RoleIds'")
	}
	if args == nil {
		args = &AccountMemberArgs{}
	}
	var resource AccountMember
	err := ctx.RegisterResource("cloudflare:index/accountMember:AccountMember", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAccountMember gets an existing AccountMember resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAccountMember(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AccountMemberState, opts ...pulumi.ResourceOption) (*AccountMember, error) {
	var resource AccountMember
	err := ctx.ReadResource("cloudflare:index/accountMember:AccountMember", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AccountMember resources.
type accountMemberState struct {
	// The email address of the user who you wish to manage. Note: Following creation, this field becomes read only via the API and cannot be updated.
	EmailAddress *string `pulumi:"emailAddress"`
	// Array of account role IDs that you want to assign to a member.
	RoleIds []string `pulumi:"roleIds"`
}

type AccountMemberState struct {
	// The email address of the user who you wish to manage. Note: Following creation, this field becomes read only via the API and cannot be updated.
	EmailAddress pulumi.StringPtrInput
	// Array of account role IDs that you want to assign to a member.
	RoleIds pulumi.StringArrayInput
}

func (AccountMemberState) ElementType() reflect.Type {
	return reflect.TypeOf((*accountMemberState)(nil)).Elem()
}

type accountMemberArgs struct {
	// The email address of the user who you wish to manage. Note: Following creation, this field becomes read only via the API and cannot be updated.
	EmailAddress string `pulumi:"emailAddress"`
	// Array of account role IDs that you want to assign to a member.
	RoleIds []string `pulumi:"roleIds"`
}

// The set of arguments for constructing a AccountMember resource.
type AccountMemberArgs struct {
	// The email address of the user who you wish to manage. Note: Following creation, this field becomes read only via the API and cannot be updated.
	EmailAddress pulumi.StringInput
	// Array of account role IDs that you want to assign to a member.
	RoleIds pulumi.StringArrayInput
}

func (AccountMemberArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*accountMemberArgs)(nil)).Elem()
}

