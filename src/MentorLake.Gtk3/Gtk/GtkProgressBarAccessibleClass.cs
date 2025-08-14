namespace MentorLake.Gtk;


public class GtkProgressBarAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkProgressBarAccessibleClassExtensions
{

	public static GtkProgressBarAccessibleClass Dereference(this GtkProgressBarAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkProgressBarAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkProgressBarAccessibleClassExterns
{
}


public struct GtkProgressBarAccessibleClass
{
	
public GtkWidgetAccessibleClass parent_class;
}
