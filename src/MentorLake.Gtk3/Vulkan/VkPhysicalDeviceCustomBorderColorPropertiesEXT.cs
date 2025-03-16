namespace MentorLake.Vulkan;

public class VkPhysicalDeviceCustomBorderColorPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCustomBorderColorPropertiesEXTExtensions
{

	public static VkPhysicalDeviceCustomBorderColorPropertiesEXT Dereference(this VkPhysicalDeviceCustomBorderColorPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCustomBorderColorPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCustomBorderColorPropertiesEXTExterns
{
}

public struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
{
}
