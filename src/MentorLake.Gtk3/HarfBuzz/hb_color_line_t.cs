namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A struct containing color information for a gradient.
/// </para>
/// </summary>

public class hb_color_line_tHandle : BaseSafeHandle
{
}


public static class hb_color_line_tExtensions
{

	public static hb_color_line_t Dereference(this hb_color_line_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_color_line_t>(x.DangerousGetHandle());
}
internal class hb_color_line_tExterns
{
}

/// <summary>
/// <para>
/// A struct containing color information for a gradient.
/// </para>
/// </summary>

public struct hb_color_line_t
{
	
public IntPtr data;
	
public hb_color_line_get_color_stops_func_t get_color_stops;
	
public IntPtr get_color_stops_user_data;
	
public hb_color_line_get_extend_func_t get_extend;
	
public IntPtr get_extend_user_data;
	
public IntPtr reserved0;
	
public IntPtr reserved1;
	
public IntPtr reserved2;
	
public IntPtr reserved3;
	
public IntPtr reserved5;
	
public IntPtr reserved6;
	
public IntPtr reserved7;
	
public IntPtr reserved8;
}
