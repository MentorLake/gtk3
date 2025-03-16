namespace MentorLake.Vulkan;

public class VkFenceCreateInfoHandle : BaseSafeHandle
{
}


public static class VkFenceCreateInfoExtensions
{

	public static VkFenceCreateInfo Dereference(this VkFenceCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFenceCreateInfo>(x.DangerousGetHandle());
}
internal class VkFenceCreateInfoExterns
{
}

public struct VkFenceCreateInfo
{
}
