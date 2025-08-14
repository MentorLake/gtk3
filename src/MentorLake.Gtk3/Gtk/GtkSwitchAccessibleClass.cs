namespace MentorLake.Gtk;


public class GtkSwitchAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkSwitchAccessibleClassExtensions
{

	public static GtkSwitchAccessibleClass Dereference(this GtkSwitchAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSwitchAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkSwitchAccessibleClassExterns
{
}


public struct GtkSwitchAccessibleClass
{
	
public GtkWidgetAccessibleClass parent_class;
}
