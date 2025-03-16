namespace MentorLake.Gtk;

public class GtkWidgetAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkWidgetAccessiblePrivateExtensions
{

	public static GtkWidgetAccessiblePrivate Dereference(this GtkWidgetAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWidgetAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkWidgetAccessiblePrivateExterns
{
}

public struct GtkWidgetAccessiblePrivate
{
}
