namespace MentorLake.Gtk;


public class GtkSpinnerAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkSpinnerAccessibleClassExtensions
{

	public static GtkSpinnerAccessibleClass Dereference(this GtkSpinnerAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSpinnerAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkSpinnerAccessibleClassExterns
{
}


public struct GtkSpinnerAccessibleClass
{
	
public GtkWidgetAccessibleClass parent_class;
}
