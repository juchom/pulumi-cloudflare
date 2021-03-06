// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package cloudflare

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Workers KV Namespace
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/workers_kv_namespace.html.markdown.
type WorkersKvNamespace struct {
	pulumi.CustomResourceState

	// The name of the namespace you wish to create.
	Title pulumi.StringOutput `pulumi:"title"`
}

// NewWorkersKvNamespace registers a new resource with the given unique name, arguments, and options.
func NewWorkersKvNamespace(ctx *pulumi.Context,
	name string, args *WorkersKvNamespaceArgs, opts ...pulumi.ResourceOption) (*WorkersKvNamespace, error) {
	if args == nil || args.Title == nil {
		return nil, errors.New("missing required argument 'Title'")
	}
	if args == nil {
		args = &WorkersKvNamespaceArgs{}
	}
	var resource WorkersKvNamespace
	err := ctx.RegisterResource("cloudflare:index/workersKvNamespace:WorkersKvNamespace", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWorkersKvNamespace gets an existing WorkersKvNamespace resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWorkersKvNamespace(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WorkersKvNamespaceState, opts ...pulumi.ResourceOption) (*WorkersKvNamespace, error) {
	var resource WorkersKvNamespace
	err := ctx.ReadResource("cloudflare:index/workersKvNamespace:WorkersKvNamespace", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WorkersKvNamespace resources.
type workersKvNamespaceState struct {
	// The name of the namespace you wish to create.
	Title *string `pulumi:"title"`
}

type WorkersKvNamespaceState struct {
	// The name of the namespace you wish to create.
	Title pulumi.StringPtrInput
}

func (WorkersKvNamespaceState) ElementType() reflect.Type {
	return reflect.TypeOf((*workersKvNamespaceState)(nil)).Elem()
}

type workersKvNamespaceArgs struct {
	// The name of the namespace you wish to create.
	Title string `pulumi:"title"`
}

// The set of arguments for constructing a WorkersKvNamespace resource.
type WorkersKvNamespaceArgs struct {
	// The name of the namespace you wish to create.
	Title pulumi.StringInput
}

func (WorkersKvNamespaceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*workersKvNamespaceArgs)(nil)).Elem()
}

