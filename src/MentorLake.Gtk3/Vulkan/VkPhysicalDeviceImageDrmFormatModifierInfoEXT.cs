namespace MentorLake.Vulkan;


public class VkPhysicalDeviceImageDrmFormatModifierInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageDrmFormatModifierInfoEXTExtensions
{

	public static VkPhysicalDeviceImageDrmFormatModifierInfoEXT Dereference(this VkPhysicalDeviceImageDrmFormatModifierInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageDrmFormatModifierInfoEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageDrmFormatModifierInfoEXTExterns
{
}


public struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
{
}
