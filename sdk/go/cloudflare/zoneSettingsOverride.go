// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package cloudflare

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a resource which customizes Cloudflare zone settings. Note that after destroying this resource Zone Settings will be reset to their initial values.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/zone_settings_override.html.markdown.
type ZoneSettingsOverride struct {
	s *pulumi.ResourceState
}

// NewZoneSettingsOverride registers a new resource with the given unique name, arguments, and options.
func NewZoneSettingsOverride(ctx *pulumi.Context,
	name string, args *ZoneSettingsOverrideArgs, opts ...pulumi.ResourceOpt) (*ZoneSettingsOverride, error) {
	if args == nil || args.ZoneId == nil {
		return nil, errors.New("missing required argument 'ZoneId'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["settings"] = nil
		inputs["zoneId"] = nil
	} else {
		inputs["settings"] = args.Settings
		inputs["zoneId"] = args.ZoneId
	}
	inputs["initialSettings"] = nil
	inputs["initialSettingsReadAt"] = nil
	inputs["readonlySettings"] = nil
	inputs["zoneStatus"] = nil
	inputs["zoneType"] = nil
	s, err := ctx.RegisterResource("cloudflare:index/zoneSettingsOverride:ZoneSettingsOverride", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ZoneSettingsOverride{s: s}, nil
}

// GetZoneSettingsOverride gets an existing ZoneSettingsOverride resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetZoneSettingsOverride(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ZoneSettingsOverrideState, opts ...pulumi.ResourceOpt) (*ZoneSettingsOverride, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["initialSettings"] = state.InitialSettings
		inputs["initialSettingsReadAt"] = state.InitialSettingsReadAt
		inputs["readonlySettings"] = state.ReadonlySettings
		inputs["settings"] = state.Settings
		inputs["zoneId"] = state.ZoneId
		inputs["zoneStatus"] = state.ZoneStatus
		inputs["zoneType"] = state.ZoneType
	}
	s, err := ctx.ReadResource("cloudflare:index/zoneSettingsOverride:ZoneSettingsOverride", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ZoneSettingsOverride{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ZoneSettingsOverride) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ZoneSettingsOverride) ID() pulumi.IDOutput {
	return r.s.ID()
}

// Settings present in the zone at the time the resource is created. This will be used to restore the original settings when this resource is destroyed. Shares the same schema as the `settings` attribute (Above).
func (r *ZoneSettingsOverride) InitialSettings() pulumi.Output {
	return r.s.State["initialSettings"]
}

func (r *ZoneSettingsOverride) InitialSettingsReadAt() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["initialSettingsReadAt"])
}

// Which of the current `settings` are not able to be set by the user. Which settings these are is determined by plan level and user permissions.
// * `zoneStatus`. A full zone implies that DNS is hosted with Cloudflare. A partial zone is typically a partner-hosted zone or a CNAME setup.
// * `zoneType`. Status of the zone. Valid values: active, pending, initializing, moved, deleted, deactivated.
func (r *ZoneSettingsOverride) ReadonlySettings() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["readonlySettings"])
}

// Settings overrides that will be applied to the zone. If a setting is not specified the existing setting will be used. For a full list of available settings see below.
func (r *ZoneSettingsOverride) Settings() pulumi.Output {
	return r.s.State["settings"]
}

// The DNS zone ID to which apply settings.
func (r *ZoneSettingsOverride) ZoneId() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["zoneId"])
}

func (r *ZoneSettingsOverride) ZoneStatus() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["zoneStatus"])
}

func (r *ZoneSettingsOverride) ZoneType() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["zoneType"])
}

// Input properties used for looking up and filtering ZoneSettingsOverride resources.
type ZoneSettingsOverrideState struct {
	// Settings present in the zone at the time the resource is created. This will be used to restore the original settings when this resource is destroyed. Shares the same schema as the `settings` attribute (Above).
	InitialSettings interface{}
	InitialSettingsReadAt interface{}
	// Which of the current `settings` are not able to be set by the user. Which settings these are is determined by plan level and user permissions.
	// * `zoneStatus`. A full zone implies that DNS is hosted with Cloudflare. A partial zone is typically a partner-hosted zone or a CNAME setup.
	// * `zoneType`. Status of the zone. Valid values: active, pending, initializing, moved, deleted, deactivated.
	ReadonlySettings interface{}
	// Settings overrides that will be applied to the zone. If a setting is not specified the existing setting will be used. For a full list of available settings see below.
	Settings interface{}
	// The DNS zone ID to which apply settings.
	ZoneId interface{}
	ZoneStatus interface{}
	ZoneType interface{}
}

// The set of arguments for constructing a ZoneSettingsOverride resource.
type ZoneSettingsOverrideArgs struct {
	// Settings overrides that will be applied to the zone. If a setting is not specified the existing setting will be used. For a full list of available settings see below.
	Settings interface{}
	// The DNS zone ID to which apply settings.
	ZoneId interface{}
}
