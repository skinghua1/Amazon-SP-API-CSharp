/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    /// BuyBoxPriceType
    /// </summary>
    [DataContract]
    public partial class BuyBoxPriceType : IEquatable<BuyBoxPriceType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyBoxPriceType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuyBoxPriceType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyBoxPriceType" /> class.
        /// </summary>
        /// <param name="Condition">Indicates the condition of the item. For example: New, Used, Collectible, Refurbished, or Club. (required).</param>
        /// <param name="LandedPrice">The value calculated by adding ListingPrice + Shipping - Points. (required).</param>
        /// <param name="ListingPrice">The price of the item. (required).</param>
        /// <param name="Shipping">The shipping cost. (required).</param>
        /// <param name="Points">The number of Amazon Points offered with the purchase of an item..</param>
        public BuyBoxPriceType(string Condition = default(string), MoneyType LandedPrice = default(MoneyType), MoneyType ListingPrice = default(MoneyType), MoneyType Shipping = default(MoneyType), Points Points = default(Points))
        {
            // to ensure "Condition" is required (not null)
            if (Condition == null)
            {
                throw new InvalidDataException("Condition is a required property for BuyBoxPriceType and cannot be null");
            }
            else
            {
                this.Condition = Condition;
            }
            // to ensure "LandedPrice" is required (not null)
            if (LandedPrice == null)
            {
                throw new InvalidDataException("LandedPrice is a required property for BuyBoxPriceType and cannot be null");
            }
            else
            {
                this.LandedPrice = LandedPrice;
            }
            // to ensure "ListingPrice" is required (not null)
            if (ListingPrice == null)
            {
                throw new InvalidDataException("ListingPrice is a required property for BuyBoxPriceType and cannot be null");
            }
            else
            {
                this.ListingPrice = ListingPrice;
            }
            // to ensure "Shipping" is required (not null)
            if (Shipping == null)
            {
                throw new InvalidDataException("Shipping is a required property for BuyBoxPriceType and cannot be null");
            }
            else
            {
                this.Shipping = Shipping;
            }
            this.Points = Points;
        }

        /// <summary>
        /// Indicates the condition of the item. For example: New, Used, Collectible, Refurbished, or Club.
        /// </summary>
        /// <value>Indicates the condition of the item. For example: New, Used, Collectible, Refurbished, or Club.</value>
        [DataMember(Name = "condition", EmitDefaultValue = false)]
        public string Condition { get; set; }

        /// <summary>
        /// The value calculated by adding ListingPrice + Shipping - Points.
        /// </summary>
        /// <value>The value calculated by adding ListingPrice + Shipping - Points.</value>
        [DataMember(Name = "LandedPrice", EmitDefaultValue = false)]
        public MoneyType LandedPrice { get; set; }

        /// <summary>
        /// The price of the item.
        /// </summary>
        /// <value>The price of the item.</value>
        [DataMember(Name = "ListingPrice", EmitDefaultValue = false)]
        public MoneyType ListingPrice { get; set; }

        /// <summary>
        /// The shipping cost.
        /// </summary>
        /// <value>The shipping cost.</value>
        [DataMember(Name = "Shipping", EmitDefaultValue = false)]
        public MoneyType Shipping { get; set; }

        /// <summary>
        /// The number of Amazon Points offered with the purchase of an item.
        /// </summary>
        /// <value>The number of Amazon Points offered with the purchase of an item.</value>
        [DataMember(Name = "Points", EmitDefaultValue = false)]
        public Points Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuyBoxPriceType {\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  LandedPrice: ").Append(LandedPrice).Append("\n");
            sb.Append("  ListingPrice: ").Append(ListingPrice).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(input as BuyBoxPriceType);
        }

        /// <summary>
        /// Returns true if BuyBoxPriceType instances are equal
        /// </summary>
        /// <param name="input">Instance of BuyBoxPriceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuyBoxPriceType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) &&
                (
                    this.LandedPrice == input.LandedPrice ||
                    (this.LandedPrice != null &&
                    this.LandedPrice.Equals(input.LandedPrice))
                ) &&
                (
                    this.ListingPrice == input.ListingPrice ||
                    (this.ListingPrice != null &&
                    this.ListingPrice.Equals(input.ListingPrice))
                ) &&
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) &&
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
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
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.LandedPrice != null)
                    hashCode = hashCode * 59 + this.LandedPrice.GetHashCode();
                if (this.ListingPrice != null)
                    hashCode = hashCode * 59 + this.ListingPrice.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
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
