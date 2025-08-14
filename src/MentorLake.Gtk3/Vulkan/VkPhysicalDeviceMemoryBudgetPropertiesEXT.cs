namespace MentorLake.Vulkan;


public class VkPhysicalDeviceMemoryBudgetPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMemoryBudgetPropertiesEXTExtensions
{

	public static VkPhysicalDeviceMemoryBudgetPropertiesEXT Dereference(this VkPhysicalDeviceMemoryBudgetPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMemoryBudgetPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMemoryBudgetPropertiesEXTExterns
{
}


public struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
}
