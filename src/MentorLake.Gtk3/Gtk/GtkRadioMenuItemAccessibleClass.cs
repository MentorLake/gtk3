namespace MentorLake.Gtk;

public class GtkRadioMenuItemAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkRadioMenuItemAccessibleClassExtensions
{

	public static GtkRadioMenuItemAccessibleClass Dereference(this GtkRadioMenuItemAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioMenuItemAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkRadioMenuItemAccessibleClassExterns
{
}

public struct GtkRadioMenuItemAccessibleClass
{
	public GtkCheckMenuItemAccessibleClass parent_class;
}
