namespace MentorLake.Gtk;


public class GtkFileChooserButtonClassHandle : BaseSafeHandle
{
}


public static class GtkFileChooserButtonClassExtensions
{

	public static GtkFileChooserButtonClass Dereference(this GtkFileChooserButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileChooserButtonClass>(x.DangerousGetHandle());
}
internal class GtkFileChooserButtonClassExterns
{
}


public struct GtkFileChooserButtonClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBoxClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when the user selects a file.
/// </para>
/// </summary>

public IntPtr file_set;
	
public IntPtr __gtk_reserved1;
	
public IntPtr __gtk_reserved2;
	
public IntPtr __gtk_reserved3;
	
public IntPtr __gtk_reserved4;
}
