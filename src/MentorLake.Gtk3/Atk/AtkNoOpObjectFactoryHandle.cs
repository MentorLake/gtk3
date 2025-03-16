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
	internal static extern MentorLake.Atk.AtkNoOpObjectFactoryHandle atk_no_op_object_factory_new();

}
