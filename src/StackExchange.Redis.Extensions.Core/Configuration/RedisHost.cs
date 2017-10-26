using System;
using System.Configuration;

namespace StackExchange.Redis.Extensions.Core.Configuration
{
	/// <summary>
	/// Configuration element for Redis Host
	/// </summary>
	public class RedisHost
	{
		/// <summary>
		/// Gets the Redis host.
		/// </summary>
		/// <value>
		/// The host.
		/// </value>
		public string Host { get; set; }

		/// <summary>
		/// Gets the port.
		/// </summary>
		/// <value>
		/// The port.
		/// </value> 
		public int CachePort { get; set; }
	}
}