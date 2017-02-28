// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.21.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Manufacturer Center API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/manufacturers/'>Manufacturer Center API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20161028 (666)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/manufacturers/'>
 *              https://developers.google.com/manufacturers/</a>
 *      <tr><th>Discovery Name<td>manufacturers
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Manufacturer Center API can be found at
 * <a href='https://developers.google.com/manufacturers/'>https://developers.google.com/manufacturers/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.ManufacturerCenter.v1
{
    /// <summary>The ManufacturerCenter Service.</summary>
    public class ManufacturerCenterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ManufacturerCenterService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ManufacturerCenterService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            accounts = new AccountsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "manufacturers"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://manufacturers.googleapis.com/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        /// <summary>Available OAuth 2.0 scopes for use with the Manufacturer Center API.</summary>
        public class Scope
        {
            /// <summary>Manage your product listings for Google Manufacturer Center</summary>
            public static string Manufacturercenter = "https://www.googleapis.com/auth/manufacturercenter";

        }



        private readonly AccountsResource accounts;

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts
        {
            get { return accounts; }
        }
    }

    ///<summary>A base abstract class for ManufacturerCenter requests.</summary>
    public abstract class ManufacturerCenterBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new ManufacturerCenterBaseServiceRequest instance.</summary>
        protected ManufacturerCenterBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>OAuth bearer token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("bearer_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string BearerToken { get; set; }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Pretty-print response.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("pp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> Pp { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes ManufacturerCenter parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "bearer_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "bearer_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "pp", new Google.Apis.Discovery.Parameter
                {
                    Name = "pp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            products = new ProductsResource(service);

        }

        private readonly ProductsResource products;

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products
        {
            get { return products; }
        }

        /// <summary>The "products" collection of methods.</summary>
        public class ProductsResource
        {
            private const string Resource = "products";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProductsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Gets the product from a Manufacturer Center account, including product issues.</summary>
            /// <param name="parent">Parent ID in the format `accounts/{account_id}`.
            ///
            /// `account_id` - The ID of the Manufacturer Center account.</param>
            /// <param name="name">Name in the format
            /// `{target_country}:{content_language}:{product_id}`.
            ///
            /// `target_country`   - The target country of the product as a CLDR territory                      code (for example,
            /// US).
            ///
            /// `content_language` - The content language of the product as a two-letter                      ISO 639-1 language
            /// code (for example, en).
            ///
            /// `product_id`     -   The ID of the product. For more information, see
            /// https://support.google.com/manufacturers/answer/6124116#id.</param>
            public virtual GetRequest Get(string parent, string name)
            {
                return new GetRequest(service, parent, name);
            }

            /// <summary>Gets the product from a Manufacturer Center account, including product issues.</summary>
            public class GetRequest : ManufacturerCenterBaseServiceRequest<Google.Apis.ManufacturerCenter.v1.Data.Product>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string parent, string name)
                    : base(service)
                {
                    Parent = parent;
                    Name = name;
                    InitParameters();
                }


                /// <summary>Parent ID in the format `accounts/{account_id}`.
                ///
                /// `account_id` - The ID of the Manufacturer Center account.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Name in the format `{target_country}:{content_language}:{product_id}`.
                ///
                /// `target_country`   - The target country of the product as a CLDR territory code (for example, US).
                ///
                /// `content_language` - The content language of the product as a two-letter ISO 639-1 language code
                /// (for example, en).
                ///
                /// `product_id`     -   The ID of the product. For more information, see
                /// https://support.google.com/manufacturers/answer/6124116#id.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName
                {
                    get { return "get"; }
                }

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod
                {
                    get { return "GET"; }
                }

                ///<summary>Gets the REST path.</summary>
                public override string RestPath
                {
                    get { return "v1/{+parent}/products/{+name}"; }
                }

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+$",
                        });
                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^[^/]+$",
                        });
                }

            }

            /// <summary>Lists all the products in a Manufacturer Center account.</summary>
            /// <param name="parent">Parent ID in the format `accounts/{account_id}`.
            ///
            /// `account_id` - The ID of the Manufacturer Center account.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all the products in a Manufacturer Center account.</summary>
            public class ListRequest : ManufacturerCenterBaseServiceRequest<Google.Apis.ManufacturerCenter.v1.Data.ListProductsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent)
                    : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Parent ID in the format `accounts/{account_id}`.
                ///
                /// `account_id` - The ID of the Manufacturer Center account.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The token returned by the previous request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Maximum number of product statuses to return in the response, used for paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName
                {
                    get { return "list"; }
                }

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod
                {
                    get { return "GET"; }
                }

                ///<summary>Gets the REST path.</summary>
                public override string RestPath
                {
                    get { return "v1/{+parent}/products"; }
                }

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+$",
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }
    }
}

namespace Google.Apis.ManufacturerCenter.v1.Data
{    

    /// <summary>Attributes of the product. For more information, see
    /// https://support.google.com/manufacturers/answer/6124116.</summary>
    public class Attributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The brand name of the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#brand.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; } 

        /// <summary>The Global Trade Item Number (GTIN) of the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#gtin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual System.Collections.Generic.IList<string> Gtin { get; set; } 

        /// <summary>The Manufacturer Part Number (MPN) of the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#mpn.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mpn")]
        public virtual string Mpn { get; set; } 

        /// <summary>The name of the group of products related to the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#productline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productLine")]
        public virtual string ProductLine { get; set; } 

        /// <summary>The canonical name of the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#productname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productName")]
        public virtual string ProductName { get; set; } 

        /// <summary>The URL of the manufacturer's detail page of the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#productpage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productPageUrl")]
        public virtual string ProductPageUrl { get; set; } 

        /// <summary>The manufacturer's category of the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#producttype.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productType")]
        public virtual System.Collections.Generic.IList<string> ProductType { get; set; } 

        /// <summary>The title of the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Product issue.</summary>
    public class Issue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If present, the attribute that triggered the issue. For more information about attributes, see
        /// https://support.google.com/manufacturers/answer/6124116.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; } 

        /// <summary>Description of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The severity of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; } 

        /// <summary>The server-generated type of the issue, for example, “INCORRECT_TEXT_FORMATTING”,
        /// “IMAGE_NOT_SERVEABLE”, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token for the retrieval of the next page of product statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>List of the products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<Product> Products { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Product data.</summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content language of the product as a two-letter ISO 639-1 language code (for example, en).
        /// @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; } 

        /// <summary>Final attributes of the product. The final attributes are obtained by overriding the uploaded
        /// attributes with the manually provided and deleted attributes. Google systems only process, evaluate, review,
        /// and/or use final attributes. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalAttributes")]
        public virtual Attributes FinalAttributes { get; set; } 

        /// <summary>A server-generated list of issues associated with the product. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<Issue> Issues { get; set; } 

        /// <summary>Names of the attributes of the product deleted manually via the Manufacturer Center UI.
        /// @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manuallyDeletedAttributes")]
        public virtual System.Collections.Generic.IList<string> ManuallyDeletedAttributes { get; set; } 

        /// <summary>Attributes of the product provided manually via the Manufacturer Center UI. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manuallyProvidedAttributes")]
        public virtual Attributes ManuallyProvidedAttributes { get; set; } 

        /// <summary>Name in the format `{target_country}:{content_language}:{product_id}`.
        ///
        /// `target_country`   - The target country of the product as a CLDR territory code (for example, US).
        ///
        /// `content_language` - The content language of the product as a two-letter ISO 639-1 language code (for
        /// example, en).
        ///
        /// `product_id`     -   The ID of the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#id. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Parent ID in the format `accounts/{account_id}`.
        ///
        /// `account_id` - The ID of the Manufacturer Center account. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; } 

        /// <summary>The ID of the product. For more information, see
        /// https://support.google.com/manufacturers/answer/6124116#id. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; } 

        /// <summary>The target country of the product as a CLDR territory code (for example, US). @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCountry")]
        public virtual string TargetCountry { get; set; } 

        /// <summary>Attributes of the product uploaded via the Manufacturer Center API or via feeds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadedAttributes")]
        public virtual Attributes UploadedAttributes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
