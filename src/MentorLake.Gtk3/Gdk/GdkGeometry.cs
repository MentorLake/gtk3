namespace MentorLake.Gdk;

public class GdkGeometryHandle : BaseSafeHandle
{
}


public static class GdkGeometryExtensions
{

	public static GdkGeometry Dereference(this GdkGeometryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkGeometry>(x.DangerousGetHandle());
}
internal class GdkGeometryExterns
{
}

public struct GdkGeometry
{
	public int min_width;
	public int min_height;
	public int max_width;
	public int max_height;
	public int base_width;
	public int base_height;
	public int width_inc;
	public int height_inc;
	public double min_aspect;
	public double max_aspect;
	public GdkGravity win_gravity;
}
