namespace MentorLake.Gtk3.Atk;

public class AtkSocketHandle : AtkObjectHandle, AtkComponentHandle
{
	public static AtkSocketHandle New()
	{
		return AtkSocketExterns.atk_socket_new();
	}

}

public static class AtkSocketHandleExtensions
{
	public static AtkSocketHandle Embed(this AtkSocketHandle obj, string plug_id)
	{
		AtkSocketExterns.atk_socket_embed(obj, plug_id);
		return obj;
	}

	public static bool IsOccupied(this AtkSocketHandle obj)
	{
		return AtkSocketExterns.atk_socket_is_occupied(obj);
	}

}

internal class AtkSocketExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkSocketHandle atk_socket_new();

	[DllImport(Libraries.Atk)]
	internal static extern void atk_socket_embed(AtkSocketHandle obj, string plug_id);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_socket_is_occupied(AtkSocketHandle obj);

}
