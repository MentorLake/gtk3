namespace MentorLake.GObject;

public class GParamSpecTypeInfoHandle : BaseSafeHandle
{
}


public static class GParamSpecTypeInfoExtensions
{

	public static GParamSpecTypeInfo Dereference(this GParamSpecTypeInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GParamSpecTypeInfo>(x.DangerousGetHandle());
}
internal class GParamSpecTypeInfoExterns
{
}

public struct GParamSpecTypeInfo
{
	public ushort instance_size;
	public ushort n_preallocs;
	public IntPtr instance_init;
	public GType value_type;
	public IntPtr finalize;
	public IntPtr value_set_default;
	public IntPtr value_validate;
	public IntPtr values_cmp;
}
