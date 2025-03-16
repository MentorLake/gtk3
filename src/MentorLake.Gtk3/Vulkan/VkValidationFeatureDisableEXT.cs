namespace MentorLake.Vulkan;

public class VkValidationFeatureDisableEXTHandle : BaseSafeHandle
{
}


public static class VkValidationFeatureDisableEXTExtensions
{

	public static VkValidationFeatureDisableEXT Dereference(this VkValidationFeatureDisableEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkValidationFeatureDisableEXT>(x.DangerousGetHandle());
}
internal class VkValidationFeatureDisableEXTExterns
{
}

public struct VkValidationFeatureDisableEXT
{
}
