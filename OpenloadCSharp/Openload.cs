using System.Net;
using Newtonsoft.Json;

namespace OpenloadCSharp {
	public class Openload {
		private static string login;
		private static string key;

		public static void Authenticate(string login, string key) {
			Openload.login = login;
			Openload.key = key;
		}
		public static void Deauthenticate() {
			login = null;
			key = null;
		}
		public static bool Authenticated() {
			return login != null && key != null;
		}

		public static AccountInfoResponse AccountInfo() {
			return Request<AccountInfoResponse>($"account/info?login={login}&key={key}");
		}
		public static DownloadTicketResponse DownloadTicket(string file) {
			return Request<DownloadTicketResponse>($"file/dlticket?{ new ParamsBuilder { { "file", file }, { "login", login }, { "key", key } } }");
		}
		public static DownloadLinkResponse DownloadLink(string file, string ticket, string captcha_response) {
			return Request<DownloadLinkResponse>($"file/dl?{ new ParamsBuilder { { "file", file }, { "ticket", ticket }, { "captcha_response", captcha_response } } }");
		}
		public static DownloadLinkResponse DownloadLink(string file, string ticket) {

			return Request<DownloadLinkResponse>($"file/dl?{ new ParamsBuilder { { "file", file }, { "ticket", ticket } } }");
		}
		public static FileInfoResponse FileInfo(params string[] file) {
			string fileids = string.Join(",", file);
			return Request<FileInfoResponse>($"file/info?{ new ParamsBuilder { { "file", fileids }, { "login", login }, { "key", key } } }");
		}
		public static UploadResponse Upload(int? folder = null, string sha1 = null, string httponly = null) {
			return Request<UploadResponse>($"file/ul?{ new ParamsBuilder { { "login", login }, { "key", key }, { "folder", folder }, { "sha1", sha1 }, { "httponly", httponly } } }");
		}
		public static AddRemoteUploadResponse AddRemoteUpload(string url, int? folder = null, string headers = null) {
			return Request<AddRemoteUploadResponse>($"remotedl/add?{ new ParamsBuilder { { "login", login }, { "key", key }, { "url", url }, { "folder", folder }, { "headers", headers } } }");
		}
		public static CheckRemoteUploadResponse CheckRemoteUpload(int? limit = null, int? id = null) {
			return Request<CheckRemoteUploadResponse>($"remotedl/status?{ new ParamsBuilder { { "login", login }, { "key", key }, { "limit", limit }, { "id", id } } }");
		}
		public static ListFolderResponse ListFolder(int? folder = null) {
			return Request<ListFolderResponse>($"file/listfolder?{ new ParamsBuilder { { "login", login }, { "key", key }, { "folder", folder } } }");
		}
		public static ConvertingFilesResponse ConvertingFiles(string file) {
			return Request<ConvertingFilesResponse>($"file/convert?{ new ParamsBuilder { { "login", login }, { "key", key }, { "file", file } } }");
		}
		public static RunningConvertsResponse RunningConverts(int? folder = null) {
			return Request<RunningConvertsResponse>($"file/listfolder?{ new ParamsBuilder { { "login", login }, { "key", key }, { "folder", folder } } }");
		}
		public static GetSplashResponse GetSplash(string file) {
			return Request<GetSplashResponse>($"file/convert?{ new ParamsBuilder { { "login", login }, { "key", key }, { "file", file } } }");
		}

		private static TResponse Request<TResponse>(string request) {
			using (WebClient wc = new WebClient()) {
				string json = wc.DownloadString("https://api.openload.co/1/" + request);
				return JsonConvert.DeserializeObject<TResponse>(json);
			}
		}
	}
}