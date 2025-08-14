namespace MentorLake.Gtk;


public class GtkRecentChooserIfaceHandle : BaseSafeHandle
{
}


public static class GtkRecentChooserIfaceExtensions
{

	public static GtkRecentChooserIface Dereference(this GtkRecentChooserIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentChooserIface>(x.DangerousGetHandle());
}
internal class GtkRecentChooserIfaceExterns
{
}


public struct GtkRecentChooserIface
{
	/// <summary>
/// <para>
/// Sets uri as the current URI for chooser.
/// </para>
/// </summary>

public IntPtr set_current_uri;
	/// <summary>
/// <para>
/// Gets the URI currently selected by chooser.
/// </para>
/// </summary>

public IntPtr get_current_uri;
	/// <summary>
/// <para>
/// Selects uri inside chooser.
/// </para>
/// </summary>

public IntPtr select_uri;
	/// <summary>
/// <para>
/// Unselects uri inside chooser.
/// </para>
/// </summary>

public IntPtr unselect_uri;
	/// <summary>
/// <para>
/// Selects all the items inside chooser, if the chooser
///    supports multiple selection.
/// </para>
/// </summary>

public IntPtr select_all;
	/// <summary>
/// <para>
/// Unselects all the items inside chooser.
/// </para>
/// </summary>

public IntPtr unselect_all;
	/// <summary>
/// <para>
/// Gets the list of recently used resources in form of
///    #GtkRecentInfo objects.
/// </para>
/// </summary>

public IntPtr get_items;
	/// <summary>
/// <para>
/// Gets the #GtkRecentManager used by chooser.
/// </para>
/// </summary>

public IntPtr get_recent_manager;
	/// <summary>
/// <para>
/// Adds filter to the list of #GtkRecentFilter objects
///    held by chooser.
/// </para>
/// </summary>

public IntPtr add_filter;
	/// <summary>
/// <para>
/// Removes filter from the list of #GtkRecentFilter
///    objects held by chooser.
/// </para>
/// </summary>

public IntPtr remove_filter;
	/// <summary>
/// <para>
/// Gets the #GtkRecentFilter objects held by chooser.
/// </para>
/// </summary>

public IntPtr list_filters;
	/// <summary>
/// <para>
/// Sets the comparison function used when sorting to
///    be sort_func.
/// </para>
/// </summary>

public IntPtr set_sort_func;
	/// <summary>
/// <para>
/// Signal emitted when the user “activates” a recent
///    item in the recent chooser.
/// </para>
/// </summary>

public IntPtr item_activated;
	/// <summary>
/// <para>
/// Signal emitted when there is a change in the
///    set of selected recently used resources.
/// </para>
/// </summary>

public IntPtr selection_changed;
}
