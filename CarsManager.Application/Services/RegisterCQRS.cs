﻿
using CarsManager.Application.Cqrs.Queries;

namespace CarsManager.Application.Services;
public static class RegisterCqrs
{
    public static IServiceCollection AddCqrs(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllCarReservationsQuery).Assembly));
        return services;
    }
}