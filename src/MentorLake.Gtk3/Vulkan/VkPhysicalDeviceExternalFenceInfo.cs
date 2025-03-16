namespace MentorLake.Vulkan;

public class VkPhysicalDeviceExternalFenceInfoHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExternalFenceInfoExtensions
{

	public static VkPhysicalDeviceExternalFenceInfo Dereference(this VkPhysicalDeviceExternalFenceInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExternalFenceInfo>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExternalFenceInfoExterns
{
}

public struct VkPhysicalDeviceExternalFenceInfo
{
}
