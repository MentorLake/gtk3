namespace MentorLake.Gtk;


public class GtkRadioButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkRadioButtonPrivateExtensions
{

	public static GtkRadioButtonPrivate Dereference(this GtkRadioButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkRadioButtonPrivateExterns
{
}


public struct GtkRadioButtonPrivate
{
}
