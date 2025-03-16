namespace MentorLake.Gio;

public class GConverterIfaceHandle : BaseSafeHandle
{
}


public static class GConverterIfaceExtensions
{

	public static GConverterIface Dereference(this GConverterIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GConverterIface>(x.DangerousGetHandle());
}
internal class GConverterIfaceExterns
{
}

public struct GConverterIface
{
	public GTypeInterface g_iface;
	public IntPtr convert;
	public IntPtr reset;
}
