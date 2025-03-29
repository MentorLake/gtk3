namespace MentorLake.Gio;

public interface GTlsFileDatabaseHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GTlsFileDatabaseHandleImpl : BaseSafeHandle, GTlsFileDatabaseHandle
{
}

public static class GTlsFileDatabaseHandleExtensions
{
	public static MentorLake.Gio.GTlsDatabaseHandle New(string anchors)
	{
		var externCallResult = GTlsFileDatabaseHandleExterns.g_tls_file_database_new(anchors, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GTlsFileDatabaseHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle g_tls_file_database_new(string anchors, out MentorLake.GLib.GErrorHandle error);

}
