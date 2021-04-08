using Aspenlaub.Net.GitHub.CSharp.Pegh.Interfaces;

namespace Aspenlaub.Net.GitHub.CSharp.GittyNet.Interfaces {
    public interface IDotNetCakeInstaller {
        bool IsGlobalDotNetCakeInstalled(IErrorsAndInfos errorsAndInfos);
        void InstallGlobalDotNetCakeIfNecessary(IErrorsAndInfos errorsAndInfos);
    }
}
