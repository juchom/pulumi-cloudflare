# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from . import utilities, tables

class FirewallRule(pulumi.CustomResource):
    action: pulumi.Output[str]
    """
    The action to apply to a matched request. Allowed values: "block", "challenge", "allow", "js_challenge". Enterprise plan also allows "log".
    """
    description: pulumi.Output[str]
    """
    A description of the rule to help identify it.
    """
    filter_id: pulumi.Output[str]
    paused: pulumi.Output[bool]
    """
    Whether this filter based firewall rule is currently paused. Boolean value.
    """
    priority: pulumi.Output[int]
    """
    The priority of the rule to allow control of processing order. A lower number indicates high priority. If not provided, any rules with a priority will be sequenced before those without.
    """
    zone: pulumi.Output[str]
    """
    The DNS zone to which the Firewall Rule should be added. Will be resolved to `zone_id` upon creation.
    """
    zone_id: pulumi.Output[str]
    """
    The DNS zone to which the Filter should be added.
    """
    def __init__(__self__, resource_name, opts=None, action=None, description=None, filter_id=None, paused=None, priority=None, zone=None, zone_id=None, __name__=None, __opts__=None):
        """
        Define Firewall rules using filter expressions for more control over how traffic is matched to the rule.
        A filter expression permits selecting traffic by multiple criteria allowing greater freedom in rule creation.
        
        Filter expressions needs to be created first before using Firewall Rule. See Filter.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] action: The action to apply to a matched request. Allowed values: "block", "challenge", "allow", "js_challenge". Enterprise plan also allows "log".
        :param pulumi.Input[str] description: A description of the rule to help identify it.
        :param pulumi.Input[bool] paused: Whether this filter based firewall rule is currently paused. Boolean value.
        :param pulumi.Input[int] priority: The priority of the rule to allow control of processing order. A lower number indicates high priority. If not provided, any rules with a priority will be sequenced before those without.
        :param pulumi.Input[str] zone: The DNS zone to which the Firewall Rule should be added. Will be resolved to `zone_id` upon creation.
        :param pulumi.Input[str] zone_id: The DNS zone to which the Filter should be added.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if action is None:
            raise TypeError('Missing required property action')
        __props__['action'] = action

        __props__['description'] = description

        if filter_id is None:
            raise TypeError('Missing required property filter_id')
        __props__['filter_id'] = filter_id

        __props__['paused'] = paused

        __props__['priority'] = priority

        __props__['zone'] = zone

        __props__['zone_id'] = zone_id

        super(FirewallRule, __self__).__init__(
            'cloudflare:index/firewallRule:FirewallRule',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
