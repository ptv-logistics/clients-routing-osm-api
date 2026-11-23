# RoutingApi

All URIs are relative to *https://api.myptv.com/routing-osm/v1*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**calculateRoute**](RoutingApi.md#calculateroute) | **GET** /routes |  |



## calculateRoute

> RouteResponse calculateRoute(waypoints, profile, options, results)



Calculates a route by specifying a list of waypoints.

### Example

```ts
import {
  Configuration,
  RoutingApi,
} from '';
import type { CalculateRouteRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new RoutingApi(config);

  const body = {
    // Array<string> | The list of waypoints the route will be calculated for. At least two waypoints are necessary. The first waypoint is the start and the last is the destination of the route. Additional intermediate waypoints are possible.   The format of each waypoint is `<lat>,<lon>[;<attribute>;<attribute>;...]` representing a point with the latitude value in degrees from south to north and the longitude value in degrees (WGS84/EPSG:4326) from west to east. This point will be matched to the nearest possible road.   By default the air-line connection between given and matched coordinates is not included in the route polyline, distance and duration. We will refer to this type of waypoint as an _on-road waypoint_.  The behavior of a waypoint can be changed by appending the following attributes:    * `includeLastMeters` to include the air-line connection between given and matched coordinates in the route polyline, distance and duration.  We will refer to this type of waypoint as an _off-road waypoint_.  * `roadAccess=<lat>,<lon>`, to use these coordinates for matching to the nearest road. Implies **includeLastMeter**, i.e.  the air-line connection between the waypoint coordinates and the matched coordinates  is included in the route polyline, distance and duration. This is useful if the waypoint should not be matched to the nearest possible road but to some road further away,  e.g. garage exit at a different road.
    waypoints: ["49.01318,8.4279;","49.01835,8.36881;includeLastMeters"],
    // string | A profile defines a vehicle by a set of attributes, matching typical transport situations. It must be the name of one of the [predefined profiles](../data-api/concepts/osm-profiles) such as _EUR_OSM_CAR_. (optional)
    profile: profile_example,
    // Options | Routing-relevant options like the polyline format. Use array notation like `options[polylineFormat]=GEO_JSON` to set options. (optional)
    options: ...,
    // Array<Results> | Comma-separated list that defines which results will be returned.  * `LEGS`     Response includes information about the route **legs** defined as the parts of the route between two consecutive waypoints.  * `LEGS_POLYLINE`     Response includes the **polyline** of each of the **legs** in the format specified by **options[polylineFormat]**. _LEGS_ will automatically be included.  * `POLYLINE`     Response includes the complete **polyline** of the entire route in the format specified by **options[polylineFormat]**. (optional)
    results: ["POLYLINE"],
  } satisfies CalculateRouteRequest;

  try {
    const data = await api.calculateRoute(body);
    console.log(data);
  } catch (error) {
    console.error(error);
  }
}

// Run the test
example().catch(console.error);
```

### Parameters


| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **waypoints** | `Array<string>` | The list of waypoints the route will be calculated for. At least two waypoints are necessary. The first waypoint is the start and the last is the destination of the route. Additional intermediate waypoints are possible.   The format of each waypoint is &#x60;&lt;lat&gt;,&lt;lon&gt;[;&lt;attribute&gt;;&lt;attribute&gt;;...]&#x60; representing a point with the latitude value in degrees from south to north and the longitude value in degrees (WGS84/EPSG:4326) from west to east. This point will be matched to the nearest possible road.   By default the air-line connection between given and matched coordinates is not included in the route polyline, distance and duration. We will refer to this type of waypoint as an _on-road waypoint_.  The behavior of a waypoint can be changed by appending the following attributes:    * &#x60;includeLastMeters&#x60; to include the air-line connection between given and matched coordinates in the route polyline, distance and duration.  We will refer to this type of waypoint as an _off-road waypoint_.  * &#x60;roadAccess&#x3D;&lt;lat&gt;,&lt;lon&gt;&#x60;, to use these coordinates for matching to the nearest road. Implies **includeLastMeter**, i.e.  the air-line connection between the waypoint coordinates and the matched coordinates  is included in the route polyline, distance and duration. This is useful if the waypoint should not be matched to the nearest possible road but to some road further away,  e.g. garage exit at a different road. | |
| **profile** | `string` | A profile defines a vehicle by a set of attributes, matching typical transport situations. It must be the name of one of the [predefined profiles](../data-api/concepts/osm-profiles) such as _EUR_OSM_CAR_. | [Optional] [Defaults to `&#39;EUR_OSM_CAR&#39;`] |
| **options** | [](.md) | Routing-relevant options like the polyline format. Use array notation like &#x60;options[polylineFormat]&#x3D;GEO_JSON&#x60; to set options. | [Optional] [Defaults to `undefined`] |
| **results** | `Array<Results>` | Comma-separated list that defines which results will be returned.  * &#x60;LEGS&#x60;     Response includes information about the route **legs** defined as the parts of the route between two consecutive waypoints.  * &#x60;LEGS_POLYLINE&#x60;     Response includes the **polyline** of each of the **legs** in the format specified by **options[polylineFormat]**. _LEGS_ will automatically be included.  * &#x60;POLYLINE&#x60;     Response includes the complete **polyline** of the entire route in the format specified by **options[polylineFormat]**. | [Optional] |

### Return type

[**RouteResponse**](RouteResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)

