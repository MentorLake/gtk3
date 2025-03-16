namespace MentorLake.HarfBuzz;

public class hb_user_data_key_tHandle : BaseSafeHandle
{
}


public static class hb_user_data_key_tExtensions
{

	public static hb_user_data_key_t Dereference(this hb_user_data_key_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_user_data_key_t>(x.DangerousGetHandle());
}
internal class hb_user_data_key_tExterns
{
}

public struct hb_user_data_key_t
{
}
