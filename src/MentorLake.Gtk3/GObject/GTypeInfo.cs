namespace MentorLake.GObject;

public class GTypeInfoHandle : BaseSafeHandle
{
}


public static class GTypeInfoExtensions
{

	public static GTypeInfo Dereference(this GTypeInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeInfo>(x.DangerousGetHandle());
}
internal class GTypeInfoExterns
{
}

public struct GTypeInfo
{
	public ushort class_size;
	public GBaseInitFunc base_init;
	public GBaseFinalizeFunc base_finalize;
	public GClassInitFunc class_init;
	public GClassFinalizeFunc class_finalize;
	public IntPtr class_data;
	public ushort instance_size;
	public ushort n_preallocs;
	public GInstanceInitFunc instance_init;
	public IntPtr value_table;
}
