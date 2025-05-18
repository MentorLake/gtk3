namespace MentorLake.Atk;

public class AtkNoOpObjectFactoryHandle : AtkObjectFactoryHandle
{
	public static MentorLake.Atk.AtkNoOpObjectFactoryHandle New()
	{
		return AtkNoOpObjectFactoryHandleExterns.atk_no_op_object_factory_new();
	}

}

public static class AtkNoOpObjectFactoryHandleExtensions
{
}

internal class AtkNoOpObjectFactoryHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkNoOpObjectFactoryHandle>))]
	internal static extern MentorLake.Atk.AtkNoOpObjectFactoryHandle atk_no_op_object_factory_new();

}
