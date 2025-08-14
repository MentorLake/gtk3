namespace MentorLake.Vulkan;


public class VkIndirectCommandsLayoutCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkIndirectCommandsLayoutCreateInfoNVExtensions
{

	public static VkIndirectCommandsLayoutCreateInfoNV Dereference(this VkIndirectCommandsLayoutCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkIndirectCommandsLayoutCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkIndirectCommandsLayoutCreateInfoNVExterns
{
}


public struct VkIndirectCommandsLayoutCreateInfoNV
{
}
