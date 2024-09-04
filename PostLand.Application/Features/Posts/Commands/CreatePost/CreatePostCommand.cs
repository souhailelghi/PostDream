using MediatR;
using PostLand.Domain;

namespace PostLand.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<Post>
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
    }
}
