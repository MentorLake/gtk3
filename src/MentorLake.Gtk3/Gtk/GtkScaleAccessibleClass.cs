namespace MentorLake.Gtk;

public class GtkScaleAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkScaleAccessibleClassExtensions
{

	public static GtkScaleAccessibleClass Dereference(this GtkScaleAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScaleAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkScaleAccessibleClassExterns
{
}

public struct GtkScaleAccessibleClass
{
	public GtkRangeAccessibleClass parent_class;
}
