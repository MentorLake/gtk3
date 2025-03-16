namespace MentorLake.Vulkan;

public class VkDeviceCreateInfoHandle : BaseSafeHandle
{
}


public static class VkDeviceCreateInfoExtensions
{

	public static VkDeviceCreateInfo Dereference(this VkDeviceCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceCreateInfo>(x.DangerousGetHandle());
}
internal class VkDeviceCreateInfoExterns
{
}

public struct VkDeviceCreateInfo
{
}
