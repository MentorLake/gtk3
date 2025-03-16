namespace MentorLake.Gtk;

public class GtkWidgetAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkWidgetAccessibleClassExtensions
{

	public static GtkWidgetAccessibleClass Dereference(this GtkWidgetAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWidgetAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkWidgetAccessibleClassExterns
{
}

public struct GtkWidgetAccessibleClass
{
	public GtkAccessibleClass parent_class;
	public IntPtr notify_gtk;
}
