namespace MentorLake.Gtk;

public class GtkFixedClassHandle : BaseSafeHandle
{
}


public static class GtkFixedClassExtensions
{

	public static GtkFixedClass Dereference(this GtkFixedClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFixedClass>(x.DangerousGetHandle());
}
internal class GtkFixedClassExterns
{
}

public struct GtkFixedClass
{
	public GtkContainerClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
