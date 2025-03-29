namespace MentorLake.Gio;

public interface GTlsFileDatabaseHandle
{
}

internal class GTlsFileDatabaseHandleImpl : BaseSafeHandle, GTlsFileDatabaseHandle
{
}

public static class GTlsFileDatabaseHandleExtensions
{
	public static MentorLake.Gio.GTlsDatabaseHandle New(string anchors, IntPtr error)
	{
		return GTlsFileDatabaseHandleExterns.g_tls_file_database_new(anchors, error);
	}

}

internal class GTlsFileDatabaseHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle g_tls_file_database_new(string anchors, IntPtr error);

}
