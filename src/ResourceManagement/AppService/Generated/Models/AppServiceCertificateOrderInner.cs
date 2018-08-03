// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SSL certificate purchase order.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AppServiceCertificateOrderInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the AppServiceCertificateOrderInner
        /// class.
        /// </summary>
        public AppServiceCertificateOrderInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppServiceCertificateOrderInner
        /// class.
        /// </summary>
        /// <param name="productType">Certificate product type. Possible values
        /// include: 'StandardDomainValidatedSsl',
        /// 'StandardDomainValidatedWildCardSsl'</param>
        /// <param name="certificates">State of the Key Vault secret.</param>
        /// <param name="distinguishedName">Certificate distinguished
        /// name.</param>
        /// <param name="domainVerificationToken">Domain verification
        /// token.</param>
        /// <param name="validityInYears">Duration in years (must be between 1
        /// and 3).</param>
        /// <param name="keySize">Certificate key size.</param>
        /// <param name="autoRenew">&lt;code&gt;true&lt;/code&gt; if the
        /// certificate should be automatically renewed when it expires;
        /// otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="provisioningState">Status of certificate order.
        /// Possible values include: 'Succeeded', 'Failed', 'Canceled',
        /// 'InProgress', 'Deleting'</param>
        /// <param name="status">Current order status. Possible values include:
        /// 'Pendingissuance', 'Issued', 'Revoked', 'Canceled', 'Denied',
        /// 'Pendingrevocation', 'PendingRekey', 'Unused', 'Expired',
        /// 'NotSubmitted'</param>
        /// <param name="signedCertificate">Signed certificate.</param>
        /// <param name="csr">Last CSR that was created for this order.</param>
        /// <param name="intermediate">Intermediate certificate.</param>
        /// <param name="root">Root certificate.</param>
        /// <param name="serialNumber">Current serial number of the
        /// certificate.</param>
        /// <param name="lastCertificateIssuanceTime">Certificate last issuance
        /// time.</param>
        /// <param name="expirationTime">Certificate expiration time.</param>
        /// <param name="isPrivateKeyExternal">&lt;code&gt;true&lt;/code&gt; if
        /// private key is external; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="appServiceCertificateNotRenewableReasons">Reasons why
        /// App Service Certificate is not renewable at the current
        /// moment.</param>
        /// <param name="nextAutoRenewalTimeStamp">Time stamp when the
        /// certificate would be auto renewed next</param>
        /// <param name="kind">Kind of resource.</param>
        public AppServiceCertificateOrderInner(string location, CertificateProductType productType, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IDictionary<string, AppServiceCertificateInner> certificates = default(IDictionary<string, AppServiceCertificateInner>), string distinguishedName = default(string), string domainVerificationToken = default(string), int? validityInYears = default(int?), int? keySize = default(int?), bool? autoRenew = default(bool?), ProvisioningState? provisioningState = default(ProvisioningState?), CertificateOrderStatus? status = default(CertificateOrderStatus?), CertificateDetails signedCertificate = default(CertificateDetails), string csr = default(string), CertificateDetails intermediate = default(CertificateDetails), CertificateDetails root = default(CertificateDetails), string serialNumber = default(string), System.DateTime? lastCertificateIssuanceTime = default(System.DateTime?), System.DateTime? expirationTime = default(System.DateTime?), bool? isPrivateKeyExternal = default(bool?), IList<AppServiceCertificateNotRenewableReasons> appServiceCertificateNotRenewableReasons = default(IList<AppServiceCertificateNotRenewableReasons>), System.DateTime? nextAutoRenewalTimeStamp = default(System.DateTime?), string kind = default(string))
            : base(location, id, name, type, tags)
        {
            Certificates = certificates;
            DistinguishedName = distinguishedName;
            DomainVerificationToken = domainVerificationToken;
            ValidityInYears = validityInYears;
            KeySize = keySize;
            ProductType = productType;
            AutoRenew = autoRenew;
            ProvisioningState = provisioningState;
            Status = status;
            SignedCertificate = signedCertificate;
            Csr = csr;
            Intermediate = intermediate;
            Root = root;
            SerialNumber = serialNumber;
            LastCertificateIssuanceTime = lastCertificateIssuanceTime;
            ExpirationTime = expirationTime;
            IsPrivateKeyExternal = isPrivateKeyExternal;
            AppServiceCertificateNotRenewableReasons = appServiceCertificateNotRenewableReasons;
            NextAutoRenewalTimeStamp = nextAutoRenewalTimeStamp;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets state of the Key Vault secret.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificates")]
        public IDictionary<string, AppServiceCertificateInner> Certificates { get; set; }

        /// <summary>
        /// Gets or sets certificate distinguished name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.distinguishedName")]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Gets domain verification token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainVerificationToken")]
        public string DomainVerificationToken { get; private set; }

        /// <summary>
        /// Gets or sets duration in years (must be between 1 and 3).
        /// </summary>
        [JsonProperty(PropertyName = "properties.validityInYears")]
        public int? ValidityInYears { get; set; }

        /// <summary>
        /// Gets or sets certificate key size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keySize")]
        public int? KeySize { get; set; }

        /// <summary>
        /// Gets or sets certificate product type. Possible values include:
        /// 'StandardDomainValidatedSsl', 'StandardDomainValidatedWildCardSsl'
        /// </summary>
        [JsonProperty(PropertyName = "properties.productType")]
        public CertificateProductType ProductType { get; set; }

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if the
        /// certificate should be automatically renewed when it expires;
        /// otherwise, &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoRenew")]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Gets status of certificate order. Possible values include:
        /// 'Succeeded', 'Failed', 'Canceled', 'InProgress', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets current order status. Possible values include:
        /// 'Pendingissuance', 'Issued', 'Revoked', 'Canceled', 'Denied',
        /// 'Pendingrevocation', 'PendingRekey', 'Unused', 'Expired',
        /// 'NotSubmitted'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public CertificateOrderStatus? Status { get; private set; }

        /// <summary>
        /// Gets signed certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.signedCertificate")]
        public CertificateDetails SignedCertificate { get; private set; }

        /// <summary>
        /// Gets or sets last CSR that was created for this order.
        /// </summary>
        [JsonProperty(PropertyName = "properties.csr")]
        public string Csr { get; set; }

        /// <summary>
        /// Gets intermediate certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.intermediate")]
        public CertificateDetails Intermediate { get; private set; }

        /// <summary>
        /// Gets root certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.root")]
        public CertificateDetails Root { get; private set; }

        /// <summary>
        /// Gets current serial number of the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serialNumber")]
        public string SerialNumber { get; private set; }

        /// <summary>
        /// Gets certificate last issuance time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCertificateIssuanceTime")]
        public System.DateTime? LastCertificateIssuanceTime { get; private set; }

        /// <summary>
        /// Gets certificate expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationTime")]
        public System.DateTime? ExpirationTime { get; private set; }

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if private key
        /// is external; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isPrivateKeyExternal")]
        public bool? IsPrivateKeyExternal { get; private set; }

        /// <summary>
        /// Gets reasons why App Service Certificate is not renewable at the
        /// current moment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appServiceCertificateNotRenewableReasons")]
        public IList<AppServiceCertificateNotRenewableReasons> AppServiceCertificateNotRenewableReasons { get; private set; }

        /// <summary>
        /// Gets time stamp when the certificate would be auto renewed next
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextAutoRenewalTimeStamp")]
        public System.DateTime? NextAutoRenewalTimeStamp { get; private set; }

        /// <summary>
        /// Gets or sets kind of resource.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ValidityInYears > 3)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "ValidityInYears", 3);
            }
            if (ValidityInYears < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ValidityInYears", 1);
            }
        }
    }
}
