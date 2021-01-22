using Newtonsoft.Json;

namespace Securancy.Labs.KvkApi.Models
{
    public class SearchProfileParameters
    {
        /// <summary>
        /// KvK number, identifying number for a registration in the Netherlands Business Register. Consists of 8 digits
        /// </summary>
        public string KvkNumber { get; set; }

        /// <summary>
        /// Branche number (Vestigingsnummer), identifying number of a branch. Consists of 12 digits.
        /// </summary>
        public string BranchNumber { get; set; }

        /// <summary>
        /// RSIN is an identification number for legal entities and partnerships. Consist of only digits.
        /// </summary>
        public string Rsin { get; set; }

        /// <summary>
        /// Indication (true/false) to include searching through inactive dossiers/deregistered companies. Default is false. Note: History of inactive companies is after 1 January 2013.
        /// </summary>
        public bool? IncludeInactiveRegistrations { get; set; }

        /// <summary>
        /// Search is restricted to main branches. Default is false.
        /// </summary>
        public bool? RestrictToMainBranch { get; set; }

        /// <summary>
        /// User can optionally add a context to identify his result later on.
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// Free format text search for in the compiled search description.
        /// </summary>
        [JsonProperty("q")]
        public string Query { get; set; }
    }
}