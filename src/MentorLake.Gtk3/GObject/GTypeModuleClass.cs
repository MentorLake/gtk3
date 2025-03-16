namespace MentorLake.GObject;

public class GTypeModuleClassHandle : BaseSafeHandle
{
}


public static class GTypeModuleClassExtensions
{

	public static GTypeModuleClass Dereference(this GTypeModuleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeModuleClass>(x.DangerousGetHandle());
}
internal class GTypeModuleClassExterns
{
}

public struct GTypeModuleClass
{
	public GObjectClass parent_class;
	public IntPtr load;
	public IntPtr unload;
	public IntPtr reserved1;
	public IntPtr reserved2;
	public IntPtr reserved3;
	public IntPtr reserved4;
}
