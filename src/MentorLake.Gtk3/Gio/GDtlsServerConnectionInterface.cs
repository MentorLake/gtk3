namespace MentorLake.Gio;

public class GDtlsServerConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GDtlsServerConnectionInterfaceExtensions
{

	public static GDtlsServerConnectionInterface Dereference(this GDtlsServerConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDtlsServerConnectionInterface>(x.DangerousGetHandle());
}
internal class GDtlsServerConnectionInterfaceExterns
{
}

public struct GDtlsServerConnectionInterface
{
	public GTypeInterface g_iface;
}
