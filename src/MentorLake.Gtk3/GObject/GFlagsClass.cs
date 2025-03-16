namespace MentorLake.GObject;

public class GFlagsClassHandle : BaseSafeHandle
{
}


public static class GFlagsClassExtensions
{

	public static GFlagsClass Dereference(this GFlagsClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFlagsClass>(x.DangerousGetHandle());
}
internal class GFlagsClassExterns
{
}

public struct GFlagsClass
{
	public GTypeClass g_type_class;
	public uint mask;
	public uint n_values;
	public IntPtr values;
}
