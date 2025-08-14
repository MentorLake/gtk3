namespace MentorLake.Gtk;


public class GtkEntryAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkEntryAccessibleClassExtensions
{

	public static GtkEntryAccessibleClass Dereference(this GtkEntryAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEntryAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkEntryAccessibleClassExterns
{
}


public struct GtkEntryAccessibleClass
{
	
public GtkWidgetAccessibleClass parent_class;
}
