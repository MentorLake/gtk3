namespace MentorLake.Gtk;


public class GtkToolbarPrivateHandle : BaseSafeHandle
{
}


public static class GtkToolbarPrivateExtensions
{

	public static GtkToolbarPrivate Dereference(this GtkToolbarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolbarPrivate>(x.DangerousGetHandle());
}
internal class GtkToolbarPrivateExterns
{
}


public struct GtkToolbarPrivate
{
}
