namespace MentorLake.Gtk;


public class GtkViewportPrivateHandle : BaseSafeHandle
{
}


public static class GtkViewportPrivateExtensions
{

	public static GtkViewportPrivate Dereference(this GtkViewportPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkViewportPrivate>(x.DangerousGetHandle());
}
internal class GtkViewportPrivateExterns
{
}


public struct GtkViewportPrivate
{
}
