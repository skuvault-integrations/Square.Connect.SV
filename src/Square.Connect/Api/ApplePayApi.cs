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
    public interface IApplePayApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// RegisterDomain
        /// </summary>
        /// <remarks>
        /// Activates a domain for use with Web Apple Pay and Square. A validation will be performed on this domain by Apple to ensure is it properly set up as an Apple Pay enabled domain.  This endpoint provides an easy way for platform developers to bulk activate Web Apple Pay with Square for merchants using their platform.  To learn more about Apple Pay on Web see the Apple Pay section in the [Embedding the Square Payment Form](/payment-form/add-digital-wallets/apple-pay) guide.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>RegisterDomainResponse</returns>
        RegisterDomainResponse RegisterDomain (RegisterDomainRequest body);

        /// <summary>
        /// RegisterDomain
        /// </summary>
        /// <remarks>
        /// Activates a domain for use with Web Apple Pay and Square. A validation will be performed on this domain by Apple to ensure is it properly set up as an Apple Pay enabled domain.  This endpoint provides an easy way for platform developers to bulk activate Web Apple Pay with Square for merchants using their platform.  To learn more about Apple Pay on Web see the Apple Pay section in the [Embedding the Square Payment Form](/payment-form/add-digital-wallets/apple-pay) guide.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of RegisterDomainResponse</returns>
        ApiResponse<RegisterDomainResponse> RegisterDomainWithHttpInfo (RegisterDomainRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// RegisterDomain
        /// </summary>
        /// <remarks>
        /// Activates a domain for use with Web Apple Pay and Square. A validation will be performed on this domain by Apple to ensure is it properly set up as an Apple Pay enabled domain.  This endpoint provides an easy way for platform developers to bulk activate Web Apple Pay with Square for merchants using their platform.  To learn more about Apple Pay on Web see the Apple Pay section in the [Embedding the Square Payment Form](/payment-form/add-digital-wallets/apple-pay) guide.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of RegisterDomainResponse</returns>
        System.Threading.Tasks.Task<RegisterDomainResponse> RegisterDomainAsync (RegisterDomainRequest body);

        /// <summary>
        /// RegisterDomain
        /// </summary>
        /// <remarks>
        /// Activates a domain for use with Web Apple Pay and Square. A validation will be performed on this domain by Apple to ensure is it properly set up as an Apple Pay enabled domain.  This endpoint provides an easy way for platform developers to bulk activate Web Apple Pay with Square for merchants using their platform.  To learn more about Apple Pay on Web see the Apple Pay section in the [Embedding the Square Payment Form](/payment-form/add-digital-wallets/apple-pay) guide.
        /// </remarks>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (RegisterDomainResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RegisterDomainResponse>> RegisterDomainAsyncWithHttpInfo (RegisterDomainRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApplePayApi : IApplePayApi
    {
        private Square.Connect.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplePayApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplePayApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ApplePayApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApplePayApi(Configuration configuration = null)
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
        /// RegisterDomain Activates a domain for use with Web Apple Pay and Square. A validation will be performed on this domain by Apple to ensure is it properly set up as an Apple Pay enabled domain.  This endpoint provides an easy way for platform developers to bulk activate Web Apple Pay with Square for merchants using their platform.  To learn more about Apple Pay on Web see the Apple Pay section in the [Embedding the Square Payment Form](/payment-form/add-digital-wallets/apple-pay) guide.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>RegisterDomainResponse</returns>
        public RegisterDomainResponse RegisterDomain (RegisterDomainRequest body)
        {
             ApiResponse<RegisterDomainResponse> localVarResponse = RegisterDomainWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// RegisterDomain Activates a domain for use with Web Apple Pay and Square. A validation will be performed on this domain by Apple to ensure is it properly set up as an Apple Pay enabled domain.  This endpoint provides an easy way for platform developers to bulk activate Web Apple Pay with Square for merchants using their platform.  To learn more about Apple Pay on Web see the Apple Pay section in the [Embedding the Square Payment Form](/payment-form/add-digital-wallets/apple-pay) guide.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>ApiResponse of RegisterDomainResponse</returns>
        public ApiResponse< RegisterDomainResponse > RegisterDomainWithHttpInfo (RegisterDomainRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplePayApi->RegisterDomain");

            var localVarPath = "/v2/apple-pay/domains";
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
            localVarHeaderParams.Add("Square-Version", "2019-06-12");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RegisterDomain", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RegisterDomainResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RegisterDomainResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RegisterDomainResponse)));
            
        }

        /// <summary>
        /// RegisterDomain Activates a domain for use with Web Apple Pay and Square. A validation will be performed on this domain by Apple to ensure is it properly set up as an Apple Pay enabled domain.  This endpoint provides an easy way for platform developers to bulk activate Web Apple Pay with Square for merchants using their platform.  To learn more about Apple Pay on Web see the Apple Pay section in the [Embedding the Square Payment Form](/payment-form/add-digital-wallets/apple-pay) guide.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of RegisterDomainResponse</returns>
        public async System.Threading.Tasks.Task<RegisterDomainResponse> RegisterDomainAsync (RegisterDomainRequest body)
        {
             ApiResponse<RegisterDomainResponse> localVarResponse = await RegisterDomainAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// RegisterDomain Activates a domain for use with Web Apple Pay and Square. A validation will be performed on this domain by Apple to ensure is it properly set up as an Apple Pay enabled domain.  This endpoint provides an easy way for platform developers to bulk activate Web Apple Pay with Square for merchants using their platform.  To learn more about Apple Pay on Web see the Apple Pay section in the [Embedding the Square Payment Form](/payment-form/add-digital-wallets/apple-pay) guide.
        /// </summary>
        /// <exception cref="Square.Connect.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <returns>Task of ApiResponse (RegisterDomainResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RegisterDomainResponse>> RegisterDomainAsyncWithHttpInfo (RegisterDomainRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ApplePayApi->RegisterDomain");

            var localVarPath = "/v2/apple-pay/domains";
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

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RegisterDomain", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RegisterDomainResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RegisterDomainResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RegisterDomainResponse)));
            
        }

    }
}
