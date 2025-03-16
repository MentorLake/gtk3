namespace MentorLake.Vulkan;

public class VkScopeNVHandle : BaseSafeHandle
{
}


public static class VkScopeNVExtensions
{

	public static VkScopeNV Dereference(this VkScopeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkScopeNV>(x.DangerousGetHandle());
}
internal class VkScopeNVExterns
{
}

public struct VkScopeNV
{
}
