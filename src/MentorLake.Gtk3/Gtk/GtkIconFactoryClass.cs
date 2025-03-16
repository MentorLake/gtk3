namespace MentorLake.Gtk;

public class GtkIconFactoryClassHandle : BaseSafeHandle
{
}


public static class GtkIconFactoryClassExtensions
{

	public static GtkIconFactoryClass Dereference(this GtkIconFactoryClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconFactoryClass>(x.DangerousGetHandle());
}
internal class GtkIconFactoryClassExterns
{
}

public struct GtkIconFactoryClass
{
	public GObjectClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
