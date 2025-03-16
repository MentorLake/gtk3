namespace MentorLake.GLib;

public class GMarkupParserHandle : BaseSafeHandle
{
}


public static class GMarkupParserExtensions
{

	public static GMarkupParser Dereference(this GMarkupParserHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMarkupParser>(x.DangerousGetHandle());
}
internal class GMarkupParserExterns
{
}

public struct GMarkupParser
{
	public IntPtr start_element;
	public IntPtr end_element;
	public IntPtr text;
	public IntPtr passthrough;
	public IntPtr error;
}
