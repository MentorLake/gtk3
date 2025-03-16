namespace MentorLake.Gtk;

public class GtkEventBoxClassHandle : BaseSafeHandle
{
}


public static class GtkEventBoxClassExtensions
{

	public static GtkEventBoxClass Dereference(this GtkEventBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEventBoxClass>(x.DangerousGetHandle());
}
internal class GtkEventBoxClassExterns
{
}

public struct GtkEventBoxClass
{
	public GtkBinClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
