namespace MentorLake.Gtk;

public class GtkDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkDialogPrivateExtensions
{

	public static GtkDialogPrivate Dereference(this GtkDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkDialogPrivateExterns
{
}

public struct GtkDialogPrivate
{
}
