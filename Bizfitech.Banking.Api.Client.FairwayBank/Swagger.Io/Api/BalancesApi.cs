/* 
 * FairWayBank
 *
 * FairWayBank Accounts + Transactions API
 *
 * OpenAPI spec version: v1
 * Contact: development@bizfitech.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBalancesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountNumber"></param>
        /// <returns>BalanceViewModel</returns>
        BalanceViewModel ApiV1AccountsByAccountNumberBalanceGet (string accountNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountNumber"></param>
        /// <returns>ApiResponse of BalanceViewModel</returns>
        ApiResponse<BalanceViewModel> ApiV1AccountsByAccountNumberBalanceGetWithHttpInfo (string accountNumber);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountNumber"></param>
        /// <returns>Task of BalanceViewModel</returns>
        System.Threading.Tasks.Task<BalanceViewModel> ApiV1AccountsByAccountNumberBalanceGetAsync (string accountNumber);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountNumber"></param>
        /// <returns>Task of ApiResponse (BalanceViewModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<BalanceViewModel>> ApiV1AccountsByAccountNumberBalanceGetAsyncWithHttpInfo (string accountNumber);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BalancesApi : IBalancesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BalancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BalancesApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalancesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BalancesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountNumber"></param>
        /// <returns>BalanceViewModel</returns>
        public BalanceViewModel ApiV1AccountsByAccountNumberBalanceGet (string accountNumber)
        {
             ApiResponse<BalanceViewModel> localVarResponse = ApiV1AccountsByAccountNumberBalanceGetWithHttpInfo(accountNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountNumber"></param>
        /// <returns>ApiResponse of BalanceViewModel</returns>
        public ApiResponse< BalanceViewModel > ApiV1AccountsByAccountNumberBalanceGetWithHttpInfo (string accountNumber)
        {
            // verify the required parameter 'accountNumber' is set
            if (accountNumber == null)
                throw new ApiException(400, "Missing required parameter 'accountNumber' when calling BalancesApi->ApiV1AccountsByAccountNumberBalanceGet");

            var localVarPath = "/api/v1/accounts/{account_number}/balance";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (accountNumber != null) localVarPathParams.Add("account_number", Configuration.ApiClient.ParameterToString(accountNumber)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1AccountsByAccountNumberBalanceGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BalanceViewModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BalanceViewModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BalanceViewModel)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountNumber"></param>
        /// <returns>Task of BalanceViewModel</returns>
        public async System.Threading.Tasks.Task<BalanceViewModel> ApiV1AccountsByAccountNumberBalanceGetAsync (string accountNumber)
        {
             ApiResponse<BalanceViewModel> localVarResponse = await ApiV1AccountsByAccountNumberBalanceGetAsyncWithHttpInfo(accountNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountNumber"></param>
        /// <returns>Task of ApiResponse (BalanceViewModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BalanceViewModel>> ApiV1AccountsByAccountNumberBalanceGetAsyncWithHttpInfo (string accountNumber)
        {
            // verify the required parameter 'accountNumber' is set
            if (accountNumber == null)
                throw new ApiException(400, "Missing required parameter 'accountNumber' when calling BalancesApi->ApiV1AccountsByAccountNumberBalanceGet");

            var localVarPath = "/api/v1/accounts/{account_number}/balance";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (accountNumber != null) localVarPathParams.Add("account_number", Configuration.ApiClient.ParameterToString(accountNumber)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ApiV1AccountsByAccountNumberBalanceGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BalanceViewModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BalanceViewModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BalanceViewModel)));
        }

    }
}
