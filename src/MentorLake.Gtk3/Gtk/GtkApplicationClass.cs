namespace MentorLake.Gtk;


public class GtkApplicationClassHandle : BaseSafeHandle
{
}


public static class GtkApplicationClassExtensions
{

	public static GtkApplicationClass Dereference(this GtkApplicationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkApplicationClass>(x.DangerousGetHandle());
}
internal class GtkApplicationClassExterns
{
}


public struct GtkApplicationClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GApplicationClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when a #GtkWindow is added to
///    application through gtk_application_add_window().
/// </para>
/// </summary>

public IntPtr window_added;
	/// <summary>
/// <para>
/// Signal emitted when a #GtkWindow is removed from
///    application, either as a side-effect of being destroyed or
///    explicitly through gtk_application_remove_window().
/// </para>
/// </summary>

public IntPtr window_removed;
}
