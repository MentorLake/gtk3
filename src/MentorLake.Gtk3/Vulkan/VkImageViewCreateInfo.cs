namespace MentorLake.Vulkan;

public class VkImageViewCreateInfoHandle : BaseSafeHandle
{
}


public static class VkImageViewCreateInfoExtensions
{

	public static VkImageViewCreateInfo Dereference(this VkImageViewCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewCreateInfo>(x.DangerousGetHandle());
}
internal class VkImageViewCreateInfoExterns
{
}

public struct VkImageViewCreateInfo
{
}
