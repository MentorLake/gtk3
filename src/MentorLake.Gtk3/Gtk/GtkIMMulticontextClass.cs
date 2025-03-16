namespace MentorLake.Gtk;

public class GtkIMMulticontextClassHandle : BaseSafeHandle
{
}


public static class GtkIMMulticontextClassExtensions
{

	public static GtkIMMulticontextClass Dereference(this GtkIMMulticontextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIMMulticontextClass>(x.DangerousGetHandle());
}
internal class GtkIMMulticontextClassExterns
{
}

public struct GtkIMMulticontextClass
{
	public GtkIMContextClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
