using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace StackExchange.Redis.Extensions.Core.Configuration
{
	/// <summary>
	/// The implementation of <see cref="IRedisCachingConfiguration"/>
	/// </summary>
	public class RedisCachingSectionHandler : IRedisCachingConfiguration
	{
	    /// <summary>
	    /// The host of Redis Server
	    /// </summary>
	    /// <value>
	    /// The ip or name
	    /// </value>
	    //[ConfigurationProperty("hosts")]
	    public RedisHost[] Hosts { get; private set; }

	    /// <summary>
		/// The strategy to use when executing server wide commands
		/// </summary> 
		public ServerEnumerationStrategy ServerEnumerationStrategy { get; private set; }

		/// <summary>
		/// Specify if the connection can use Admin commands like flush database
		/// </summary>
		/// <value>
		///   <c>true</c> if can use admin commands; otherwise, <c>false</c>.
		/// </value> 
		public bool AllowAdmin { get; private set; }
		/// <summary>
		/// Specify if the connection is a secure connection or not.
		/// </summary>
		/// <value>
		///   <c>true</c> if is secure; otherwise, <c>false</c>.
		/// </value> 
		public bool Ssl { get; private set; }

	    /// <summary>
	    /// The connection timeout
	    /// </summary> 
	    public int ConnectTimeout { get; private set; } = 5000;

		/// <summary>
		/// If true, Connect will not create a connection while no servers are available
		/// </summary> 
		public bool AbortOnConnectFail { get; private set; }

		/// <summary>
		/// Database Id
		/// </summary>
		/// <value>
		/// The database id, the default value is 0
		/// </value> 
		public int Database { get; private set; }

		/// <summary>
		/// The password or access key
		/// </summary> 
		public string Password { get; private set; }

        /// <summary>
        /// The key separation prefix used for all cache entries
        /// </summary> 
        public string KeyPrefix { get; private set; }

	    /// <summary>
	    /// Gets the configuration.
	    /// </summary>
	    /// <returns></returns>
	    public static RedisCachingSectionHandler GetConfig(IConfigurationRoot config)
	    {
	        RedisCachingSectionHandler handler = new RedisCachingSectionHandler();
            config.GetSection("redisCacheClient").Bind(handler);
	        return handler;
	    }
	}
}