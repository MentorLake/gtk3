namespace MentorLake.GObject;

public class GParamSpecClassHandle : BaseSafeHandle
{
}


public static class GParamSpecClassExtensions
{

	public static GParamSpecClass Dereference(this GParamSpecClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GParamSpecClass>(x.DangerousGetHandle());
}
internal class GParamSpecClassExterns
{
}

public struct GParamSpecClass
{
	public GTypeClass g_type_class;
	public GType value_type;
	public IntPtr finalize;
	public IntPtr value_set_default;
	public IntPtr value_validate;
	public IntPtr values_cmp;
	public IntPtr value_is_valid;
}
