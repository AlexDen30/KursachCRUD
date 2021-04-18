using System.Collections.Generic;

namespace CursachCRUD.Lecturer
{
    public interface IWallMessageRepository
    {
        public IEnumerable<WallMessageModel> GetAllPosts();

        public IEnumerable<WallMessageModel> GetAllPostsBetween(int fromId, int toId);

        public IEnumerable<WallMessageModel> GetLastFivePosts();

        public bool AddPost(WallMessageModel news);

        public bool DeletePost(int id);
    }
}
