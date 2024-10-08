﻿using MediatrCRUDService.Application.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using System.Reflection;
using System.Globalization;
using MediatR;
using MediatrCRUDService.Application.Beheviors;
using MediatrCRUDService.Application.Bases;

namespace MediatrCRUDService.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddTransient<ExceptionMiddleware>();
            services.AddRulesFromAssemblyContaining(assembly, typeof(BaseRules));
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));
            services.AddValidatorsFromAssembly(assembly);
            
            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehevior<,>));
        }
        private static IServiceCollection AddRulesFromAssemblyContaining(this IServiceCollection services, Assembly assembly, Type type)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();

            foreach (var item in types)
            {
                services.AddTransient(item);
            }
            return services;
        }
    }
}
