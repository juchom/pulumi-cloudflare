# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class AccessPolicy(pulumi.CustomResource):
    application_id: pulumi.Output[str]
    """
    The ID of the application the policy is
    associated with.
    """
    decision: pulumi.Output[str]
    """
    Defines the action Access will take if the policy matches the user.
    Allowed values: `allow`, `deny`, `bypass`
    """
    excludes: pulumi.Output[list]
    """
    A series of access conditions, see below for
    full list.
    
      * `emails` (`list`)
      * `emailDomains` (`list`)
      * `everyone` (`bool`)
      * `ips` (`list`)
    """
    includes: pulumi.Output[list]
    """
    A series of access conditions, see below for
    full list.
    
      * `emails` (`list`)
      * `emailDomains` (`list`)
      * `everyone` (`bool`)
      * `ips` (`list`)
    """
    name: pulumi.Output[str]
    """
    Friendly name of the Access Application.
    """
    precedence: pulumi.Output[float]
    """
    The unique precedence for policies on a single application. Integer.
    """
    requires: pulumi.Output[list]
    """
    A series of access conditions, see below for
    full list.
    
      * `emails` (`list`)
      * `emailDomains` (`list`)
      * `everyone` (`bool`)
      * `ips` (`list`)
    """
    zone_id: pulumi.Output[str]
    """
    The DNS zone to which the access rule should be
    added.
    """
    def __init__(__self__, resource_name, opts=None, application_id=None, decision=None, excludes=None, includes=None, name=None, precedence=None, requires=None, zone_id=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Cloudflare Access Policy resource. Access Policies are used
        in conjunction with Access Applications to restrict access to a
        particular resource.
        
        ## Conditions
        
        `require`, `exclude` and `include` arguments share the available
        conditions which can be applied. The conditions are:
        
        * `ip` - (Optional) A list of IP addresses or ranges. Example:
          `ip = ["1.2.3.4", "10.0.0.0/2"]`
        * `email` - (Optional) A list of email addresses. Example:
          `email = ["test@example.com"]`
        * `email_domain` - (Optional) A list of email domains. Example:
          `email_domain = ["example.com"]`
        * `everyone` - (Optional) Boolean indicating permitting access for all
          requests. Example: `everyone = true`
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] application_id: The ID of the application the policy is
               associated with.
        :param pulumi.Input[str] decision: Defines the action Access will take if the policy matches the user.
               Allowed values: `allow`, `deny`, `bypass`
        :param pulumi.Input[list] excludes: A series of access conditions, see below for
               full list.
        :param pulumi.Input[list] includes: A series of access conditions, see below for
               full list.
        :param pulumi.Input[str] name: Friendly name of the Access Application.
        :param pulumi.Input[float] precedence: The unique precedence for policies on a single application. Integer.
        :param pulumi.Input[list] requires: A series of access conditions, see below for
               full list.
        :param pulumi.Input[str] zone_id: The DNS zone to which the access rule should be
               added.
        
        The **excludes** object supports the following:
        
          * `emails` (`pulumi.Input[list]`)
          * `emailDomains` (`pulumi.Input[list]`)
          * `everyone` (`pulumi.Input[bool]`)
          * `ips` (`pulumi.Input[list]`)
        
        The **includes** object supports the following:
        
          * `emails` (`pulumi.Input[list]`)
          * `emailDomains` (`pulumi.Input[list]`)
          * `everyone` (`pulumi.Input[bool]`)
          * `ips` (`pulumi.Input[list]`)
        
        The **requires** object supports the following:
        
          * `emails` (`pulumi.Input[list]`)
          * `emailDomains` (`pulumi.Input[list]`)
          * `everyone` (`pulumi.Input[bool]`)
          * `ips` (`pulumi.Input[list]`)

        > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/access_policy.html.markdown.
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

            if application_id is None:
                raise TypeError("Missing required property 'application_id'")
            __props__['application_id'] = application_id
            if decision is None:
                raise TypeError("Missing required property 'decision'")
            __props__['decision'] = decision
            __props__['excludes'] = excludes
            if includes is None:
                raise TypeError("Missing required property 'includes'")
            __props__['includes'] = includes
            if name is None:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['precedence'] = precedence
            __props__['requires'] = requires
            if zone_id is None:
                raise TypeError("Missing required property 'zone_id'")
            __props__['zone_id'] = zone_id
        super(AccessPolicy, __self__).__init__(
            'cloudflare:index/accessPolicy:AccessPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, application_id=None, decision=None, excludes=None, includes=None, name=None, precedence=None, requires=None, zone_id=None):
        """
        Get an existing AccessPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] application_id: The ID of the application the policy is
               associated with.
        :param pulumi.Input[str] decision: Defines the action Access will take if the policy matches the user.
               Allowed values: `allow`, `deny`, `bypass`
        :param pulumi.Input[list] excludes: A series of access conditions, see below for
               full list.
        :param pulumi.Input[list] includes: A series of access conditions, see below for
               full list.
        :param pulumi.Input[str] name: Friendly name of the Access Application.
        :param pulumi.Input[float] precedence: The unique precedence for policies on a single application. Integer.
        :param pulumi.Input[list] requires: A series of access conditions, see below for
               full list.
        :param pulumi.Input[str] zone_id: The DNS zone to which the access rule should be
               added.
        
        The **excludes** object supports the following:
        
          * `emails` (`pulumi.Input[list]`)
          * `emailDomains` (`pulumi.Input[list]`)
          * `everyone` (`pulumi.Input[bool]`)
          * `ips` (`pulumi.Input[list]`)
        
        The **includes** object supports the following:
        
          * `emails` (`pulumi.Input[list]`)
          * `emailDomains` (`pulumi.Input[list]`)
          * `everyone` (`pulumi.Input[bool]`)
          * `ips` (`pulumi.Input[list]`)
        
        The **requires** object supports the following:
        
          * `emails` (`pulumi.Input[list]`)
          * `emailDomains` (`pulumi.Input[list]`)
          * `everyone` (`pulumi.Input[bool]`)
          * `ips` (`pulumi.Input[list]`)

        > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/r/access_policy.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["application_id"] = application_id
        __props__["decision"] = decision
        __props__["excludes"] = excludes
        __props__["includes"] = includes
        __props__["name"] = name
        __props__["precedence"] = precedence
        __props__["requires"] = requires
        __props__["zone_id"] = zone_id
        return AccessPolicy(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

