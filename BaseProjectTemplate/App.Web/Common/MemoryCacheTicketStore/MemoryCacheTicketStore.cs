using App.Web.WebConfig;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace App.Web.Common.MemoryCacheTicketStore
{
	public class MemoryCacheTicketStore : ITicketStore
	{
		private IMemoryCache _cache;
		public MemoryCacheTicketStore()
		{
			_cache = new MemoryCache(new MemoryCacheOptions());
		}

		public async Task ClearAll()
		{
			_cache.Dispose();
			_cache = new MemoryCache(new MemoryCacheOptions());
		}

		public async Task<string> StoreAsync(AuthenticationTicket ticket)
		{
			var key = ticket.Principal.FindFirstValue(ClaimTypes.NameIdentifier);
			await RenewAsync(key, ticket);
			return key;
		}

		public Task RenewAsync(string key, AuthenticationTicket ticket)
		{
			var options = new MemoryCacheEntryOptions();
			var expiresUtc = ticket.Properties.ExpiresUtc;
			if (expiresUtc.HasValue)
			{
				options.SetAbsoluteExpiration(expiresUtc.Value);
			}
			options.SetSlidingExpiration(TimeSpan.FromHours(1)); // TODO: configurable.

			_cache.Set(key, ticket, options);

			return Task.FromResult(0);
		}

		public Task<AuthenticationTicket> RetrieveAsync(string key)
		{
			AuthenticationTicket ticket;
			_cache.TryGetValue(key, out ticket);
			return Task.FromResult(ticket);
		}

		public Task RemoveAsync(string key)
		{
			_cache.Remove(key);
			return Task.FromResult(0);
		}
	}
}
