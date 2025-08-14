namespace MentorLake.Atk;


public class AtkStreamableContentIfaceHandle : BaseSafeHandle
{
}


public static class AtkStreamableContentIfaceExtensions
{

	public static AtkStreamableContentIface Dereference(this AtkStreamableContentIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkStreamableContentIface>(x.DangerousGetHandle());
}
internal class AtkStreamableContentIfaceExterns
{
}


public struct AtkStreamableContentIface
{
	
public GTypeInterface parent;
	
public IntPtr get_n_mime_types;
	
public IntPtr get_mime_type;
	
public IntPtr get_stream;
	
public IntPtr get_uri;
	
public AtkFunction pad1;
	
public AtkFunction pad2;
	
public AtkFunction pad3;
}
