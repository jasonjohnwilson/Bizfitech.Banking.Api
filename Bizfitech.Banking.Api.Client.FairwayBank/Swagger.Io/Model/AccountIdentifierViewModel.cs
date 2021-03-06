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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// AccountIdentifierViewModel
    /// </summary>
    [DataContract]
    public partial class AccountIdentifierViewModel :  IEquatable<AccountIdentifierViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentifierViewModel" /> class.
        /// </summary>
        /// <param name="AccountNumber">The account number of the account.</param>
        /// <param name="SortCode">The sort code of the account.</param>
        public AccountIdentifierViewModel(string AccountNumber = default(string), string SortCode = default(string))
        {
            this.AccountNumber = AccountNumber;
            this.SortCode = SortCode;
        }
        
        /// <summary>
        /// The account number of the account
        /// </summary>
        /// <value>The account number of the account</value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The sort code of the account
        /// </summary>
        /// <value>The sort code of the account</value>
        [DataMember(Name="sortCode", EmitDefaultValue=false)]
        public string SortCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountIdentifierViewModel {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  SortCode: ").Append(SortCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountIdentifierViewModel);
        }

        /// <summary>
        /// Returns true if AccountIdentifierViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountIdentifierViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountIdentifierViewModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.SortCode == input.SortCode ||
                    (this.SortCode != null &&
                    this.SortCode.Equals(input.SortCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.SortCode != null)
                    hashCode = hashCode * 59 + this.SortCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
