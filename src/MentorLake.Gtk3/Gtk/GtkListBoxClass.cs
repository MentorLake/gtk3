namespace MentorLake.Gtk;


public class GtkListBoxClassHandle : BaseSafeHandle
{
}


public static class GtkListBoxClassExtensions
{

	public static GtkListBoxClass Dereference(this GtkListBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkListBoxClass>(x.DangerousGetHandle());
}
internal class GtkListBoxClassExterns
{
}


public struct GtkListBoxClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkContainerClass parent_class;
	/// <summary>
/// <para>
/// Class handler for the #GtkListBox::row-selected signal
/// </para>
/// </summary>

public IntPtr row_selected;
	/// <summary>
/// <para>
/// Class handler for the #GtkListBox::row-activated signal
/// </para>
/// </summary>

public IntPtr row_activated;
	/// <summary>
/// <para>
/// Class handler for the #GtkListBox::activate-cursor-row signal
/// </para>
/// </summary>

public IntPtr activate_cursor_row;
	/// <summary>
/// <para>
/// Class handler for the #GtkListBox::toggle-cursor-row signal
/// </para>
/// </summary>

public IntPtr toggle_cursor_row;
	/// <summary>
/// <para>
/// Class handler for the #GtkListBox::move-cursor signal
/// </para>
/// </summary>

public IntPtr move_cursor;
	/// <summary>
/// <para>
/// Class handler for the #GtkListBox::selected-rows-changed signal
/// </para>
/// </summary>

public IntPtr selected_rows_changed;
	/// <summary>
/// <para>
/// Class handler for the #GtkListBox::select-all signal
/// </para>
/// </summary>

public IntPtr select_all;
	/// <summary>
/// <para>
/// Class handler for the #GtkListBox::unselect-all signal
/// </para>
/// </summary>

public IntPtr unselect_all;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
}
