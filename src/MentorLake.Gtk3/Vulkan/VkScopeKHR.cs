namespace MentorLake.Vulkan;

public class VkScopeKHRHandle : BaseSafeHandle
{
}


public static class VkScopeKHRExtensions
{

	public static VkScopeKHR Dereference(this VkScopeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkScopeKHR>(x.DangerousGetHandle());
}
internal class VkScopeKHRExterns
{
}

public struct VkScopeKHR
{
}
