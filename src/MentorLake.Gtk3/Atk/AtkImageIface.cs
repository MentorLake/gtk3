namespace MentorLake.Atk;


public class AtkImageIfaceHandle : BaseSafeHandle
{
}


public static class AtkImageIfaceExtensions
{

	public static AtkImageIface Dereference(this AtkImageIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkImageIface>(x.DangerousGetHandle());
}
internal class AtkImageIfaceExterns
{
}


public struct AtkImageIface
{
	
public GTypeInterface parent;
	
public IntPtr get_image_position;
	
public IntPtr get_image_description;
	
public IntPtr get_image_size;
	
public IntPtr set_image_description;
	
public IntPtr get_image_locale;
}
