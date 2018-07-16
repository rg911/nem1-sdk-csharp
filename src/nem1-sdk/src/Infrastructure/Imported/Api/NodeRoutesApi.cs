/* 
 * NIS1 API
 *
 * This document defines all the nis1 api routes and behaviour
 *
 * OpenAPI spec version: 1.0.0
 * Contact: kodtycoon@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using io.nem1.sdk.Infrastructure.Imported.Client;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace io.nem1.sdk.Infrastructure.Imported.Api
{
    /// <exclude />
    internal interface INodeRoutesApi : IApiAccessor
    {
        
        #region Asynchronous Operations
        /// <summary>
        /// Getting a list of all active peers
        /// </summary>
        /// <remarks>
        /// Returns a list of all active peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PeerListDTO</returns>
        System.Threading.Tasks.Task<List<JObject>> ActiveNodePeerListAllAsync ();

        /// <summary>
        /// Getting a list of all active peers
        /// </summary>
        /// <remarks>
        /// Returns a list of all active peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PeerListDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<JObject>> ActiveNodePeerListAllAsyncWithHttpInfo ();
        /// <summary>
        /// Getting the active peer max chain height
        /// </summary>
        /// <remarks>
        /// Returns the max chain height from the list of all active peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChainHeightDTO</returns>
        System.Threading.Tasks.Task<JObject> ActiveNodePeerMaxHeightAsync ();

        /// <summary>
        /// Getting the active peer max chain height
        /// </summary>
        /// <remarks>
        /// Returns the max chain height from the list of all active peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChainHeightDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ActiveNodePeerMaxHeightAsyncWithHttpInfo ();
        /// <summary>
        /// Getting extended node and nis information
        /// </summary>
        /// <remarks>
        /// Returns the node and nis information for the supplied node endpoint
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ExtendedNodeInfoDTO</returns>
        System.Threading.Tasks.Task<JObject> ExtendedNodeInfoAsync ();

        /// <summary>
        /// Getting extended node and nis information
        /// </summary>
        /// <remarks>
        /// Returns the node and nis information for the supplied node endpoint
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ExtendedNodeInfoDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ExtendedNodeInfoAsyncWithHttpInfo ();
        /// <summary>
        /// Getting node experiences
        /// </summary>
        /// <remarks>
        /// Returns experiences of all reachable peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of NodeExperiencesInfoDTO</returns>
        System.Threading.Tasks.Task<JObject> NodeExperiencesAsync ();

        /// <summary>
        /// Getting node experiences
        /// </summary>
        /// <remarks>
        /// Returns experiences of all reachable peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (NodeExperiencesInfoDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> NodeExperiencesAsyncWithHttpInfo ();
        /// <summary>
        /// Getting node information
        /// </summary>
        /// <remarks>
        /// Returns the information for the supplied node endpoint
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of NodeInfoDTO</returns>
        System.Threading.Tasks.Task<JObject> NodeInfoAsync ();

        /// <summary>
        /// Getting node information
        /// </summary>
        /// <remarks>
        /// Returns the information for the supplied node endpoint
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (NodeInfoDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> NodeInfoAsyncWithHttpInfo ();
        /// <summary>
        /// Getting a list of all peers
        /// </summary>
        /// <remarks>
        /// Returns a list of all known peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PeerListInfoDTO</returns>
        System.Threading.Tasks.Task<JObject> NodePeerListAllAsync ();

        /// <summary>
        /// Getting a list of all peers
        /// </summary>
        /// <remarks>
        /// Returns a list of all known peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PeerListInfoDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<JObject>> NodePeerListAllAsyncWithHttpInfo ();
        /// <summary>
        /// Getting a list of all reachable peers
        /// </summary>
        /// <remarks>
        /// Returns a list of all reachable peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PeerListDTO</returns>
        System.Threading.Tasks.Task<JObject> ReachableNodePeerListAllAsync ();

        /// <summary>
        /// Getting a list of all reachable peers
        /// </summary>
        /// <remarks>
        /// Returns a list of all reachable peers
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PeerListDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ReachableNodePeerListAllAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <exclude />
    internal partial class NodeRoutesApi : INodeRoutesApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRoutesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NodeRoutesApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeRoutesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NodeRoutesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
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
        public ExceptionFactory ExceptionFactory
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
        /// Getting a list of all active peers Returns a list of all active peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PeerListDTO</returns>
        public async System.Threading.Tasks.Task<List<JObject>> ActiveNodePeerListAllAsync ()
        {
             ApiResponse<JObject> localVarResponse = await ActiveNodePeerListAllAsyncWithHttpInfo();

             return localVarResponse.Data["data"].ToObject<List<JObject>>();

        }

        /// <summary>
        /// Getting a list of all active peers Returns a list of all active peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PeerListDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JObject>> ActiveNodePeerListAllAsyncWithHttpInfo ()
        {

            var localVarPath = "/node/peer-list/active";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ActiveNodePeerListAll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<JObject>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JObject) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JObject)));
        }

        
        /// <summary>
        /// Getting the active peer max chain height Returns the max chain height from the list of all active peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ChainHeightDTO</returns>
        public async System.Threading.Tasks.Task<JObject> ActiveNodePeerMaxHeightAsync ()
        {
             ApiResponse<string> localVarResponse = await ActiveNodePeerMaxHeightAsyncWithHttpInfo();
             return JObject.Parse(localVarResponse.Data);

        }

        /// <summary>
        /// Getting the active peer max chain height Returns the max chain height from the list of all active peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ChainHeightDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ActiveNodePeerMaxHeightAsyncWithHttpInfo ()
        {

            var localVarPath = "/node/active-peers/max-chain-height";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ActiveNodePeerMaxHeight", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

       
        /// <summary>
        /// Getting extended node and nis information Returns the node and nis information for the supplied node endpoint
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ExtendedNodeInfoDTO</returns>
        public async System.Threading.Tasks.Task<JObject> ExtendedNodeInfoAsync ()
        {
             ApiResponse<string> localVarResponse = await ExtendedNodeInfoAsyncWithHttpInfo();

            return JObject.Parse(localVarResponse.Data);

        }

        /// <summary>
        /// Getting extended node and nis information Returns the node and nis information for the supplied node endpoint
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ExtendedNodeInfoDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ExtendedNodeInfoAsyncWithHttpInfo ()
        {

            var localVarPath = "/node/extended-info";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExtendedNodeInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Getting node experiences Returns experiences of all reachable peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of NodeExperiencesInfoDTO</returns>
        public async System.Threading.Tasks.Task<JObject> NodeExperiencesAsync ()
        {
             ApiResponse<string> localVarResponse = await NodeExperiencesAsyncWithHttpInfo();
             return JObject.Parse(localVarResponse.Data);

        }

        /// <summary>
        /// Getting node experiences Returns experiences of all reachable peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (NodeExperiencesInfoDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> NodeExperiencesAsyncWithHttpInfo ()
        {

            var localVarPath = "/node/experiences";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NodeExperiences", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Getting node information Returns the information for the supplied node endpoint
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of NodeInfoDTO</returns>
        public async System.Threading.Tasks.Task<JObject> NodeInfoAsync ()
        {
             ApiResponse<string> localVarResponse = await NodeInfoAsyncWithHttpInfo();
             return JObject.Parse(localVarResponse.Data);

        }

        /// <summary>
        /// Getting node information Returns the information for the supplied node endpoint
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (NodeInfoDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> NodeInfoAsyncWithHttpInfo ()
        {

            var localVarPath = "/node/info";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NodeInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

       
        /// <summary>
        /// Getting a list of all peers Returns a list of all known peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PeerListInfoDTO</returns>
        public async System.Threading.Tasks.Task<JObject> NodePeerListAllAsync ()
        {
             ApiResponse<JObject> localVarResponse = await NodePeerListAllAsyncWithHttpInfo();

             return localVarResponse.Data.ToObject<JObject>();

        }

        /// <summary>
        /// Getting a list of all peers Returns a list of all known peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PeerListInfoDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JObject>> NodePeerListAllAsyncWithHttpInfo()
        {

            var localVarPath = "/node/peer-list/all";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NodePeerListAll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<JObject>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JObject) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JObject)));
        }

        

        /// <summary>
        /// Getting a list of all reachable peers Returns a list of all reachable peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PeerListDTO</returns>
        public async System.Threading.Tasks.Task<JObject> ReachableNodePeerListAllAsync ()
        {
             ApiResponse<string> localVarResponse = await ReachableNodePeerListAllAsyncWithHttpInfo();
             return JObject.Parse(localVarResponse.Data);

        }

        /// <summary>
        /// Getting a list of all reachable peers Returns a list of all reachable peers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PeerListDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ReachableNodePeerListAllAsyncWithHttpInfo ()
        {

            var localVarPath = "/node/peer-list/reachable";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReachableNodePeerListAll", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
