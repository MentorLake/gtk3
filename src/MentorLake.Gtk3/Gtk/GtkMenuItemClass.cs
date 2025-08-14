namespace MentorLake.Gtk;


public class GtkMenuItemClassHandle : BaseSafeHandle
{
}


public static class GtkMenuItemClassExtensions
{

	public static GtkMenuItemClass Dereference(this GtkMenuItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuItemClass>(x.DangerousGetHandle());
}
internal class GtkMenuItemClassExterns
{
}


public struct GtkMenuItemClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBinClass parent_class;
	/// <summary>
/// <para>
/// If %TRUE, then we should always
///    hide the menu when the %GtkMenuItem is activated. Otherwise,
///    it is up to the caller.
/// </para>
/// </summary>

public uint hide_on_activate;
	/// <summary>
/// <para>
/// Signal emitted when the item is activated.
/// </para>
/// </summary>

public IntPtr activate;
	/// <summary>
/// <para>
/// Signal emitted when the item is activated, but also
///    if the menu item has a submenu.
/// </para>
/// </summary>

public IntPtr activate_item;
	
public IntPtr toggle_size_request;
	
public IntPtr toggle_size_allocate;
	/// <summary>
/// <para>
/// Sets @text on the #GtkMenuItem label
/// </para>
/// </summary>

public IntPtr set_label;
	/// <summary>
/// <para>
/// Gets @text from the #GtkMenuItem label
/// </para>
/// </summary>

public IntPtr get_label;
	/// <summary>
/// <para>
/// Signal emitted when the item is selected.
/// </para>
/// </summary>

public IntPtr select;
	/// <summary>
/// <para>
/// Signal emitted when the item is deselected.
/// </para>
/// </summary>

public IntPtr deselect;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
