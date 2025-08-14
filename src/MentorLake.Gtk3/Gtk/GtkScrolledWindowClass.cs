namespace MentorLake.Gtk;


public class GtkScrolledWindowClassHandle : BaseSafeHandle
{
}


public static class GtkScrolledWindowClassExtensions
{

	public static GtkScrolledWindowClass Dereference(this GtkScrolledWindowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScrolledWindowClass>(x.DangerousGetHandle());
}
internal class GtkScrolledWindowClassExterns
{
}


public struct GtkScrolledWindowClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBinClass parent_class;
	
public int scrollbar_spacing;
	/// <summary>
/// <para>
/// Keybinding signal which gets emitted when a
///    keybinding that scrolls is pressed.
/// </para>
/// </summary>

public IntPtr scroll_child;
	/// <summary>
/// <para>
/// Keybinding signal which gets emitted when focus is
///    moved away from the scrolled window by a keybinding.
/// </para>
/// </summary>

public IntPtr move_focus_out;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
