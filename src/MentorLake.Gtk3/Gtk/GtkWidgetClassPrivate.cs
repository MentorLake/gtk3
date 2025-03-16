namespace MentorLake.Gtk;

public class GtkWidgetClassPrivateHandle : BaseSafeHandle
{
}


public static class GtkWidgetClassPrivateExtensions
{

	public static GtkWidgetClassPrivate Dereference(this GtkWidgetClassPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWidgetClassPrivate>(x.DangerousGetHandle());
}
internal class GtkWidgetClassPrivateExterns
{
}

public struct GtkWidgetClassPrivate
{
}
