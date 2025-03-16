namespace MentorLake.Vulkan;

public class VkPhysicalDeviceDiscardRectanglePropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceDiscardRectanglePropertiesEXTExtensions
{

	public static VkPhysicalDeviceDiscardRectanglePropertiesEXT Dereference(this VkPhysicalDeviceDiscardRectanglePropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceDiscardRectanglePropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceDiscardRectanglePropertiesEXTExterns
{
}

public struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
}
