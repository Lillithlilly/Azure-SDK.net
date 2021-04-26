namespace Azure.AI.TextAnalytics.Protocol
{
    public partial class TextAnalyticsClient
    {
        protected TextAnalyticsClient() { }
        public TextAnalyticsClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public TextAnalyticsClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.Core.ProtocolClientOptions options) { }
        public virtual System.Uri Endpoint { get { throw null; } }
        public virtual Azure.Core.DynamicResponse GetEntities(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicResponse GetEntities(dynamic body, string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetEntitiesAsync(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetEntitiesAsync(dynamic body, string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicResponse GetEntitiesPii(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), string domain = null, string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicResponse GetEntitiesPii(dynamic body, string modelVersion = null, bool? showStats = default(bool?), string domain = null, string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetEntitiesPiiAsync(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), string domain = null, string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetEntitiesPiiAsync(dynamic body, string modelVersion = null, bool? showStats = default(bool?), string domain = null, string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicRequest GetEntitiesPiiRequest(string modelVersion = null, bool? showStats = default(bool?), string domain = null, string stringIndexType = null) { throw null; }
        public virtual Azure.Core.DynamicRequest GetEntitiesRequest(string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null) { throw null; }
        public virtual Azure.Core.DynamicResponse GetKeyPhrases(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicResponse GetKeyPhrases(dynamic body, string modelVersion = null, bool? showStats = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetKeyPhrasesAsync(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetKeyPhrasesAsync(dynamic body, string modelVersion = null, bool? showStats = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicRequest GetKeyPhrasesRequest(string modelVersion = null, bool? showStats = default(bool?)) { throw null; }
        public virtual Azure.Core.DynamicResponse GetLanguages(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicResponse GetLanguages(dynamic body, string modelVersion = null, bool? showStats = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetLanguagesAsync(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetLanguagesAsync(dynamic body, string modelVersion = null, bool? showStats = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicRequest GetLanguagesRequest(string modelVersion = null, bool? showStats = default(bool?)) { throw null; }
        public virtual Azure.Core.DynamicResponse GetLinkedEntities(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicResponse GetLinkedEntities(dynamic body, string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetLinkedEntitiesAsync(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetLinkedEntitiesAsync(dynamic body, string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicRequest GetLinkedEntitiesRequest(string modelVersion = null, bool? showStats = default(bool?), string stringIndexType = null) { throw null; }
        public virtual Azure.Core.DynamicResponse GetSentiment(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), bool? opinionMining = false, string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicResponse GetSentiment(dynamic body, string modelVersion = null, bool? showStats = default(bool?), bool? opinionMining = false, string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetSentimentAsync(Azure.Core.JsonData body, string modelVersion = null, bool? showStats = default(bool?), bool? opinionMining = default(bool?), string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Core.DynamicResponse> GetSentimentAsync(dynamic body, string modelVersion = null, bool? showStats = default(bool?), bool? opinionMining = false, string stringIndexType = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Core.DynamicRequest GetSentimentRequest(string modelVersion = null, bool? showStats = default(bool?), bool? opinionMining = false, string stringIndexType = null) { throw null; }
    }
}