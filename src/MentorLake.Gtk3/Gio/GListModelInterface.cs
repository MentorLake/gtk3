namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The virtual function table for #GListModel.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The virtual function table for #GListModel.
/// </para>
/// </summary>

public struct GListModelInterface
{
	/// <summary>
/// <para>
/// parent #GTypeInterface
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// the virtual function pointer for g_list_model_get_item_type()
/// </para>
/// </summary>

public IntPtr get_item_type;
	/// <summary>
/// <para>
/// the virtual function pointer for g_list_model_get_n_items()
/// </para>
/// </summary>

public IntPtr get_n_items;
	/// <summary>
/// <para>
/// the virtual function pointer for g_list_model_get_item()
/// </para>
/// </summary>

public IntPtr get_item;
}
