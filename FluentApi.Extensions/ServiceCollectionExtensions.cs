using FluentJwt = FluentApi.Extensions.Jwt;
using Microsoft.Extensions.DependencyInjection;

namespace FluentApi.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static FluentJwt.IJwt AddJwt(this IServiceCollection services)
		{
			return new FluentJwt.Jwt(services);
		}
	}
}
