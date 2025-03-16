namespace MentorLake.Atk;

public class AtkAttributeHandle : BaseSafeHandle
{
}


public static class AtkAttributeExtensions
{

	public static AtkAttribute Dereference(this AtkAttributeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkAttribute>(x.DangerousGetHandle());
}
internal class AtkAttributeExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_attribute_set_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkAttributeSetHandle>))] MentorLake.Atk.AtkAttributeSetHandle attrib_set);

}

public struct AtkAttribute
{
	public string name;
	public string value;
	public static void SetFree(MentorLake.Atk.AtkAttributeSetHandle attrib_set)
	{
		AtkAttributeExterns.atk_attribute_set_free(attrib_set);
	}

}
