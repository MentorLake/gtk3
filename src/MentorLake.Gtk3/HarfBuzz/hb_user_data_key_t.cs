namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data structure for holding user-data keys.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Data structure for holding user-data keys.
/// </para>
/// </summary>

public struct hb_user_data_key_t
{
}
