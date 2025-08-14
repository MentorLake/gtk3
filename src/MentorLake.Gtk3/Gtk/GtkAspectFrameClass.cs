namespace MentorLake.Gtk;


public class GtkAspectFrameClassHandle : BaseSafeHandle
{
}


public static class GtkAspectFrameClassExtensions
{

	public static GtkAspectFrameClass Dereference(this GtkAspectFrameClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAspectFrameClass>(x.DangerousGetHandle());
}
internal class GtkAspectFrameClassExterns
{
}


public struct GtkAspectFrameClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkFrameClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
