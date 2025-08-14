namespace MentorLake.Gtk;


public class GtkBoxPrivateHandle : BaseSafeHandle
{
}


public static class GtkBoxPrivateExtensions
{

	public static GtkBoxPrivate Dereference(this GtkBoxPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBoxPrivate>(x.DangerousGetHandle());
}
internal class GtkBoxPrivateExterns
{
}


public struct GtkBoxPrivate
{
}
