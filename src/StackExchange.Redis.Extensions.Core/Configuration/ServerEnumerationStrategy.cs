using System;
using System.Configuration;

namespace StackExchange.Redis.Extensions.Core.Configuration
{
	public class ServerEnumerationStrategy
	{
		public enum ModeOptions
		{
			All = 0,
			Single
		}

		public enum TargetRoleOptions
		{
			Any = 0,
			PreferSlave
		}

		public enum UnreachableServerActionOptions
		{
			Throw = 0,
			IgnoreIfOtherAvailable
		}
         
	    public ModeOptions Mode { get; set; } = ModeOptions.All;
	    public TargetRoleOptions TargetRole { get; set; } = TargetRoleOptions.Any;

	    public UnreachableServerActionOptions UnreachableServerAction { get; set; } = UnreachableServerActionOptions.Throw;
	}
}
