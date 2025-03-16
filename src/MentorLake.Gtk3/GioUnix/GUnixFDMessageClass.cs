namespace MentorLake.GioUnix;

public class GUnixFDMessageClassHandle : BaseSafeHandle
{
}


public static class GUnixFDMessageClassExtensions
{

	public static GUnixFDMessageClass Dereference(this GUnixFDMessageClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixFDMessageClass>(x.DangerousGetHandle());
}
internal class GUnixFDMessageClassExterns
{
}

public struct GUnixFDMessageClass
{
	public GSocketControlMessageClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
}
