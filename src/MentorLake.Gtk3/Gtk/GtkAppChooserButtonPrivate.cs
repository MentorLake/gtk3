namespace MentorLake.Gtk;

public class GtkAppChooserButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkAppChooserButtonPrivateExtensions
{

	public static GtkAppChooserButtonPrivate Dereference(this GtkAppChooserButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAppChooserButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkAppChooserButtonPrivateExterns
{
}

public struct GtkAppChooserButtonPrivate
{
}
