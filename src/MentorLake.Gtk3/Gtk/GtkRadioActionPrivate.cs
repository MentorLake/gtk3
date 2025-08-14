namespace MentorLake.Gtk;


public class GtkRadioActionPrivateHandle : BaseSafeHandle
{
}


public static class GtkRadioActionPrivateExtensions
{

	public static GtkRadioActionPrivate Dereference(this GtkRadioActionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioActionPrivate>(x.DangerousGetHandle());
}
internal class GtkRadioActionPrivateExterns
{
}


public struct GtkRadioActionPrivate
{
}
