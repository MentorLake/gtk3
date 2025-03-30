namespace MentorLake.GModule;

[Flags]
public enum GModuleFlags : uint
{
	G_MODULE_BIND_LAZY = 1,
	G_MODULE_BIND_LOCAL = 2,
	G_MODULE_BIND_MASK = 3
}
