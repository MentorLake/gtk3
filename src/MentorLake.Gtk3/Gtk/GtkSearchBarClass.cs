namespace MentorLake.Gtk;


public class GtkSearchBarClassHandle : BaseSafeHandle
{
}


public static class GtkSearchBarClassExtensions
{

	public static GtkSearchBarClass Dereference(this GtkSearchBarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSearchBarClass>(x.DangerousGetHandle());
}
internal class GtkSearchBarClassExterns
{
}


public struct GtkSearchBarClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBinClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
