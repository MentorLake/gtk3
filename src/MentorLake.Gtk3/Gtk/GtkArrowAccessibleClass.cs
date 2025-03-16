namespace MentorLake.Gtk;

public class GtkArrowAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkArrowAccessibleClassExtensions
{

	public static GtkArrowAccessibleClass Dereference(this GtkArrowAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkArrowAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkArrowAccessibleClassExterns
{
}

public struct GtkArrowAccessibleClass
{
	public GtkWidgetAccessibleClass parent_class;
}
