namespace MentorLake.Vulkan;

public class VkDeviceGroupDeviceCreateInfoHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupDeviceCreateInfoExtensions
{

	public static VkDeviceGroupDeviceCreateInfo Dereference(this VkDeviceGroupDeviceCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupDeviceCreateInfo>(x.DangerousGetHandle());
}
internal class VkDeviceGroupDeviceCreateInfoExterns
{
}

public struct VkDeviceGroupDeviceCreateInfo
{
}
