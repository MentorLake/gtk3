namespace MentorLake.Gtk;

public class GtkToggleActionPrivateHandle : BaseSafeHandle
{
}


public static class GtkToggleActionPrivateExtensions
{

	public static GtkToggleActionPrivate Dereference(this GtkToggleActionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleActionPrivate>(x.DangerousGetHandle());
}
internal class GtkToggleActionPrivateExterns
{
}

public struct GtkToggleActionPrivate
{
}
