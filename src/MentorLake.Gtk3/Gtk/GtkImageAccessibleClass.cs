namespace MentorLake.Gtk;


public class GtkImageAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkImageAccessibleClassExtensions
{

	public static GtkImageAccessibleClass Dereference(this GtkImageAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkImageAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkImageAccessibleClassExterns
{
}


public struct GtkImageAccessibleClass
{
	
public GtkWidgetAccessibleClass parent_class;
}
