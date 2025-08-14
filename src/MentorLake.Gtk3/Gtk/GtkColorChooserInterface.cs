namespace MentorLake.Gtk;


public class GtkColorChooserInterfaceHandle : BaseSafeHandle
{
}


public static class GtkColorChooserInterfaceExtensions
{

	public static GtkColorChooserInterface Dereference(this GtkColorChooserInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorChooserInterface>(x.DangerousGetHandle());
}
internal class GtkColorChooserInterfaceExterns
{
}


public struct GtkColorChooserInterface
{
	
public GTypeInterface base_interface;
	
public IntPtr get_rgba;
	
public IntPtr set_rgba;
	
public IntPtr add_palette;
	
public IntPtr color_activated;
	
public IntPtr padding;
}
