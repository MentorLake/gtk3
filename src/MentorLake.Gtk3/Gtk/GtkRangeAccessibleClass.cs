namespace MentorLake.Gtk;


public class GtkRangeAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkRangeAccessibleClassExtensions
{

	public static GtkRangeAccessibleClass Dereference(this GtkRangeAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRangeAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkRangeAccessibleClassExterns
{
}


public struct GtkRangeAccessibleClass
{
	
public GtkWidgetAccessibleClass parent_class;
}
