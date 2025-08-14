namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVariablePointersFeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVariablePointersFeaturesExtensions
{

	public static VkPhysicalDeviceVariablePointersFeatures Dereference(this VkPhysicalDeviceVariablePointersFeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVariablePointersFeatures>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVariablePointersFeaturesExterns
{
}


public struct VkPhysicalDeviceVariablePointersFeatures
{
}
