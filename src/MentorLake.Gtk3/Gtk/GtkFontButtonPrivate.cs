namespace MentorLake.Gtk;

public class GtkFontButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkFontButtonPrivateExtensions
{

	public static GtkFontButtonPrivate Dereference(this GtkFontButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkFontButtonPrivateExterns
{
}

public struct GtkFontButtonPrivate
{
}
