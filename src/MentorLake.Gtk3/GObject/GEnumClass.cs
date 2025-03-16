namespace MentorLake.GObject;

public class GEnumClassHandle : BaseSafeHandle
{
}


public static class GEnumClassExtensions
{

	public static GEnumClass Dereference(this GEnumClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GEnumClass>(x.DangerousGetHandle());
}
internal class GEnumClassExterns
{
}

public struct GEnumClass
{
	public GTypeClass g_type_class;
	public int minimum;
	public int maximum;
	public uint n_values;
	public IntPtr values;
}
