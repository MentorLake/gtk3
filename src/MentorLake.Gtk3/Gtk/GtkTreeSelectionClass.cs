namespace MentorLake.Gtk;


public class GtkTreeSelectionClassHandle : BaseSafeHandle
{
}


public static class GtkTreeSelectionClassExtensions
{

	public static GtkTreeSelectionClass Dereference(this GtkTreeSelectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeSelectionClass>(x.DangerousGetHandle());
}
internal class GtkTreeSelectionClassExterns
{
}


public struct GtkTreeSelectionClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted whenever the selection has (possibly) changed.
/// </para>
/// </summary>

public IntPtr changed;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
