namespace MentorLake.Vulkan;

public class VkPhysicalDeviceVariablePointersFeaturesKHRHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVariablePointersFeaturesKHRExtensions
{

	public static VkPhysicalDeviceVariablePointersFeaturesKHR Dereference(this VkPhysicalDeviceVariablePointersFeaturesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVariablePointersFeaturesKHR>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVariablePointersFeaturesKHRExterns
{
}

public struct VkPhysicalDeviceVariablePointersFeaturesKHR
{
}
