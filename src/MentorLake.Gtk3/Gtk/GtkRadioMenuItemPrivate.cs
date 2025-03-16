namespace MentorLake.Gtk;

public class GtkRadioMenuItemPrivateHandle : BaseSafeHandle
{
}


public static class GtkRadioMenuItemPrivateExtensions
{

	public static GtkRadioMenuItemPrivate Dereference(this GtkRadioMenuItemPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioMenuItemPrivate>(x.DangerousGetHandle());
}
internal class GtkRadioMenuItemPrivateExterns
{
}

public struct GtkRadioMenuItemPrivate
{
}
