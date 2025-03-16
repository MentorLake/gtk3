namespace MentorLake.Gtk;

public class GtkBinClassHandle : BaseSafeHandle
{
}


public static class GtkBinClassExtensions
{

	public static GtkBinClass Dereference(this GtkBinClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBinClass>(x.DangerousGetHandle());
}
internal class GtkBinClassExterns
{
}

public struct GtkBinClass
{
	public GtkContainerClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
