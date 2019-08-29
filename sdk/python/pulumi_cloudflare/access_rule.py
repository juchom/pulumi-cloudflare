# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class AccessRule(pulumi.CustomResource):
    configuration: pulumi.Output[dict]
    """
    Rule configuration to apply to a matched request. It's a complex value. See description below.
    
      * `target` (`str`) - The request property to target. Allowed values: "ip", "ip_range", "asn", "country"
      * `value` (`str`) - The value to target. Depends on target's type.
    """
    mode: pulumi.Output[str]
    """
    The action to apply to a matched request. Allowed values: "block", "challenge", "whitelist", "js_challenge"
    """
    notes: pulumi.Output[str]
    """
    A personal note about the rule. Typically used as a reminder or explanation for the rule.
    """
    zone: pulumi.Output[str]
    """
    The DNS zone to which the access rule should be added. Will be resolved to `zone_id` upon creation.
    """
    zone_id: pulumi.Output[str]
    """
    The DNS zone to which the access rule should be added.
    """
    def __init__(__self__, resource_name, opts=None, configuration=None, mode=None, notes=None, zone=None, zone_id=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Cloudflare IP Firewall Access Rule resource. Access control can be applied on basis of IP addresses, IP ranges, AS numbers or countries.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] configuration: Rule configuration to apply to a matched request. It's a complex value. See description below.
        :param pulumi.Input[str] mode: The action to apply to a matched request. Allowed values: "block", "challenge", "whitelist", "js_challenge"
        :param pulumi.Input[str] notes: A personal note about the rule. Typically used as a reminder or explanation for the rule.
        :param pulumi.Input[str] zone: The DNS zone to which the access rule should be added. Will be resolved to `zone_id` upon creation.
        :param pulumi.Input[str] zone_id: The DNS zone to which the access rule should be added.
        
        The **configuration** object supports the following:
        
          * `target` (`pulumi.Input[str]`) - The request property to target. Allowed values: "ip", "ip_range", "asn", "country"
          * `value` (`pulumi.Input[str]`) - The value to target. Depends on target's type.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/access_rule.html.markdown.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if configuration is None:
                raise TypeError("Missing required property 'configuration'")
            __props__['configuration'] = configuration
            if mode is None:
                raise TypeError("Missing required property 'mode'")
            __props__['mode'] = mode
            __props__['notes'] = notes
            __props__['zone'] = zone
            __props__['zone_id'] = zone_id
        super(AccessRule, __self__).__init__(
            'cloudflare:index/accessRule:AccessRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, configuration=None, mode=None, notes=None, zone=None, zone_id=None):
        """
        Get an existing AccessRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] configuration: Rule configuration to apply to a matched request. It's a complex value. See description below.
        :param pulumi.Input[str] mode: The action to apply to a matched request. Allowed values: "block", "challenge", "whitelist", "js_challenge"
        :param pulumi.Input[str] notes: A personal note about the rule. Typically used as a reminder or explanation for the rule.
        :param pulumi.Input[str] zone: The DNS zone to which the access rule should be added. Will be resolved to `zone_id` upon creation.
        :param pulumi.Input[str] zone_id: The DNS zone to which the access rule should be added.
        
        The **configuration** object supports the following:
        
          * `target` (`pulumi.Input[str]`) - The request property to target. Allowed values: "ip", "ip_range", "asn", "country"
          * `value` (`pulumi.Input[str]`) - The value to target. Depends on target's type.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/access_rule.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["configuration"] = configuration
        __props__["mode"] = mode
        __props__["notes"] = notes
        __props__["zone"] = zone
        __props__["zone_id"] = zone_id
        return AccessRule(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

