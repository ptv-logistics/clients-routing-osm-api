
# RouteResponse


## Properties

Name | Type
------------ | -------------
`distance` | number
`travelTime` | number
`legs` | [Array&lt;Leg&gt;](Leg.md)
`polyline` | string

## Example

```typescript
import type { RouteResponse } from ''

// TODO: Update the object below with actual values
const example = {
  "distance": 1422,
  "travelTime": 56,
  "legs": null,
  "polyline": null,
} satisfies RouteResponse

console.log(example)

// Convert the instance to a JSON string
const exampleJSON: string = JSON.stringify(example)
console.log(exampleJSON)

// Parse the JSON string back to an object
const exampleParsed = JSON.parse(exampleJSON) as RouteResponse
console.log(exampleParsed)
```

[[Back to top]](#) [[Back to API list]](../README.md#api-endpoints) [[Back to Model list]](../README.md#models) [[Back to README]](../README.md)


