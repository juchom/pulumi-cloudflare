# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class GetZonesResult:
    """
    A collection of values returned by getZones.
    """
    def __init__(__self__, filter=None, id=None, zones=None):
        if filter and not isinstance(filter, dict):
            raise TypeError("Expected argument 'filter' to be a dict")
        __self__.filter = filter
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
        if zones and not isinstance(zones, list):
            raise TypeError("Expected argument 'zones' to be a list")
        __self__.zones = zones
class AwaitableGetZonesResult(GetZonesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetZonesResult(
            filter=self.filter,
            id=self.id,
            zones=self.zones)

def get_zones(filter=None,opts=None):
    """
    Use this data source to look up [Zone][1] records.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-cloudflare/blob/master/website/docs/d/zones.html.md.



    The **filter** object supports the following:

      * `name` (`str`)
      * `paused` (`bool`)
      * `status` (`str`)
    """
    __args__ = dict()


    __args__['filter'] = filter
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('cloudflare:index/getZones:getZones', __args__, opts=opts).value

    return AwaitableGetZonesResult(
        filter=__ret__.get('filter'),
        id=__ret__.get('id'),
        zones=__ret__.get('zones'))
