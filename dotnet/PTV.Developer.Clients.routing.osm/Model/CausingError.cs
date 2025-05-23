/*
 * Routing OSM
 *
 * With the Routing OSM service you can calculate routes from a list of waypoints based on open street map data.
 *
 * The version of the OpenAPI document: 1.6
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PTV.Developer.Clients.routing.osm.Client.OpenAPIDateConverter;

namespace PTV.Developer.Clients.routing.osm.Model
{
    /// <summary>
    /// CausingError
    /// </summary>
    [DataContract(Name = "CausingError")]
    public partial class CausingError : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CausingError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CausingError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CausingError" /> class.
        /// </summary>
        /// <param name="description">A human readable message that describes the error. (required).</param>
        /// <param name="errorCode">A constant string that can be used to identify this error class programmatically.  If additional information is available for an errorCode, it will be provided as key-value pairs with the parameter **details**. The keys available for a specific errorCode are documented directly with the errorCode. Unless stated otherwise, the values are of type string.  As an example, the following errorCode provides one key-value pair in the **details**. The key is called **value**. * &#x60;GENERAL_INVALID_VALUE&#x60; - A parameter is set to an invalid value.   * &#x60;value&#x60; - The invalid value.  Note that additional errorCodes as well as the **details** of existing errorCodes may be added at any time. Furthermore, the **description** may change at any time.  **Error codes for** &#x60;GENERAL_VALIDATION_ERROR&#x60;  * &#x60;GENERAL_UNRECOGNIZED_PARAMETER&#x60; - A parameter is unknown. * &#x60;GENERAL_MISSING_PARAMETER&#x60; - A required parameter is missing. * &#x60;GENERAL_TYPE_VIOLATED&#x60; - The value of a parameter has an invalid type.   * &#x60;type&#x60; - The type. * &#x60;GENERAL_FORMAT_VIOLATED&#x60; - The value of a parameter has an invalid format.   * &#x60;format&#x60; - The format. * &#x60;GENERAL_PATTERN_VIOLATED&#x60; - The value of a string parameter does not satisfy the required pattern.   * &#x60;pattern&#x60; - The pattern. * &#x60;GENERAL_MINIMUM_LENGTH_VIOLATED&#x60; - The minimum length of a string is violated.   * &#x60;minimumLength&#x60; - The minimum length (integer). * &#x60;GENERAL_MAXIMUM_LENGTH_VIOLATED&#x60; - The maximum length of a string is violated.   * &#x60;maximumLength&#x60; - The maximum length (integer). * &#x60;GENERAL_MINIMUM_ITEMS_VIOLATED&#x60; - The minimum number of items of an array is violated.   * &#x60;minimumItems&#x60; - The minimum number of items (integer). * &#x60;GENERAL_MAXIMUM_ITEMS_VIOLATED&#x60; - The maximum number of items of an array is violated.   * &#x60;maximumItems&#x60; - The maximum number of items (integer). * &#x60;GENERAL_MINIMUM_VALUE_VIOLATED&#x60; - The minimum value of a parameter is violated.   * &#x60;minimumValue&#x60; - The minimum value (integer or double). * &#x60;GENERAL_MAXIMUM_VALUE_VIOLATED&#x60; - The maximum value of a parameter is violated.   * &#x60;maximumValue&#x60; - The maximum value (integer or double). * &#x60;GENERAL_ENUM_VIOLATED&#x60; - The value of a parameter is not one of the specified enum values.   * &#x60;enum&#x60; - The allowed enum values. * &#x60;GENERAL_INVALID_VALUE&#x60; - A parameter is set to an invalid value.   * &#x60;value&#x60; - The invalid value. * &#x60;GENERAL_DUPLICATE_PARAMETER&#x60; - A parameter is duplicated. * &#x60;GENERAL_INVALID_LIST&#x60; - A list has an invalid format such as duplicate commas.   * &#x60;value&#x60; - The invalid list. * &#x60;ROUTING_INVALID_WAYPOINT_ATTRIBUTE&#x60; - A waypoint attribute is set to an invalid value.   * &#x60;attribute&#x60; - The invalid waypoint attribute. * &#x60;ROUTING_UNRECOGNIZED_WAYPOINT_ATTRIBUTE&#x60; - A waypoint attribute is unknown.   * &#x60;attribute&#x60; - The invalid waypoint key. * &#x60;ROUTING_DUPLICATE_WAYPOINT_ATTRIBUTE&#x60; - A waypoint attribute is duplicated.   * &#x60;attribute&#x60; - The duplicated waypoint key. * &#x60;ROUTING_MUST_HAVE_WAYPOINTS&#x60; - The request must have at least two waypoints. * &#x60;ROUTING_PROFILE_NOT_FOUND&#x60; - The requested profile could not be found.   * &#x60;value&#x60; - The profile name. * &#x60;ROUTING_ESTIMATED_DISTANCE_TOO_LONG&#x60; - The distance of the route (estimated by air-line) for non-motorized vehicles is too long. - _The **parameter** remains empty._   * &#x60;distance&#x60; - The estimated distance (integer).   * &#x60;limit&#x60; - The maximum allowable distance (integer). * &#x60;ROUTING_MAXIMUM_HORIZON_VALUE_VIOLATED&#x60; - The maximum value of horizon is violated.   * &#x60;limit&#x60; - The maximum allowable horizon (integer).  **Error codes for** &#x60;ROUTING_ERROR&#x60;  * &#x60;ROUTING_WAYPOINT_CANNOT_BE_MATCHED&#x60; - The waypoint cannot be matched to the nearest possible road. * &#x60;ROUTING_ROUTE_NOT_FOUND&#x60; - A route between at least two waypoints could not be found for the current configuration and profile. The **parameter** contains the waypoint where the problematic part that could not be routed starts, i.e., the problematic part of the route is between this waypoint and the next one. Note that only the first problematic part that was encountered is reported.  **Error codes for** &#x60;ROUTING_RESTRICTION_EXCEEDED&#x60;  * &#x60;ROUTING_TOO_MANY_WAYPOINTS&#x60; - The request contains too many waypoints.   * &#x60;limit&#x60;- The maximum allowed number of waypoints for a single request (integer).  **Error codes for** &#x60;GENERAL_RESOURCE_NOT_FOUND&#x60;  * &#x60;GENERAL_INVALID_ID&#x60; - No resource exists for the provided ID.   * &#x60;value&#x60; - The ID for which no resource exists. (required).</param>
        /// <param name="varParameter">The name of the affected query or path parameter or a JSONPath to the affected property of the request..</param>
        /// <param name="details">Additional properties specific to this error class..</param>
        public CausingError(string description = default(string), string errorCode = default(string), string varParameter = default(string), Dictionary<string, Object> details = default(Dictionary<string, Object>))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for CausingError and cannot be null");
            }
            this.Description = description;
            // to ensure "errorCode" is required (not null)
            if (errorCode == null)
            {
                throw new ArgumentNullException("errorCode is a required property for CausingError and cannot be null");
            }
            this.ErrorCode = errorCode;
            this.Parameter = varParameter;
            this.Details = details;
        }

        /// <summary>
        /// A human readable message that describes the error.
        /// </summary>
        /// <value>A human readable message that describes the error.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// A constant string that can be used to identify this error class programmatically.  If additional information is available for an errorCode, it will be provided as key-value pairs with the parameter **details**. The keys available for a specific errorCode are documented directly with the errorCode. Unless stated otherwise, the values are of type string.  As an example, the following errorCode provides one key-value pair in the **details**. The key is called **value**. * &#x60;GENERAL_INVALID_VALUE&#x60; - A parameter is set to an invalid value.   * &#x60;value&#x60; - The invalid value.  Note that additional errorCodes as well as the **details** of existing errorCodes may be added at any time. Furthermore, the **description** may change at any time.  **Error codes for** &#x60;GENERAL_VALIDATION_ERROR&#x60;  * &#x60;GENERAL_UNRECOGNIZED_PARAMETER&#x60; - A parameter is unknown. * &#x60;GENERAL_MISSING_PARAMETER&#x60; - A required parameter is missing. * &#x60;GENERAL_TYPE_VIOLATED&#x60; - The value of a parameter has an invalid type.   * &#x60;type&#x60; - The type. * &#x60;GENERAL_FORMAT_VIOLATED&#x60; - The value of a parameter has an invalid format.   * &#x60;format&#x60; - The format. * &#x60;GENERAL_PATTERN_VIOLATED&#x60; - The value of a string parameter does not satisfy the required pattern.   * &#x60;pattern&#x60; - The pattern. * &#x60;GENERAL_MINIMUM_LENGTH_VIOLATED&#x60; - The minimum length of a string is violated.   * &#x60;minimumLength&#x60; - The minimum length (integer). * &#x60;GENERAL_MAXIMUM_LENGTH_VIOLATED&#x60; - The maximum length of a string is violated.   * &#x60;maximumLength&#x60; - The maximum length (integer). * &#x60;GENERAL_MINIMUM_ITEMS_VIOLATED&#x60; - The minimum number of items of an array is violated.   * &#x60;minimumItems&#x60; - The minimum number of items (integer). * &#x60;GENERAL_MAXIMUM_ITEMS_VIOLATED&#x60; - The maximum number of items of an array is violated.   * &#x60;maximumItems&#x60; - The maximum number of items (integer). * &#x60;GENERAL_MINIMUM_VALUE_VIOLATED&#x60; - The minimum value of a parameter is violated.   * &#x60;minimumValue&#x60; - The minimum value (integer or double). * &#x60;GENERAL_MAXIMUM_VALUE_VIOLATED&#x60; - The maximum value of a parameter is violated.   * &#x60;maximumValue&#x60; - The maximum value (integer or double). * &#x60;GENERAL_ENUM_VIOLATED&#x60; - The value of a parameter is not one of the specified enum values.   * &#x60;enum&#x60; - The allowed enum values. * &#x60;GENERAL_INVALID_VALUE&#x60; - A parameter is set to an invalid value.   * &#x60;value&#x60; - The invalid value. * &#x60;GENERAL_DUPLICATE_PARAMETER&#x60; - A parameter is duplicated. * &#x60;GENERAL_INVALID_LIST&#x60; - A list has an invalid format such as duplicate commas.   * &#x60;value&#x60; - The invalid list. * &#x60;ROUTING_INVALID_WAYPOINT_ATTRIBUTE&#x60; - A waypoint attribute is set to an invalid value.   * &#x60;attribute&#x60; - The invalid waypoint attribute. * &#x60;ROUTING_UNRECOGNIZED_WAYPOINT_ATTRIBUTE&#x60; - A waypoint attribute is unknown.   * &#x60;attribute&#x60; - The invalid waypoint key. * &#x60;ROUTING_DUPLICATE_WAYPOINT_ATTRIBUTE&#x60; - A waypoint attribute is duplicated.   * &#x60;attribute&#x60; - The duplicated waypoint key. * &#x60;ROUTING_MUST_HAVE_WAYPOINTS&#x60; - The request must have at least two waypoints. * &#x60;ROUTING_PROFILE_NOT_FOUND&#x60; - The requested profile could not be found.   * &#x60;value&#x60; - The profile name. * &#x60;ROUTING_ESTIMATED_DISTANCE_TOO_LONG&#x60; - The distance of the route (estimated by air-line) for non-motorized vehicles is too long. - _The **parameter** remains empty._   * &#x60;distance&#x60; - The estimated distance (integer).   * &#x60;limit&#x60; - The maximum allowable distance (integer). * &#x60;ROUTING_MAXIMUM_HORIZON_VALUE_VIOLATED&#x60; - The maximum value of horizon is violated.   * &#x60;limit&#x60; - The maximum allowable horizon (integer).  **Error codes for** &#x60;ROUTING_ERROR&#x60;  * &#x60;ROUTING_WAYPOINT_CANNOT_BE_MATCHED&#x60; - The waypoint cannot be matched to the nearest possible road. * &#x60;ROUTING_ROUTE_NOT_FOUND&#x60; - A route between at least two waypoints could not be found for the current configuration and profile. The **parameter** contains the waypoint where the problematic part that could not be routed starts, i.e., the problematic part of the route is between this waypoint and the next one. Note that only the first problematic part that was encountered is reported.  **Error codes for** &#x60;ROUTING_RESTRICTION_EXCEEDED&#x60;  * &#x60;ROUTING_TOO_MANY_WAYPOINTS&#x60; - The request contains too many waypoints.   * &#x60;limit&#x60;- The maximum allowed number of waypoints for a single request (integer).  **Error codes for** &#x60;GENERAL_RESOURCE_NOT_FOUND&#x60;  * &#x60;GENERAL_INVALID_ID&#x60; - No resource exists for the provided ID.   * &#x60;value&#x60; - The ID for which no resource exists.
        /// </summary>
        /// <value>A constant string that can be used to identify this error class programmatically.  If additional information is available for an errorCode, it will be provided as key-value pairs with the parameter **details**. The keys available for a specific errorCode are documented directly with the errorCode. Unless stated otherwise, the values are of type string.  As an example, the following errorCode provides one key-value pair in the **details**. The key is called **value**. * &#x60;GENERAL_INVALID_VALUE&#x60; - A parameter is set to an invalid value.   * &#x60;value&#x60; - The invalid value.  Note that additional errorCodes as well as the **details** of existing errorCodes may be added at any time. Furthermore, the **description** may change at any time.  **Error codes for** &#x60;GENERAL_VALIDATION_ERROR&#x60;  * &#x60;GENERAL_UNRECOGNIZED_PARAMETER&#x60; - A parameter is unknown. * &#x60;GENERAL_MISSING_PARAMETER&#x60; - A required parameter is missing. * &#x60;GENERAL_TYPE_VIOLATED&#x60; - The value of a parameter has an invalid type.   * &#x60;type&#x60; - The type. * &#x60;GENERAL_FORMAT_VIOLATED&#x60; - The value of a parameter has an invalid format.   * &#x60;format&#x60; - The format. * &#x60;GENERAL_PATTERN_VIOLATED&#x60; - The value of a string parameter does not satisfy the required pattern.   * &#x60;pattern&#x60; - The pattern. * &#x60;GENERAL_MINIMUM_LENGTH_VIOLATED&#x60; - The minimum length of a string is violated.   * &#x60;minimumLength&#x60; - The minimum length (integer). * &#x60;GENERAL_MAXIMUM_LENGTH_VIOLATED&#x60; - The maximum length of a string is violated.   * &#x60;maximumLength&#x60; - The maximum length (integer). * &#x60;GENERAL_MINIMUM_ITEMS_VIOLATED&#x60; - The minimum number of items of an array is violated.   * &#x60;minimumItems&#x60; - The minimum number of items (integer). * &#x60;GENERAL_MAXIMUM_ITEMS_VIOLATED&#x60; - The maximum number of items of an array is violated.   * &#x60;maximumItems&#x60; - The maximum number of items (integer). * &#x60;GENERAL_MINIMUM_VALUE_VIOLATED&#x60; - The minimum value of a parameter is violated.   * &#x60;minimumValue&#x60; - The minimum value (integer or double). * &#x60;GENERAL_MAXIMUM_VALUE_VIOLATED&#x60; - The maximum value of a parameter is violated.   * &#x60;maximumValue&#x60; - The maximum value (integer or double). * &#x60;GENERAL_ENUM_VIOLATED&#x60; - The value of a parameter is not one of the specified enum values.   * &#x60;enum&#x60; - The allowed enum values. * &#x60;GENERAL_INVALID_VALUE&#x60; - A parameter is set to an invalid value.   * &#x60;value&#x60; - The invalid value. * &#x60;GENERAL_DUPLICATE_PARAMETER&#x60; - A parameter is duplicated. * &#x60;GENERAL_INVALID_LIST&#x60; - A list has an invalid format such as duplicate commas.   * &#x60;value&#x60; - The invalid list. * &#x60;ROUTING_INVALID_WAYPOINT_ATTRIBUTE&#x60; - A waypoint attribute is set to an invalid value.   * &#x60;attribute&#x60; - The invalid waypoint attribute. * &#x60;ROUTING_UNRECOGNIZED_WAYPOINT_ATTRIBUTE&#x60; - A waypoint attribute is unknown.   * &#x60;attribute&#x60; - The invalid waypoint key. * &#x60;ROUTING_DUPLICATE_WAYPOINT_ATTRIBUTE&#x60; - A waypoint attribute is duplicated.   * &#x60;attribute&#x60; - The duplicated waypoint key. * &#x60;ROUTING_MUST_HAVE_WAYPOINTS&#x60; - The request must have at least two waypoints. * &#x60;ROUTING_PROFILE_NOT_FOUND&#x60; - The requested profile could not be found.   * &#x60;value&#x60; - The profile name. * &#x60;ROUTING_ESTIMATED_DISTANCE_TOO_LONG&#x60; - The distance of the route (estimated by air-line) for non-motorized vehicles is too long. - _The **parameter** remains empty._   * &#x60;distance&#x60; - The estimated distance (integer).   * &#x60;limit&#x60; - The maximum allowable distance (integer). * &#x60;ROUTING_MAXIMUM_HORIZON_VALUE_VIOLATED&#x60; - The maximum value of horizon is violated.   * &#x60;limit&#x60; - The maximum allowable horizon (integer).  **Error codes for** &#x60;ROUTING_ERROR&#x60;  * &#x60;ROUTING_WAYPOINT_CANNOT_BE_MATCHED&#x60; - The waypoint cannot be matched to the nearest possible road. * &#x60;ROUTING_ROUTE_NOT_FOUND&#x60; - A route between at least two waypoints could not be found for the current configuration and profile. The **parameter** contains the waypoint where the problematic part that could not be routed starts, i.e., the problematic part of the route is between this waypoint and the next one. Note that only the first problematic part that was encountered is reported.  **Error codes for** &#x60;ROUTING_RESTRICTION_EXCEEDED&#x60;  * &#x60;ROUTING_TOO_MANY_WAYPOINTS&#x60; - The request contains too many waypoints.   * &#x60;limit&#x60;- The maximum allowed number of waypoints for a single request (integer).  **Error codes for** &#x60;GENERAL_RESOURCE_NOT_FOUND&#x60;  * &#x60;GENERAL_INVALID_ID&#x60; - No resource exists for the provided ID.   * &#x60;value&#x60; - The ID for which no resource exists.</value>
        [DataMember(Name = "errorCode", IsRequired = true, EmitDefaultValue = true)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The name of the affected query or path parameter or a JSONPath to the affected property of the request.
        /// </summary>
        /// <value>The name of the affected query or path parameter or a JSONPath to the affected property of the request.</value>
        [DataMember(Name = "parameter", EmitDefaultValue = true)]
        public string Parameter { get; set; }

        /// <summary>
        /// Additional properties specific to this error class.
        /// </summary>
        /// <value>Additional properties specific to this error class.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public Dictionary<string, Object> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CausingError {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
