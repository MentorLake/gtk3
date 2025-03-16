namespace MentorLake.Vulkan;

public class VkPhysicalDeviceHostImageCopyPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceHostImageCopyPropertiesEXTExtensions
{

	public static VkPhysicalDeviceHostImageCopyPropertiesEXT Dereference(this VkPhysicalDeviceHostImageCopyPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceHostImageCopyPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceHostImageCopyPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceHostImageCopyPropertiesEXT
{
}
