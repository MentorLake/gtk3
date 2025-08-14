namespace MentorLake.Gtk;


public class GtkGridPrivateHandle : BaseSafeHandle
{
}


public static class GtkGridPrivateExtensions
{

	public static GtkGridPrivate Dereference(this GtkGridPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGridPrivate>(x.DangerousGetHandle());
}
internal class GtkGridPrivateExterns
{
}


public struct GtkGridPrivate
{
}
