namespace MentorLake.Gtk;

public class GtkTextTagTablePrivateHandle : BaseSafeHandle
{
}


public static class GtkTextTagTablePrivateExtensions
{

	public static GtkTextTagTablePrivate Dereference(this GtkTextTagTablePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextTagTablePrivate>(x.DangerousGetHandle());
}
internal class GtkTextTagTablePrivateExterns
{
}

public struct GtkTextTagTablePrivate
{
}
