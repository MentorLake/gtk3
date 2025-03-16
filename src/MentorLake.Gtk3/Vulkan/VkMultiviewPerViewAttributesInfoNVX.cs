namespace MentorLake.Vulkan;

public class VkMultiviewPerViewAttributesInfoNVXHandle : BaseSafeHandle
{
}


public static class VkMultiviewPerViewAttributesInfoNVXExtensions
{

	public static VkMultiviewPerViewAttributesInfoNVX Dereference(this VkMultiviewPerViewAttributesInfoNVXHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMultiviewPerViewAttributesInfoNVX>(x.DangerousGetHandle());
}
internal class VkMultiviewPerViewAttributesInfoNVXExterns
{
}

public struct VkMultiviewPerViewAttributesInfoNVX
{
}
