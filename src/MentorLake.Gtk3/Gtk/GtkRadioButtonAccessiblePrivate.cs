namespace MentorLake.Gtk;


public class GtkRadioButtonAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkRadioButtonAccessiblePrivateExtensions
{

	public static GtkRadioButtonAccessiblePrivate Dereference(this GtkRadioButtonAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioButtonAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkRadioButtonAccessiblePrivateExterns
{
}


public struct GtkRadioButtonAccessiblePrivate
{
}
