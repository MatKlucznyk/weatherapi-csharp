/* 
 * Weather API
 *
 *  # Introduction  WeatherAPI.com provides access to weather and geo data via a JSON/XML restful API. It allows developers to create desktop, web and mobile applications using this data very easy.   We provide following data through our API:    * Real-time weather<br />    * 14 day weather forecast<br />    * Astronomy<br />    * Time zone<br />    * Location data<br />    * Search or Autocomplete API<br />    * NEW: Historical weather      * NEW: Future Weather (Upto 300 days ahead)      * Weather Alerts      * Air Quality Data  # Getting Started  You need to [signup](https://www.weatherapi.com/signup.aspx) and then you can find your API key under [your account](https://www.weatherapi.com/login.aspx), and start using API right away!  We have [code libraries](https://www.weatherapi.com/docs/code-libraries.aspx) for different programming languages like PHP, .net, JAVA, etc.  If you find any features missing or have any suggestions, please [contact us](https://www.weatherapi.com/contact.aspx).  # Authentication  API access to the data is protected by an API key. If at anytime, you find the API key has become vulnerable, please regenerate the key using Regenerate button next to the API key.  Authentication to the WeatherAPI.com API is provided by passing your API key as request parameter through an API .    ##  key parameter   key=\\<YOUR API KEY\\> 
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
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
    /// Current
    /// </summary>
    [DataContract]
        public partial class Current :  IEquatable<Current>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Current" /> class.
        /// </summary>
        /// <param name="lastUpdatedEpoch">lastUpdatedEpoch.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="tempC">tempC.</param>
        /// <param name="tempF">tempF.</param>
        /// <param name="isDay">isDay.</param>
        /// <param name="condition">condition.</param>
        /// <param name="windMph">windMph.</param>
        /// <param name="windKph">windKph.</param>
        /// <param name="windDegree">windDegree.</param>
        /// <param name="windDir">windDir.</param>
        /// <param name="pressureMb">pressureMb.</param>
        /// <param name="pressureIn">pressureIn.</param>
        /// <param name="precipMm">precipMm.</param>
        /// <param name="precipIn">precipIn.</param>
        /// <param name="humidity">humidity.</param>
        /// <param name="cloud">cloud.</param>
        /// <param name="feelslikeC">feelslikeC.</param>
        /// <param name="feelslikeF">feelslikeF.</param>
        /// <param name="visKm">visKm.</param>
        /// <param name="visMiles">visMiles.</param>
        /// <param name="uv">uv.</param>
        /// <param name="gustMph">gustMph.</param>
        /// <param name="gustKph">gustKph.</param>
        /// <param name="airQuality">airQuality.</param>
        public Current(int? lastUpdatedEpoch = default(int?), string lastUpdated = default(string), decimal? tempC = default(decimal?), decimal? tempF = default(decimal?), int? isDay = default(int?), CurrentCondition condition = default(CurrentCondition), decimal? windMph = default(decimal?), decimal? windKph = default(decimal?), int? windDegree = default(int?), string windDir = default(string), int? pressureMb = default(int?), decimal? pressureIn = default(decimal?), int? precipMm = default(int?), int? precipIn = default(int?), int? humidity = default(int?), int? cloud = default(int?), int? feelslikeC = default(int?), decimal? feelslikeF = default(decimal?), int? visKm = default(int?), int? visMiles = default(int?), int? uv = default(int?), decimal? gustMph = default(decimal?), decimal? gustKph = default(decimal?), CurrentAirQuality airQuality = default(CurrentAirQuality))
        {
            this.LastUpdatedEpoch = lastUpdatedEpoch;
            this.LastUpdated = lastUpdated;
            this.TempC = tempC;
            this.TempF = tempF;
            this.IsDay = isDay;
            this.Condition = condition;
            this.WindMph = windMph;
            this.WindKph = windKph;
            this.WindDegree = windDegree;
            this.WindDir = windDir;
            this.PressureMb = pressureMb;
            this.PressureIn = pressureIn;
            this.PrecipMm = precipMm;
            this.PrecipIn = precipIn;
            this.Humidity = humidity;
            this.Cloud = cloud;
            this.FeelslikeC = feelslikeC;
            this.FeelslikeF = feelslikeF;
            this.VisKm = visKm;
            this.VisMiles = visMiles;
            this.Uv = uv;
            this.GustMph = gustMph;
            this.GustKph = gustKph;
            this.AirQuality = airQuality;
        }
        
        /// <summary>
        /// Gets or Sets LastUpdatedEpoch
        /// </summary>
        [DataMember(Name="last_updated_epoch", EmitDefaultValue=false)]
        public int? LastUpdatedEpoch { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets TempC
        /// </summary>
        [DataMember(Name="temp_c", EmitDefaultValue=false)]
        public decimal? TempC { get; set; }

        /// <summary>
        /// Gets or Sets TempF
        /// </summary>
        [DataMember(Name="temp_f", EmitDefaultValue=false)]
        public decimal? TempF { get; set; }

        /// <summary>
        /// Gets or Sets IsDay
        /// </summary>
        [DataMember(Name="is_day", EmitDefaultValue=false)]
        public int? IsDay { get; set; }

        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public CurrentCondition Condition { get; set; }

        /// <summary>
        /// Gets or Sets WindMph
        /// </summary>
        [DataMember(Name="wind_mph", EmitDefaultValue=false)]
        public decimal? WindMph { get; set; }

        /// <summary>
        /// Gets or Sets WindKph
        /// </summary>
        [DataMember(Name="wind_kph", EmitDefaultValue=false)]
        public decimal? WindKph { get; set; }

        /// <summary>
        /// Gets or Sets WindDegree
        /// </summary>
        [DataMember(Name="wind_degree", EmitDefaultValue=false)]
        public int? WindDegree { get; set; }

        /// <summary>
        /// Gets or Sets WindDir
        /// </summary>
        [DataMember(Name="wind_dir", EmitDefaultValue=false)]
        public string WindDir { get; set; }

        /// <summary>
        /// Gets or Sets PressureMb
        /// </summary>
        [DataMember(Name="pressure_mb", EmitDefaultValue=false)]
        public int? PressureMb { get; set; }

        /// <summary>
        /// Gets or Sets PressureIn
        /// </summary>
        [DataMember(Name="pressure_in", EmitDefaultValue=false)]
        public decimal? PressureIn { get; set; }

        /// <summary>
        /// Gets or Sets PrecipMm
        /// </summary>
        [DataMember(Name="precip_mm", EmitDefaultValue=false)]
        public int? PrecipMm { get; set; }

        /// <summary>
        /// Gets or Sets PrecipIn
        /// </summary>
        [DataMember(Name="precip_in", EmitDefaultValue=false)]
        public int? PrecipIn { get; set; }

        /// <summary>
        /// Gets or Sets Humidity
        /// </summary>
        [DataMember(Name="humidity", EmitDefaultValue=false)]
        public int? Humidity { get; set; }

        /// <summary>
        /// Gets or Sets Cloud
        /// </summary>
        [DataMember(Name="cloud", EmitDefaultValue=false)]
        public int? Cloud { get; set; }

        /// <summary>
        /// Gets or Sets FeelslikeC
        /// </summary>
        [DataMember(Name="feelslike_c", EmitDefaultValue=false)]
        public int? FeelslikeC { get; set; }

        /// <summary>
        /// Gets or Sets FeelslikeF
        /// </summary>
        [DataMember(Name="feelslike_f", EmitDefaultValue=false)]
        public decimal? FeelslikeF { get; set; }

        /// <summary>
        /// Gets or Sets VisKm
        /// </summary>
        [DataMember(Name="vis_km", EmitDefaultValue=false)]
        public int? VisKm { get; set; }

        /// <summary>
        /// Gets or Sets VisMiles
        /// </summary>
        [DataMember(Name="vis_miles", EmitDefaultValue=false)]
        public int? VisMiles { get; set; }

        /// <summary>
        /// Gets or Sets Uv
        /// </summary>
        [DataMember(Name="uv", EmitDefaultValue=false)]
        public int? Uv { get; set; }

        /// <summary>
        /// Gets or Sets GustMph
        /// </summary>
        [DataMember(Name="gust_mph", EmitDefaultValue=false)]
        public decimal? GustMph { get; set; }

        /// <summary>
        /// Gets or Sets GustKph
        /// </summary>
        [DataMember(Name="gust_kph", EmitDefaultValue=false)]
        public decimal? GustKph { get; set; }

        /// <summary>
        /// Gets or Sets AirQuality
        /// </summary>
        [DataMember(Name="air_quality", EmitDefaultValue=false)]
        public CurrentAirQuality AirQuality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Current {\n");
            sb.Append("  LastUpdatedEpoch: ").Append(LastUpdatedEpoch).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  TempC: ").Append(TempC).Append("\n");
            sb.Append("  TempF: ").Append(TempF).Append("\n");
            sb.Append("  IsDay: ").Append(IsDay).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  WindMph: ").Append(WindMph).Append("\n");
            sb.Append("  WindKph: ").Append(WindKph).Append("\n");
            sb.Append("  WindDegree: ").Append(WindDegree).Append("\n");
            sb.Append("  WindDir: ").Append(WindDir).Append("\n");
            sb.Append("  PressureMb: ").Append(PressureMb).Append("\n");
            sb.Append("  PressureIn: ").Append(PressureIn).Append("\n");
            sb.Append("  PrecipMm: ").Append(PrecipMm).Append("\n");
            sb.Append("  PrecipIn: ").Append(PrecipIn).Append("\n");
            sb.Append("  Humidity: ").Append(Humidity).Append("\n");
            sb.Append("  Cloud: ").Append(Cloud).Append("\n");
            sb.Append("  FeelslikeC: ").Append(FeelslikeC).Append("\n");
            sb.Append("  FeelslikeF: ").Append(FeelslikeF).Append("\n");
            sb.Append("  VisKm: ").Append(VisKm).Append("\n");
            sb.Append("  VisMiles: ").Append(VisMiles).Append("\n");
            sb.Append("  Uv: ").Append(Uv).Append("\n");
            sb.Append("  GustMph: ").Append(GustMph).Append("\n");
            sb.Append("  GustKph: ").Append(GustKph).Append("\n");
            sb.Append("  AirQuality: ").Append(AirQuality).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Current);
        }

        /// <summary>
        /// Returns true if Current instances are equal
        /// </summary>
        /// <param name="input">Instance of Current to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Current input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastUpdatedEpoch == input.LastUpdatedEpoch ||
                    (this.LastUpdatedEpoch != null &&
                    this.LastUpdatedEpoch.Equals(input.LastUpdatedEpoch))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.TempC == input.TempC ||
                    (this.TempC != null &&
                    this.TempC.Equals(input.TempC))
                ) && 
                (
                    this.TempF == input.TempF ||
                    (this.TempF != null &&
                    this.TempF.Equals(input.TempF))
                ) && 
                (
                    this.IsDay == input.IsDay ||
                    (this.IsDay != null &&
                    this.IsDay.Equals(input.IsDay))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.WindMph == input.WindMph ||
                    (this.WindMph != null &&
                    this.WindMph.Equals(input.WindMph))
                ) && 
                (
                    this.WindKph == input.WindKph ||
                    (this.WindKph != null &&
                    this.WindKph.Equals(input.WindKph))
                ) && 
                (
                    this.WindDegree == input.WindDegree ||
                    (this.WindDegree != null &&
                    this.WindDegree.Equals(input.WindDegree))
                ) && 
                (
                    this.WindDir == input.WindDir ||
                    (this.WindDir != null &&
                    this.WindDir.Equals(input.WindDir))
                ) && 
                (
                    this.PressureMb == input.PressureMb ||
                    (this.PressureMb != null &&
                    this.PressureMb.Equals(input.PressureMb))
                ) && 
                (
                    this.PressureIn == input.PressureIn ||
                    (this.PressureIn != null &&
                    this.PressureIn.Equals(input.PressureIn))
                ) && 
                (
                    this.PrecipMm == input.PrecipMm ||
                    (this.PrecipMm != null &&
                    this.PrecipMm.Equals(input.PrecipMm))
                ) && 
                (
                    this.PrecipIn == input.PrecipIn ||
                    (this.PrecipIn != null &&
                    this.PrecipIn.Equals(input.PrecipIn))
                ) && 
                (
                    this.Humidity == input.Humidity ||
                    (this.Humidity != null &&
                    this.Humidity.Equals(input.Humidity))
                ) && 
                (
                    this.Cloud == input.Cloud ||
                    (this.Cloud != null &&
                    this.Cloud.Equals(input.Cloud))
                ) && 
                (
                    this.FeelslikeC == input.FeelslikeC ||
                    (this.FeelslikeC != null &&
                    this.FeelslikeC.Equals(input.FeelslikeC))
                ) && 
                (
                    this.FeelslikeF == input.FeelslikeF ||
                    (this.FeelslikeF != null &&
                    this.FeelslikeF.Equals(input.FeelslikeF))
                ) && 
                (
                    this.VisKm == input.VisKm ||
                    (this.VisKm != null &&
                    this.VisKm.Equals(input.VisKm))
                ) && 
                (
                    this.VisMiles == input.VisMiles ||
                    (this.VisMiles != null &&
                    this.VisMiles.Equals(input.VisMiles))
                ) && 
                (
                    this.Uv == input.Uv ||
                    (this.Uv != null &&
                    this.Uv.Equals(input.Uv))
                ) && 
                (
                    this.GustMph == input.GustMph ||
                    (this.GustMph != null &&
                    this.GustMph.Equals(input.GustMph))
                ) && 
                (
                    this.GustKph == input.GustKph ||
                    (this.GustKph != null &&
                    this.GustKph.Equals(input.GustKph))
                ) && 
                (
                    this.AirQuality == input.AirQuality ||
                    (this.AirQuality != null &&
                    this.AirQuality.Equals(input.AirQuality))
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
                if (this.LastUpdatedEpoch != null)
                    hashCode = hashCode * 59 + this.LastUpdatedEpoch.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.TempC != null)
                    hashCode = hashCode * 59 + this.TempC.GetHashCode();
                if (this.TempF != null)
                    hashCode = hashCode * 59 + this.TempF.GetHashCode();
                if (this.IsDay != null)
                    hashCode = hashCode * 59 + this.IsDay.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.WindMph != null)
                    hashCode = hashCode * 59 + this.WindMph.GetHashCode();
                if (this.WindKph != null)
                    hashCode = hashCode * 59 + this.WindKph.GetHashCode();
                if (this.WindDegree != null)
                    hashCode = hashCode * 59 + this.WindDegree.GetHashCode();
                if (this.WindDir != null)
                    hashCode = hashCode * 59 + this.WindDir.GetHashCode();
                if (this.PressureMb != null)
                    hashCode = hashCode * 59 + this.PressureMb.GetHashCode();
                if (this.PressureIn != null)
                    hashCode = hashCode * 59 + this.PressureIn.GetHashCode();
                if (this.PrecipMm != null)
                    hashCode = hashCode * 59 + this.PrecipMm.GetHashCode();
                if (this.PrecipIn != null)
                    hashCode = hashCode * 59 + this.PrecipIn.GetHashCode();
                if (this.Humidity != null)
                    hashCode = hashCode * 59 + this.Humidity.GetHashCode();
                if (this.Cloud != null)
                    hashCode = hashCode * 59 + this.Cloud.GetHashCode();
                if (this.FeelslikeC != null)
                    hashCode = hashCode * 59 + this.FeelslikeC.GetHashCode();
                if (this.FeelslikeF != null)
                    hashCode = hashCode * 59 + this.FeelslikeF.GetHashCode();
                if (this.VisKm != null)
                    hashCode = hashCode * 59 + this.VisKm.GetHashCode();
                if (this.VisMiles != null)
                    hashCode = hashCode * 59 + this.VisMiles.GetHashCode();
                if (this.Uv != null)
                    hashCode = hashCode * 59 + this.Uv.GetHashCode();
                if (this.GustMph != null)
                    hashCode = hashCode * 59 + this.GustMph.GetHashCode();
                if (this.GustKph != null)
                    hashCode = hashCode * 59 + this.GustKph.GetHashCode();
                if (this.AirQuality != null)
                    hashCode = hashCode * 59 + this.AirQuality.GetHashCode();
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
