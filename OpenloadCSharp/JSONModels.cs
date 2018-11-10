using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenloadCSharp {
	public class Response<TResult> {
		public int status;
		public string msg;
		public TResult result;
	}

	public struct AccountInfoResult {
		public string extid;
		public string email;
		public string signup_at;
		public int storage_left;
		public string storage_used;
		public struct Traffic {
			public int left;
			public int used_24h;
		}
		public Traffic traffic;
		public double balance;
	}
	public class AccountInfoResponse : Response<AccountInfoResult> { }

	public struct DownloadTicketResult {
		public string ticket;
		public string captcha_url;
		public int captcha_w;
		public int captcha_h;
		public int wait_time;
		public string valid_until;
	}
	public class DownloadTicketResponse : Response<DownloadTicketResult> { }

	public struct DownloadLinkResult {
		public string name;
		public int size;
		public string sha1;
		public string content_type;
		public string upload_at;
		public string url;
		public string token;
	}
	public class DownloadLinkResponse : Response<DownloadLinkResult> { }

	public struct FileInfoFile {
		public string id;
		public int status;
		public string name;
		public int size;
		public string sha1;
		public string content_type;
	}
	public class FileInfoResponse : Response<IDictionary<string, FileInfoFile>> { }

	public struct UploadResult {
		public string url;
		public string valid_until;
	}
	public class UploadResponse : Response<UploadResult> { }

	public struct AddRemoteUploadResult {
		public string id;
		public string folderid;
	}
	public class AddRemoteUploadResponse : Response<AddRemoteUploadResult> { }

	public struct RemoteUpload {
		public int id;
		public string remoteurl;
		public string status;
		public string bytes_loaded;
		public string bytes_total;
		public string folderid;
		public string added;
		public string last_update;
		public string extid;
		public string url;
	}
	public class CheckRemoteUploadResponse : Response<IDictionary<int, RemoteUpload>> { }

	public struct ListFolderResult {
		public struct Folder {
			public string id;
			public string name;
		}
		public Folder[] folders;

		public struct File {
			public string name;
			public string sha1;
			public string folderid;
			public string upload_at;
			public string status;
			public string size;
			public string content_type;
			public string download_count;
			public string cstatus;
			public string link;
			public string linkextid;
		}
		public File[] files;
	}
	public class ListFolderResponse : Response<ListFolderResult> { }

	public class ConvertingFilesResponse : Response<bool> { }

	public struct RunningConvertsResult {
		public string name;
		public string id;
		public string status;
		public string last_update;
		public double progress;
		public string retries;
		public string link;
		public string linkextid;
	}
	public class RunningConvertsResponse : Response<RunningConvertsResult> { }

	public class GetSplashResponse : Response<string> { }
}