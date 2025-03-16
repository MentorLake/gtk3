namespace MentorLake.Gtk;

public class GtkExpanderClassHandle : BaseSafeHandle
{
}


public static class GtkExpanderClassExtensions
{

	public static GtkExpanderClass Dereference(this GtkExpanderClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkExpanderClass>(x.DangerousGetHandle());
}
internal class GtkExpanderClassExterns
{
}

public struct GtkExpanderClass
{
	public GtkBinClass parent_class;
	public IntPtr activate;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
