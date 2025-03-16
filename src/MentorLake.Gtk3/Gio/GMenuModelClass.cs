namespace MentorLake.Gio;

public class GMenuModelClassHandle : BaseSafeHandle
{
}


public static class GMenuModelClassExtensions
{

	public static GMenuModelClass Dereference(this GMenuModelClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMenuModelClass>(x.DangerousGetHandle());
}
internal class GMenuModelClassExterns
{
}

public struct GMenuModelClass
{
	public GObjectClass parent_class;
	public IntPtr is_mutable;
	public IntPtr get_n_items;
	public IntPtr get_item_attributes;
	public IntPtr iterate_item_attributes;
	public IntPtr get_item_attribute_value;
	public IntPtr get_item_links;
	public IntPtr iterate_item_links;
	public IntPtr get_item_link;
}
