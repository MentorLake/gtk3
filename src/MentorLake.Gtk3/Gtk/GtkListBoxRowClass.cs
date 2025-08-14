namespace MentorLake.Gtk;


public class GtkListBoxRowClassHandle : BaseSafeHandle
{
}


public static class GtkListBoxRowClassExtensions
{

	public static GtkListBoxRowClass Dereference(this GtkListBoxRowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkListBoxRowClass>(x.DangerousGetHandle());
}
internal class GtkListBoxRowClassExterns
{
}


public struct GtkListBoxRowClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBinClass parent_class;
	
public IntPtr activate;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
}
