namespace MentorLake.Vulkan;

public class VkCuFunctionCreateInfoNVXHandle : BaseSafeHandle
{
}


public static class VkCuFunctionCreateInfoNVXExtensions
{

	public static VkCuFunctionCreateInfoNVX Dereference(this VkCuFunctionCreateInfoNVXHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCuFunctionCreateInfoNVX>(x.DangerousGetHandle());
}
internal class VkCuFunctionCreateInfoNVXExterns
{
}

public struct VkCuFunctionCreateInfoNVX
{
}
