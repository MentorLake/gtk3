namespace MentorLake.Gtk;


public class GtkRadioMenuItemAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkRadioMenuItemAccessiblePrivateExtensions
{

	public static GtkRadioMenuItemAccessiblePrivate Dereference(this GtkRadioMenuItemAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioMenuItemAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkRadioMenuItemAccessiblePrivateExterns
{
}


public struct GtkRadioMenuItemAccessiblePrivate
{
}
