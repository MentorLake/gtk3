namespace MentorLake.Gtk;


public class GtkWindowClassHandle : BaseSafeHandle
{
}


public static class GtkWindowClassExtensions
{

	public static GtkWindowClass Dereference(this GtkWindowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWindowClass>(x.DangerousGetHandle());
}
internal class GtkWindowClassExterns
{
}


public struct GtkWindowClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBinClass parent_class;
	/// <summary>
/// <para>
/// Sets child as the focus widget for the window.
/// </para>
/// </summary>

public IntPtr set_focus;
	/// <summary>
/// <para>
/// Activates the current focused widget within the window.
/// </para>
/// </summary>

public IntPtr activate_focus;
	/// <summary>
/// <para>
/// Activates the default widget for the window.
/// </para>
/// </summary>

public IntPtr activate_default;
	/// <summary>
/// <para>
/// Signal gets emitted when the set of accelerators or
///   mnemonics that are associated with window changes.
/// </para>
/// </summary>

public IntPtr keys_changed;
	/// <summary>
/// <para>
/// Class handler for the #GtkWindow::enable-debugging
///   keybinding signal. Since: 3.14
/// </para>
/// </summary>

public IntPtr enable_debugging;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
}
