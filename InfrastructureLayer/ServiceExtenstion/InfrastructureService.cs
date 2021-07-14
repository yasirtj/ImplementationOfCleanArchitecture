using ApplicationLayer.Students;
using ApplicationLayer.Students.Commands;
using InfrastructureLayer.Student;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.ServiceExtenstion
{
    public static class InfrastructureServices
    {
        public static void InfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();

        }
    }
}
