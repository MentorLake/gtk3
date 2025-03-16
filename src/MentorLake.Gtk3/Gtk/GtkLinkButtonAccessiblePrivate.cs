namespace MentorLake.Gtk;

public class GtkLinkButtonAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkLinkButtonAccessiblePrivateExtensions
{

	public static GtkLinkButtonAccessiblePrivate Dereference(this GtkLinkButtonAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLinkButtonAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkLinkButtonAccessiblePrivateExterns
{
}

public struct GtkLinkButtonAccessiblePrivate
{
}
