using Octokit;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Updater
{
    private const string OWNER = "gudtldn";
    private const string REPO = "CustomerManagement";
    public static string CURRENT_VERSION
    {
        get
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            return "v" + fvi.FileVersion;
        }
    }

    public async Task CheckAndUpdate()
    {
        var github = new GitHubClient(new ProductHeaderValue("CustomerManagement"));
        var releases = await github.Repository.Release.GetAll(OWNER, REPO);

        var latestRelease = releases[0]; // 가장 최신 릴리스

        int latestReleaseVersion = int.Parse(latestRelease.TagName.Substring(1));
        int currentVersion = int.Parse(CURRENT_VERSION.Substring(1));
        if (latestReleaseVersion > currentVersion)
        {
            // 새 버전이 있다면
            var asset = latestRelease.Assets.FirstOrDefault(a => a.Name.EndsWith(".zip"));
            if (asset != null)
            {
                await DownloadAndUpdate(asset.BrowserDownloadUrl);
            }
        }
    }

    private async Task DownloadAndUpdate(string downloadUrl)
    {
        using (var client = new System.Net.WebClient())
        {
            string tempPath = Path.GetTempFileName();
            await client.DownloadFileTaskAsync(downloadUrl, tempPath);

            string extractPath = Path.Combine(Path.GetTempPath(), "UpdateExtract");
            ZipFile.ExtractToDirectory(tempPath, extractPath);

            // TODO: msi 사용해서 설치
            // Directory.Move(extractPath, System.Windows.Forms.Application.StartupPath);

            File.Delete(tempPath);
            Directory.Delete(extractPath, true);
        }

        MessageBox.Show("업데이트가 완료되었습니다. 프로그램을 재시작합니다.", "업데이트 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // 업데이트 완료 후 프로그램 재시작
        System.Windows.Forms.Application.Restart();
        Environment.Exit(0);
    }
}
