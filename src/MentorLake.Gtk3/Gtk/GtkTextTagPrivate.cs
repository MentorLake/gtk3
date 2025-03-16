namespace MentorLake.Gtk;

public class GtkTextTagPrivateHandle : BaseSafeHandle
{
}


public static class GtkTextTagPrivateExtensions
{

	public static GtkTextTagPrivate Dereference(this GtkTextTagPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextTagPrivate>(x.DangerousGetHandle());
}
internal class GtkTextTagPrivateExterns
{
}

public struct GtkTextTagPrivate
{
}
