namespace MentorLake.Gtk;

public class GtkEntryCompletionPrivateHandle : BaseSafeHandle
{
}


public static class GtkEntryCompletionPrivateExtensions
{

	public static GtkEntryCompletionPrivate Dereference(this GtkEntryCompletionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEntryCompletionPrivate>(x.DangerousGetHandle());
}
internal class GtkEntryCompletionPrivateExterns
{
}

public struct GtkEntryCompletionPrivate
{
}
