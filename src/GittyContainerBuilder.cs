using Aspenlaub.Net.GitHub.CSharp.GittyNet.Components;
using Aspenlaub.Net.GitHub.CSharp.GittyNet.Interfaces;
using Aspenlaub.Net.GitHub.CSharp.Pegh.Components;
using Aspenlaub.Net.GitHub.CSharp.Pegh.Interfaces;
using Aspenlaub.Net.GitHub.CSharp.PeghCore;
using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace Aspenlaub.Net.GitHub.CSharp.GittyNet {
    public static class GittyContainerBuilder {
        public static ContainerBuilder UseGittyAndPegh(this ContainerBuilder builder, ICsArgumentPrompter csArgumentPrompter) {
            builder.UsePegh(csArgumentPrompter);
            builder.RegisterType<DotNetCakeInstaller>().As<IDotNetCakeInstaller>();
            builder.RegisterType<ProcessRunner>().As<IProcessRunner>();

            return builder;
        }

        // ReSharper disable once UnusedMember.Global
        public static IServiceCollection UseGittyAndPegh(this IServiceCollection services, ICsArgumentPrompter csArgumentPrompter) {
            services.UsePegh(csArgumentPrompter);
            services.AddTransient<IDotNetCakeInstaller, DotNetCakeInstaller>();
            services.AddTransient<IProcessRunner, ProcessRunner>();

            return services;
        }
    }
}