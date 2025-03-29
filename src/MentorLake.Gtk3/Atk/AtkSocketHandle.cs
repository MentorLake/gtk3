namespace MentorLake.Atk;

public class AtkSocketHandle : AtkObjectHandle, AtkComponentHandle
{
	public static MentorLake.Atk.AtkSocketHandle New()
	{
		return AtkSocketHandleExterns.atk_socket_new();
	}

}

public static class AtkSocketHandleExtensions
{
	public static T Embed<T>(this T obj, string plug_id) where T : AtkSocketHandle
	{
		if (obj.IsInvalid || obj.IsClosed) throw new Exception("Invalid or closed handle (AtkSocketHandle)");
		AtkSocketHandleExterns.atk_socket_embed(obj, plug_id);
		return obj;
	}

	public static bool IsOccupied(this MentorLake.Atk.AtkSocketHandle obj)
	{
		if (obj.IsInvalid || obj.IsClosed) throw new Exception("Invalid or closed handle (AtkSocketHandle)");
		return AtkSocketHandleExterns.atk_socket_is_occupied(obj);
	}

}

internal class AtkSocketHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkSocketHandle atk_socket_new();

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_socket_embed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSocketHandle>))] MentorLake.Atk.AtkSocketHandle obj, string plug_id);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_socket_is_occupied([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSocketHandle>))] MentorLake.Atk.AtkSocketHandle obj);

}
