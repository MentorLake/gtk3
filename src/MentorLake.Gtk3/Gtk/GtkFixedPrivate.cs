namespace MentorLake.Gtk;


public class GtkFixedPrivateHandle : BaseSafeHandle
{
}


public static class GtkFixedPrivateExtensions
{

	public static GtkFixedPrivate Dereference(this GtkFixedPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFixedPrivate>(x.DangerousGetHandle());
}
internal class GtkFixedPrivateExterns
{
}


public struct GtkFixedPrivate
{
}
