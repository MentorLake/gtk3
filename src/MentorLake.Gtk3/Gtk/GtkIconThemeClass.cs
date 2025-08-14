namespace MentorLake.Gtk;


public class GtkIconThemeClassHandle : BaseSafeHandle
{
}


public static class GtkIconThemeClassExtensions
{

	public static GtkIconThemeClass Dereference(this GtkIconThemeClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconThemeClass>(x.DangerousGetHandle());
}
internal class GtkIconThemeClassExterns
{
}


public struct GtkIconThemeClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when the current icon theme is switched or
///    GTK+ detects that a change has occurred in the contents of the
///    current icon theme.
/// </para>
/// </summary>

public IntPtr changed;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
