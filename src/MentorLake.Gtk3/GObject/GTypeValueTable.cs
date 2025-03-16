namespace MentorLake.GObject;

public class GTypeValueTableHandle : BaseSafeHandle
{
}


public static class GTypeValueTableExtensions
{

	public static GTypeValueTable Dereference(this GTypeValueTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeValueTable>(x.DangerousGetHandle());
}
internal class GTypeValueTableExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GTypeValueTableHandle g_type_value_table_peek(MentorLake.GObject.GType type);

}

public struct GTypeValueTable
{
	public GTypeValueInitFunc value_init;
	public GTypeValueFreeFunc value_free;
	public GTypeValueCopyFunc value_copy;
	public GTypeValuePeekPointerFunc value_peek_pointer;
	public string collect_format;
	public GTypeValueCollectFunc collect_value;
	public string lcopy_format;
	public GTypeValueLCopyFunc lcopy_value;
	public static MentorLake.GObject.GTypeValueTableHandle Peek(MentorLake.GObject.GType type)
	{
		return GTypeValueTableExterns.g_type_value_table_peek(type);
	}

}
