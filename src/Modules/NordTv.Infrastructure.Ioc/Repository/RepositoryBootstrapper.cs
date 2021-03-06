﻿using Microsoft.Extensions.DependencyInjection;
using NordTv.Domain.Interfaces.Repositories;
using NordTv.Infrastructure.Repositories;


namespace NordTv.Infrastructure.Ioc.Repository
{
    internal class RepositoryBootstrapper
    {
        internal void ChildRegisterService(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<IWorkRepository, WorkRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
        }
    }
}
