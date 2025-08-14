namespace MentorLake.Gtk;


public class GtkMenuBarPrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuBarPrivateExtensions
{

	public static GtkMenuBarPrivate Dereference(this GtkMenuBarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuBarPrivate>(x.DangerousGetHandle());
}
internal class GtkMenuBarPrivateExterns
{
}


public struct GtkMenuBarPrivate
{
}
