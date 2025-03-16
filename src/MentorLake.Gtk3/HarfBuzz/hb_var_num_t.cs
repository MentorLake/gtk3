namespace MentorLake.HarfBuzz;

public class hb_var_num_tHandle : BaseSafeHandle
{
}


public static class hb_var_num_tExtensions
{

	public static hb_var_num_t Dereference(this hb_var_num_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_var_num_t>(x.DangerousGetHandle());
}
internal class hb_var_num_tExterns
{
}

public struct hb_var_num_t
{
	public float f;
	public uint u32;
	public int i32;
	public ushort[] u16;
	public short[] i16;
	public byte[] u8;
	public byte[] i8;
}
