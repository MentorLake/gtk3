namespace MentorLake.Gtk3.Atk;

public class AtkStateSetHandle : GObjectHandle
{
	public static AtkStateSetHandle New()
	{
		return AtkStateSetExterns.atk_state_set_new();
	}

}

public static class AtkStateSetHandleExtensions
{
	public static bool AddState(this AtkStateSetHandle set, AtkStateType type)
	{
		return AtkStateSetExterns.atk_state_set_add_state(set, type);
	}

	public static T AddStates<T>(this T set, AtkStateType[] types, int n_types) where T : AtkStateSetHandle
	{
		AtkStateSetExterns.atk_state_set_add_states(set, types, n_types);
		return set;
	}

	public static AtkStateSetHandle AndSets(this AtkStateSetHandle set, AtkStateSetHandle compare_set)
	{
		return AtkStateSetExterns.atk_state_set_and_sets(set, compare_set);
	}

	public static T ClearStates<T>(this T set) where T : AtkStateSetHandle
	{
		AtkStateSetExterns.atk_state_set_clear_states(set);
		return set;
	}

	public static bool ContainsState(this AtkStateSetHandle set, AtkStateType type)
	{
		return AtkStateSetExterns.atk_state_set_contains_state(set, type);
	}

	public static bool ContainsStates(this AtkStateSetHandle set, AtkStateType[] types, int n_types)
	{
		return AtkStateSetExterns.atk_state_set_contains_states(set, types, n_types);
	}

	public static bool IsEmpty(this AtkStateSetHandle set)
	{
		return AtkStateSetExterns.atk_state_set_is_empty(set);
	}

	public static AtkStateSetHandle OrSets(this AtkStateSetHandle set, AtkStateSetHandle compare_set)
	{
		return AtkStateSetExterns.atk_state_set_or_sets(set, compare_set);
	}

	public static bool RemoveState(this AtkStateSetHandle set, AtkStateType type)
	{
		return AtkStateSetExterns.atk_state_set_remove_state(set, type);
	}

	public static AtkStateSetHandle XorSets(this AtkStateSetHandle set, AtkStateSetHandle compare_set)
	{
		return AtkStateSetExterns.atk_state_set_xor_sets(set, compare_set);
	}

}

internal class AtkStateSetExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkStateSetHandle atk_state_set_new();

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_state_set_add_state(AtkStateSetHandle set, AtkStateType type);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_state_set_add_states(AtkStateSetHandle set, AtkStateType[] types, int n_types);

	[DllImport(Libraries.Atk)]
	internal static extern AtkStateSetHandle atk_state_set_and_sets(AtkStateSetHandle set, AtkStateSetHandle compare_set);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_state_set_clear_states(AtkStateSetHandle set);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_state_set_contains_state(AtkStateSetHandle set, AtkStateType type);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_state_set_contains_states(AtkStateSetHandle set, AtkStateType[] types, int n_types);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_state_set_is_empty(AtkStateSetHandle set);

	[DllImport(Libraries.Atk)]
	internal static extern AtkStateSetHandle atk_state_set_or_sets(AtkStateSetHandle set, AtkStateSetHandle compare_set);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_state_set_remove_state(AtkStateSetHandle set, AtkStateType type);

	[DllImport(Libraries.Atk)]
	internal static extern AtkStateSetHandle atk_state_set_xor_sets(AtkStateSetHandle set, AtkStateSetHandle compare_set);

}
