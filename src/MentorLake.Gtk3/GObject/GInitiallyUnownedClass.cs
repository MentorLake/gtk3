namespace MentorLake.GObject;

public class GInitiallyUnownedClassHandle : BaseSafeHandle
{
}


public static class GInitiallyUnownedClassExtensions
{

	public static GInitiallyUnownedClass Dereference(this GInitiallyUnownedClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInitiallyUnownedClass>(x.DangerousGetHandle());
}
internal class GInitiallyUnownedClassExterns
{
}

public struct GInitiallyUnownedClass
{
	public GTypeClass g_type_class;
	public IntPtr constructor;
	public IntPtr set_property;
	public IntPtr get_property;
	public IntPtr dispose;
	public IntPtr finalize;
	public IntPtr dispatch_properties_changed;
	public IntPtr notify;
	public IntPtr constructed;
}
