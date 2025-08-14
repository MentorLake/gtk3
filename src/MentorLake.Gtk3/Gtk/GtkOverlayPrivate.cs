namespace MentorLake.Gtk;


public class GtkOverlayPrivateHandle : BaseSafeHandle
{
}


public static class GtkOverlayPrivateExtensions
{

	public static GtkOverlayPrivate Dereference(this GtkOverlayPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkOverlayPrivate>(x.DangerousGetHandle());
}
internal class GtkOverlayPrivateExterns
{
}


public struct GtkOverlayPrivate
{
}
