namespace MentorLake.Gtk3.Atk;

public class AtkRelationSetHandle : GObjectHandle
{
	public static AtkRelationSetHandle New()
	{
		return AtkRelationSetExterns.atk_relation_set_new();
	}

}

public static class AtkRelationSetHandleExtensions
{
	public static T Add<T>(this T set, AtkRelationHandle relation) where T : AtkRelationSetHandle
	{
		AtkRelationSetExterns.atk_relation_set_add(set, relation);
		return set;
	}

	public static T AddRelationByType<T>(this T set, AtkRelationType relationship, AtkObjectHandle target) where T : AtkRelationSetHandle
	{
		AtkRelationSetExterns.atk_relation_set_add_relation_by_type(set, relationship, target);
		return set;
	}

	public static bool Contains(this AtkRelationSetHandle set, AtkRelationType relationship)
	{
		return AtkRelationSetExterns.atk_relation_set_contains(set, relationship);
	}

	public static bool ContainsTarget(this AtkRelationSetHandle set, AtkRelationType relationship, AtkObjectHandle target)
	{
		return AtkRelationSetExterns.atk_relation_set_contains_target(set, relationship, target);
	}

	public static int GetNRelations(this AtkRelationSetHandle set)
	{
		return AtkRelationSetExterns.atk_relation_set_get_n_relations(set);
	}

	public static AtkRelationHandle GetRelation(this AtkRelationSetHandle set, int i)
	{
		return AtkRelationSetExterns.atk_relation_set_get_relation(set, i);
	}

	public static AtkRelationHandle GetRelationByType(this AtkRelationSetHandle set, AtkRelationType relationship)
	{
		return AtkRelationSetExterns.atk_relation_set_get_relation_by_type(set, relationship);
	}

	public static T Remove<T>(this T set, AtkRelationHandle relation) where T : AtkRelationSetHandle
	{
		AtkRelationSetExterns.atk_relation_set_remove(set, relation);
		return set;
	}

}

internal class AtkRelationSetExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkRelationSetHandle atk_relation_set_new();

	[DllImport(Libraries.Atk)]
	internal static extern void atk_relation_set_add(AtkRelationSetHandle set, AtkRelationHandle relation);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_relation_set_add_relation_by_type(AtkRelationSetHandle set, AtkRelationType relationship, AtkObjectHandle target);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_relation_set_contains(AtkRelationSetHandle set, AtkRelationType relationship);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_relation_set_contains_target(AtkRelationSetHandle set, AtkRelationType relationship, AtkObjectHandle target);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_relation_set_get_n_relations(AtkRelationSetHandle set);

	[DllImport(Libraries.Atk)]
	internal static extern AtkRelationHandle atk_relation_set_get_relation(AtkRelationSetHandle set, int i);

	[DllImport(Libraries.Atk)]
	internal static extern AtkRelationHandle atk_relation_set_get_relation_by_type(AtkRelationSetHandle set, AtkRelationType relationship);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_relation_set_remove(AtkRelationSetHandle set, AtkRelationHandle relation);

}
