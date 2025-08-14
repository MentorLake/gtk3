namespace MentorLake.Gtk;


public class GtkArrowPrivateHandle : BaseSafeHandle
{
}


public static class GtkArrowPrivateExtensions
{

	public static GtkArrowPrivate Dereference(this GtkArrowPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkArrowPrivate>(x.DangerousGetHandle());
}
internal class GtkArrowPrivateExterns
{
}


public struct GtkArrowPrivate
{
}
