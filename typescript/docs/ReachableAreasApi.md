# ReachableAreasApi

All URIs are relative to *https://api.myptv.com/routing-osm/v1*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**calculateReachableAreas**](ReachableAreasApi.md#calculatereachableareas) | **GET** /reachable-areas |  |
| [**deleteReachableAreas**](ReachableAreasApi.md#deletereachableareas) | **DELETE** /reachable-areas/{id} |  |
| [**getReachableAreas**](ReachableAreasApi.md#getreachableareas) | **GET** /reachable-areas/{id} |  |
| [**startAndCreateReachableAreas**](ReachableAreasApi.md#startandcreatereachableareas) | **POST** /reachable-areas |  |



## calculateReachableAreas

> ReachableAreas calculateReachableAreas(waypoint, horizons, profile, horizonType, options)



Calculates the areas which can be reached from a waypoint, within given horizons (limited to 25 km or 20 minutes). Use the asynchronous POST and GET requests for larger horizons.

### Example

```ts
import {
  Configuration,
  ReachableAreasApi,
} from '';
import type { CalculateReachableAreasRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new ReachableAreasApi(config);

  const body = {
    // string | The start or destination waypoint. The format of the waypoint is `<lat>,<lon>[;<attribute>;<attribute>;...]` representing a point with the latitude value in degrees from south to north and the longitude value in degrees (WGS84/EPSG:4326) from west to east. This point will be matched to the nearest possible road. By default the air-line connection between given and matched coordinates is not included in the distance or duration. We will refer to this type of waypoint as an _on-road waypoint_.  The behavior of a waypoint can be changed by appending the following attributes:   * `includeLastMeters` to include the air-line connection between given and matched coordinates in the distance or duration.   We will refer to this type of waypoint as an _off-road waypoint_.   * `roadAccess=<lat>,<lon>`, to use these coordinates for matching to the nearest road. Implies **includeLastMeters**, i.e.   the air-line connection between the waypoint coordinates and the matched coordinates   is included in the distance or duration. This is useful if the waypoint should not be matched to the nearest possible road but to some road further away,   e.g. garage exit at a different road.  See [here](./concepts/waypoints) for more information.
    waypoint: waypoint_example,
    // Array<number> | The distances [m] or travel times [s] of the horizons, depending on the **horizonType**. Limited to 5 horizons.
    horizons: ...,
    // string | A profile defines a vehicle by a set of attributes, matching typical transport situations. It must be the name of one of the [predefined profiles](../data-api/concepts/osm-profiles) such as _EUR_OSM_CAR_. (optional)
    profile: profile_example,
    // HorizonType (optional)
    horizonType: ...,
    // ReachableOptions | Routing-relevant options like driving direction or the use of additional data. Use array notation like `options[drivingDirection]=OUTBOUND` to set options. (optional)
    options: ...,
  } satisfies CalculateReachableAreasRequest;

  try {
    const data = await api.calculateReachableAreas(body);
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
| **waypoint** | `string` | The start or destination waypoint. The format of the waypoint is &#x60;&lt;lat&gt;,&lt;lon&gt;[;&lt;attribute&gt;;&lt;attribute&gt;;...]&#x60; representing a point with the latitude value in degrees from south to north and the longitude value in degrees (WGS84/EPSG:4326) from west to east. This point will be matched to the nearest possible road. By default the air-line connection between given and matched coordinates is not included in the distance or duration. We will refer to this type of waypoint as an _on-road waypoint_.  The behavior of a waypoint can be changed by appending the following attributes:   * &#x60;includeLastMeters&#x60; to include the air-line connection between given and matched coordinates in the distance or duration.   We will refer to this type of waypoint as an _off-road waypoint_.   * &#x60;roadAccess&#x3D;&lt;lat&gt;,&lt;lon&gt;&#x60;, to use these coordinates for matching to the nearest road. Implies **includeLastMeters**, i.e.   the air-line connection between the waypoint coordinates and the matched coordinates   is included in the distance or duration. This is useful if the waypoint should not be matched to the nearest possible road but to some road further away,   e.g. garage exit at a different road.  See [here](./concepts/waypoints) for more information. | [Defaults to `undefined`] |
| **horizons** | `Array<number>` | The distances [m] or travel times [s] of the horizons, depending on the **horizonType**. Limited to 5 horizons. | |
| **profile** | `string` | A profile defines a vehicle by a set of attributes, matching typical transport situations. It must be the name of one of the [predefined profiles](../data-api/concepts/osm-profiles) such as _EUR_OSM_CAR_. | [Optional] [Defaults to `&#39;EUR_OSM_CAR&#39;`] |
| **horizonType** | `HorizonType` |  | [Optional] [Defaults to `undefined`] [Enum: DISTANCE, TRAVEL_TIME] |
| **options** | [](.md) | Routing-relevant options like driving direction or the use of additional data. Use array notation like &#x60;options[drivingDirection]&#x3D;OUTBOUND&#x60; to set options. | [Optional] [Defaults to `undefined`] |

### Return type

[**ReachableAreas**](ReachableAreas.md)

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


## deleteReachableAreas

> deleteReachableAreas(id)



Cancels a reachable areas calculation and deletes the calculated results specified by its ID. Results already calculated cannot be requested by its ID, anymore.

### Example

```ts
import {
  Configuration,
  ReachableAreasApi,
} from '';
import type { DeleteReachableAreasRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new ReachableAreasApi(config);

  const body = {
    // string | The ID of a reachable areas calculation.
    id: 38400000-8cf0-11bd-b23e-10b96e4ef00d,
  } satisfies DeleteReachableAreasRequest;

  try {
    const data = await api.deleteReachableAreas(body);
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
| **id** | `string` | The ID of a reachable areas calculation. | [Defaults to `undefined`] |

### Return type

`void` (Empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


## getReachableAreas

> ReachableAreasResponse getReachableAreas(id, maximumPollingPeriod)



Gets the results of a reachable areas calculation specified by its ID.

### Example

```ts
import {
  Configuration,
  ReachableAreasApi,
} from '';
import type { GetReachableAreasRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new ReachableAreasApi(config);

  const body = {
    // string | The ID of a reachable areas calculation.
    id: 38400000-8cf0-11bd-b23e-10b96e4ef00d,
    // number | If the calculation is still running, this operation will be blocked and will not return before this period [ms] expires. If the calculation is completed, it will return immediately.  The default of 0 ms will cause the operation to return immediately in any case. Use a value > 0 to implement long polling to reduce the number of requests. See the [tutorial](https://developer.myptv.com/en/resources/tutorials/general/how-use-asynchronous-requests-ptv-developer-apis) on asynchronous requests for details.  (optional)
    maximumPollingPeriod: 56,
  } satisfies GetReachableAreasRequest;

  try {
    const data = await api.getReachableAreas(body);
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
| **id** | `string` | The ID of a reachable areas calculation. | [Defaults to `undefined`] |
| **maximumPollingPeriod** | `number` | If the calculation is still running, this operation will be blocked and will not return before this period [ms] expires. If the calculation is completed, it will return immediately.  The default of 0 ms will cause the operation to return immediately in any case. Use a value &gt; 0 to implement long polling to reduce the number of requests. See the [tutorial](https://developer.myptv.com/en/resources/tutorials/general/how-use-asynchronous-requests-ptv-developer-apis) on asynchronous requests for details.  | [Optional] [Defaults to `0`] |

### Return type

[**ReachableAreasResponse**](ReachableAreasResponse.md)

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


## startAndCreateReachableAreas

> ReachableAreasId startAndCreateReachableAreas(waypoint, horizons, profile, horizonType, options)



Starts and creates the areas which can be reached from a waypoint, within given horizons. This type of request is recommended when the &#x60;horizons&#x60; parameter is more than 20 minutes or 25 km.

### Example

```ts
import {
  Configuration,
  ReachableAreasApi,
} from '';
import type { StartAndCreateReachableAreasRequest } from '';

async function example() {
  console.log("🚀 Testing  SDK...");
  const config = new Configuration({ 
    // To configure API key authorization: apiKeyAuth
    apiKey: "YOUR API KEY",
  });
  const api = new ReachableAreasApi(config);

  const body = {
    // string | The start or destination waypoint. The format of the waypoint is `<lat>,<lon>[;<attribute>;<attribute>;...]` representing a point with the latitude value in degrees from south to north and the longitude value in degrees (WGS84/EPSG:4326) from west to east. This point will be matched to the nearest possible road. By default the air-line connection between given and matched coordinates is not included in the distance or duration. We will refer to this type of waypoint as an _on-road waypoint_.  The behavior of a waypoint can be changed by appending the following attributes:   * `includeLastMeters` to include the air-line connection between given and matched coordinates in the distance or duration.   We will refer to this type of waypoint as an _off-road waypoint_.   * `roadAccess=<lat>,<lon>`, to use these coordinates for matching to the nearest road. Implies **includeLastMeters**, i.e.   the air-line connection between the waypoint coordinates and the matched coordinates   is included in the distance or duration. This is useful if the waypoint should not be matched to the nearest possible road but to some road further away,   e.g. garage exit at a different road.  See [here](./concepts/waypoints) for more information.
    waypoint: waypoint_example,
    // Array<number> | The distances [m] or travel times [s] of the horizons, depending on the **horizonType**. Limited to 5 horizons.
    horizons: ...,
    // string | A profile defines a vehicle by a set of attributes, matching typical transport situations. It must be the name of one of the [predefined profiles](../data-api/concepts/osm-profiles) such as _EUR_OSM_CAR_. (optional)
    profile: profile_example,
    // HorizonType (optional)
    horizonType: ...,
    // ReachableOptions | Routing-relevant options like driving direction or the use of additional data. Use array notation like `options[drivingDirection]=OUTBOUND` to set options. (optional)
    options: ...,
  } satisfies StartAndCreateReachableAreasRequest;

  try {
    const data = await api.startAndCreateReachableAreas(body);
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
| **waypoint** | `string` | The start or destination waypoint. The format of the waypoint is &#x60;&lt;lat&gt;,&lt;lon&gt;[;&lt;attribute&gt;;&lt;attribute&gt;;...]&#x60; representing a point with the latitude value in degrees from south to north and the longitude value in degrees (WGS84/EPSG:4326) from west to east. This point will be matched to the nearest possible road. By default the air-line connection between given and matched coordinates is not included in the distance or duration. We will refer to this type of waypoint as an _on-road waypoint_.  The behavior of a waypoint can be changed by appending the following attributes:   * &#x60;includeLastMeters&#x60; to include the air-line connection between given and matched coordinates in the distance or duration.   We will refer to this type of waypoint as an _off-road waypoint_.   * &#x60;roadAccess&#x3D;&lt;lat&gt;,&lt;lon&gt;&#x60;, to use these coordinates for matching to the nearest road. Implies **includeLastMeters**, i.e.   the air-line connection between the waypoint coordinates and the matched coordinates   is included in the distance or duration. This is useful if the waypoint should not be matched to the nearest possible road but to some road further away,   e.g. garage exit at a different road.  See [here](./concepts/waypoints) for more information. | [Defaults to `undefined`] |
| **horizons** | `Array<number>` | The distances [m] or travel times [s] of the horizons, depending on the **horizonType**. Limited to 5 horizons. | |
| **profile** | `string` | A profile defines a vehicle by a set of attributes, matching typical transport situations. It must be the name of one of the [predefined profiles](../data-api/concepts/osm-profiles) such as _EUR_OSM_CAR_. | [Optional] [Defaults to `&#39;EUR_OSM_CAR&#39;`] |
| **horizonType** | `HorizonType` |  | [Optional] [Defaults to `undefined`] [Enum: DISTANCE, TRAVEL_TIME] |
| **options** | [](.md) | Routing-relevant options like driving direction or the use of additional data. Use array notation like &#x60;options[drivingDirection]&#x3D;OUTBOUND&#x60; to set options. | [Optional] [Defaults to `undefined`] |

### Return type

[**ReachableAreasId**](ReachableAreasId.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Response on success. |  -  |
| **0** | Response on failure. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)

