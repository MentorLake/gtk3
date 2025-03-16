namespace MentorLake.Vulkan;

public class VkPhysicalDeviceAddressBindingReportFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceAddressBindingReportFeaturesEXTExtensions
{

	public static VkPhysicalDeviceAddressBindingReportFeaturesEXT Dereference(this VkPhysicalDeviceAddressBindingReportFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceAddressBindingReportFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceAddressBindingReportFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceAddressBindingReportFeaturesEXT
{
}
