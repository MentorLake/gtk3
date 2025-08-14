namespace MentorLake.Gtk;


public class GtkViewportClassHandle : BaseSafeHandle
{
}


public static class GtkViewportClassExtensions
{

	public static GtkViewportClass Dereference(this GtkViewportClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkViewportClass>(x.DangerousGetHandle());
}
internal class GtkViewportClassExterns
{
}


public struct GtkViewportClass
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
