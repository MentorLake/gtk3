namespace MentorLake.Gtk;

public class GtkTextViewPrivateHandle : BaseSafeHandle
{
}


public static class GtkTextViewPrivateExtensions
{

	public static GtkTextViewPrivate Dereference(this GtkTextViewPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextViewPrivate>(x.DangerousGetHandle());
}
internal class GtkTextViewPrivateExterns
{
}

public struct GtkTextViewPrivate
{
}
