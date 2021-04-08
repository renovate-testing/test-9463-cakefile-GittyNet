using Aspenlaub.Net.GitHub.CSharp.GittyNet.Interfaces;
using Aspenlaub.Net.GitHub.CSharp.Pegh.Interfaces;

namespace Aspenlaub.Net.GitHub.CSharp.GittyNet {
    public class DotNetCakeInstaller : IDotNetCakeInstaller {
        public bool IsGlobalDotNetCakeInstalled(IErrorsAndInfos errorsAndInfos) {
            return true;
        }

        public void InstallGlobalDotNetCakeIfNecessary(IErrorsAndInfos errorsAndInfos) {
        }
    }
}
