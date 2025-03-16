namespace MentorLake.cairo;

public class cairo_user_data_key_tHandle : BaseSafeHandle
{
}


public static class cairo_user_data_key_tExtensions
{

	public static cairo_user_data_key_t Dereference(this cairo_user_data_key_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_user_data_key_t>(x.DangerousGetHandle());
}
internal class cairo_user_data_key_tExterns
{
}

public struct cairo_user_data_key_t
{
	public int unused;
}
