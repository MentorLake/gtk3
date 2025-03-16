namespace MentorLake.Gtk;

public class GtkFileChooserWidgetAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkFileChooserWidgetAccessiblePrivateExtensions
{

	public static GtkFileChooserWidgetAccessiblePrivate Dereference(this GtkFileChooserWidgetAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileChooserWidgetAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkFileChooserWidgetAccessiblePrivateExterns
{
}

public struct GtkFileChooserWidgetAccessiblePrivate
{
}
