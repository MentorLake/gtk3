namespace MentorLake.cairo;

public class cairo_path_data_t_headerHandle : BaseSafeHandle
{
}


public static class cairo_path_data_t_headerExtensions
{

	public static cairo_path_data_t_header Dereference(this cairo_path_data_t_headerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_path_data_t_header>(x.DangerousGetHandle());
}
internal class cairo_path_data_t_headerExterns
{
}

public struct cairo_path_data_t_header
{
	public cairo_path_data_type_t type;
	public int length;
}

public class cairo_path_data_t_pointHandle : BaseSafeHandle
{
}


public static class cairo_path_data_t_pointExtensions
{

	public static cairo_path_data_t_point Dereference(this cairo_path_data_t_pointHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_path_data_t_point>(x.DangerousGetHandle());
}
internal class cairo_path_data_t_pointExterns
{
}

public struct cairo_path_data_t_point
{
	public double x;
	public double y;
}

public class cairo_path_data_tHandle : BaseSafeHandle
{
}


public static class cairo_path_data_tExtensions
{

	public static cairo_path_data_t Dereference(this cairo_path_data_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_path_data_t>(x.DangerousGetHandle());
}
internal class cairo_path_data_tExterns
{
}

public struct cairo_path_data_t
{
	public cairo_path_data_t_header header;
	public cairo_path_data_t_point point;
}
