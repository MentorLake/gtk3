namespace MentorLake.Gio;

public class GTlsServerConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GTlsServerConnectionInterfaceExtensions
{

	public static GTlsServerConnectionInterface Dereference(this GTlsServerConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsServerConnectionInterface>(x.DangerousGetHandle());
}
internal class GTlsServerConnectionInterfaceExterns
{
}

public struct GTlsServerConnectionInterface
{
	public GTypeInterface g_iface;
}
