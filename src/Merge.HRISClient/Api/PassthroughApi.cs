/*
 * Merge HRIS API
 *
 * The unified API for building rich integrations with multiple HR Information System platforms.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: hello@merge.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Merge.HRISClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPassthroughApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Pull data from an endpoint not currently supported by Merge.
        /// </remarks>
        /// <exception cref="Merge.HRISClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="dataPassthroughRequest"></param>
        /// <returns>RemoteResponse</returns>
        RemoteResponse PassthroughCreate(string xAccountToken, DataPassthroughRequest dataPassthroughRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Pull data from an endpoint not currently supported by Merge.
        /// </remarks>
        /// <exception cref="Merge.HRISClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="dataPassthroughRequest"></param>
        /// <returns>ApiResponse of RemoteResponse</returns>
        ApiResponse<RemoteResponse> PassthroughCreateWithHttpInfo(string xAccountToken, DataPassthroughRequest dataPassthroughRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPassthroughApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Pull data from an endpoint not currently supported by Merge.
        /// </remarks>
        /// <exception cref="Merge.HRISClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="dataPassthroughRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RemoteResponse</returns>
        System.Threading.Tasks.Task<RemoteResponse> PassthroughCreateAsync(string xAccountToken, DataPassthroughRequest dataPassthroughRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Pull data from an endpoint not currently supported by Merge.
        /// </remarks>
        /// <exception cref="Merge.HRISClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="dataPassthroughRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RemoteResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RemoteResponse>> PassthroughCreateWithHttpInfoAsync(string xAccountToken, DataPassthroughRequest dataPassthroughRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPassthroughApi : IPassthroughApiSync, IPassthroughApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PassthroughApi : IPassthroughApi
    {
        private Merge.HRISClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PassthroughApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PassthroughApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassthroughApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PassthroughApi(String basePath)
        {
            this.Configuration = Merge.HRISClient.Client.Configuration.MergeConfigurations(
                Merge.HRISClient.Client.GlobalConfiguration.Instance,
                new Merge.HRISClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Merge.HRISClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Merge.HRISClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Merge.HRISClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassthroughApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PassthroughApi(Merge.HRISClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Merge.HRISClient.Client.Configuration.MergeConfigurations(
                Merge.HRISClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Merge.HRISClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Merge.HRISClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Merge.HRISClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassthroughApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PassthroughApi(Merge.HRISClient.Client.ISynchronousClient client, Merge.HRISClient.Client.IAsynchronousClient asyncClient, Merge.HRISClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Merge.HRISClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Merge.HRISClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Merge.HRISClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Merge.HRISClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Merge.HRISClient.Client.ExceptionFactory ExceptionFactory
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
        ///  Pull data from an endpoint not currently supported by Merge.
        /// </summary>
        /// <exception cref="Merge.HRISClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="dataPassthroughRequest"></param>
        /// <returns>RemoteResponse</returns>
        public RemoteResponse PassthroughCreate(string xAccountToken, DataPassthroughRequest dataPassthroughRequest)
        {
            Merge.HRISClient.Client.ApiResponse<RemoteResponse> localVarResponse = PassthroughCreateWithHttpInfo(xAccountToken, dataPassthroughRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Pull data from an endpoint not currently supported by Merge.
        /// </summary>
        /// <exception cref="Merge.HRISClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="dataPassthroughRequest"></param>
        /// <returns>ApiResponse of RemoteResponse</returns>
        public Merge.HRISClient.Client.ApiResponse<RemoteResponse> PassthroughCreateWithHttpInfo(string xAccountToken, DataPassthroughRequest dataPassthroughRequest)
        {
            // verify the required parameter 'xAccountToken' is set
            if (xAccountToken == null)
                throw new Merge.HRISClient.Client.ApiException(400, "Missing required parameter 'xAccountToken' when calling PassthroughApi->PassthroughCreate");

            // verify the required parameter 'dataPassthroughRequest' is set
            if (dataPassthroughRequest == null)
                throw new Merge.HRISClient.Client.ApiException(400, "Missing required parameter 'dataPassthroughRequest' when calling PassthroughApi->PassthroughCreate");

            Merge.HRISClient.Client.RequestOptions localVarRequestOptions = new Merge.HRISClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json",
                "application/x-www-form-urlencoded",
                "multipart/form-data"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Merge.HRISClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Merge.HRISClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("X-Account-Token", Merge.HRISClient.Client.ClientUtils.ParameterToString(xAccountToken)); // header parameter
            localVarRequestOptions.Data = dataPassthroughRequest;

            // authentication (tokenAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<RemoteResponse>("/passthrough", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PassthroughCreate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Pull data from an endpoint not currently supported by Merge.
        /// </summary>
        /// <exception cref="Merge.HRISClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="dataPassthroughRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RemoteResponse</returns>
        public async System.Threading.Tasks.Task<RemoteResponse> PassthroughCreateAsync(string xAccountToken, DataPassthroughRequest dataPassthroughRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Merge.HRISClient.Client.ApiResponse<RemoteResponse> localVarResponse = await PassthroughCreateWithHttpInfoAsync(xAccountToken, dataPassthroughRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Pull data from an endpoint not currently supported by Merge.
        /// </summary>
        /// <exception cref="Merge.HRISClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="dataPassthroughRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RemoteResponse)</returns>
        public async System.Threading.Tasks.Task<Merge.HRISClient.Client.ApiResponse<RemoteResponse>> PassthroughCreateWithHttpInfoAsync(string xAccountToken, DataPassthroughRequest dataPassthroughRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'xAccountToken' is set
            if (xAccountToken == null)
                throw new Merge.HRISClient.Client.ApiException(400, "Missing required parameter 'xAccountToken' when calling PassthroughApi->PassthroughCreate");

            // verify the required parameter 'dataPassthroughRequest' is set
            if (dataPassthroughRequest == null)
                throw new Merge.HRISClient.Client.ApiException(400, "Missing required parameter 'dataPassthroughRequest' when calling PassthroughApi->PassthroughCreate");


            Merge.HRISClient.Client.RequestOptions localVarRequestOptions = new Merge.HRISClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Merge.HRISClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Merge.HRISClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("X-Account-Token", Merge.HRISClient.Client.ClientUtils.ParameterToString(xAccountToken)); // header parameter
            localVarRequestOptions.Data = dataPassthroughRequest;

            // authentication (tokenAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<RemoteResponse>("/passthrough", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PassthroughCreate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
