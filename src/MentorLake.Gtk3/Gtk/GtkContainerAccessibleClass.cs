namespace MentorLake.Gtk;

public class GtkContainerAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkContainerAccessibleClassExtensions
{

	public static GtkContainerAccessibleClass Dereference(this GtkContainerAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkContainerAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkContainerAccessibleClassExterns
{
}

public struct GtkContainerAccessibleClass
{
	public GtkWidgetAccessibleClass parent_class;
	public IntPtr add_gtk;
	public IntPtr remove_gtk;
}
