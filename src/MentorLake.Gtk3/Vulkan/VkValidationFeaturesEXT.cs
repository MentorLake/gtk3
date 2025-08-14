namespace MentorLake.Vulkan;


public class VkValidationFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkValidationFeaturesEXTExtensions
{

	public static VkValidationFeaturesEXT Dereference(this VkValidationFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkValidationFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkValidationFeaturesEXTExterns
{
}


public struct VkValidationFeaturesEXT
{
}
