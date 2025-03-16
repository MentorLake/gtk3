namespace MentorLake.Gio;

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

public struct GTlsFileDatabaseInterface
{
	public GTypeInterface g_iface;
}
