using Newtonsoft.Json;

namespace Vainglory_CSharp.Model.Player
{
    /// <summary>
    /// The PlayerRelationships class
    /// Contains the Objects for the data under the relationships node when getting players from url.
    /// </summary>
    public class PlayerRelationships
    {
        /// <summary>
        /// Gets or sets Assests
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty assets</para>
        /// </remarks>
        /// See <see cref="Assets"/>
        [JsonProperty("assets")]
        public AssetsData Assets { get; set; }
    }
}