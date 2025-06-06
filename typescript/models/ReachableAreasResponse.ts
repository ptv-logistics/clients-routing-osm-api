/* tslint:disable */
/* eslint-disable */
/**
 * Routing OSM
 * With the Routing OSM service you can calculate routes from a list of waypoints based on open street map data.
 *
 * The version of the OpenAPI document: 1.6
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { CalculationStatus } from './CalculationStatus';
import {
    CalculationStatusFromJSON,
    CalculationStatusFromJSONTyped,
    CalculationStatusToJSON,
} from './CalculationStatus';
import type { ReachableAreas } from './ReachableAreas';
import {
    ReachableAreasFromJSON,
    ReachableAreasFromJSONTyped,
    ReachableAreasToJSON,
} from './ReachableAreas';
import type { ErrorResponse } from './ErrorResponse';
import {
    ErrorResponseFromJSON,
    ErrorResponseFromJSONTyped,
    ErrorResponseToJSON,
} from './ErrorResponse';

/**
 * 
 * @export
 * @interface ReachableAreasResponse
 */
export interface ReachableAreasResponse {
    /**
     * 
     * @type {CalculationStatus}
     * @memberof ReachableAreasResponse
     */
    status?: CalculationStatus;
    /**
     * 
     * @type {ReachableAreas}
     * @memberof ReachableAreasResponse
     */
    reachableAreas?: ReachableAreas;
    /**
     * 
     * @type {ErrorResponse}
     * @memberof ReachableAreasResponse
     */
    error?: ErrorResponse;
}



/**
 * Check if a given object implements the ReachableAreasResponse interface.
 */
export function instanceOfReachableAreasResponse(value: object): value is ReachableAreasResponse {
    return true;
}

export function ReachableAreasResponseFromJSON(json: any): ReachableAreasResponse {
    return ReachableAreasResponseFromJSONTyped(json, false);
}

export function ReachableAreasResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): ReachableAreasResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'status': json['status'] == null ? undefined : CalculationStatusFromJSON(json['status']),
        'reachableAreas': json['reachableAreas'] == null ? undefined : ReachableAreasFromJSON(json['reachableAreas']),
        'error': json['error'] == null ? undefined : ErrorResponseFromJSON(json['error']),
    };
}

export function ReachableAreasResponseToJSON(value?: ReachableAreasResponse | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'status': CalculationStatusToJSON(value['status']),
        'reachableAreas': ReachableAreasToJSON(value['reachableAreas']),
        'error': ErrorResponseToJSON(value['error']),
    };
}

