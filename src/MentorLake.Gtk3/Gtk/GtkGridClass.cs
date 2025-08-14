namespace MentorLake.Gtk;


public class GtkGridClassHandle : BaseSafeHandle
{
}


public static class GtkGridClassExtensions
{

	public static GtkGridClass Dereference(this GtkGridClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGridClass>(x.DangerousGetHandle());
}
internal class GtkGridClassExterns
{
}


public struct GtkGridClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkContainerClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
	
public IntPtr _gtk_reserved7;
	
public IntPtr _gtk_reserved8;
}
