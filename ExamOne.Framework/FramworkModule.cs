using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Module = Autofac.Module;

namespace ExamOne.Framework
{
    public class FramworkModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        public FramworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Student>().As<Student>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<Subject>().As<Subject>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<Grade>().As<Grade>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<FrameworkContext>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<FrameworkContext>().As<IFrameworkContext>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<GradeUnitOfWork>().As<IGradeUnitOfWork>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SubjectRepository>().As<ISubjectRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<IStudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<GradeRepository>().As<IGradeRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<GradeRepository>().As<IGradeRepository>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
