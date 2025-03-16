namespace MentorLake.Gio;

public class GListModelInterfaceHandle : BaseSafeHandle
{
}


public static class GListModelInterfaceExtensions
{

	public static GListModelInterface Dereference(this GListModelInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GListModelInterface>(x.DangerousGetHandle());
}
internal class GListModelInterfaceExterns
{
}

public struct GListModelInterface
{
	public GTypeInterface g_iface;
	public IntPtr get_item_type;
	public IntPtr get_n_items;
	public IntPtr get_item;
}
