namespace MentorLake.Atk;

public class AtkImplementorHandle : BaseSafeHandle
{
}


public static class AtkImplementorExtensions
{
	public static MentorLake.Atk.AtkObjectHandle RefAccessible(this MentorLake.Atk.AtkImplementorHandle implementor)
	{
		if (implementor.IsInvalid) throw new Exception("Invalid handle (AtkImplementor)");
		return AtkImplementorExterns.atk_implementor_ref_accessible(implementor);
	}


	public static AtkImplementor Dereference(this AtkImplementorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkImplementor>(x.DangerousGetHandle());
}
internal class AtkImplementorExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_implementor_ref_accessible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImplementorHandle>))] MentorLake.Atk.AtkImplementorHandle implementor);

}

public struct AtkImplementor
{
}
