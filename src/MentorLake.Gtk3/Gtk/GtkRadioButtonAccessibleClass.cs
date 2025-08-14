namespace MentorLake.Gtk;


public class GtkRadioButtonAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkRadioButtonAccessibleClassExtensions
{

	public static GtkRadioButtonAccessibleClass Dereference(this GtkRadioButtonAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioButtonAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkRadioButtonAccessibleClassExterns
{
}


public struct GtkRadioButtonAccessibleClass
{
	
public GtkToggleButtonAccessibleClass parent_class;
}
