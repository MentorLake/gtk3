namespace MentorLake.Gtk3.Atk;

public class AtkRelationHandle : GObjectHandle
{
	public static AtkRelationHandle New(AtkObjectHandle[] targets, int n_targets, AtkRelationType relationship)
	{
		return AtkRelationExterns.atk_relation_new(targets, n_targets, relationship);
	}

}

public static class AtkRelationHandleExtensions
{
	public static AtkRelationHandle AddTarget(this AtkRelationHandle relation, AtkObjectHandle target)
	{
		AtkRelationExterns.atk_relation_add_target(relation, target);
		return relation;
	}

	public static AtkRelationType GetRelationType(this AtkRelationHandle relation)
	{
		return AtkRelationExterns.atk_relation_get_relation_type(relation);
	}

	public static IntPtr GetTarget(this AtkRelationHandle relation)
	{
		return AtkRelationExterns.atk_relation_get_target(relation);
	}

	public static bool RemoveTarget(this AtkRelationHandle relation, AtkObjectHandle target)
	{
		return AtkRelationExterns.atk_relation_remove_target(relation, target);
	}

}

internal class AtkRelationExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkRelationHandle atk_relation_new(AtkObjectHandle[] targets, int n_targets, AtkRelationType relationship);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_relation_add_target(AtkRelationHandle relation, AtkObjectHandle target);

	[DllImport(Libraries.Atk)]
	internal static extern AtkRelationType atk_relation_get_relation_type(AtkRelationHandle relation);

	[DllImport(Libraries.Atk)]
	internal static extern IntPtr atk_relation_get_target(AtkRelationHandle relation);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_relation_remove_target(AtkRelationHandle relation, AtkObjectHandle target);

}
