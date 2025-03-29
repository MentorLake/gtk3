namespace MentorLake.Atk;

public class AtkPlugHandle : AtkObjectHandle, AtkComponentHandle
{
	public static MentorLake.Atk.AtkPlugHandle New()
	{
		return AtkPlugHandleExterns.atk_plug_new();
	}

}

public static class AtkPlugHandleExtensions
{
	public static string GetId(this MentorLake.Atk.AtkPlugHandle plug)
	{
		if (plug.IsInvalid || plug.IsClosed) throw new Exception("Invalid or closed handle (AtkPlugHandle)");
		return AtkPlugHandleExterns.atk_plug_get_id(plug);
	}

}

internal class AtkPlugHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkPlugHandle atk_plug_new();

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_plug_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkPlugHandle>))] MentorLake.Atk.AtkPlugHandle plug);

}
