using ApplicationLayer.Students.Commands;
using ApplicationLayer.Students.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.ServiceExtenstion
{
    public static class ServiceCollectionExtensions
    {
        public static void ApplicationService(this IServiceCollection services)
        {
            services.AddTransient<ICreateStudent, CreateStudent>();
            services.AddTransient<IEditStudent, EditStudent>();
            services.AddTransient<IEditStudent, EditStudent>();
            services.AddTransient<IGetAllStudents, GetAllStudents>();
            services.AddTransient<IGetStudentById, GetStudentById>();
            services.AddTransient<IDeleteStudent, DeleteStudent>();
        }
    }
}
