namespace MentorLake.Atk;


public class AtkEditableTextIfaceHandle : BaseSafeHandle
{
}


public static class AtkEditableTextIfaceExtensions
{

	public static AtkEditableTextIface Dereference(this AtkEditableTextIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkEditableTextIface>(x.DangerousGetHandle());
}
internal class AtkEditableTextIfaceExterns
{
}


public struct AtkEditableTextIface
{
	
public GTypeInterface parent_interface;
	
public IntPtr set_run_attributes;
	
public IntPtr set_text_contents;
	
public IntPtr insert_text;
	
public IntPtr copy_text;
	
public IntPtr cut_text;
	
public IntPtr delete_text;
	
public IntPtr paste_text;
}
