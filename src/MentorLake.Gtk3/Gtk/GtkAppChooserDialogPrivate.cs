namespace MentorLake.Gtk;

public class GtkAppChooserDialogPrivateHandle : BaseSafeHandle
{
}


public static class GtkAppChooserDialogPrivateExtensions
{

	public static GtkAppChooserDialogPrivate Dereference(this GtkAppChooserDialogPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAppChooserDialogPrivate>(x.DangerousGetHandle());
}
internal class GtkAppChooserDialogPrivateExterns
{
}

public struct GtkAppChooserDialogPrivate
{
}
