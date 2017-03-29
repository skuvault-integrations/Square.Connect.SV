/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Square.Connect.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IV1LocationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Provides details for a business&#39;s locations, including their IDs.
        /// </summary>
        /// <remarks>
        /// Provides details for a business&#39;s locations, including their IDs.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;V1Merchant&gt;</returns>
        List<V1Merchant> ListLocations ();

        /// <summary>
        /// Provides details for a business&#39;s locations, including their IDs.
        /// </summary>
        /// <remarks>
        /// Provides details for a business&#39;s locations, including their IDs.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;V1Merchant&gt;</returns>
        ApiResponse<List<V1Merchant>> ListLocationsWithHttpInfo ();
        /// <summary>
        /// Get a business&#39;s information.
        /// </summary>
        /// <remarks>
        /// Get a business&#39;s information.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>V1Merchant</returns>
        V1Merchant RetrieveBusiness ();

        /// <summary>
        /// Get a business&#39;s information.
        /// </summary>
        /// <remarks>
        /// Get a business&#39;s information.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of V1Merchant</returns>
        ApiResponse<V1Merchant> RetrieveBusinessWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Provides details for a business&#39;s locations, including their IDs.
        /// </summary>
        /// <remarks>
        /// Provides details for a business&#39;s locations, including their IDs.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;V1Merchant&gt;</returns>
        System.Threading.Tasks.Task<List<V1Merchant>> ListLocationsAsync ();

        /// <summary>
        /// Provides details for a business&#39;s locations, including their IDs.
        /// </summary>
        /// <remarks>
        /// Provides details for a business&#39;s locations, including their IDs.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;V1Merchant&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<V1Merchant>>> ListLocationsAsyncWithHttpInfo ();
        /// <summary>
        /// Get a business&#39;s information.
        /// </summary>
        /// <remarks>
        /// Get a business&#39;s information.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of V1Merchant</returns>
        System.Threading.Tasks.Task<V1Merchant> RetrieveBusinessAsync ();

        /// <summary>
        /// Get a business&#39;s information.
        /// </summary>
        /// <remarks>
        /// Get a business&#39;s information.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (V1Merchant)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1Merchant>> RetrieveBusinessAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class V1LocationApi : IV1LocationApi
    {
        private Square.Connect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public V1LocationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Square.Connect.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LocationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public V1LocationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Square.Connect.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Square.Connect.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Provides details for a business&#39;s locations, including their IDs. Provides details for a business&#39;s locations, including their IDs.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;V1Merchant&gt;</returns>
        public List<V1Merchant> ListLocations ()
        {
             ApiResponse<List<V1Merchant>> localVarResponse = ListLocationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Provides details for a business&#39;s locations, including their IDs. Provides details for a business&#39;s locations, including their IDs.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;V1Merchant&gt;</returns>
        public ApiResponse< List<V1Merchant> > ListLocationsWithHttpInfo ()
        {

            var localVarPath = "/v1/me/locations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<V1Merchant>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<V1Merchant>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<V1Merchant>)));
            
        }

        /// <summary>
        /// Provides details for a business&#39;s locations, including their IDs. Provides details for a business&#39;s locations, including their IDs.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;V1Merchant&gt;</returns>
        public async System.Threading.Tasks.Task<List<V1Merchant>> ListLocationsAsync ()
        {
             ApiResponse<List<V1Merchant>> localVarResponse = await ListLocationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Provides details for a business&#39;s locations, including their IDs. Provides details for a business&#39;s locations, including their IDs.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;V1Merchant&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<V1Merchant>>> ListLocationsAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/me/locations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListLocations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<V1Merchant>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<V1Merchant>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<V1Merchant>)));
            
        }

        /// <summary>
        /// Get a business&#39;s information. Get a business&#39;s information.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>V1Merchant</returns>
        public V1Merchant RetrieveBusiness ()
        {
             ApiResponse<V1Merchant> localVarResponse = RetrieveBusinessWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a business&#39;s information. Get a business&#39;s information.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of V1Merchant</returns>
        public ApiResponse< V1Merchant > RetrieveBusinessWithHttpInfo ()
        {

            var localVarPath = "/v1/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetrieveBusiness", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<V1Merchant>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Merchant) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Merchant)));
            
        }

        /// <summary>
        /// Get a business&#39;s information. Get a business&#39;s information.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of V1Merchant</returns>
        public async System.Threading.Tasks.Task<V1Merchant> RetrieveBusinessAsync ()
        {
             ApiResponse<V1Merchant> localVarResponse = await RetrieveBusinessAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a business&#39;s information. Get a business&#39;s information.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (V1Merchant)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1Merchant>> RetrieveBusinessAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetrieveBusiness", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<V1Merchant>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1Merchant) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1Merchant)));
            
        }

    }
}