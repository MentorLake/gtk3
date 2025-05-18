namespace MentorLake.HarfBuzz;

public class hb_variation_tHandle : BaseSafeHandle
{
}


public static class hb_variation_tExtensions
{
	public static void String(this MentorLake.HarfBuzz.hb_variation_tHandle variation, out string[] buf, out uint size)
	{
		if (variation.IsInvalid) throw new Exception("Invalid handle (hb_variation_t)");
		hb_variation_tExterns.hb_variation_to_string(variation, out buf, out size);
	}


	public static hb_variation_t Dereference(this hb_variation_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_variation_t>(x.DangerousGetHandle());
}
internal class hb_variation_tExterns
{
	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_variation_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_variation_tHandle>))] MentorLake.HarfBuzz.hb_variation_tHandle variation, out string[] buf, out uint size);

}

public struct hb_variation_t
{
	public hb_tag_t tag;
	public float value;
}
