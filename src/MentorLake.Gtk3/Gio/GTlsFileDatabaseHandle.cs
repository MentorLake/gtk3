namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GTlsFileDatabase` is implemented by [class@Gio.TlsDatabase] objects which
/// load their certificate information from a file. It is an interface which
/// TLS library specific subtypes implement.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Creates a new #GTlsFileDatabase which uses anchor certificate authorities
/// in @anchors to verify certificate chains.
/// </para>
/// <para>
/// The certificates in @anchors must be PEM encoded.
/// </para>
/// </summary>

/// <param name="anchors">
/// filename of anchor certificate authorities.
/// </param>
/// <return>
/// the new
/// #GTlsFileDatabase, or %NULL on error
/// </return>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle g_tls_file_database_new(string anchors, out MentorLake.GLib.GErrorHandle error);

}
