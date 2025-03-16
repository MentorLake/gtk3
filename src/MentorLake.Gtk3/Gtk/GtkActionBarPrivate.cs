namespace MentorLake.Gtk;

public class GtkActionBarPrivateHandle : BaseSafeHandle
{
}


public static class GtkActionBarPrivateExtensions
{

	public static GtkActionBarPrivate Dereference(this GtkActionBarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionBarPrivate>(x.DangerousGetHandle());
}
internal class GtkActionBarPrivateExterns
{
}

public struct GtkActionBarPrivate
{
}
