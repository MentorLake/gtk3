namespace MentorLake.Vulkan;

public class VkCommandPoolCreateInfoHandle : BaseSafeHandle
{
}


public static class VkCommandPoolCreateInfoExtensions
{

	public static VkCommandPoolCreateInfo Dereference(this VkCommandPoolCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCommandPoolCreateInfo>(x.DangerousGetHandle());
}
internal class VkCommandPoolCreateInfoExterns
{
}

public struct VkCommandPoolCreateInfo
{
}
