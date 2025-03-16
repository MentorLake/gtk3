namespace MentorLake.Gtk;

public class GtkFlowBoxChildClassHandle : BaseSafeHandle
{
}


public static class GtkFlowBoxChildClassExtensions
{

	public static GtkFlowBoxChildClass Dereference(this GtkFlowBoxChildClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFlowBoxChildClass>(x.DangerousGetHandle());
}
internal class GtkFlowBoxChildClassExterns
{
}

public struct GtkFlowBoxChildClass
{
	public GtkBinClass parent_class;
	public IntPtr activate;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
}
