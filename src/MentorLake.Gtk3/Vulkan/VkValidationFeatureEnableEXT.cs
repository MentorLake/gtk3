namespace MentorLake.Vulkan;

public class VkValidationFeatureEnableEXTHandle : BaseSafeHandle
{
}


public static class VkValidationFeatureEnableEXTExtensions
{

	public static VkValidationFeatureEnableEXT Dereference(this VkValidationFeatureEnableEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkValidationFeatureEnableEXT>(x.DangerousGetHandle());
}
internal class VkValidationFeatureEnableEXTExterns
{
}

public struct VkValidationFeatureEnableEXT
{
}
