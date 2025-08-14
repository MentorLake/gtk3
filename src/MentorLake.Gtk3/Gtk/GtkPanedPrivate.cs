namespace MentorLake.Gtk;


public class GtkPanedPrivateHandle : BaseSafeHandle
{
}


public static class GtkPanedPrivateExtensions
{

	public static GtkPanedPrivate Dereference(this GtkPanedPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPanedPrivate>(x.DangerousGetHandle());
}
internal class GtkPanedPrivateExterns
{
}


public struct GtkPanedPrivate
{
}
