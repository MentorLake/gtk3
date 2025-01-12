namespace MentorLake.Gtk3.GObject;

public class GTypeValueTableHandle : BaseSafeHandle
{
}


public static class GTypeValueTableHandleExtensions
{
	public static GTypeValueTableHandle Peek(GType type)
	{
		return GTypeValueTableExterns.g_type_value_table_peek(type);
	}

}
internal class GTypeValueTableExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GTypeValueTableHandle g_type_value_table_peek(GType type);

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
}
