namespace MentorLake.Gtk;


public class GtkUIManagerPrivateHandle : BaseSafeHandle
{
}


public static class GtkUIManagerPrivateExtensions
{

	public static GtkUIManagerPrivate Dereference(this GtkUIManagerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkUIManagerPrivate>(x.DangerousGetHandle());
}
internal class GtkUIManagerPrivateExterns
{
}


public struct GtkUIManagerPrivate
{
}
