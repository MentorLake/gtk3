namespace MentorLake.Gtk;

public class GtkHSVPrivateHandle : BaseSafeHandle
{
}


public static class GtkHSVPrivateExtensions
{

	public static GtkHSVPrivate Dereference(this GtkHSVPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHSVPrivate>(x.DangerousGetHandle());
}
internal class GtkHSVPrivateExterns
{
}

public struct GtkHSVPrivate
{
}
