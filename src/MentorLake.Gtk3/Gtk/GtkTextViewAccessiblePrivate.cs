namespace MentorLake.Gtk;

public class GtkTextViewAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkTextViewAccessiblePrivateExtensions
{

	public static GtkTextViewAccessiblePrivate Dereference(this GtkTextViewAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextViewAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkTextViewAccessiblePrivateExterns
{
}

public struct GtkTextViewAccessiblePrivate
{
}
