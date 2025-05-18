namespace MentorLake.HarfBuzz;

public class hb_feature_tHandle : BaseSafeHandle
{
}


public static class hb_feature_tExtensions
{
	public static void String(this MentorLake.HarfBuzz.hb_feature_tHandle feature, out string[] buf, out uint size)
	{
		if (feature.IsInvalid) throw new Exception("Invalid handle (hb_feature_t)");
		hb_feature_tExterns.hb_feature_to_string(feature, out buf, out size);
	}


	public static hb_feature_t Dereference(this hb_feature_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_feature_t>(x.DangerousGetHandle());
}
internal class hb_feature_tExterns
{
	[DllImport(HarfBuzzLibrary.Name)]
	internal static extern void hb_feature_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_feature_tHandle>))] MentorLake.HarfBuzz.hb_feature_tHandle feature, out string[] buf, out uint size);

}

public struct hb_feature_t
{
	public hb_tag_t tag;
	public uint value;
	public uint start;
	public uint end;
}
