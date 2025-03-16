namespace MentorLake.Gio;

public class GDtlsClientConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GDtlsClientConnectionInterfaceExtensions
{

	public static GDtlsClientConnectionInterface Dereference(this GDtlsClientConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDtlsClientConnectionInterface>(x.DangerousGetHandle());
}
internal class GDtlsClientConnectionInterfaceExterns
{
}

public struct GDtlsClientConnectionInterface
{
	public GTypeInterface g_iface;
}
