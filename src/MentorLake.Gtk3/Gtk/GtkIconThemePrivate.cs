namespace MentorLake.Gtk;

public class GtkIconThemePrivateHandle : BaseSafeHandle
{
}


public static class GtkIconThemePrivateExtensions
{

	public static GtkIconThemePrivate Dereference(this GtkIconThemePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIconThemePrivate>(x.DangerousGetHandle());
}
internal class GtkIconThemePrivateExterns
{
}

public struct GtkIconThemePrivate
{
}
