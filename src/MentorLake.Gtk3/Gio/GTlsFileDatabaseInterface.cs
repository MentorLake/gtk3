namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface for #GTlsFileDatabase implementations.
/// </para>
/// </summary>

public class GTlsFileDatabaseInterfaceHandle : BaseSafeHandle
{
}


public static class GTlsFileDatabaseInterfaceExtensions
{

	public static GTlsFileDatabaseInterface Dereference(this GTlsFileDatabaseInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsFileDatabaseInterface>(x.DangerousGetHandle());
}
internal class GTlsFileDatabaseInterfaceExterns
{
}

/// <summary>
/// <para>
/// Provides an interface for #GTlsFileDatabase implementations.
/// </para>
/// </summary>

public struct GTlsFileDatabaseInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
}
