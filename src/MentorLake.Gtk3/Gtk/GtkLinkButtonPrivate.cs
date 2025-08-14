namespace MentorLake.Gtk;


public class GtkLinkButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkLinkButtonPrivateExtensions
{

	public static GtkLinkButtonPrivate Dereference(this GtkLinkButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLinkButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkLinkButtonPrivateExterns
{
}


public struct GtkLinkButtonPrivate
{
}
