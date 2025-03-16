namespace MentorLake.Gtk;

public class GtkSpinnerClassHandle : BaseSafeHandle
{
}


public static class GtkSpinnerClassExtensions
{

	public static GtkSpinnerClass Dereference(this GtkSpinnerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSpinnerClass>(x.DangerousGetHandle());
}
internal class GtkSpinnerClassExterns
{
}

public struct GtkSpinnerClass
{
	public GtkWidgetClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
