namespace MentorLake.Gtk3.Gio;

public interface GTlsFileDatabaseHandle
{
}

internal class GTlsFileDatabaseHandleImpl : BaseSafeHandle, GTlsFileDatabaseHandle
{
}

public static class GTlsFileDatabaseHandleExtensions
{
	public static GTlsDatabaseHandle New(string anchors, out GErrorHandle error)
	{
		return GTlsFileDatabaseExterns.g_tls_file_database_new(anchors, out error);
	}

}

internal class GTlsFileDatabaseExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GTlsDatabaseHandle g_tls_file_database_new(string anchors, out GErrorHandle error);

}
