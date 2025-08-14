namespace MentorLake.Gtk;


public class GtkRadioMenuItemClassHandle : BaseSafeHandle
{
}


public static class GtkRadioMenuItemClassExtensions
{

	public static GtkRadioMenuItemClass Dereference(this GtkRadioMenuItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioMenuItemClass>(x.DangerousGetHandle());
}
internal class GtkRadioMenuItemClassExterns
{
}


public struct GtkRadioMenuItemClass
{
	
public GtkCheckMenuItemClass parent_class;
	
public IntPtr group_changed;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
