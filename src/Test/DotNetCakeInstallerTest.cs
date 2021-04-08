using Aspenlaub.Net.GitHub.CSharp.GittyNet.Interfaces;
using Aspenlaub.Net.GitHub.CSharp.Pegh.Components;
using Aspenlaub.Net.GitHub.CSharp.Pegh.Entities;
using Aspenlaub.Net.GitHub.CSharp.Pegh.Extensions;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspenlaub.Net.GitHub.CSharp.GittyNet.Test {
    [TestClass]
    public class DotNetCakeInstallerTest {
        protected IDotNetCakeInstaller Sut;

        [TestInitialize]
        public void Initialize() {
            var container = new ContainerBuilder().UseGittyAndPegh(new DummyCsArgumentPrompter()).Build();
            Sut = container.Resolve<IDotNetCakeInstaller>();
        }

        [TestMethod]
        public void CanInstallGlobalDotNetCakeIfNecessary() {
            var errorsAndInfos = new ErrorsAndInfos();
            Sut.InstallGlobalDotNetCakeIfNecessary(errorsAndInfos);
            Assert.IsFalse(errorsAndInfos.AnyErrors(), errorsAndInfos.ErrorsToString());
        }

        [TestMethod]
        public void GlobalDotNetCakeIsInstalled() {
            var errorsAndInfos = new ErrorsAndInfos();
            Assert.IsTrue(Sut.IsGlobalDotNetCakeInstalled(errorsAndInfos));
            Assert.IsFalse(errorsAndInfos.AnyErrors(), errorsAndInfos.ErrorsToString());
        }
    }
}
