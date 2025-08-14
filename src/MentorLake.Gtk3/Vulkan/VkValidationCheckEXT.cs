namespace MentorLake.Vulkan;


public class VkValidationCheckEXTHandle : BaseSafeHandle
{
}


public static class VkValidationCheckEXTExtensions
{

	public static VkValidationCheckEXT Dereference(this VkValidationCheckEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkValidationCheckEXT>(x.DangerousGetHandle());
}
internal class VkValidationCheckEXTExterns
{
}


public struct VkValidationCheckEXT
{
}
