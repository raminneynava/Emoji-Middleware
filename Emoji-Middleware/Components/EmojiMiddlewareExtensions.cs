namespace Emoji_Middleware.Components
{
    public static class EmojiMiddlewareExtensions
    {
        public static IApplicationBuilder UseEmojiMiddleware(
        this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<EmojiMiddleware>();
        }
    }

}
