namespace MentorLake.Gtk;


public class GtkLabelAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkLabelAccessibleClassExtensions
{

	public static GtkLabelAccessibleClass Dereference(this GtkLabelAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLabelAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkLabelAccessibleClassExterns
{
}


public struct GtkLabelAccessibleClass
{
	
public GtkWidgetAccessibleClass parent_class;
}
