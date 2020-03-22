# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class GetWafPackagesResult:
    """
    A collection of values returned by getWafPackages.
    """
    def __init__(__self__, filter=None, id=None, packages=None, zone_id=None):
        if filter and not isinstance(filter, dict):
            raise TypeError("Expected argument 'filter' to be a dict")
        __self__.filter = filter
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
        if packages and not isinstance(packages, list):
            raise TypeError("Expected argument 'packages' to be a list")
        __self__.packages = packages
        if zone_id and not isinstance(zone_id, str):
            raise TypeError("Expected argument 'zone_id' to be a str")
        __self__.zone_id = zone_id
class AwaitableGetWafPackagesResult(GetWafPackagesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetWafPackagesResult(
            filter=self.filter,
            id=self.id,
            packages=self.packages,
            zone_id=self.zone_id)

def get_waf_packages(filter=None,zone_id=None,opts=None):
    """
    Use this data source to look up [WAF Rule Packages][1].

    > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/d/waf_packages.html.md.



    The **filter** object supports the following:

      * `action_mode` (`str`)
      * `detectionMode` (`str`)
      * `name` (`str`)
      * `sensitivity` (`str`)
    """
    __args__ = dict()


    __args__['filter'] = filter
    __args__['zoneId'] = zone_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('cloudflare:index/getWafPackages:getWafPackages', __args__, opts=opts).value

    return AwaitableGetWafPackagesResult(
        filter=__ret__.get('filter'),
        id=__ret__.get('id'),
        packages=__ret__.get('packages'),
        zone_id=__ret__.get('zoneId'))
