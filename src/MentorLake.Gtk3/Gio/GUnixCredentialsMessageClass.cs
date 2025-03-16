namespace MentorLake.Gio;

public class GUnixCredentialsMessageClassHandle : BaseSafeHandle
{
}


public static class GUnixCredentialsMessageClassExtensions
{

	public static GUnixCredentialsMessageClass Dereference(this GUnixCredentialsMessageClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixCredentialsMessageClass>(x.DangerousGetHandle());
}
internal class GUnixCredentialsMessageClassExterns
{
}

public struct GUnixCredentialsMessageClass
{
	public GSocketControlMessageClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
}
